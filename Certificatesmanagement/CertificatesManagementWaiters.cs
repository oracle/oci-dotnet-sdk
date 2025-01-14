/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.CertificatesmanagementService.Models;
using Oci.CertificatesmanagementService.Requests;
using Oci.CertificatesmanagementService.Responses;

namespace Oci.CertificatesmanagementService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of CertificatesManagement.
    /// </summary>
    public class CertificatesManagementWaiters
    {
        private readonly CertificatesManagementClient client;

        public  CertificatesManagementWaiters(CertificatesManagementClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetAssociationRequest, GetAssociationResponse> ForAssociation(GetAssociationRequest request, params AssociationLifecycleState[] targetStates)
        {
            return this.ForAssociation(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetAssociationRequest, GetAssociationResponse> ForAssociation(GetAssociationRequest request, WaiterConfiguration config, params AssociationLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetAssociationRequest, GetAssociationResponse>(
                request,
                request => client.GetAssociation(request),
                response => targetStates.Contains(response.Association.LifecycleState.Value)
            );
            return new Waiter<GetAssociationRequest, GetAssociationResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetCaBundleRequest, GetCaBundleResponse> ForCaBundle(GetCaBundleRequest request, params CaBundleLifecycleState[] targetStates)
        {
            return this.ForCaBundle(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetCaBundleRequest, GetCaBundleResponse> ForCaBundle(GetCaBundleRequest request, WaiterConfiguration config, params CaBundleLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetCaBundleRequest, GetCaBundleResponse>(
                request,
                request => client.GetCaBundle(request),
                response => targetStates.Contains(response.CaBundle.LifecycleState.Value),
                targetStates.Contains(CaBundleLifecycleState.Deleted)
            );
            return new Waiter<GetCaBundleRequest, GetCaBundleResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetCertificateRequest, GetCertificateResponse> ForCertificate(GetCertificateRequest request, params CertificateLifecycleState[] targetStates)
        {
            return this.ForCertificate(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetCertificateRequest, GetCertificateResponse> ForCertificate(GetCertificateRequest request, WaiterConfiguration config, params CertificateLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetCertificateRequest, GetCertificateResponse>(
                request,
                request => client.GetCertificate(request),
                response => targetStates.Contains(response.Certificate.LifecycleState.Value),
                targetStates.Contains(CertificateLifecycleState.Deleted)
            );
            return new Waiter<GetCertificateRequest, GetCertificateResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetCertificateAuthorityRequest, GetCertificateAuthorityResponse> ForCertificateAuthority(GetCertificateAuthorityRequest request, params CertificateAuthorityLifecycleState[] targetStates)
        {
            return this.ForCertificateAuthority(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetCertificateAuthorityRequest, GetCertificateAuthorityResponse> ForCertificateAuthority(GetCertificateAuthorityRequest request, WaiterConfiguration config, params CertificateAuthorityLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetCertificateAuthorityRequest, GetCertificateAuthorityResponse>(
                request,
                request => client.GetCertificateAuthority(request),
                response => targetStates.Contains(response.CertificateAuthority.LifecycleState.Value),
                targetStates.Contains(CertificateAuthorityLifecycleState.Deleted)
            );
            return new Waiter<GetCertificateAuthorityRequest, GetCertificateAuthorityResponse>(config, agent);
        }
    }
}
