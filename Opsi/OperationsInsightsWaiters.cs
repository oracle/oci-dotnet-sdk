/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.OpsiService.Models;
using Oci.OpsiService.Requests;
using Oci.OpsiService.Responses;

namespace Oci.OpsiService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of OperationsInsights.
    /// </summary>
    public class OperationsInsightsWaiters
    {
        private readonly OperationsInsightsClient client;

        public  OperationsInsightsWaiters(OperationsInsightsClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetAwrHubRequest, GetAwrHubResponse> ForAwrHub(GetAwrHubRequest request, params AwrHubLifecycleState[] targetStates)
        {
            return this.ForAwrHub(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetAwrHubRequest, GetAwrHubResponse> ForAwrHub(GetAwrHubRequest request, WaiterConfiguration config, params AwrHubLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetAwrHubRequest, GetAwrHubResponse>(
                request,
                request => client.GetAwrHub(request),
                response => targetStates.Contains(response.AwrHub.LifecycleState.Value),
                targetStates.Contains(AwrHubLifecycleState.Deleted)
            );
            return new Waiter<GetAwrHubRequest, GetAwrHubResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetAwrHubSourceRequest, GetAwrHubSourceResponse> ForAwrHubSource(GetAwrHubSourceRequest request, params AwrHubSourceLifecycleState[] targetStates)
        {
            return this.ForAwrHubSource(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetAwrHubSourceRequest, GetAwrHubSourceResponse> ForAwrHubSource(GetAwrHubSourceRequest request, WaiterConfiguration config, params AwrHubSourceLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetAwrHubSourceRequest, GetAwrHubSourceResponse>(
                request,
                request => client.GetAwrHubSource(request),
                response => targetStates.Contains(response.AwrHubSource.LifecycleState.Value),
                targetStates.Contains(AwrHubSourceLifecycleState.Deleted)
            );
            return new Waiter<GetAwrHubSourceRequest, GetAwrHubSourceResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDatabaseInsightRequest, GetDatabaseInsightResponse> ForDatabaseInsight(GetDatabaseInsightRequest request, params LifecycleState[] targetStates)
        {
            return this.ForDatabaseInsight(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDatabaseInsightRequest, GetDatabaseInsightResponse> ForDatabaseInsight(GetDatabaseInsightRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetDatabaseInsightRequest, GetDatabaseInsightResponse>(
                request,
                request => client.GetDatabaseInsight(request),
                response => targetStates.Contains(response.DatabaseInsight.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetDatabaseInsightRequest, GetDatabaseInsightResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetEnterpriseManagerBridgeRequest, GetEnterpriseManagerBridgeResponse> ForEnterpriseManagerBridge(GetEnterpriseManagerBridgeRequest request, params LifecycleState[] targetStates)
        {
            return this.ForEnterpriseManagerBridge(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetEnterpriseManagerBridgeRequest, GetEnterpriseManagerBridgeResponse> ForEnterpriseManagerBridge(GetEnterpriseManagerBridgeRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetEnterpriseManagerBridgeRequest, GetEnterpriseManagerBridgeResponse>(
                request,
                request => client.GetEnterpriseManagerBridge(request),
                response => targetStates.Contains(response.EnterpriseManagerBridge.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetEnterpriseManagerBridgeRequest, GetEnterpriseManagerBridgeResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetExadataInsightRequest, GetExadataInsightResponse> ForExadataInsight(GetExadataInsightRequest request, params ExadataInsightLifecycleState[] targetStates)
        {
            return this.ForExadataInsight(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetExadataInsightRequest, GetExadataInsightResponse> ForExadataInsight(GetExadataInsightRequest request, WaiterConfiguration config, params ExadataInsightLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetExadataInsightRequest, GetExadataInsightResponse>(
                request,
                request => client.GetExadataInsight(request),
                response => targetStates.Contains(response.ExadataInsight.LifecycleState.Value),
                targetStates.Contains(ExadataInsightLifecycleState.Deleted)
            );
            return new Waiter<GetExadataInsightRequest, GetExadataInsightResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetHostInsightRequest, GetHostInsightResponse> ForHostInsight(GetHostInsightRequest request, params LifecycleState[] targetStates)
        {
            return this.ForHostInsight(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetHostInsightRequest, GetHostInsightResponse> ForHostInsight(GetHostInsightRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetHostInsightRequest, GetHostInsightResponse>(
                request,
                request => client.GetHostInsight(request),
                response => targetStates.Contains(response.HostInsight.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetHostInsightRequest, GetHostInsightResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetNewsReportRequest, GetNewsReportResponse> ForNewsReport(GetNewsReportRequest request, params LifecycleState[] targetStates)
        {
            return this.ForNewsReport(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetNewsReportRequest, GetNewsReportResponse> ForNewsReport(GetNewsReportRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetNewsReportRequest, GetNewsReportResponse>(
                request,
                request => client.GetNewsReport(request),
                response => targetStates.Contains(response.NewsReport.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetNewsReportRequest, GetNewsReportResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetOperationsInsightsPrivateEndpointRequest, GetOperationsInsightsPrivateEndpointResponse> ForOperationsInsightsPrivateEndpoint(GetOperationsInsightsPrivateEndpointRequest request, params OperationsInsightsPrivateEndpointLifecycleState[] targetStates)
        {
            return this.ForOperationsInsightsPrivateEndpoint(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetOperationsInsightsPrivateEndpointRequest, GetOperationsInsightsPrivateEndpointResponse> ForOperationsInsightsPrivateEndpoint(GetOperationsInsightsPrivateEndpointRequest request, WaiterConfiguration config, params OperationsInsightsPrivateEndpointLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetOperationsInsightsPrivateEndpointRequest, GetOperationsInsightsPrivateEndpointResponse>(
                request,
                request => client.GetOperationsInsightsPrivateEndpoint(request),
                response => targetStates.Contains(response.OperationsInsightsPrivateEndpoint.LifecycleState.Value),
                targetStates.Contains(OperationsInsightsPrivateEndpointLifecycleState.Deleted)
            );
            return new Waiter<GetOperationsInsightsPrivateEndpointRequest, GetOperationsInsightsPrivateEndpointResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetOperationsInsightsWarehouseRequest, GetOperationsInsightsWarehouseResponse> ForOperationsInsightsWarehouse(GetOperationsInsightsWarehouseRequest request, params OperationsInsightsWarehouseLifecycleState[] targetStates)
        {
            return this.ForOperationsInsightsWarehouse(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetOperationsInsightsWarehouseRequest, GetOperationsInsightsWarehouseResponse> ForOperationsInsightsWarehouse(GetOperationsInsightsWarehouseRequest request, WaiterConfiguration config, params OperationsInsightsWarehouseLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetOperationsInsightsWarehouseRequest, GetOperationsInsightsWarehouseResponse>(
                request,
                request => client.GetOperationsInsightsWarehouse(request),
                response => targetStates.Contains(response.OperationsInsightsWarehouse.LifecycleState.Value),
                targetStates.Contains(OperationsInsightsWarehouseLifecycleState.Deleted)
            );
            return new Waiter<GetOperationsInsightsWarehouseRequest, GetOperationsInsightsWarehouseResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetOperationsInsightsWarehouseUserRequest, GetOperationsInsightsWarehouseUserResponse> ForOperationsInsightsWarehouseUser(GetOperationsInsightsWarehouseUserRequest request, params OperationsInsightsWarehouseUserLifecycleState[] targetStates)
        {
            return this.ForOperationsInsightsWarehouseUser(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetOperationsInsightsWarehouseUserRequest, GetOperationsInsightsWarehouseUserResponse> ForOperationsInsightsWarehouseUser(GetOperationsInsightsWarehouseUserRequest request, WaiterConfiguration config, params OperationsInsightsWarehouseUserLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetOperationsInsightsWarehouseUserRequest, GetOperationsInsightsWarehouseUserResponse>(
                request,
                request => client.GetOperationsInsightsWarehouseUser(request),
                response => targetStates.Contains(response.OperationsInsightsWarehouseUser.LifecycleState.Value),
                targetStates.Contains(OperationsInsightsWarehouseUserLifecycleState.Deleted)
            );
            return new Waiter<GetOperationsInsightsWarehouseUserRequest, GetOperationsInsightsWarehouseUserResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetOpsiConfigurationRequest, GetOpsiConfigurationResponse> ForOpsiConfiguration(GetOpsiConfigurationRequest request, params OpsiConfigurationLifecycleState[] targetStates)
        {
            return this.ForOpsiConfiguration(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetOpsiConfigurationRequest, GetOpsiConfigurationResponse> ForOpsiConfiguration(GetOpsiConfigurationRequest request, WaiterConfiguration config, params OpsiConfigurationLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetOpsiConfigurationRequest, GetOpsiConfigurationResponse>(
                request,
                request => client.GetOpsiConfiguration(request),
                response => targetStates.Contains(response.OpsiConfiguration.LifecycleState.Value),
                targetStates.Contains(OpsiConfigurationLifecycleState.Deleted)
            );
            return new Waiter<GetOpsiConfigurationRequest, GetOpsiConfigurationResponse>(config, agent);
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
