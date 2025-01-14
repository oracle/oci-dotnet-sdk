/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.DevopsService.Models;
using Oci.DevopsService.Requests;
using Oci.DevopsService.Responses;

namespace Oci.DevopsService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of Devops.
    /// </summary>
    public class DevopsWaiters
    {
        private readonly DevopsClient client;

        public  DevopsWaiters(DevopsClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetBuildPipelineRequest, GetBuildPipelineResponse> ForBuildPipeline(GetBuildPipelineRequest request, params BuildPipeline.LifecycleStateEnum[] targetStates)
        {
            return this.ForBuildPipeline(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetBuildPipelineRequest, GetBuildPipelineResponse> ForBuildPipeline(GetBuildPipelineRequest request, WaiterConfiguration config, params BuildPipeline.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetBuildPipelineRequest, GetBuildPipelineResponse>(
                request,
                request => client.GetBuildPipeline(request),
                response => targetStates.Contains(response.BuildPipeline.LifecycleState.Value),
                targetStates.Contains(BuildPipeline.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetBuildPipelineRequest, GetBuildPipelineResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetBuildPipelineStageRequest, GetBuildPipelineStageResponse> ForBuildPipelineStage(GetBuildPipelineStageRequest request, params BuildPipelineStage.LifecycleStateEnum[] targetStates)
        {
            return this.ForBuildPipelineStage(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetBuildPipelineStageRequest, GetBuildPipelineStageResponse> ForBuildPipelineStage(GetBuildPipelineStageRequest request, WaiterConfiguration config, params BuildPipelineStage.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetBuildPipelineStageRequest, GetBuildPipelineStageResponse>(
                request,
                request => client.GetBuildPipelineStage(request),
                response => targetStates.Contains(response.BuildPipelineStage.LifecycleState.Value),
                targetStates.Contains(BuildPipelineStage.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetBuildPipelineStageRequest, GetBuildPipelineStageResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetBuildRunRequest, GetBuildRunResponse> ForBuildRun(GetBuildRunRequest request, params BuildRun.LifecycleStateEnum[] targetStates)
        {
            return this.ForBuildRun(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetBuildRunRequest, GetBuildRunResponse> ForBuildRun(GetBuildRunRequest request, WaiterConfiguration config, params BuildRun.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetBuildRunRequest, GetBuildRunResponse>(
                request,
                request => client.GetBuildRun(request),
                response => targetStates.Contains(response.BuildRun.LifecycleState.Value)
            );
            return new Waiter<GetBuildRunRequest, GetBuildRunResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetConnectionRequest, GetConnectionResponse> ForConnection(GetConnectionRequest request, params Connection.LifecycleStateEnum[] targetStates)
        {
            return this.ForConnection(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetConnectionRequest, GetConnectionResponse> ForConnection(GetConnectionRequest request, WaiterConfiguration config, params Connection.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetConnectionRequest, GetConnectionResponse>(
                request,
                request => client.GetConnection(request),
                response => targetStates.Contains(response.Connection.LifecycleState.Value)
            );
            return new Waiter<GetConnectionRequest, GetConnectionResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDeployArtifactRequest, GetDeployArtifactResponse> ForDeployArtifact(GetDeployArtifactRequest request, params DeployArtifact.LifecycleStateEnum[] targetStates)
        {
            return this.ForDeployArtifact(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDeployArtifactRequest, GetDeployArtifactResponse> ForDeployArtifact(GetDeployArtifactRequest request, WaiterConfiguration config, params DeployArtifact.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetDeployArtifactRequest, GetDeployArtifactResponse>(
                request,
                request => client.GetDeployArtifact(request),
                response => targetStates.Contains(response.DeployArtifact.LifecycleState.Value),
                targetStates.Contains(DeployArtifact.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetDeployArtifactRequest, GetDeployArtifactResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDeployEnvironmentRequest, GetDeployEnvironmentResponse> ForDeployEnvironment(GetDeployEnvironmentRequest request, params DeployEnvironment.LifecycleStateEnum[] targetStates)
        {
            return this.ForDeployEnvironment(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDeployEnvironmentRequest, GetDeployEnvironmentResponse> ForDeployEnvironment(GetDeployEnvironmentRequest request, WaiterConfiguration config, params DeployEnvironment.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetDeployEnvironmentRequest, GetDeployEnvironmentResponse>(
                request,
                request => client.GetDeployEnvironment(request),
                response => targetStates.Contains(response.DeployEnvironment.LifecycleState.Value),
                targetStates.Contains(DeployEnvironment.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetDeployEnvironmentRequest, GetDeployEnvironmentResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDeployPipelineRequest, GetDeployPipelineResponse> ForDeployPipeline(GetDeployPipelineRequest request, params DeployPipeline.LifecycleStateEnum[] targetStates)
        {
            return this.ForDeployPipeline(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDeployPipelineRequest, GetDeployPipelineResponse> ForDeployPipeline(GetDeployPipelineRequest request, WaiterConfiguration config, params DeployPipeline.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetDeployPipelineRequest, GetDeployPipelineResponse>(
                request,
                request => client.GetDeployPipeline(request),
                response => targetStates.Contains(response.DeployPipeline.LifecycleState.Value),
                targetStates.Contains(DeployPipeline.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetDeployPipelineRequest, GetDeployPipelineResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDeployStageRequest, GetDeployStageResponse> ForDeployStage(GetDeployStageRequest request, params DeployStage.LifecycleStateEnum[] targetStates)
        {
            return this.ForDeployStage(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDeployStageRequest, GetDeployStageResponse> ForDeployStage(GetDeployStageRequest request, WaiterConfiguration config, params DeployStage.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetDeployStageRequest, GetDeployStageResponse>(
                request,
                request => client.GetDeployStage(request),
                response => targetStates.Contains(response.DeployStage.LifecycleState.Value),
                targetStates.Contains(DeployStage.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetDeployStageRequest, GetDeployStageResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDeploymentRequest, GetDeploymentResponse> ForDeployment(GetDeploymentRequest request, params Deployment.LifecycleStateEnum[] targetStates)
        {
            return this.ForDeployment(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDeploymentRequest, GetDeploymentResponse> ForDeployment(GetDeploymentRequest request, WaiterConfiguration config, params Deployment.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetDeploymentRequest, GetDeploymentResponse>(
                request,
                request => client.GetDeployment(request),
                response => targetStates.Contains(response.Deployment.LifecycleState.Value)
            );
            return new Waiter<GetDeploymentRequest, GetDeploymentResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetProjectRequest, GetProjectResponse> ForProject(GetProjectRequest request, params Project.LifecycleStateEnum[] targetStates)
        {
            return this.ForProject(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetProjectRequest, GetProjectResponse> ForProject(GetProjectRequest request, WaiterConfiguration config, params Project.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetProjectRequest, GetProjectResponse>(
                request,
                request => client.GetProject(request),
                response => targetStates.Contains(response.Project.LifecycleState.Value),
                targetStates.Contains(Project.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetProjectRequest, GetProjectResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetPullRequestRequest, GetPullRequestResponse> ForPullRequest(GetPullRequestRequest request, params PullRequest.LifecycleStateEnum[] targetStates)
        {
            return this.ForPullRequest(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetPullRequestRequest, GetPullRequestResponse> ForPullRequest(GetPullRequestRequest request, WaiterConfiguration config, params PullRequest.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetPullRequestRequest, GetPullRequestResponse>(
                request,
                request => client.GetPullRequest(request),
                response => targetStates.Contains(response.PullRequest.LifecycleState.Value),
                targetStates.Contains(PullRequest.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetPullRequestRequest, GetPullRequestResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetRepositoryRequest, GetRepositoryResponse> ForRepository(GetRepositoryRequest request, params Repository.LifecycleStateEnum[] targetStates)
        {
            return this.ForRepository(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetRepositoryRequest, GetRepositoryResponse> ForRepository(GetRepositoryRequest request, WaiterConfiguration config, params Repository.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetRepositoryRequest, GetRepositoryResponse>(
                request,
                request => client.GetRepository(request),
                response => targetStates.Contains(response.Repository.LifecycleState.Value),
                targetStates.Contains(Repository.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetRepositoryRequest, GetRepositoryResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTriggerRequest, GetTriggerResponse> ForTrigger(GetTriggerRequest request, params Trigger.LifecycleStateEnum[] targetStates)
        {
            return this.ForTrigger(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTriggerRequest, GetTriggerResponse> ForTrigger(GetTriggerRequest request, WaiterConfiguration config, params Trigger.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetTriggerRequest, GetTriggerResponse>(
                request,
                request => client.GetTrigger(request),
                response => targetStates.Contains(response.Trigger.LifecycleState.Value)
            );
            return new Waiter<GetTriggerRequest, GetTriggerResponse>(config, agent);
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
