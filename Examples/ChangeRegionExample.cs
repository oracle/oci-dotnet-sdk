/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Threading.Tasks;
using Oci.AuditService;
using Oci.AuditService.Requests;
using Oci.AuditService.Responses;
using Oci.Common;
using Oci.Common.Auth;

namespace Oci.Examples
{
    /**
    * This example demonstrates how to change the OCI region.
    */
    public class ChangeRegionExample
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static async Task MainChangeRegion()
        {
            logger.Info("Starting example");
            AuditClient client = null;

            try
            {
                // Assumption: the compartment id has been set in environment variable.
                var compartmentId = Environment.GetEnvironmentVariable("OCI_COMPARTMENT_ID");
                logger.Info(compartmentId);

                // ListEvents
                var listEventsRequest = new ListEventsRequest
                {
                    CompartmentId = compartmentId,
                    StartTime = DateTime.Now.AddDays(-1),
                    EndTime = DateTime.Now
                };

                // Create AuditClient
                var provider = new ConfigFileAuthenticationDetailsProvider("DEFAULT");

                using (client = new AuditClient(provider, new ClientConfiguration()))
                {
                    logger.Info($"AuditClient created. Region is set to: {provider.Region}");
                    ListEventsResponse listEventsResp = await GetEvents(client, listEventsRequest);
                    logger.Info($"Received {listEventsResp?.Items.Count} items");
                }

                // Change the region to US_ASHBURN_1 using SetRegion Call
                // We cannot use the same client to change the region. See:
                // https://stackoverflow.com/questions/51478525/httpclient-this-instance-has-already-started-one-or-more-requests-properties-ca
                using (client = new AuditClient(provider, new ClientConfiguration()))
                {
                    client.SetRegion(Region.US_ASHBURN_1);
                    logger.Info("Changing region to US_ASHBURN_1");
                    ListEventsResponse listEventsRespDiffRegion = await GetEvents(client, listEventsRequest);
                    logger.Info($"Received {listEventsRespDiffRegion?.Items.Count} items");
                }
            }
            catch (Exception e)
            {
                logger.Error($"Failed Change Region example: {e.Message}");
            }
        }

        public static async Task<ListEventsResponse> GetEvents(AuditClient client, ListEventsRequest request)
        {
            logger.Info("Get events");
            try
            {
                return await client.ListEvents(request);
            }
            catch (Exception e)
            {
                logger.Error($"Failed at GetEvents:\n{e}");
                throw;
            }
        }
    }
}
