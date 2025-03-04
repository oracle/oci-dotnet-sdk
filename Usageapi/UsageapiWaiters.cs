/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.UsageapiService.Models;
using Oci.UsageapiService.Requests;
using Oci.UsageapiService.Responses;

namespace Oci.UsageapiService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of Usageapi.
    /// </summary>
    public class UsageapiWaiters
    {
        private readonly UsageapiClient client;

        public  UsageapiWaiters(UsageapiClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetEmailRecipientsGroupRequest, GetEmailRecipientsGroupResponse> ForEmailRecipientsGroup(GetEmailRecipientsGroupRequest request, params EmailRecipientsGroup.LifecycleStateEnum[] targetStates)
        {
            return this.ForEmailRecipientsGroup(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetEmailRecipientsGroupRequest, GetEmailRecipientsGroupResponse> ForEmailRecipientsGroup(GetEmailRecipientsGroupRequest request, WaiterConfiguration config, params EmailRecipientsGroup.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetEmailRecipientsGroupRequest, GetEmailRecipientsGroupResponse>(
                request,
                request => client.GetEmailRecipientsGroup(request),
                response => targetStates.Contains(response.EmailRecipientsGroup.LifecycleState.Value)
            );
            return new Waiter<GetEmailRecipientsGroupRequest, GetEmailRecipientsGroupResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetScheduleRequest, GetScheduleResponse> ForSchedule(GetScheduleRequest request, params Schedule.LifecycleStateEnum[] targetStates)
        {
            return this.ForSchedule(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetScheduleRequest, GetScheduleResponse> ForSchedule(GetScheduleRequest request, WaiterConfiguration config, params Schedule.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetScheduleRequest, GetScheduleResponse>(
                request,
                request => client.GetSchedule(request),
                response => targetStates.Contains(response.Schedule.LifecycleState.Value)
            );
            return new Waiter<GetScheduleRequest, GetScheduleResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetScheduledRunRequest, GetScheduledRunResponse> ForScheduledRun(GetScheduledRunRequest request, params ScheduledRun.LifecycleStateEnum[] targetStates)
        {
            return this.ForScheduledRun(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetScheduledRunRequest, GetScheduledRunResponse> ForScheduledRun(GetScheduledRunRequest request, WaiterConfiguration config, params ScheduledRun.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetScheduledRunRequest, GetScheduledRunResponse>(
                request,
                request => client.GetScheduledRun(request),
                response => targetStates.Contains(response.ScheduledRun.LifecycleState.Value)
            );
            return new Waiter<GetScheduledRunRequest, GetScheduledRunResponse>(config, agent);
        }
    }
}
