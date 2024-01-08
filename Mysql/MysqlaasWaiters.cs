/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.MysqlService.Models;
using Oci.MysqlService.Requests;
using Oci.MysqlService.Responses;

namespace Oci.MysqlService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of Mysqlaas.
    /// </summary>
    public class MysqlaasWaiters
    {
        private readonly MysqlaasClient client;

        public  MysqlaasWaiters(MysqlaasClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetConfigurationRequest, GetConfigurationResponse> ForConfiguration(GetConfigurationRequest request, params Configuration.LifecycleStateEnum[] targetStates)
        {
            return this.ForConfiguration(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetConfigurationRequest, GetConfigurationResponse> ForConfiguration(GetConfigurationRequest request, WaiterConfiguration config, params Configuration.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetConfigurationRequest, GetConfigurationResponse>(
                request,
                request => client.GetConfiguration(request),
                response => targetStates.Contains(response.Configuration.LifecycleState.Value),
                targetStates.Contains(Configuration.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetConfigurationRequest, GetConfigurationResponse>(config, agent);
        }
    }
}
