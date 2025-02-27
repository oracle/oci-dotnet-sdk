/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.WaasService.Models;
using Oci.WaasService.Requests;
using Oci.WaasService.Responses;

namespace Oci.WaasService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of Redirect.
    /// </summary>
    public class RedirectWaiters
    {
        private readonly RedirectClient client;

        public  RedirectWaiters(RedirectClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetHttpRedirectRequest, GetHttpRedirectResponse> ForHttpRedirect(GetHttpRedirectRequest request, params LifecycleStates[] targetStates)
        {
            return this.ForHttpRedirect(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetHttpRedirectRequest, GetHttpRedirectResponse> ForHttpRedirect(GetHttpRedirectRequest request, WaiterConfiguration config, params LifecycleStates[] targetStates)
        {
            var agent = new WaiterAgent<GetHttpRedirectRequest, GetHttpRedirectResponse>(
                request,
                request => client.GetHttpRedirect(request),
                response => targetStates.Contains(response.HttpRedirect.LifecycleState.Value),
                targetStates.Contains(LifecycleStates.Deleted)
            );
            return new Waiter<GetHttpRedirectRequest, GetHttpRedirectResponse>(config, agent);
        }
    }
}
