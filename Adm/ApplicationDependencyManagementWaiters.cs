/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.AdmService.Models;
using Oci.AdmService.Requests;
using Oci.AdmService.Responses;

namespace Oci.AdmService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of ApplicationDependencyManagement.
    /// </summary>
    public class ApplicationDependencyManagementWaiters
    {
        private readonly ApplicationDependencyManagementClient client;

        public  ApplicationDependencyManagementWaiters(ApplicationDependencyManagementClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetKnowledgeBaseRequest, GetKnowledgeBaseResponse> ForKnowledgeBase(GetKnowledgeBaseRequest request, params KnowledgeBase.LifecycleStateEnum[] targetStates)
        {
            return this.ForKnowledgeBase(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetKnowledgeBaseRequest, GetKnowledgeBaseResponse> ForKnowledgeBase(GetKnowledgeBaseRequest request, WaiterConfiguration config, params KnowledgeBase.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetKnowledgeBaseRequest, GetKnowledgeBaseResponse>(
                request,
                request => client.GetKnowledgeBase(request),
                response => targetStates.Contains(response.KnowledgeBase.LifecycleState.Value),
                targetStates.Contains(KnowledgeBase.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetKnowledgeBaseRequest, GetKnowledgeBaseResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetRemediationRecipeRequest, GetRemediationRecipeResponse> ForRemediationRecipe(GetRemediationRecipeRequest request, params RemediationRecipe.LifecycleStateEnum[] targetStates)
        {
            return this.ForRemediationRecipe(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetRemediationRecipeRequest, GetRemediationRecipeResponse> ForRemediationRecipe(GetRemediationRecipeRequest request, WaiterConfiguration config, params RemediationRecipe.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetRemediationRecipeRequest, GetRemediationRecipeResponse>(
                request,
                request => client.GetRemediationRecipe(request),
                response => targetStates.Contains(response.RemediationRecipe.LifecycleState.Value),
                targetStates.Contains(RemediationRecipe.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetRemediationRecipeRequest, GetRemediationRecipeResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetRemediationRunRequest, GetRemediationRunResponse> ForRemediationRun(GetRemediationRunRequest request, params RemediationRun.LifecycleStateEnum[] targetStates)
        {
            return this.ForRemediationRun(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetRemediationRunRequest, GetRemediationRunResponse> ForRemediationRun(GetRemediationRunRequest request, WaiterConfiguration config, params RemediationRun.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetRemediationRunRequest, GetRemediationRunResponse>(
                request,
                request => client.GetRemediationRun(request),
                response => targetStates.Contains(response.RemediationRun.LifecycleState.Value),
                targetStates.Contains(RemediationRun.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetRemediationRunRequest, GetRemediationRunResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetVulnerabilityAuditRequest, GetVulnerabilityAuditResponse> ForVulnerabilityAudit(GetVulnerabilityAuditRequest request, params VulnerabilityAudit.LifecycleStateEnum[] targetStates)
        {
            return this.ForVulnerabilityAudit(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetVulnerabilityAuditRequest, GetVulnerabilityAuditResponse> ForVulnerabilityAudit(GetVulnerabilityAuditRequest request, WaiterConfiguration config, params VulnerabilityAudit.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetVulnerabilityAuditRequest, GetVulnerabilityAuditResponse>(
                request,
                request => client.GetVulnerabilityAudit(request),
                response => targetStates.Contains(response.VulnerabilityAudit.LifecycleState.Value),
                targetStates.Contains(VulnerabilityAudit.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetVulnerabilityAuditRequest, GetVulnerabilityAuditResponse>(config, agent);
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
