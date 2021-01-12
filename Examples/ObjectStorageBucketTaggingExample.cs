/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
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

    /**
     * This example demonstrates the following operations:
     * 1. Create a bucket
     * 2. Add freeform and defined tags to the bucket
     * 3. Update tags
     * 4. Remove tags and delete the bucket
     */

    public class ObjectStorageBucketTagging
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static async Task MainOSBucketTagging()
        {

            string compartmentId = Environment.GetEnvironmentVariable("OCI_COMPARTMENT_ID");
            string bucketName = Environment.GetEnvironmentVariable("BUCKET_NAME");
            string tagNamespace = Environment.GetEnvironmentVariable("TAG_NAMESPACE");
            string tagName = Environment.GetEnvironmentVariable("TAG_NAME");

            logger.Info("Starting example");
            // Create Object Storage Client
            var provider = new ConfigFileAuthenticationDetailsProvider("DEFAULT");
            var osClient = new ObjectStorageClient(provider, new ClientConfiguration());
            logger.Info("Object Storage client created.");

            GetNamespaceRequest getNamespaceRequest = new GetNamespaceRequest
            {
                CompartmentId = compartmentId
            };
            GetNamespaceResponse getNamespaceResponse = await osClient.GetNamespace(getNamespaceRequest);
            string nSpace = getNamespaceResponse.Value.Trim('"');
            logger.Info($"namespace is {nSpace}");

            /*
            We can assign tags to a bucket at creation time. Like other taggable resources, we can
            assign freeform and defined tags to a bucket. Freeform tags are a dictionary of
            string-to-string, where the key is the tag name and the value is the tag value.

            Defined tags are a dictionary where the key is the tag namespace (string) and the value is another dictionary. In
            this second dictionary, the key is the tag name (string) and the value is the tag value. The tag names have to
            correspond to the name of a tag within the specified namespace (and the namespace must exist).
            */
            try
            {

                Dictionary<string, string> freeformTags = new Dictionary<string, string>(){
                    {"free","form"},
                    {"another","item"}
                };

                Dictionary<string, object> definedTagsMap = new Dictionary<string, object>(){
                    {tagName, "original value"}
                };

                Dictionary<string, Dictionary<string, object>> definedTags = new Dictionary<string, Dictionary<string, object>>(){
                    {tagNamespace, definedTagsMap}
                };

                CreateBucketDetails createBucketDetails = new CreateBucketDetails
                {
                    Name = bucketName,
                    CompartmentId = compartmentId,
                    FreeformTags = freeformTags,
                    DefinedTags = definedTags,
                    ObjectEventsEnabled = false
                };
                CreateBucketRequest createBucketRequest = new CreateBucketRequest
                {
                    CreateBucketDetails = createBucketDetails,
                    NamespaceName = nSpace
                };
                CreateBucketResponse createBucketResponse = await osClient.CreateBucket(createBucketRequest);

                logger.Info($"Created a bucket with tags Bucket name: {createBucketResponse.Bucket.Name}");
                logger.Info("========================================");
                definedTags = createBucketResponse.Bucket.DefinedTags;
                foreach (KeyValuePair<string, Dictionary<string, object>> kvp in definedTags)
                {
                    foreach (KeyValuePair<string, object> tags in kvp.Value)
                    {
                        logger.Info($"tag key name: {tags.Key} and tag value is {tags.Value}");
                    }
                }

                // Tags come back when retrieving the bucket
                GetBucketRequest getBucketRequest = new GetBucketRequest
                {
                    NamespaceName = nSpace,
                    BucketName = bucketName
                };
                GetBucketResponse getBucketResponse = await osClient.GetBucket(getBucketRequest);
                logger.Info($"Retrieved a bucket with tags Bucket name: {getBucketResponse.Bucket.Name}");
                logger.Info("==========================================");
                definedTags = getBucketResponse.Bucket.DefinedTags;
                foreach (KeyValuePair<string, Dictionary<string, object>> kvp in definedTags)
                {
                    foreach (KeyValuePair<string, object> tags in kvp.Value)
                    {
                        logger.Info($"tag key name: {tags.Key} and tag value is {tags.Value}");
                    }
                }

                /*
                Unlike other resources (e.g. instances, VCNs, and block volumes), when listing buckets
                tags are not returned by default. Instead, you need to provide a value to the fields
                parameter when listing buckets in order to have those tags returned.

                Here we can see the result of providing and not providing that parameter.
                */
                ListBucketsRequest listBucketsRequest = new ListBucketsRequest
                {
                    CompartmentId = compartmentId,
                    NamespaceName = nSpace
                };
                IEnumerable<BucketSummary> bucketSummaries = osClient.Paginators.ListBucketsRecordEnumerator(listBucketsRequest);
                foreach (BucketSummary bucketSummary in bucketSummaries)
                {
                    if (bucketSummary.Name.Equals(bucketName))
                    {
                        logger.Info($"Bucket summary without tags: Bucket Name: {bucketSummary.Name}");
                        logger.Info("=========================================");
                        if (bucketSummary.DefinedTags != null)
                        {
                            logger.Error($"expected tags to be zero but got: {bucketSummary.DefinedTags.Count}");
                        }
                        break;
                    }
                }

                List<ListBucketsRequest.FieldsEnum> fields = new List<ListBucketsRequest.FieldsEnum>(){
                    ListBucketsRequest.FieldsEnum.Tags
                };

                listBucketsRequest = new ListBucketsRequest
                {
                    CompartmentId = compartmentId,
                    NamespaceName = nSpace,
                    Fields = fields
                };
                bucketSummaries = osClient.Paginators.ListBucketsRecordEnumerator(listBucketsRequest);
                foreach (BucketSummary bucketSummary in bucketSummaries)
                {
                    if (bucketSummary.Name.Equals(bucketName))
                    {
                        logger.Info($"Bucket summary with tags: Bucket Name: {bucketSummary.Name}");
                        logger.Info("======================================");
                        definedTags = bucketSummary.DefinedTags;
                        foreach (KeyValuePair<string, Dictionary<string, object>> kvp in definedTags)
                        {
                            foreach (KeyValuePair<string, object> tags in kvp.Value)
                            {
                                logger.Info($"tag key name: {tags.Key} and tag value is {tags.Value}");
                            }
                        }
                    }
                }

                /*
                We can also update tags on a bucket. Note that this is a total replacement for any
                previously set freeform or defined tags.
                */
                Dictionary<string, string> updateFreeformTags = new Dictionary<string, string>(){
                    {"new","freeform"}
                };

                Dictionary<string, object> updateDefinedTagsMap = new Dictionary<string, object>(){
                    {tagName, "replaced"}
                };
                Dictionary<string, Dictionary<string, object>> updateDefinedTags = new Dictionary<string, Dictionary<string, object>>(){
                    {tagNamespace, updateDefinedTagsMap}
                };

                UpdateBucketDetails updateBucketDetails = new UpdateBucketDetails
                {
                    Name = bucketName,
                    FreeformTags = updateFreeformTags,
                    DefinedTags = updateDefinedTags
                };
                UpdateBucketRequest updateBucketRequest = new UpdateBucketRequest
                {
                    NamespaceName = nSpace,
                    BucketName = bucketName,
                    UpdateBucketDetails = updateBucketDetails
                };
                UpdateBucketResponse updateBucketResponse = await osClient.UpdateBucket(updateBucketRequest);
                logger.Info($"Updated the bucket with new tags Bucket name: {updateBucketResponse.Bucket.Name}");
                logger.Info("==============================================");
                definedTags = updateBucketResponse.Bucket.DefinedTags;
                foreach (KeyValuePair<string, Dictionary<string, object>> kvp in definedTags)
                {
                    foreach (KeyValuePair<string, object> tags in kvp.Value)
                    {
                        logger.Info($"tag key name: {tags.Key} and tag value is {tags.Value}");
                    }
                }

                updateBucketDetails = new UpdateBucketDetails
                {
                    Name = bucketName,
                    FreeformTags = new Dictionary<string, string>(),
                    DefinedTags = new Dictionary<string, Dictionary<string, object>>()
                };
                updateBucketRequest = new UpdateBucketRequest
                {
                    NamespaceName = nSpace,
                    BucketName = bucketName,
                    UpdateBucketDetails = updateBucketDetails
                };
                updateBucketResponse = await osClient.UpdateBucket(updateBucketRequest);

                logger.Info($"cleared the tags for the bucket: {updateBucketResponse.Bucket.Name}");
                logger.Info("=================================");

                // Clean up
                DeleteBucketRequest deleteBucketRequest = new DeleteBucketRequest
                {
                    NamespaceName = nSpace,
                    BucketName = bucketName
                };
                await osClient.DeleteBucket(deleteBucketRequest);

                logger.Info("Deleted the bucket");
                logger.Info("Ending example.");

            }
            catch (Exception e)
            {
                logger.Error($"Failed Object Storage example: {e.Message}");
            }
            finally
            {
                osClient.Dispose();
            }
        }
    }
}
