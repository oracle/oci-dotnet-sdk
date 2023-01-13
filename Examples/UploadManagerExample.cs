/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Threading.Tasks;
using Oci.Common;
using Oci.Common.Auth;
using Oci.ObjectstorageService;
using Oci.ObjectstorageService.Requests;
using Oci.ObjectstorageService.Transfer;

namespace Oci.Examples
{
    public class UploadManagerExample
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static async Task MainUploadManager()
        {
            logger.Info("Starting Upload Manager Example");
            var provider = new ConfigFileAuthenticationDetailsProvider("DEFAULT");
            var osClient = new ObjectStorageClient(provider, new ClientConfiguration()
            {
                TimeoutMillis = 1000 * 1000 // 1000 secs. Setting large timeouts is required for uploading large objects to avoid httpclient timeout exceptions.
            });

            var putObjectRequest = new PutObjectRequest()
            {
                BucketName = Environment.GetEnvironmentVariable("BUCKET_NAME"),
                NamespaceName = Environment.GetEnvironmentVariable("NAMESPACE_NAME"),
                ObjectName = Environment.GetEnvironmentVariable("OBJECT_NAME"),
                PutObjectBody = System.IO.File.OpenRead(Environment.GetEnvironmentVariable("FILE_TO_UPLOAD")),
                ContentLength = Convert.ToInt64(Environment.GetEnvironmentVariable("CONTENT_LENGTH")),
                ContentType = Environment.GetEnvironmentVariable("CONTENT_TYPE")
            };

            var uploadConfiguration = new UploadConfiguration()
            {
                AllowMultipartUploads = true
            };

            var uploadManager = new UploadManager(osClient, uploadConfiguration);
            var uploadRequest = new UploadManager.UploadRequest(putObjectRequest)
            {
                AllowOverwrite = true,
                OnProgress = OnProgres
            };

            var uploadResponse = await uploadManager.Upload(uploadRequest);
            logger.Info(uploadResponse);

            var headObject = await osClient.HeadObject(new HeadObjectRequest()
            {
                BucketName = Environment.GetEnvironmentVariable("BUCKET_NAME"),
                NamespaceName = Environment.GetEnvironmentVariable("NAMESPACE_NAME"),
                ObjectName = Environment.GetEnvironmentVariable("OBJECT_NAME")
            });

            logger.Info($"{headObject.ETag}");
            osClient.Dispose();
        }

        private static void OnProgres(long bytesRead, long totalBytes)
        {
            logger.Info($"{bytesRead} : {totalBytes}");
        }
    }
}
