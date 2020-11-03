/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Oci.LoadbalancerService;
using Oci.LoadbalancerService.Models;
using Oci.LoadbalancerService.Requests;
using Oci.Common.Auth;
using Oci.Common.Waiters;

namespace Oci.Examples
{
    /**
    * Please refer to https://docs.cloud.oracle.com/iaas/api/#/en/loadbalancer/latest/RuleSet/CreateRuleSet
    * for information about using the API to create a rule set.
    * This example requires an existing LoadBalancer and it will create new rule set.
    *
    * This example demonstrates how to use waiters on work requests.
    * Waiters can be used to wait on some condition either in blocking or async manner.
    * In this example, a work request is submitted to create a ruleset.
    * It uses waiters on the work request to be succeeded.
    */

    public class WaitersExample
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        private static string RuleSetName = "oci_dotnet_sdk_example_ruleset";

        public static async Task MainWaiters()
        {
            logger.Info("Starting example");

            var provider = new ConfigFileAuthenticationDetailsProvider("DEFAULT");

            var compartmentId = Environment.GetEnvironmentVariable("OCI_COMPARTMENT_ID");
            var loadBalancerId = Environment.GetEnvironmentVariable("LOADBALANCER_ID");
            var backendSetName = Environment.GetEnvironmentVariable("BACKEND_SET_NAME");

            var loadBalancerClient = new LoadBalancerClient(provider);

            try
            {
                var ruleSet = await CreateRuleSet(loadBalancerClient, loadBalancerId);
            }
            catch (Exception e)
            {
                logger.Error($"Failed to add ruleset: {e}");
            }
            finally
            {
                loadBalancerClient.Dispose();
            }

            logger.Info("End example");
        }

        private static async Task<RuleSet> CreateRuleSet(LoadBalancerClient lbClient, string loadBalancerId)
        {
            logger.Info($"Creating new rule set: {RuleSetName}");

            List<Rule> rules = new List<Rule>();

            var addHttpRequestHeaderRule = new AddHttpRequestHeaderRule
            {
                Header = "someRequestHeader",
                Value = "/example/1"
            };
            var extendHttpRequestHeaderValueRule = new ExtendHttpRequestHeaderValueRule
            {
                Header = "someRequestHeader",
                Suffix = "Some-static-suffix-value",
                Prefix = "Some-static-prefix-value"
            };
            var removeHttpResponseHeaderRule = new RemoveHttpResponseHeaderRule
            {
                Header = "someResponseHeader"
            };

            rules.Add(addHttpRequestHeaderRule);
            rules.Add(extendHttpRequestHeaderValueRule);
            rules.Add(removeHttpResponseHeaderRule);

            var createRuleSetDetails = new CreateRuleSetDetails
            {
                Name = RuleSetName,
                Items = rules
            };
            var createRuleSetRequest = new CreateRuleSetRequest
            {
                CreateRuleSetDetails = createRuleSetDetails,
                LoadBalancerId = loadBalancerId
            };
            var createRuleSetResponse = await lbClient.CreateRuleSet(createRuleSetRequest);

            var waiterConfiguration = new WaiterConfiguration
            {
                MaxAttempts = 20,
                GetNextDelayInSeconds = DelayStrategy.GetExponentialDelayInSeconds
            };
            var getWorkRequestRequest = new GetWorkRequestRequest
            {
                WorkRequestId = createRuleSetResponse.OpcWorkRequestId
            };
            // using waiters
            lbClient.Waiters.ForWorkRequest(getWorkRequestRequest, waiterConfiguration, WorkRequest.LifecycleStateEnum.Succeeded).Execute();

            logger.Info($"RuleSet: {RuleSetName} is created");
            var getRuleSetRequest = new GetRuleSetRequest
            {
                LoadBalancerId = loadBalancerId,
                RuleSetName = RuleSetName
            };
            var getRuleSetResponse = await lbClient.GetRuleSet(getRuleSetRequest);

            return getRuleSetResponse.RuleSet;
        }
    }
}
