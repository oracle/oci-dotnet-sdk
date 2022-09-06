/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Threading;
using System.Threading.Tasks;
using Oci.Common;
using Oci.Common.Auth;
using Oci.IdentityService;
using Oci.IdentityService.Models;
using Oci.IdentityService.Requests;
using Oci.IdentityService.Responses;

namespace Oci.Examples
{
    public class SessionTokenAuthenticationDetailsProviderExample
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static async Task MainSession()
        {
            // Accepts profile name and creates a auth provider based on config file
            var provider = new SessionTokenAuthenticationDetailsProvider(Environment.GetEnvironmentVariable("PROFILE_WITH_SESSION_TOKEN") ?? "DEFAULT");
            // Create a client for the service to enable using its APIs
            var client = new IdentityClient(provider, new ClientConfiguration());

            try
            {
                await ListOciRegions(client);
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
    }
}