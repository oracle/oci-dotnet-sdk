/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.FleetappsmanagementService.Models;
using Oci.FleetappsmanagementService.Requests;
using Oci.FleetappsmanagementService.Responses;

namespace Oci.FleetappsmanagementService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of FleetAppsManagementMaintenanceWindow.
    /// </summary>
    public class FleetAppsManagementMaintenanceWindowWaiters
    {
        private readonly FleetAppsManagementMaintenanceWindowClient client;

        public  FleetAppsManagementMaintenanceWindowWaiters(FleetAppsManagementMaintenanceWindowClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetMaintenanceWindowRequest, GetMaintenanceWindowResponse> ForMaintenanceWindow(GetMaintenanceWindowRequest request, params MaintenanceWindow.LifecycleStateEnum[] targetStates)
        {
            return this.ForMaintenanceWindow(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetMaintenanceWindowRequest, GetMaintenanceWindowResponse> ForMaintenanceWindow(GetMaintenanceWindowRequest request, WaiterConfiguration config, params MaintenanceWindow.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetMaintenanceWindowRequest, GetMaintenanceWindowResponse>(
                request,
                request => client.GetMaintenanceWindow(request),
                response => targetStates.Contains(response.MaintenanceWindow.LifecycleState.Value),
                targetStates.Contains(MaintenanceWindow.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetMaintenanceWindowRequest, GetMaintenanceWindowResponse>(config, agent);
        }
    }
}
