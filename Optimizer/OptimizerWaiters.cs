/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.OptimizerService.Models;
using Oci.OptimizerService.Requests;
using Oci.OptimizerService.Responses;

namespace Oci.OptimizerService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of Optimizer.
    /// </summary>
    public class OptimizerWaiters
    {
        private readonly OptimizerClient client;

        public  OptimizerWaiters(OptimizerClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetCategoryRequest, GetCategoryResponse> ForCategory(GetCategoryRequest request, params LifecycleState[] targetStates)
        {
            return this.ForCategory(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetCategoryRequest, GetCategoryResponse> ForCategory(GetCategoryRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetCategoryRequest, GetCategoryResponse>(
                request,
                request => client.GetCategory(request),
                response => targetStates.Contains(response.Category.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetCategoryRequest, GetCategoryResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetEnrollmentStatusRequest, GetEnrollmentStatusResponse> ForEnrollmentStatus(GetEnrollmentStatusRequest request, params LifecycleState[] targetStates)
        {
            return this.ForEnrollmentStatus(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetEnrollmentStatusRequest, GetEnrollmentStatusResponse> ForEnrollmentStatus(GetEnrollmentStatusRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetEnrollmentStatusRequest, GetEnrollmentStatusResponse>(
                request,
                request => client.GetEnrollmentStatus(request),
                response => targetStates.Contains(response.EnrollmentStatus.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetEnrollmentStatusRequest, GetEnrollmentStatusResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetProfileRequest, GetProfileResponse> ForProfile(GetProfileRequest request, params LifecycleState[] targetStates)
        {
            return this.ForProfile(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetProfileRequest, GetProfileResponse> ForProfile(GetProfileRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetProfileRequest, GetProfileResponse>(
                request,
                request => client.GetProfile(request),
                response => targetStates.Contains(response.Profile.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetProfileRequest, GetProfileResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetRecommendationRequest, GetRecommendationResponse> ForRecommendation(GetRecommendationRequest request, params LifecycleState[] targetStates)
        {
            return this.ForRecommendation(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetRecommendationRequest, GetRecommendationResponse> ForRecommendation(GetRecommendationRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetRecommendationRequest, GetRecommendationResponse>(
                request,
                request => client.GetRecommendation(request),
                response => targetStates.Contains(response.Recommendation.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetRecommendationRequest, GetRecommendationResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetResourceActionRequest, GetResourceActionResponse> ForResourceAction(GetResourceActionRequest request, params LifecycleState[] targetStates)
        {
            return this.ForResourceAction(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetResourceActionRequest, GetResourceActionResponse> ForResourceAction(GetResourceActionRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetResourceActionRequest, GetResourceActionResponse>(
                request,
                request => client.GetResourceAction(request),
                response => targetStates.Contains(response.ResourceAction.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetResourceActionRequest, GetResourceActionResponse>(config, agent);
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
