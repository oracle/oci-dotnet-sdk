/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

﻿using System;
using System.IO;
using System.Threading.Tasks;
using Oci.Common;
using Oci.Common.Auth;
using Oci.ObjectstorageService;
using Oci.ObjectstorageService.Requests;
using Oci.ObjectstorageService.Responses;


namespace Oci.Examples
{
    public class ObjectStorageExamples
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static async Task MainOS()
        {
            logger.Info("Starting Object Storage Examples");

            var provider = new ConfigFileAuthenticationDetailsProvider("DEFAULT");
            var osClient = new ObjectStorageClient(provider, new ClientConfiguration());
            try
            {
                await PutObjectExample(osClient);
                await GetObjectExample(osClient);
            }
            catch (Exception e)
            {
                logger.Error($"Failed ObjectStorage example: {e.Message}");
            }
            finally
            {
                osClient.Dispose();
            }
        }

        public static async Task<PutObjectResponse> PutObjectExample(ObjectStorageClient osClient)
        {
            var putObjectRequest = new PutObjectRequest()
            {
                BucketName = Environment.GetEnvironmentVariable("BUCKET_NAME"),
                NamespaceName = Environment.GetEnvironmentVariable("NAMESPACE_NAME"),
                ObjectName = Environment.GetEnvironmentVariable("OBJECT_NAME"),
                PutObjectBody = GenerateStreamFromString("Hello World!!!!")
            };

            try
            {
                var response = await osClient.PutObject(putObjectRequest);
                logger.Info($"Put Object is successful: " + response.ETag);
                return response;
            }
            catch (Exception e)
            {
                logger.Error($"Failed at PutObjectExample:\n{e}");
                throw;
            }

        }

        public static async Task<GetObjectResponse> GetObjectExample(ObjectStorageClient osClient)
        {
            var getObjectObjectRequest = new GetObjectRequest()
            {
                BucketName = Environment.GetEnvironmentVariable("BUCKET_NAME"),
                NamespaceName = Environment.GetEnvironmentVariable("NAMESPACE_NAME"),
                ObjectName = Environment.GetEnvironmentVariable("OBJECT_NAME"),
                Range = new Common.Model.Range()
                {
                    StartByte = 2,
                    EndByte = 10
                }
            };

            try
            {
                var response = await osClient.GetObject(getObjectObjectRequest);
                logger.Info($"Get Object is successful: " + response.ETag);

                var fileContents = new StreamReader(response.InputStream).ReadToEnd();
                logger.Info($"file contents: {fileContents}");

                logger.Info($"Range: Start Index: {response.ContentRange.StartByte}, End Index: {response.ContentRange.EndByte}");

                return response;
            }
            catch (Exception e)
            {
                logger.Error($"Failed at GetObjectExample:\n{e}");
                throw;
            }
        }

        public static Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}
