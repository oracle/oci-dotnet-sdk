/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.LockboxService.Models;
using Oci.LockboxService.Requests;
using Oci.LockboxService.Responses;

namespace Oci.LockboxService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of Lockbox.
    /// </summary>
    public class LockboxWaiters
    {
        private readonly LockboxClient client;

        public  LockboxWaiters(LockboxClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetAccessRequestRequest, GetAccessRequestResponse> ForAccessRequest(GetAccessRequestRequest request, params AccessRequest.LifecycleStateEnum[] targetStates)
        {
            return this.ForAccessRequest(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetAccessRequestRequest, GetAccessRequestResponse> ForAccessRequest(GetAccessRequestRequest request, WaiterConfiguration config, params AccessRequest.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetAccessRequestRequest, GetAccessRequestResponse>(
                request,
                request => client.GetAccessRequest(request),
                response => targetStates.Contains(response.AccessRequest.LifecycleState.Value)
            );
            return new Waiter<GetAccessRequestRequest, GetAccessRequestResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetApprovalTemplateRequest, GetApprovalTemplateResponse> ForApprovalTemplate(GetApprovalTemplateRequest request, params ApprovalTemplate.LifecycleStateEnum[] targetStates)
        {
            return this.ForApprovalTemplate(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetApprovalTemplateRequest, GetApprovalTemplateResponse> ForApprovalTemplate(GetApprovalTemplateRequest request, WaiterConfiguration config, params ApprovalTemplate.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetApprovalTemplateRequest, GetApprovalTemplateResponse>(
                request,
                request => client.GetApprovalTemplate(request),
                response => targetStates.Contains(response.ApprovalTemplate.LifecycleState.Value),
                targetStates.Contains(ApprovalTemplate.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetApprovalTemplateRequest, GetApprovalTemplateResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetLockboxRequest, GetLockboxResponse> ForLockbox(GetLockboxRequest request, params Lockbox.LifecycleStateEnum[] targetStates)
        {
            return this.ForLockbox(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetLockboxRequest, GetLockboxResponse> ForLockbox(GetLockboxRequest request, WaiterConfiguration config, params Lockbox.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetLockboxRequest, GetLockboxResponse>(
                request,
                request => client.GetLockbox(request),
                response => targetStates.Contains(response.Lockbox.LifecycleState.Value),
                targetStates.Contains(Lockbox.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetLockboxRequest, GetLockboxResponse>(config, agent);
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
