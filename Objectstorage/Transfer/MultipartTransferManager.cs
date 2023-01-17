/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Oci.Common.Retry;
using Oci.ObjectstorageService.Requests;
using Oci.ObjectstorageService.Responses;

namespace Oci.ObjectstorageService.Transfer
{
    /// <summary>
    /// MultipartTransferManager handles the job submission and completion of parts to the manifest.
    /// </summary>
    public class MultipartTransferManager
    {
        public MultipartManifest Manifest { get; }
        public ObjectStorageClient OSClient { get; }
        public SemaphoreSlim Executor { get; }

        public MultipartTransferManager(MultipartManifest manifest,
            ObjectStorageClient osClient,
            SemaphoreSlim executor,
            CancellationToken cancellationToken = default,
            RetryConfiguration retryConfiguration = null)
        {
            this.Manifest = manifest;
            this.OSClient = osClient;
            this.Executor = executor;
            this._cancellationToken = cancellationToken;
            this._retryConfiguration = retryConfiguration;
        }

        public async Task StartTransfer(UploadPartRequest request)
        {
            await Executor.WaitAsync().ConfigureAwait(false);
            _uploadTasks.Add(UploadPart(request, Executor));
        }

        public async Task WaitForCompletion()
        {
            while (_uploadTasks.Any())
            {
                var finishedTask = await Task.WhenAny(_uploadTasks).ConfigureAwait(false);
                _uploadTasks.Remove(finishedTask);
            }
        }

        private async Task<UploadPartResponse> UploadPart(UploadPartRequest request, SemaphoreSlim throttler)
        {
            if (!request.UploadPartNum.HasValue)
            {
                throw new ArgumentException("UploadPartRequest.UploadPartNum cannot be null");
            }
            int partNum = request.UploadPartNum.Value;
            Manifest.RegisterTransfer(partNum);
            try
            {
                var response = await OSClient.UploadPart(request, _retryConfiguration, _cancellationToken).ConfigureAwait(false);
                Manifest.RegisterSuccess(partNum, response);
                _logger.Debug($"Part {partNum} has been successfully uploaded");
                return response;
            }
            catch (Exception e)
            {
                _logger.Error($"failure while uploading part {request.UploadPartNum}, message: ${e.Message}");
                Manifest.RegisterFailure(partNum);
                return null;
            }
            finally
            {
                throttler.Release();
            }
        }

        private readonly List<Task<UploadPartResponse>> _uploadTasks = new List<Task<UploadPartResponse>>();
        private readonly CancellationToken _cancellationToken = default;
        private readonly RetryConfiguration _retryConfiguration;
        private static readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();
    }
}
