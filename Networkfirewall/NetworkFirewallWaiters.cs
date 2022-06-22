/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.NetworkfirewallService.Models;
using Oci.NetworkfirewallService.Requests;
using Oci.NetworkfirewallService.Responses;

namespace Oci.NetworkfirewallService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of NetworkFirewall.
    /// </summary>
    public class NetworkFirewallWaiters
    {
        private readonly NetworkFirewallClient client;

        public  NetworkFirewallWaiters(NetworkFirewallClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetNetworkFirewallRequest, GetNetworkFirewallResponse> ForNetworkFirewall(GetNetworkFirewallRequest request, params LifecycleState[] targetStates)
        {
            return this.ForNetworkFirewall(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetNetworkFirewallRequest, GetNetworkFirewallResponse> ForNetworkFirewall(GetNetworkFirewallRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetNetworkFirewallRequest, GetNetworkFirewallResponse>(
                request,
                request => client.GetNetworkFirewall(request),
                response => targetStates.Contains(response.NetworkFirewall.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetNetworkFirewallRequest, GetNetworkFirewallResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetNetworkFirewallPolicyRequest, GetNetworkFirewallPolicyResponse> ForNetworkFirewallPolicy(GetNetworkFirewallPolicyRequest request, params LifecycleState[] targetStates)
        {
            return this.ForNetworkFirewallPolicy(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetNetworkFirewallPolicyRequest, GetNetworkFirewallPolicyResponse> ForNetworkFirewallPolicy(GetNetworkFirewallPolicyRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetNetworkFirewallPolicyRequest, GetNetworkFirewallPolicyResponse>(
                request,
                request => client.GetNetworkFirewallPolicy(request),
                response => targetStates.Contains(response.NetworkFirewallPolicy.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetNetworkFirewallPolicyRequest, GetNetworkFirewallPolicyResponse>(config, agent);
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