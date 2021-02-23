/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Oci.Common.Retry;
using Oci.ObjectstorageService.Models;
using Oci.ObjectstorageService.Requests;
using Oci.ObjectstorageService.Responses;

namespace Oci.ObjectstorageService.Transfer
{
    /// <summary>
    /// MultiPartObjectAssembler provides a simplified interaction with uploading large
    /// objects using multi-part uploads.
    /// An assembler can be used begin a new upload, or resume a previous one. Users can reference the returned
    /// manifest to watch/monitor updates to the upload as new parts are added or parts complete.
    /// </summary>
    public class MultipartObjectAssembler
    {
        public MultipartObjectAssembler(ObjectStorageClient service,
            string namespaceName, string bucketName, string objectName,
            bool allowOverwrite,
            SemaphoreSlim executor,
            string opcClientRequestId,
            bool enforceContentMD5Upload = false,
            RetryConfiguration retryConfiguration = null,
            StorageTier storageTier = StorageTier.Standard)
        {
            _service = service;
            _namespaceName = namespaceName;
            _bucketName = bucketName;
            _objectName = objectName;
            _allowOverwrite = allowOverwrite;
            _executorServiceToUse = executor;
            _retryConfiguration = retryConfiguration;
            _opcClientRequestId = opcClientRequestId;
            _enforceContentMD5Upload = enforceContentMD5Upload;
            _tokenSource = new CancellationTokenSource();
            _storageTier = storageTier;
        }

        /// <summary>
        /// Inititate a new Multipart upload request
        /// </summary>
        /// <param name="putObjectRequest"></param>
        /// <returns></returns>
        public async Task<MultipartManifest> NewRequest(
            string contentEncoding, string contentType,
            string contentLanguage, string contentDisposition,
            string cacheControl, Dictionary<string, string> metadata,
            StorageTier storageTier)
        {
            CheckInitialized();
            var ifNoneMatch = _allowOverwrite ? null : "*";

            var request = new CreateMultipartUploadRequest()
            {
                BucketName = _bucketName,
                NamespaceName = _namespaceName,
                IfNoneMatch = ifNoneMatch,
                CreateMultipartUploadDetails = new CreateMultipartUploadDetails()
                {
                    Object = _objectName,
                    ContentEncoding = contentEncoding,
                    ContentType = contentType,
                    ContentLanguage = contentLanguage,
                    Metadata = metadata,
                    ContentDisposition = contentDisposition,
                    CacheControl = cacheControl,
                    StorageTier = storageTier
                },
                OpcClientRequestId = CreateClientRequestId("New")
            };

            var response = await _service.CreateMultipartUpload(request).ConfigureAwait(false);
            _multipartManifest = new MultipartManifest(response.MultipartUpload.UploadId);
            _transferManager = new MultipartTransferManager(_multipartManifest, _service, _executorServiceToUse, _tokenSource.Token, _retryConfiguration);
            _initialized = true;

            return _multipartManifest;
        }

        /// <summary>
        /// Add the next part to the upload. Parts will be committed in the order submitted.
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="contentLength"></param>
        /// <param name="partNumber"></param>
        /// <returns>Part Number</returns>
        public async Task<int> AddPart(Stream stream, long contentLength, int partNumber)
        {
            ValidateState();
            MultipartUtils.ValidatePartNumber(partNumber);

            var request = new UploadPartRequest()
            {
                BucketName = _bucketName,
                NamespaceName = _namespaceName,
                ObjectName = _objectName,
                ContentLength = contentLength,
                UploadId = _multipartManifest.UploadId,
                UploadPartNum = partNumber,
                UploadPartBody = stream,
                OpcClientRequestId = CreateClientRequestId($"Part{partNumber}")
            };

            if (_enforceContentMD5Upload)
            {
                request.ContentMD5 = MultipartUtils.CalculateMd5(stream);
                if (stream.CanSeek)
                {
                    stream.Position = 0;
                    _logger.Info($"MD5: {request.ContentMD5}");
                }
                else
                {
                    throw new NotSupportedException("Stream cannot be seeked, Please re-try with re-readable streams.");
                }
            }

            await _transferManager.StartTransfer(request).ConfigureAwait(false);
            return partNumber;
        }

        /// <summary>
        /// Commits the multi-part upload after all in-progress uploads have completed.
        /// </summary>
        /// <returns>CommitMultipartUploadResponse</returns>
        public async Task<CommitMultipartUploadResponse> Commit()
        {
            ValidateState();
            _logger.Info("Waiting for the upload parts to complete");
            await _transferManager.WaitForCompletion();
            _logger.Info("Commiting upload");

            if (!_multipartManifest.IsUploadSuccessful())
            {
                throw new InvalidOperationException("One or more parts were have not completed upload successfully");
            }

            var request = new CommitMultipartUploadRequest()
            {
                BucketName = _bucketName,
                ObjectName = _objectName,
                NamespaceName = _namespaceName,
                UploadId = _multipartManifest.UploadId,
                OpcClientRequestId = CreateClientRequestId("Commit"),
                CommitMultipartUploadDetails = new CommitMultipartUploadDetails()
                {
                    PartsToCommit = _multipartManifest.ListCompletedParts(),
                }
            };

            _executorServiceToUse.Dispose();
            return await _service.CommitMultipartUpload(request, _retryConfiguration).ConfigureAwait(false);
        }

        /// <summary>
        /// Resumes an existing multi-part upload using the upload ID.
        /// </summary>
        /// <param name="uploadId"></param>
        /// <returns>MultipartManifest</returns>
        public async Task<MultipartManifest> ResumeUpload(string uploadId)
        {
            CheckInitialized();
            var multipartUpload = FindUpload(uploadId);

            if (multipartUpload == null)
            {
                _logger.Error($"No matching upload found for ${uploadId}");
                throw new ArgumentException($"Could not find existing upload with ID: {uploadId} in bucket: {_bucketName} and NamespaceName: {_namespaceName}");
            }

            var multipartManifest = new MultipartManifest(uploadId);
            string nextPageToken = null;
            do
            {
                var partsRequest = new ListMultipartUploadPartsRequest()
                {
                    BucketName = _bucketName,
                    NamespaceName = _namespaceName,
                    ObjectName = _objectName,
                    UploadId = uploadId,
                    Limit = 100,
                    Page = nextPageToken,
                    OpcClientRequestId = CreateClientRequestId("List")
                };

                var existingParts = await _service.ListMultipartUploadParts(partsRequest, _retryConfiguration).ConfigureAwait(false);
                nextPageToken = existingParts.OpcNextPage;

                foreach (var part in existingParts.Items)
                {
                    multipartManifest.RegisterExisting(part);
                }

            } while (nextPageToken != null);

            _multipartManifest = multipartManifest;
            _transferManager = new MultipartTransferManager(_multipartManifest, _service, _executorServiceToUse, _tokenSource.Token, _retryConfiguration);
            _initialized = true;

            return multipartManifest;
        }

        /// <summary>
        /// Aborts the current multi-part assembly and all uploads that are currently in progress.
        /// </summary>
        /// <returns>AbortMultipartUploadResponse</returns>
        public async Task<AbortMultipartUploadResponse> Abort()
        {
            ValidateState();
            _tokenSource.Cancel();
            _multipartManifest.MarkAborted();

            var request = new AbortMultipartUploadRequest()
            {
                BucketName = _bucketName,
                ObjectName = _objectName,
                NamespaceName = _namespaceName,
                UploadId = _multipartManifest.UploadId,
                OpcClientRequestId = CreateClientRequestId("Abort")
            };

            return await _service.AbortMultipartUpload(request, _retryConfiguration).ConfigureAwait(false);
        }

        private async Task<MultipartUpload> FindUpload(string uploadId)
        {
            string nextPageToken = null;

            do
            {
                var listRequest = new ListMultipartUploadsRequest()
                {
                    NamespaceName = _namespaceName,
                    BucketName = _bucketName,
                    Limit = 100,
                    Page = nextPageToken,
                    OpcClientRequestId = CreateClientRequestId("List")
                };
                var multipartUploads = await _service.ListMultipartUploads(listRequest, _retryConfiguration).ConfigureAwait(false);
                nextPageToken = multipartUploads.OpcNextPage;
                foreach (var multipart in multipartUploads.Items)
                {
                    if (uploadId.Equals(multipart.UploadId))
                    {
                        _logger.Info($"Found multipart upload for the given UploadId : {uploadId}");
                        return multipart;
                    }
                }
            } while (nextPageToken != null);

            return null;
        }

        private void CheckInitialized()
        {
            if (_initialized)
            {
                throw new InvalidCastException("Assembler has already been initialized");
            }
        }

        private void ValidateState()
        {
            if (_multipartManifest == null)
            {
                throw new InvalidOperationException("Assembler has not been initialized, must call NewRequest or ResumeRequest first");
            }
            if (_multipartManifest.IsAborted())
            {
                throw new InvalidOperationException("Cannot complete request, upload has already been aborted");
            }
        }

        private string CreateClientRequestId(string prefix)
        {
            if (_opcClientRequestId == null)
            {
                return null;
            }
            string newClientId = prefix + "/" + _opcClientRequestId;

            if (newClientId.Length > MAX_CLIENT_REQUEST_ID_LENGTH)
            {
                _logger.Info($"Truncating opcClientRequestId to 98 chars");
                return newClientId.Substring(0, MAX_CLIENT_REQUEST_ID_LENGTH);
            }

            return newClientId;
        }

        private readonly ObjectStorageClient _service;
        private readonly string _namespaceName;
        private readonly string _bucketName;
        private readonly string _objectName;
        private readonly bool _allowOverwrite;
        private readonly SemaphoreSlim _executorServiceToUse;
        private readonly CancellationTokenSource _tokenSource;
        private readonly string _opcClientRequestId;
        private readonly RetryConfiguration _retryConfiguration;
        private readonly bool _enforceContentMD5Upload;

        private MultipartManifest _multipartManifest;
        private MultipartTransferManager _transferManager;
        private bool _initialized = false;

        private static readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();
        private static readonly int MAX_CLIENT_REQUEST_ID_LENGTH = 98;
        private readonly StorageTier _storageTier;
    }
}
