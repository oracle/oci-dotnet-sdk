/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.MonitoringService.Models;
using Oci.MonitoringService.Requests;
using Oci.MonitoringService.Responses;

namespace Oci.MonitoringService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of Monitoring.
    /// </summary>
    public class MonitoringWaiters
    {
        private readonly MonitoringClient client;

        public  MonitoringWaiters(MonitoringClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetAlarmRequest, GetAlarmResponse> ForAlarm(GetAlarmRequest request, params Alarm.LifecycleStateEnum[] targetStates)
        {
            return this.ForAlarm(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetAlarmRequest, GetAlarmResponse> ForAlarm(GetAlarmRequest request, WaiterConfiguration config, params Alarm.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetAlarmRequest, GetAlarmResponse>(
                request,
                request => client.GetAlarm(request),
                response => targetStates.Contains(response.Alarm.LifecycleState.Value),
                targetStates.Contains(Alarm.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetAlarmRequest, GetAlarmResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetAlarmSuppressionRequest, GetAlarmSuppressionResponse> ForAlarmSuppression(GetAlarmSuppressionRequest request, params AlarmSuppression.LifecycleStateEnum[] targetStates)
        {
            return this.ForAlarmSuppression(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetAlarmSuppressionRequest, GetAlarmSuppressionResponse> ForAlarmSuppression(GetAlarmSuppressionRequest request, WaiterConfiguration config, params AlarmSuppression.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetAlarmSuppressionRequest, GetAlarmSuppressionResponse>(
                request,
                request => client.GetAlarmSuppression(request),
                response => targetStates.Contains(response.AlarmSuppression.LifecycleState.Value),
                targetStates.Contains(AlarmSuppression.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetAlarmSuppressionRequest, GetAlarmSuppressionResponse>(config, agent);
        }
    }
}
