/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.CapacitymanagementService.Models;
using Oci.CapacitymanagementService.Requests;
using Oci.CapacitymanagementService.Responses;

namespace Oci.CapacitymanagementService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of CapacityManagement.
    /// </summary>
    public class CapacityManagementWaiters
    {
        private readonly CapacityManagementClient client;

        public  CapacityManagementWaiters(CapacityManagementClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetOccAvailabilityCatalogRequest, GetOccAvailabilityCatalogResponse> ForOccAvailabilityCatalog(GetOccAvailabilityCatalogRequest request, params OccAvailabilityCatalog.LifecycleStateEnum[] targetStates)
        {
            return this.ForOccAvailabilityCatalog(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetOccAvailabilityCatalogRequest, GetOccAvailabilityCatalogResponse> ForOccAvailabilityCatalog(GetOccAvailabilityCatalogRequest request, WaiterConfiguration config, params OccAvailabilityCatalog.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetOccAvailabilityCatalogRequest, GetOccAvailabilityCatalogResponse>(
                request,
                request => client.GetOccAvailabilityCatalog(request),
                response => targetStates.Contains(response.OccAvailabilityCatalog.LifecycleState.Value),
                targetStates.Contains(OccAvailabilityCatalog.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetOccAvailabilityCatalogRequest, GetOccAvailabilityCatalogResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetOccCapacityRequestRequest, GetOccCapacityRequestResponse> ForOccCapacityRequest(GetOccCapacityRequestRequest request, params OccCapacityRequest.LifecycleStateEnum[] targetStates)
        {
            return this.ForOccCapacityRequest(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetOccCapacityRequestRequest, GetOccCapacityRequestResponse> ForOccCapacityRequest(GetOccCapacityRequestRequest request, WaiterConfiguration config, params OccCapacityRequest.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetOccCapacityRequestRequest, GetOccCapacityRequestResponse>(
                request,
                request => client.GetOccCapacityRequest(request),
                response => targetStates.Contains(response.OccCapacityRequest.LifecycleState.Value),
                targetStates.Contains(OccCapacityRequest.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetOccCapacityRequestRequest, GetOccCapacityRequestResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetOccCustomerGroupRequest, GetOccCustomerGroupResponse> ForOccCustomerGroup(GetOccCustomerGroupRequest request, params OccCustomerGroup.LifecycleStateEnum[] targetStates)
        {
            return this.ForOccCustomerGroup(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetOccCustomerGroupRequest, GetOccCustomerGroupResponse> ForOccCustomerGroup(GetOccCustomerGroupRequest request, WaiterConfiguration config, params OccCustomerGroup.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetOccCustomerGroupRequest, GetOccCustomerGroupResponse>(
                request,
                request => client.GetOccCustomerGroup(request),
                response => targetStates.Contains(response.OccCustomerGroup.LifecycleState.Value),
                targetStates.Contains(OccCustomerGroup.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetOccCustomerGroupRequest, GetOccCustomerGroupResponse>(config, agent);
        }
    }
}
