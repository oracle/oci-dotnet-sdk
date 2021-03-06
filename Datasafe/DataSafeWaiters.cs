/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.DatasafeService.Models;
using Oci.DatasafeService.Requests;
using Oci.DatasafeService.Responses;

namespace Oci.DatasafeService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of DataSafe.
    /// </summary>
    public class DataSafeWaiters
    {
        private readonly DataSafeClient client;

        public  DataSafeWaiters(DataSafeClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDataSafeConfigurationRequest, GetDataSafeConfigurationResponse> ForDataSafeConfiguration(GetDataSafeConfigurationRequest request, params LifecycleState[] targetStates)
        {
            return this.ForDataSafeConfiguration(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDataSafeConfigurationRequest, GetDataSafeConfigurationResponse> ForDataSafeConfiguration(GetDataSafeConfigurationRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetDataSafeConfigurationRequest, GetDataSafeConfigurationResponse>(
                request,
                request => client.GetDataSafeConfiguration(request),
                response => targetStates.Contains(response.DataSafeConfiguration.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetDataSafeConfigurationRequest, GetDataSafeConfigurationResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDataSafePrivateEndpointRequest, GetDataSafePrivateEndpointResponse> ForDataSafePrivateEndpoint(GetDataSafePrivateEndpointRequest request, params LifecycleState[] targetStates)
        {
            return this.ForDataSafePrivateEndpoint(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDataSafePrivateEndpointRequest, GetDataSafePrivateEndpointResponse> ForDataSafePrivateEndpoint(GetDataSafePrivateEndpointRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetDataSafePrivateEndpointRequest, GetDataSafePrivateEndpointResponse>(
                request,
                request => client.GetDataSafePrivateEndpoint(request),
                response => targetStates.Contains(response.DataSafePrivateEndpoint.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetDataSafePrivateEndpointRequest, GetDataSafePrivateEndpointResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetOnPremConnectorRequest, GetOnPremConnectorResponse> ForOnPremConnector(GetOnPremConnectorRequest request, params LifecycleState[] targetStates)
        {
            return this.ForOnPremConnector(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetOnPremConnectorRequest, GetOnPremConnectorResponse> ForOnPremConnector(GetOnPremConnectorRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetOnPremConnectorRequest, GetOnPremConnectorResponse>(
                request,
                request => client.GetOnPremConnector(request),
                response => targetStates.Contains(response.OnPremConnector.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetOnPremConnectorRequest, GetOnPremConnectorResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTargetDatabaseRequest, GetTargetDatabaseResponse> ForTargetDatabase(GetTargetDatabaseRequest request, params LifecycleState[] targetStates)
        {
            return this.ForTargetDatabase(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTargetDatabaseRequest, GetTargetDatabaseResponse> ForTargetDatabase(GetTargetDatabaseRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetTargetDatabaseRequest, GetTargetDatabaseResponse>(
                request,
                request => client.GetTargetDatabase(request),
                response => targetStates.Contains(response.TargetDatabase.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetTargetDatabaseRequest, GetTargetDatabaseResponse>(config, agent);
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
