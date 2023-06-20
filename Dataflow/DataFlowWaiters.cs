/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.DataflowService.Models;
using Oci.DataflowService.Requests;
using Oci.DataflowService.Responses;

namespace Oci.DataflowService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of DataFlow.
    /// </summary>
    public class DataFlowWaiters
    {
        private readonly DataFlowClient client;

        public  DataFlowWaiters(DataFlowClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetApplicationRequest, GetApplicationResponse> ForApplication(GetApplicationRequest request, params ApplicationLifecycleState[] targetStates)
        {
            return this.ForApplication(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetApplicationRequest, GetApplicationResponse> ForApplication(GetApplicationRequest request, WaiterConfiguration config, params ApplicationLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetApplicationRequest, GetApplicationResponse>(
                request,
                request => client.GetApplication(request),
                response => targetStates.Contains(response.Application.LifecycleState.Value),
                targetStates.Contains(ApplicationLifecycleState.Deleted)
            );
            return new Waiter<GetApplicationRequest, GetApplicationResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetPoolRequest, GetPoolResponse> ForPool(GetPoolRequest request, params PoolLifecycleState[] targetStates)
        {
            return this.ForPool(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetPoolRequest, GetPoolResponse> ForPool(GetPoolRequest request, WaiterConfiguration config, params PoolLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetPoolRequest, GetPoolResponse>(
                request,
                request => client.GetPool(request),
                response => targetStates.Contains(response.Pool.LifecycleState.Value),
                targetStates.Contains(PoolLifecycleState.Deleted)
            );
            return new Waiter<GetPoolRequest, GetPoolResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetPrivateEndpointRequest, GetPrivateEndpointResponse> ForPrivateEndpoint(GetPrivateEndpointRequest request, params PrivateEndpointLifecycleState[] targetStates)
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
        public Waiter<GetPrivateEndpointRequest, GetPrivateEndpointResponse> ForPrivateEndpoint(GetPrivateEndpointRequest request, WaiterConfiguration config, params PrivateEndpointLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetPrivateEndpointRequest, GetPrivateEndpointResponse>(
                request,
                request => client.GetPrivateEndpoint(request),
                response => targetStates.Contains(response.PrivateEndpoint.LifecycleState.Value),
                targetStates.Contains(PrivateEndpointLifecycleState.Deleted)
            );
            return new Waiter<GetPrivateEndpointRequest, GetPrivateEndpointResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetRunRequest, GetRunResponse> ForRun(GetRunRequest request, params RunLifecycleState[] targetStates)
        {
            return this.ForRun(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetRunRequest, GetRunResponse> ForRun(GetRunRequest request, WaiterConfiguration config, params RunLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetRunRequest, GetRunResponse>(
                request,
                request => client.GetRun(request),
                response => targetStates.Contains(response.Run.LifecycleState.Value)
            );
            return new Waiter<GetRunRequest, GetRunResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetStatementRequest, GetStatementResponse> ForStatement(GetStatementRequest request, params StatementLifecycleState[] targetStates)
        {
            return this.ForStatement(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetStatementRequest, GetStatementResponse> ForStatement(GetStatementRequest request, WaiterConfiguration config, params StatementLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetStatementRequest, GetStatementResponse>(
                request,
                request => client.GetStatement(request),
                response => targetStates.Contains(response.Statement.LifecycleState.Value)
            );
            return new Waiter<GetStatementRequest, GetStatementResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetWorkRequestRequest, GetWorkRequestResponse> ForWorkRequest(GetWorkRequestRequest request, params WorkRequestStatus[] targetStates)
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
        public Waiter<GetWorkRequestRequest, GetWorkRequestResponse> ForWorkRequest(GetWorkRequestRequest request, WaiterConfiguration config, params WorkRequestStatus[] targetStates)
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
