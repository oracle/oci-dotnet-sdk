/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.IO;

using Oci.Common.Auth.Internal;

namespace Oci.Common.Auth
{
    /// <summary>
    /// Implementation of OkeWorkloadIdentityAuthenticationDetailsProvider. This provider can only be inside pods
    /// </summary>
    public class OkeWorkloadIdentityAuthenticationDetailsProvider : AbstractRequestingAuthenticationDetailsProvider, IRegionProvider, IRefreshableOnNotAuthenticatedProvider<string>
    {
        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private const string OCI_RESOURCE_PRINCIPAL_REGION_ENV_VAR_NAME = "OCI_RESOURCE_PRINCIPAL_REGION";

        private OkeWorkloadIdentityAuthenticationDetailsProvider(IFederationClient federationClient, ISessionKeySupplier sessionKeySupplier, Region region) : base(federationClient, sessionKeySupplier)
        {
            this.Region = region;
        }

        public static OkeWorkloadIdentityAuthenticationDetailsProvider GetProvider(IServiceAccountTokenSupplier serviceAccountTokenSupplier = null, string token = null, string tokenPath = null)
        {
            return BuildProvider(serviceAccountTokenSupplier, token, tokenPath);
        }

        private static OkeWorkloadIdentityAuthenticationDetailsProvider BuildProvider(IServiceAccountTokenSupplier serviceAccountTokenSupplier, string token, string tokenPath)
        {
            var region = Environment.GetEnvironmentVariable(OCI_RESOURCE_PRINCIPAL_REGION_ENV_VAR_NAME) ?? throw new ArgumentException($"The Environment variable {OCI_RESOURCE_PRINCIPAL_REGION_ENV_VAR_NAME} is required!");
            ISessionKeySupplier sessionKeySupplier = new SessionKey();
            IServiceAccountTokenSupplier serviceAccountTokenSupplierToUse;
            if (serviceAccountTokenSupplier != null)
            {
                serviceAccountTokenSupplierToUse = serviceAccountTokenSupplier;
            }
            else if (!string.IsNullOrEmpty(token))
            {
                serviceAccountTokenSupplierToUse = new SuppliedServiceAccountTokenProvider(token);
            }
            else
            {
                // If tokenPath is null it will use the the default path
                serviceAccountTokenSupplierToUse = new DefaultServiceAccountTokenSupplier(tokenPath);
            }
            IFederationClient federationClient = OkeWorkloadIdentityResourcePrincipalsFederationClient.CreateFederationClient(sessionKeySupplier, serviceAccountTokenSupplierToUse);
            return new OkeWorkloadIdentityAuthenticationDetailsProvider(federationClient, sessionKeySupplier, Region.FromRegionCodeOrId(region));
        }
    }
}