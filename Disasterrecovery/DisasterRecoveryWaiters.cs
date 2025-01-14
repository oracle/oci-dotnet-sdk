/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.DisasterrecoveryService.Models;
using Oci.DisasterrecoveryService.Requests;
using Oci.DisasterrecoveryService.Responses;

namespace Oci.DisasterrecoveryService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of DisasterRecovery.
    /// </summary>
    public class DisasterRecoveryWaiters
    {
        private readonly DisasterRecoveryClient client;

        public  DisasterRecoveryWaiters(DisasterRecoveryClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDrPlanRequest, GetDrPlanResponse> ForDrPlan(GetDrPlanRequest request, params DrPlanLifecycleState[] targetStates)
        {
            return this.ForDrPlan(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDrPlanRequest, GetDrPlanResponse> ForDrPlan(GetDrPlanRequest request, WaiterConfiguration config, params DrPlanLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetDrPlanRequest, GetDrPlanResponse>(
                request,
                request => client.GetDrPlan(request),
                response => targetStates.Contains(response.DrPlan.LifecycleState.Value),
                targetStates.Contains(DrPlanLifecycleState.Deleted)
            );
            return new Waiter<GetDrPlanRequest, GetDrPlanResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDrPlanExecutionRequest, GetDrPlanExecutionResponse> ForDrPlanExecution(GetDrPlanExecutionRequest request, params DrPlanExecutionLifecycleState[] targetStates)
        {
            return this.ForDrPlanExecution(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDrPlanExecutionRequest, GetDrPlanExecutionResponse> ForDrPlanExecution(GetDrPlanExecutionRequest request, WaiterConfiguration config, params DrPlanExecutionLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetDrPlanExecutionRequest, GetDrPlanExecutionResponse>(
                request,
                request => client.GetDrPlanExecution(request),
                response => targetStates.Contains(response.DrPlanExecution.LifecycleState.Value),
                targetStates.Contains(DrPlanExecutionLifecycleState.Deleted)
            );
            return new Waiter<GetDrPlanExecutionRequest, GetDrPlanExecutionResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDrProtectionGroupRequest, GetDrProtectionGroupResponse> ForDrProtectionGroup(GetDrProtectionGroupRequest request, params DrProtectionGroupLifecycleState[] targetStates)
        {
            return this.ForDrProtectionGroup(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDrProtectionGroupRequest, GetDrProtectionGroupResponse> ForDrProtectionGroup(GetDrProtectionGroupRequest request, WaiterConfiguration config, params DrProtectionGroupLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetDrProtectionGroupRequest, GetDrProtectionGroupResponse>(
                request,
                request => client.GetDrProtectionGroup(request),
                response => targetStates.Contains(response.DrProtectionGroup.LifecycleState.Value),
                targetStates.Contains(DrProtectionGroupLifecycleState.Deleted)
            );
            return new Waiter<GetDrProtectionGroupRequest, GetDrProtectionGroupResponse>(config, agent);
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
