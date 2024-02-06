/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.KeymanagementService.Models;
using Oci.KeymanagementService.Requests;
using Oci.KeymanagementService.Responses;

namespace Oci.KeymanagementService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of KmsHsmCluster.
    /// </summary>
    public class KmsHsmClusterWaiters
    {
        private readonly KmsHsmClusterClient client;

        public  KmsHsmClusterWaiters(KmsHsmClusterClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetHsmClusterRequest, GetHsmClusterResponse> ForHsmCluster(GetHsmClusterRequest request, params HsmCluster.LifecycleStateEnum[] targetStates)
        {
            return this.ForHsmCluster(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetHsmClusterRequest, GetHsmClusterResponse> ForHsmCluster(GetHsmClusterRequest request, WaiterConfiguration config, params HsmCluster.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetHsmClusterRequest, GetHsmClusterResponse>(
                request,
                request => client.GetHsmCluster(request),
                response => targetStates.Contains(response.HsmCluster.LifecycleState.Value),
                targetStates.Contains(HsmCluster.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetHsmClusterRequest, GetHsmClusterResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetHsmPartitionRequest, GetHsmPartitionResponse> ForHsmPartition(GetHsmPartitionRequest request, params HsmPartition.LifecycleStateEnum[] targetStates)
        {
            return this.ForHsmPartition(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetHsmPartitionRequest, GetHsmPartitionResponse> ForHsmPartition(GetHsmPartitionRequest request, WaiterConfiguration config, params HsmPartition.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetHsmPartitionRequest, GetHsmPartitionResponse>(
                request,
                request => client.GetHsmPartition(request),
                response => targetStates.Contains(response.HsmPartition.LifecycleState.Value)
            );
            return new Waiter<GetHsmPartitionRequest, GetHsmPartitionResponse>(config, agent);
        }
    }
}
