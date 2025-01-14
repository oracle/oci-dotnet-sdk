/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.IO;
using System.Threading.Tasks;
using Oci.Common;
using Oci.Common.Auth;
using Oci.ObjectstorageService;
using Oci.ObjectstorageService.Models;
using Oci.ObjectstorageService.Requests;
using Oci.ObjectstorageService.Responses;

namespace Oci.Examples
{
    public class UseRealmSpecificEndpointTemplateExample
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static async Task MainURSET()
        {
            var provider = new ConfigFileAuthenticationDetailsProvider("DEFAULT");
            var osClient = new ObjectStorageClient(provider, new ClientConfiguration());
            osClient.UseRealmSpecificEndpointTemplate(true);

            try
            {
                // Get current namespace
                var namespaceResponse = await osClient.GetNamespace(new GetNamespaceRequest { });
                var namespaceName = namespaceResponse.Value;
                logger.Info($"Using namespace:{namespaceName}");

                // Create a bucket
                string bucketName = Environment.GetEnvironmentVariable("BUCKET_NAME");
                var createBucketRequest = new CreateBucketRequest
                {
                    NamespaceName = namespaceName,
                    CreateBucketDetails = new CreateBucketDetails
                    {
                        Name = bucketName,
                        CompartmentId = provider.TenantId
                    }
                };
                var createBucketResponse = await osClient.CreateBucket(createBucketRequest);
                logger.Info($"Bucket :{createBucketResponse.Bucket.Name} created successfully with OCID:{createBucketResponse.Bucket.Id}");

                // list all buckets
                var listBucketsRequest = new ListBucketsRequest
                {
                    NamespaceName = namespaceName,
                    CompartmentId = provider.TenantId,
                };

                string nextToken = null;
                do
                {
                    listBucketsRequest.Page = nextToken;
                    var listBucketsResponse = await osClient.ListBuckets(listBucketsRequest);
                    foreach (var bucketSummary in listBucketsResponse.Items)
                    {
                        if (bucketName.Equals(bucketSummary?.Name))
                        {
                            logger.Info($"Found bucket: {bucketName} in the list of buckets");
                            break;
                        }
                    }
                } while (nextToken != null);

                // Delete the bucket for cleanup
                var deleteBucketRequest = new DeleteBucketRequest
                {
                    NamespaceName = namespaceName,
                    BucketName = bucketName
                };
                var deleteBucketResponse = await osClient.DeleteBucket(deleteBucketRequest);
                logger.Info($"Deleted bucket: {bucketName}");

            }
            catch (Exception e)
            {
                logger.Error($"Failed UseRealmSpecificEndpointTemplateExample: {e.Message}");
            }
            finally
            {
                osClient.Dispose();
            }
        }
    }
}