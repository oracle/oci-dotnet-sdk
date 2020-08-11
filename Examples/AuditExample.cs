/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Oci.AuditService;
using Oci.AuditService.Models;
using Oci.AuditService.Requests;
using Oci.AuditService.Responses;
using Oci.Common;
using Oci.Common.Auth;
using Oci.Common.Retry;

namespace Oci.Examples
{
    public class AuditExample
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static async Task Main()
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
                    logger.Info("AuditClient created.");

                    ListEventsResponse listEventsResp = await NoRetryExample(client, listEventsRequest);
                    logger.Info($"Received {listEventsResp?.Items.Count} items");

                    ListEventsResponse listEventsRespFromRetry = await RetryExample(client, listEventsRequest);
                    logger.Info($"Received {listEventsRespFromRetry?.Items.Count} items");

                    await CancellationTokenExample(client, listEventsRequest);

                    // GetConfiguration
                    var getConfigurationRequest = new GetConfigurationRequest
                    {
                        CompartmentId = compartmentId
                    };

                    logger.Info("GetConfigurationRequest created.");

                    GetConfigurationResponse getConfigurationResp = await client.GetConfiguration(getConfigurationRequest);
                    logger.Info($"Retention period days: {getConfigurationResp?.Configuration.RetentionPeriodDays}");

                    // UpdateConfiguration
                    var updateConfigurationRequest = new UpdateConfigurationRequest
                    {
                        CompartmentId = compartmentId,
                        UpdateConfigurationDetails = new UpdateConfigurationDetails
                        {
                            RetentionPeriodDays = 90
                        }
                    };

                    logger.Info("UpdateConfigurationRequest created.");

                    UpdateConfigurationResponse updateConfigurationResp = await client.UpdateConfiguration(updateConfigurationRequest);
                    logger.Info($"opc work request id: {updateConfigurationResp.OpcRequestId}");
                }

                // Change the region to US_ASHBURN_1 using SetRegion Call
                // We cannot use the same client to change the region. See:
                // https://stackoverflow.com/questions/51478525/httpclient-this-instance-has-already-started-one-or-more-requests-properties-ca
                using (client = new AuditClient(provider, new ClientConfiguration()))
                {
                    client.SetRegion(Region.US_ASHBURN_1);
                    logger.Info("Changing region to US_ASHBURN_1");
                    ListEventsResponse listEventsRespDiffRegion = await NoRetryExample(client, listEventsRequest);
                    logger.Info($"Received {listEventsRespDiffRegion?.Items.Count} items");
                }
            }
            catch (Exception e)
            {
                logger.Error($"Failed Audit example: {e.Message}");
            }
        }

        public static async Task<ListEventsResponse> NoRetryExample(AuditClient client, ListEventsRequest request)
        {
            logger.Info("Starting NoRetryExample");
            try
            {
                return await client.ListEvents(request);
            }
            catch (Exception e)
            {
                logger.Error($"Failed at NoRetryExample:\n{e}");
                throw;
            }
        }

        public static async Task<ListEventsResponse> CancellationTokenExample(AuditClient client, ListEventsRequest request)
        {
            logger.Info("Starting CancellationToken Example");
            var cts = new CancellationTokenSource();
            cts.Cancel();

            // Pass cancelled cancellation token to the list events list events operations and verify that
            // OperationCanceledException is thrown!
            try
            {
                return await client.ListEvents(request, null, cts.Token);
            }
            catch (OperationCanceledException e)
            {
                logger.Info(e.Message);
                return null;
            }
            catch (Exception e)
            {
                logger.Error($"Failed at CancellationTokenExample:\n{e}");
                throw;
            }
        }

        public static async Task<ListEventsResponse> RetryExample(AuditClient client, ListEventsRequest request)
        {
            logger.Info("Starting RetryExample");
            try
            {
                return await client.ListEvents(request, new RetryConfiguration { MaxAttempts = 5 });
            }
            catch (Exception e)
            {
                logger.Error($"Failed at RetryExample:\n{e}");
                throw;
            }
        }
    }
}
