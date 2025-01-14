/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System.Threading.Tasks;
using Oci.ResourcesearchService;
using Oci.ResourcesearchService.Models;
using Oci.ResourcesearchService.Requests;
using Oci.Common.Auth;

namespace Oci.Examples
{
    /**
    * This class demonstrates on Polymorphic objects.
    * The SearchDetails can be of type either FreeText Search or StructuredQuery Search
    */

    public class PolymorphicObjectExample
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static async Task MainPolymorphicObject()
        {
            logger.Info("Starting example");

            var provider = new ConfigFileAuthenticationDetailsProvider("DEFAULT");

            var client = new ResourceSearchClient(provider);

            logger.Info("Search for resource by freetext search");
            await FreeTextSearch(client, "admin");

            logger.Info("Search for resource by structed query search");
            await StructuredQuerySearch(client, "query all resources");

            logger.Info("End example");
        }

        private static async Task FreeTextSearch(ResourceSearchClient client, string text)
        {
            var searchResourcesRequest = new SearchResourcesRequest
            {
                SearchDetails = new FreeTextSearchDetails
                {
                    Text = text,
                    MatchingContextType = SearchDetails.MatchingContextTypeEnum.Highlights
                }
            };
            var searchResourcesResponse = await client.SearchResources(searchResourcesRequest);

            foreach (var resource in searchResourcesResponse.ResourceSummaryCollection.Items)
            {
                logger.Info($"Resource: {resource.DisplayName}");
            }
        }

        private static async Task StructuredQuerySearch(ResourceSearchClient client, string query)
        {
            var searchResourcesRequest = new SearchResourcesRequest
            {
                SearchDetails = new StructuredSearchDetails
                {
                    MatchingContextType = SearchDetails.MatchingContextTypeEnum.Highlights,
                    Query = query
                }
            };
            var searchResourcesResponse = await client.SearchResources(searchResourcesRequest);

            foreach (var resource in searchResourcesResponse.ResourceSummaryCollection.Items)
            {
                logger.Info($"Resource: {resource.DisplayName}");
            }
        }
    }
}
