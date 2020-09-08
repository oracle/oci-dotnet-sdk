/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Oci.Common;
using Oci.Common.Auth;
using Oci.IdentityService;
using Oci.IdentityService.Models;
using Oci.IdentityService.Requests;
using Oci.IdentityService.Responses;

namespace Oci.Examples
{
    public class InstancePrincipleExample
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static async Task MainInstancePrincipal()
        {
            // expose the tenancyId for the environment variable OCI_COMPARTMENT_ID
            string tenantId = Environment.GetEnvironmentVariable("OCI_COMPARTMENT_ID");

            // Creates an Instance Principal provider that holds authentication details of the OCI Instance
            // This helps in making API requests by the Instance without user involvement
            var instanceProvider = new InstancePrincipalsAuthenticationDetailsProvider();

            // Create a client for the service to enable using its APIs
            var client = new IdentityClient(instanceProvider, new ClientConfiguration());

            try
            {
                await ListOciRegions(client);
                await ListOciRegionSubscriptions(client, tenantId);
            }
            catch (Exception e)
            {
                logger.Info($"Received exception due to {e.Message}");
            }
            finally
            {
                client.Dispose();
            }
        }

        private static async Task ListOciRegions(IdentityClient client)
        {
            // List regions
            var listRegionsRequest = new ListRegionsRequest();
            ListRegionsResponse listRegionsResponse = await client.ListRegions(listRegionsRequest);
            logger.Info("List Regions");
            logger.Info("=============");
            foreach (Oci.IdentityService.Models.Region reg in listRegionsResponse.Items)
            {
                logger.Info($"{reg.Key} : {reg.Name}");
            }
        }

        private static async Task ListOciRegionSubscriptions(IdentityClient client, string tenantId)
        {
            // List RegionSubscriptions
            ListRegionSubscriptionsRequest listRegionSubscriptionsRequest = new ListRegionSubscriptionsRequest
            {
                TenancyId = tenantId
            };
            ListRegionSubscriptionsResponse listRegionSubscriptionsResponse = await client.ListRegionSubscriptions(listRegionSubscriptionsRequest);
            List<RegionSubscription> regionSubscriptions = listRegionSubscriptionsResponse.Items;
            logger.Info("List RegionSubscriptions");
            logger.Info("=========================");
            foreach (RegionSubscription regionSubscription in regionSubscriptions)
            {
                logger.Info($"{regionSubscription.RegionName} : {regionSubscription.RegionKey}");
            }
        }
    }
}
