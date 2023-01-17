/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using Oci.Common;
using Oci.Common.Auth;
using Oci.Common.Retry;
using Oci.Common.Waiters;
using Oci.IdentityService;
using Oci.IdentityService.Models;
using Oci.IdentityService.Requests;
using Oci.IdentityService.Responses;

namespace Oci.Examples
{
    /**
    * This class demonstrates how to use a RetryConfiguration with different configurable properties for making retrying calls to the Identity Service.
    */
    public class RetryExample
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        const string OciConfigProfileName = "DEFAULT";
        public static async Task MainRetry()
        {
            string compartmentId = Environment.GetEnvironmentVariable("OCI_COMPARTMENT_ID");

            // Configuring the AuthenticationDetailsProvider. It's assuming there is a default OCI config file
            // "~/.oci/config", and a profile in that config with the name OciConfigProfileName . Make changes to the following
            // line if needed and use ConfigFileAuthenticationDetailsProvider(configurationFilePath, profile);
            var provider = new ConfigFileAuthenticationDetailsProvider(OciConfigProfileName);
            // Create a client for the service to enable using its APIs
            var client = new IdentityClient(provider, new ClientConfiguration());
            try
            {
                await ListOciRegions(client);
                await ListOciRegionSubscriptions(client, compartmentId);
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
            // Create a Retry configuration to override defaults
            RetryConfiguration retryConfiguration = new RetryConfiguration
            {
                // Enable exponential backoff.
                GetNextDelayInSeconds = DelayStrategy.GetExponentialDelayInSeconds,
                //  Defines total duration in seconds for which the retry attempts.
                TotalElapsedTimeInSecs = 600,
                // Defines the total number of retry attempts.
                MaxAttempts = 4,
                // Retryable status code family. This will make the SDK retry for all 5xx.
                RetryableStatusCodeFamilies = new List<int>(new int[] { 5 }),
                // Retrying on certain HTTP Status Ccode and Error code combo.
                RetryableErrors = new Collection<Tuple<int, string>>(new Tuple<int, string>[] {
                    new Tuple<int, string>(409, "IncorrectState"),
                    new Tuple<int, string>(429, "TooManyRequests")
                })
            };
            // List regions
            var listRegionsRequest = new ListRegionsRequest();
            ListRegionsResponse listRegionsResponse = await client.ListRegions(listRegionsRequest, retryConfiguration);
            logger.Info("List Regions");
            logger.Info("=============");
            foreach (Oci.IdentityService.Models.Region reg in listRegionsResponse.Items)
            {
                logger.Info($"{reg.Key} : {reg.Name}");
            }
        }
        private static async Task ListOciRegionSubscriptions(IdentityClient client, string compartmentId)
        {
            // List RegionSubscriptions
            ListRegionSubscriptionsRequest listRegionSubscriptionsRequest = new ListRegionSubscriptionsRequest
            {
                TenancyId = compartmentId
            };
            RetryConfiguration retryConfiguration = new RetryConfiguration
            {
                // Enable exponential backoff with Full Jitter.
                GetNextDelayInSeconds = GetJitterDelayInSeconds
            };
            ListRegionSubscriptionsResponse listRegionSubscriptionsResponse = await client.ListRegionSubscriptions(listRegionSubscriptionsRequest, retryConfiguration);
            List<RegionSubscription> regionSubscriptions = listRegionSubscriptionsResponse.Items;
            logger.Info("List RegionSubscriptions");
            logger.Info("=========================");
            foreach (RegionSubscription regionSubscription in regionSubscriptions)
            {
                logger.Info($"{regionSubscription.RegionName} : {regionSubscription.RegionKey}");
            }
        }

        /// <summary>
        /// Defining a custom retry strategy that mimics an exponential backoff with Full Jitter to reduce
        /// contention between competing calls.
        /// </summary>
        private static double GetJitterDelayInSeconds(int retryAttempt)
        {
            Random random = new Random();
            return random.NextDouble() * Math.Pow(2, retryAttempt);
        }
    }
}
