/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.MarketplaceprivateofferService.Models;
using Oci.MarketplaceprivateofferService.Requests;
using Oci.MarketplaceprivateofferService.Responses;

namespace Oci.MarketplaceprivateofferService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of Attachment.
    /// </summary>
    public class AttachmentWaiters
    {
        private readonly AttachmentClient client;

        public  AttachmentWaiters(AttachmentClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetAttachmentRequest, GetAttachmentResponse> ForAttachment(GetAttachmentRequest request, params Attachment.LifecycleStateEnum[] targetStates)
        {
            return this.ForAttachment(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetAttachmentRequest, GetAttachmentResponse> ForAttachment(GetAttachmentRequest request, WaiterConfiguration config, params Attachment.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetAttachmentRequest, GetAttachmentResponse>(
                request,
                request => client.GetAttachment(request),
                response => targetStates.Contains(response.Attachment.LifecycleState.Value),
                targetStates.Contains(Attachment.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetAttachmentRequest, GetAttachmentResponse>(config, agent);
        }
    }
}
