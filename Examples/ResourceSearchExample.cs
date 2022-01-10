/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Oci.ResourcesearchService;
using Oci.ResourcesearchService.Models;
using Oci.ResourcesearchService.Requests;
using Oci.ResourcesearchService.Responses;
using Oci.Common;
using Oci.Common.Auth;
using Oci.Common.Retry;

namespace Oci.Examples
{
    /**
    * This class provides an example on how to use resource-search in the .NET SDK to:
    * 1. List searchable types.
    * 2. Get detail of searchable type.
    * 3. Search resources cross type.
    */

    public class ResourcesearchExample
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static async Task MainResourcesearch()
        {
            logger.Info("Starting example");

            var provider = new ConfigFileAuthenticationDetailsProvider("DEFAULT");

            var client = new ResourceSearchClient(provider);

            logger.Info("List all resource types");
            await ListTypes(client);

            logger.Info("Get Group type details");
            await GetTypeDetails(client, "Group");

            logger.Info("Search for resource by freetext search");
            await FreeTextSearch(client, "admin");

            logger.Info("Search for resource by structed query search");
            await StructuredQuerySearch(client, "query all resources");

            logger.Info("End example");
        }

        private static async Task ListTypes(ResourceSearchClient client)
        {
            var listResourceTypesRequest = new ListResourceTypesRequest { };
            var listResourceTypesResponse = await client.ListResourceTypes(listResourceTypesRequest);

            foreach (var type in listResourceTypesResponse.Items)
            {
                logger.Info($"Resource: {type.Name}");
            }
        }

        private static async Task GetTypeDetails(ResourceSearchClient client, string typeName)
        {
            var getResourceTypeRequest = new GetResourceTypeRequest
            {
                Name = typeName
            };
            var getResourceTypeResponse = await client.GetResourceType(getResourceTypeRequest);

            foreach (var field in getResourceTypeResponse.ResourceType.Fields)
            {
                logger.Info($"FieldName: {field.FieldName}");
            }
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
