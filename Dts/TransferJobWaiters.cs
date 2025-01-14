/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.DtsService.Models;
using Oci.DtsService.Requests;
using Oci.DtsService.Responses;

namespace Oci.DtsService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of TransferJob.
    /// </summary>
    public class TransferJobWaiters
    {
        private readonly TransferJobClient client;

        public  TransferJobWaiters(TransferJobClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTransferJobRequest, GetTransferJobResponse> ForTransferJob(GetTransferJobRequest request, params TransferJob.LifecycleStateEnum[] targetStates)
        {
            return this.ForTransferJob(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTransferJobRequest, GetTransferJobResponse> ForTransferJob(GetTransferJobRequest request, WaiterConfiguration config, params TransferJob.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetTransferJobRequest, GetTransferJobResponse>(
                request,
                request => client.GetTransferJob(request),
                response => targetStates.Contains(response.TransferJob.LifecycleState.Value),
                targetStates.Contains(TransferJob.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetTransferJobRequest, GetTransferJobResponse>(config, agent);
        }
    }
}
