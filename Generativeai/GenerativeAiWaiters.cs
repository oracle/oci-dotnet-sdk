/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.GenerativeaiService.Models;
using Oci.GenerativeaiService.Requests;
using Oci.GenerativeaiService.Responses;

namespace Oci.GenerativeaiService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of GenerativeAi.
    /// </summary>
    public class GenerativeAiWaiters
    {
        private readonly GenerativeAiClient client;

        public  GenerativeAiWaiters(GenerativeAiClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDedicatedAiClusterRequest, GetDedicatedAiClusterResponse> ForDedicatedAiCluster(GetDedicatedAiClusterRequest request, params DedicatedAiCluster.LifecycleStateEnum[] targetStates)
        {
            return this.ForDedicatedAiCluster(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDedicatedAiClusterRequest, GetDedicatedAiClusterResponse> ForDedicatedAiCluster(GetDedicatedAiClusterRequest request, WaiterConfiguration config, params DedicatedAiCluster.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetDedicatedAiClusterRequest, GetDedicatedAiClusterResponse>(
                request,
                request => client.GetDedicatedAiCluster(request),
                response => targetStates.Contains(response.DedicatedAiCluster.LifecycleState.Value),
                targetStates.Contains(DedicatedAiCluster.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetDedicatedAiClusterRequest, GetDedicatedAiClusterResponse>(config, agent);
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
        public Waiter<GetModelRequest, GetModelResponse> ForModel(GetModelRequest request, params Model.LifecycleStateEnum[] targetStates)
        {
            return this.ForModel(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetModelRequest, GetModelResponse> ForModel(GetModelRequest request, WaiterConfiguration config, params Model.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetModelRequest, GetModelResponse>(
                request,
                request => client.GetModel(request),
                response => targetStates.Contains(response.Model.LifecycleState.Value),
                targetStates.Contains(Model.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetModelRequest, GetModelResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetWorkRequestRequest, GetWorkRequestResponse> ForWorkRequest(GetWorkRequestRequest request, params OperationStatus[] targetStates)
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
        public Waiter<GetWorkRequestRequest, GetWorkRequestResponse> ForWorkRequest(GetWorkRequestRequest request, WaiterConfiguration config, params OperationStatus[] targetStates)
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
