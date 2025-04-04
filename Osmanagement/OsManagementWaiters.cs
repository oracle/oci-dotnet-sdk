/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.OsmanagementService.Models;
using Oci.OsmanagementService.Requests;
using Oci.OsmanagementService.Responses;

namespace Oci.OsmanagementService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of OsManagement.
    /// </summary>
    public class OsManagementWaiters
    {
        private readonly OsManagementClient client;

        public  OsManagementWaiters(OsManagementClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetManagedInstanceGroupRequest, GetManagedInstanceGroupResponse> ForManagedInstanceGroup(GetManagedInstanceGroupRequest request, params LifecycleStates[] targetStates)
        {
            return this.ForManagedInstanceGroup(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetManagedInstanceGroupRequest, GetManagedInstanceGroupResponse> ForManagedInstanceGroup(GetManagedInstanceGroupRequest request, WaiterConfiguration config, params LifecycleStates[] targetStates)
        {
            var agent = new WaiterAgent<GetManagedInstanceGroupRequest, GetManagedInstanceGroupResponse>(
                request,
                request => client.GetManagedInstanceGroup(request),
                response => targetStates.Contains(response.ManagedInstanceGroup.LifecycleState.Value),
                targetStates.Contains(LifecycleStates.Deleted)
            );
            return new Waiter<GetManagedInstanceGroupRequest, GetManagedInstanceGroupResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetScheduledJobRequest, GetScheduledJobResponse> ForScheduledJob(GetScheduledJobRequest request, params LifecycleStates[] targetStates)
        {
            return this.ForScheduledJob(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetScheduledJobRequest, GetScheduledJobResponse> ForScheduledJob(GetScheduledJobRequest request, WaiterConfiguration config, params LifecycleStates[] targetStates)
        {
            var agent = new WaiterAgent<GetScheduledJobRequest, GetScheduledJobResponse>(
                request,
                request => client.GetScheduledJob(request),
                response => targetStates.Contains(response.ScheduledJob.LifecycleState.Value),
                targetStates.Contains(LifecycleStates.Deleted)
            );
            return new Waiter<GetScheduledJobRequest, GetScheduledJobResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetSoftwareSourceRequest, GetSoftwareSourceResponse> ForSoftwareSource(GetSoftwareSourceRequest request, params LifecycleStates[] targetStates)
        {
            return this.ForSoftwareSource(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetSoftwareSourceRequest, GetSoftwareSourceResponse> ForSoftwareSource(GetSoftwareSourceRequest request, WaiterConfiguration config, params LifecycleStates[] targetStates)
        {
            var agent = new WaiterAgent<GetSoftwareSourceRequest, GetSoftwareSourceResponse>(
                request,
                request => client.GetSoftwareSource(request),
                response => targetStates.Contains(response.SoftwareSource.LifecycleState.Value),
                targetStates.Contains(LifecycleStates.Deleted)
            );
            return new Waiter<GetSoftwareSourceRequest, GetSoftwareSourceResponse>(config, agent);
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
