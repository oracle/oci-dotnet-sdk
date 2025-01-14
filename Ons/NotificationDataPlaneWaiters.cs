/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.OnsService.Models;
using Oci.OnsService.Requests;
using Oci.OnsService.Responses;

namespace Oci.OnsService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of NotificationDataPlane.
    /// </summary>
    public class NotificationDataPlaneWaiters
    {
        private readonly NotificationDataPlaneClient client;

        public  NotificationDataPlaneWaiters(NotificationDataPlaneClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetSubscriptionRequest, GetSubscriptionResponse> ForSubscription(GetSubscriptionRequest request, params Subscription.LifecycleStateEnum[] targetStates)
        {
            return this.ForSubscription(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetSubscriptionRequest, GetSubscriptionResponse> ForSubscription(GetSubscriptionRequest request, WaiterConfiguration config, params Subscription.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetSubscriptionRequest, GetSubscriptionResponse>(
                request,
                request => client.GetSubscription(request),
                response => targetStates.Contains(response.Subscription.LifecycleState.Value),
                targetStates.Contains(Subscription.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetSubscriptionRequest, GetSubscriptionResponse>(config, agent);
        }
    }
}
