/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Threading;
using System.Threading.Tasks;
using Oci.Common.Retry;
using Oci.ObjectstorageService.Requests;

namespace Oci.ObjectstorageService.Transfer
{
    /// <summary>
    /// UploadManager simplifies interaction with the Object Storage service by abstracting away the method used
    /// to upload objects. Depending on the configuration parameters, UploadManager may choose to do a single
    /// PutObject request, or break up the upload into multiple parts and utilize multi-part uploads.
    /// An advantage of using multi-part uploads is the ability to retry individual failed parts, as well as
    /// being able to upload parts in parallel to reduce upload time.
    /// Callers still have full control over how the UploadManager decides to perform the upload using UploadConfiguration.
    /// Callers who want even more control, or need to combine multiple files should look at using MultipartObjectAssembler directly.
    /// </summary>
    public class UploadManager
    {
        public UploadManager(ObjectStorageClient objectStorageClient, UploadConfiguration uploadConfiguration)
        {
            this._osClient = objectStorageClient;
            this._configuration = uploadConfiguration;
        }

        /// <summary>
        /// Initiates a new upload request.  The upload manager will decide whether to use
        /// a single PutObject call or multi-part uploads depending on the UploadConfiguration specified.
        /// If a multi-part upload attempt fails, the UploadManager will attempt to abort the upload to avoid leaving
        /// partially complete uploads and parts (unless explicitly disabled via UploadConfiguration).
        /// </summary>
        /// <param name="request">UploadRequest</param>
        /// <returns>Task<UploadResponse></returns>
        public async Task<UploadResponse> Upload(UploadRequest request)
        {
            if (MultipartUtils.ShouldUseMultipart(_configuration, request.PutObjectRequest.PutObjectBody.Length))
            {
                logger.Info("Using multipart Upload");
                return await MultipartUpload(request).ConfigureAwait(false);
            }

            return await SingleUpload(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Resumes a multipart upload using the existing UploadId.
        /// </summary>
        /// <param name="request">ResumeUploadRequest</param>
        /// <returns>Task<UploadResponse></returns>
        public async Task<UploadResponse> ResumeUpload(ResumeUploadRequest request)
        {
            logger.Info($"Resuming uploads for {request.UploadId}");
            return await MultipartUpload(request, false);
        }

        public class UploadRequest
        {
            /// <summary>
            /// PutObjectRequest for the object to upload.
            /// </summary>
            public PutObjectRequest PutObjectRequest { get; set; }

            /// <summary>
            /// Configures whether or not the if-none-match header will be used to prevent
            /// overwrites on PUT. If this is disabled, the ifNoneMatch value in the PutObjectRequest
            /// builder will be overwritten with "". The default value is 'true'.
            /// </summary>
            public bool AllowOverwrite { get; set; } = true;

            /// <summary>
            /// Notification to indicate that progress was made during an upload operation.
            /// Note that the value may decrease from one invocation to the next if any part
            /// of the upload to to be retried.
            /// </summary>
            public OnProgress OnProgress { get; set; }

            /// <summary>
            /// The retry configuration to be used for all the outgoing service calls.
            /// </summary>
            public RetryConfiguration RetryConfiguration { get; set; }

            public UploadRequest(PutObjectRequest request)
            {
                this.PutObjectRequest = request;
            }
        }

        public class ResumeUploadRequest : UploadRequest
        {
            public string UploadId { get; set; }

            public ResumeUploadRequest(PutObjectRequest request, string uploadId) : base(request)
            {
                UploadId = uploadId;
            }
        }

        public class UploadResponse
        {
            /// <summary>
            /// The etag of the object uploaded.
            /// </summary>
            public string ETag { get; set; }

            /// <summary>
            /// The opc-request-id associated with either the PutObject call
            /// or the final CommitMultipartUpload call (if multi-part upload was used).
            /// </summary>
            public string OpcRequestId { get; set; }

            /// <summary>
            /// The opc-client-request-id sent with every request, if provided.
            /// </summary>
            public string OpcClientRequestId { get; set; }

            /// <summary>
            /// The MD5 of the object uploaded.
            /// </summary>
            public string OpcContentMd5 { get; set; }

            /// <summary>
            /// The multipart MD5 of the object uploaded.
            /// </summary>
            public string OpcMultipartMd5 { get; set; }
        }

        /// <summary>
        /// Notification to indicate that progress was made during an upload operation.
        /// Note that the value may decrease from one invocation to the next if any part
        /// of the upload to to be retried.
        /// </summary>
        /// <param name="completed">The number of bytes that have been already been uploaded for this operation.</param>
        /// <param name="total">The total number of bytes to upload for this operation.</param>
        public delegate void OnProgress(long completed, long total);

        private async Task<UploadResponse> SingleUpload(UploadRequest request)
        {
            logger.Info("Using PutObject to upload file");

            if (_configuration.EnforceMd5Upload && request.PutObjectRequest.ContentMD5 == null)
            {
                var inputStream = request.PutObjectRequest.PutObjectBody;
                var contentMd5 = MultipartUtils.CalculateMd5(inputStream);
                if (inputStream.CanSeek)
                {
                    inputStream.Position = 0;
                }
                else
                {
                    throw new NotSupportedException("Stream cannot be seeked, Please re-try with re-readable streams.");
                }
                request.PutObjectRequest.ContentMD5 = contentMd5;
            }

            if (request.OnProgress != null)
            {
                request.PutObjectRequest.PutObjectBody = new ProgressTrackingInputStream(
                    request.PutObjectRequest.PutObjectBody, new ProgressTracker(request.OnProgress, request.PutObjectRequest.PutObjectBody.Length));
            }

            var response = await _osClient.PutObject(request.PutObjectRequest, request.RetryConfiguration).ConfigureAwait(false);

            return new UploadResponse()
            {
                ETag = response.ETag,
                OpcRequestId = response.OpcRequestId,
                OpcClientRequestId = response.OpcClientRequestId,
                OpcContentMd5 = response.OpcContentMd5
            };
        }

        private async Task<UploadResponse> MultipartUpload(UploadRequest uploadRequest, bool isNewUpload = true)
        {
            MultipartManifest manifest = null;
            var putobjectRequest = uploadRequest.PutObjectRequest;
            var chunkCreator = new StreamChunkCreator(putobjectRequest.PutObjectBody, _configuration.LengthPerUploadPartInMiB * MultipartUtils.MiB);

            // Uses single thread for multipart uploads.
            var executor = new SemaphoreSlim(_configuration.ParallelUploadCount);

            var assembler = new MultipartObjectAssembler(_osClient,
                putobjectRequest.NamespaceName,
                putobjectRequest.BucketName,
                putobjectRequest.ObjectName,
                uploadRequest.AllowOverwrite,
                executor,
                putobjectRequest.OpcClientRequestId,
                _configuration.EnforceMd5MultipartUpload,
                uploadRequest.RetryConfiguration,
                putobjectRequest.StorageTier.GetValueOrDefault(Models.StorageTier.Standard));

            try
            {
                if (isNewUpload && !(uploadRequest is ResumeUploadRequest))
                {
                    var putObjectRequest = uploadRequest.PutObjectRequest;
                    manifest = await assembler.NewRequest(
                        putobjectRequest.ContentEncoding, putobjectRequest.ContentType,
                        putobjectRequest.ContentLanguage, putobjectRequest.ContentDisposition,
                        putobjectRequest.CacheControl, putobjectRequest.OpcMeta,
                        putObjectRequest.StorageTier.GetValueOrDefault(Models.StorageTier.Standard));
                }
                else
                {
                    manifest = await assembler.ResumeUpload((uploadRequest as ResumeUploadRequest).UploadId).ConfigureAwait(false);
                }

                ProgressTracker progressTracker = null;

                if (uploadRequest.OnProgress != null)
                {
                    progressTracker = new ProgressTracker(uploadRequest.OnProgress, putobjectRequest.PutObjectBody.Length);
                }

                int partNum = 1;
                foreach (var stream in chunkCreator)
                {
                    if (!manifest.IsPartExists(partNum))
                    {
                        logger.Info($"Creating Chunk: {partNum}");

                        if (progressTracker != null)
                        {
                            var progressStream = new ProgressTrackingInputStream(stream, progressTracker);
                            await assembler.AddPart(progressStream, stream.Length, partNum).ConfigureAwait(false);
                        }
                        else
                        {
                            await assembler.AddPart(stream, stream.Length, partNum).ConfigureAwait(false);
                        }
                    }
                    else
                    {
                        if (progressTracker != null)
                        {
                            progressTracker.OnRead(stream.Length);
                        }
                        logger.Info($"Skipping Part {partNum}");
                    }
                    partNum++;
                }

                var response = await assembler.Commit().ConfigureAwait(false);
                logger.Info("Upload Complete");

                return new UploadResponse()
                {
                    ETag = response.ETag,
                    OpcClientRequestId = response.OpcClientRequestId,
                    OpcRequestId = response.OpcRequestId,
                    OpcMultipartMd5 = response.OpcMultipartMd5
                };
            }
            catch (Exception e)
            {
                if (manifest != null)
                {
                    logger.Error($"Failed to upload object using multi-part uploads.  Failed part numbers = '{string.Join(" ", manifest.ListFailedParts())}'" +
                        $".  Successful parts = '{string.Join(" ", manifest.ListCompletedParts())}', Upload Id = '{manifest.UploadId}'" +
                        $". {TransferConstants.UPLOAD_MANAGER_DEBUG_INFORMATION_LOG}");
                }
                if (_configuration.DisableAutoAbort)
                {
                    logger.Info($"Not aborting failed multipart upload {manifest.UploadId} per configuration, client must manually abort it");
                }
                else
                {
                    logger.Info("Aborting in-progress uploads");
                    await assembler.Abort();
                }
                throw e;
            }
            finally
            {
                executor.Dispose();
            }
        }

        private readonly ObjectStorageClient _osClient;
        private readonly UploadConfiguration _configuration;
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
    }
}
