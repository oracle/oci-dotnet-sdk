/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.GloballydistributeddatabaseService.Models;
using Oci.GloballydistributeddatabaseService.Requests;
using Oci.GloballydistributeddatabaseService.Responses;

namespace Oci.GloballydistributeddatabaseService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of ShardedDatabaseService.
    /// </summary>
    public class ShardedDatabaseServiceWaiters
    {
        private readonly ShardedDatabaseServiceClient client;

        public  ShardedDatabaseServiceWaiters(ShardedDatabaseServiceClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetPrivateEndpointRequest, GetPrivateEndpointResponse> ForPrivateEndpoint(GetPrivateEndpointRequest request, params PrivateEndpoint.LifecycleStateEnum[] targetStates)
        {
            return this.ForPrivateEndpoint(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetPrivateEndpointRequest, GetPrivateEndpointResponse> ForPrivateEndpoint(GetPrivateEndpointRequest request, WaiterConfiguration config, params PrivateEndpoint.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetPrivateEndpointRequest, GetPrivateEndpointResponse>(
                request,
                request => client.GetPrivateEndpoint(request),
                response => targetStates.Contains(response.PrivateEndpoint.LifecycleState.Value),
                targetStates.Contains(PrivateEndpoint.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetPrivateEndpointRequest, GetPrivateEndpointResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetShardedDatabaseRequest, GetShardedDatabaseResponse> ForShardedDatabase(GetShardedDatabaseRequest request, params ShardedDatabase.LifecycleStateEnum[] targetStates)
        {
            return this.ForShardedDatabase(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetShardedDatabaseRequest, GetShardedDatabaseResponse> ForShardedDatabase(GetShardedDatabaseRequest request, WaiterConfiguration config, params ShardedDatabase.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetShardedDatabaseRequest, GetShardedDatabaseResponse>(
                request,
                request => client.GetShardedDatabase(request),
                response => targetStates.Contains(response.ShardedDatabase.LifecycleState.Value),
                targetStates.Contains(ShardedDatabase.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetShardedDatabaseRequest, GetShardedDatabaseResponse>(config, agent);
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
