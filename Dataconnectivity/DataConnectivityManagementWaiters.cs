/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.DataconnectivityService.Models;
using Oci.DataconnectivityService.Requests;
using Oci.DataconnectivityService.Responses;

namespace Oci.DataconnectivityService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of DataConnectivityManagement.
    /// </summary>
    public class DataConnectivityManagementWaiters
    {
        private readonly DataConnectivityManagementClient client;

        public  DataConnectivityManagementWaiters(DataConnectivityManagementClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetEndpointRequest, GetEndpointResponse> ForEndpoint(GetEndpointRequest request, params Endpoint.LifecycleStateEnum[] targetStates)
        {
            return this.ForEndpoint(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetEndpointRequest, GetEndpointResponse> ForEndpoint(GetEndpointRequest request, WaiterConfiguration config, params Endpoint.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetEndpointRequest, GetEndpointResponse>(
                request,
                request => client.GetEndpoint(request),
                response => targetStates.Contains(response.Endpoint.LifecycleState.Value),
                targetStates.Contains(Endpoint.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetEndpointRequest, GetEndpointResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetRegistryRequest, GetRegistryResponse> ForRegistry(GetRegistryRequest request, params Registry.LifecycleStateEnum[] targetStates)
        {
            return this.ForRegistry(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetRegistryRequest, GetRegistryResponse> ForRegistry(GetRegistryRequest request, WaiterConfiguration config, params Registry.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetRegistryRequest, GetRegistryResponse>(
                request,
                request => client.GetRegistry(request),
                response => targetStates.Contains(response.Registry.LifecycleState.Value),
                targetStates.Contains(Registry.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetRegistryRequest, GetRegistryResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetWorkRequestRequest, GetWorkRequestResponse> ForWorkRequest(GetWorkRequestRequest request, params WorkRequest.StatusEnum[] targetStates)
        {
            return this.ForWorkRequest(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetWorkRequestRequest, GetWorkRequestResponse> ForWorkRequest(GetWorkRequestRequest request, WaiterConfiguration config, params WorkRequest.StatusEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetWorkRequestRequest, GetWorkRequestResponse>(
                request,
                request => client.GetWorkRequest(request),
                response => targetStates.Contains(response.WorkRequest.Status.Value)
            );
            return new Waiter<GetWorkRequestRequest, GetWorkRequestResponse>(config, agent);
        }
    }
}
