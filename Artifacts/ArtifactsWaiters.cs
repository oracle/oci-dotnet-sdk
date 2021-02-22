/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.ArtifactsService.Models;
using Oci.ArtifactsService.Requests;
using Oci.ArtifactsService.Responses;

namespace Oci.ArtifactsService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of Artifacts.
    /// </summary>
    public class ArtifactsWaiters
    {
        private readonly ArtifactsClient client;

        public  ArtifactsWaiters(ArtifactsClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetContainerImageRequest, GetContainerImageResponse> ForContainerImage(GetContainerImageRequest request, params ContainerImage.LifecycleStateEnum[] targetStates)
        {
            return this.ForContainerImage(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetContainerImageRequest, GetContainerImageResponse> ForContainerImage(GetContainerImageRequest request, WaiterConfiguration config, params ContainerImage.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetContainerImageRequest, GetContainerImageResponse>(
                request,
                request => client.GetContainerImage(request),
                response => targetStates.Contains(response.ContainerImage.LifecycleState.Value),
                targetStates.Contains(ContainerImage.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetContainerImageRequest, GetContainerImageResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetContainerRepositoryRequest, GetContainerRepositoryResponse> ForContainerRepository(GetContainerRepositoryRequest request, params ContainerRepository.LifecycleStateEnum[] targetStates)
        {
            return this.ForContainerRepository(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetContainerRepositoryRequest, GetContainerRepositoryResponse> ForContainerRepository(GetContainerRepositoryRequest request, WaiterConfiguration config, params ContainerRepository.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetContainerRepositoryRequest, GetContainerRepositoryResponse>(
                request,
                request => client.GetContainerRepository(request),
                response => targetStates.Contains(response.ContainerRepository.LifecycleState.Value),
                targetStates.Contains(ContainerRepository.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetContainerRepositoryRequest, GetContainerRepositoryResponse>(config, agent);
        }
    }
}
