/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.IO;

using Oci.Common.Auth.Internal;

namespace Oci.Common.Auth
{
    /// <summary>
    /// An authentication details providers that make remote requests via Resource Prinicipals
    /// </summary>
    public class ResourcePrincipalAuthenticationDetailsProvider : AbstractRequestingAuthenticationDetailsProvider,
                IRegionProvider,
                IRefreshableOnNotAuthenticatedProvider<string>
    {
        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private const string OCI_RESOURCE_PRINCIPAL_VERSION = "OCI_RESOURCE_PRINCIPAL_VERSION";
        private const string RP_VERSION_1_1 = "1.1";
        private const string RP_VERSION_2_2 = "2.2";
        private const string OCI_RESOURCE_PRINCIPAL_RPST = "OCI_RESOURCE_PRINCIPAL_RPST";
        private const string OCI_RESOURCE_PRINCIPAL_PRIVATE_PEM = "OCI_RESOURCE_PRINCIPAL_PRIVATE_PEM";
        private const string OCI_RESOURCE_PRINCIPAL_PRIVATE_PEM_PASSPHRASE = "OCI_RESOURCE_PRINCIPAL_PRIVATE_PEM_PASSPHRASE";
        private const string OCI_RESOURCE_PRINCIPAL_REGION_ENV_VAR_NAME = "OCI_RESOURCE_PRINCIPAL_REGION";
        private const string RP_DEBUG_INFORMATION_LOG = "Resource principals authentication can only be used in certain OCI services. Please check that the OCI service you're running this code from supports Resource principals. See https://docs.oracle.com/en-us/iaas/Content/API/Concepts/sdk_authentication_methods.htm#sdk_authentication_methods_resource_principal for more info.";


        /// <summary>
        /// A Resource Principals Authentication Details Provider implmentation.
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="NotImplementedException"></exception>
        /// <exception cref="ArgumentException"></exception>
        private ResourcePrincipalAuthenticationDetailsProvider(IFederationClient federationClient, ISessionKeySupplier sessionKeySupplier, Region region) : base(federationClient, sessionKeySupplier)
        {
            this.Region = region;
        }

        public static ResourcePrincipalAuthenticationDetailsProvider GetProvider()
        {
            var OciResourcePrincipalVersion = Environment.GetEnvironmentVariable(OCI_RESOURCE_PRINCIPAL_VERSION);
            if (OciResourcePrincipalVersion == null)
            {
                throw new ArgumentNullException($"Environment variable {OCI_RESOURCE_PRINCIPAL_VERSION} missing! {RP_DEBUG_INFORMATION_LOG}");
            }
            logger.Debug($"Getting ResourcePrincipalAuthenticationDetailsProvider for version {OciResourcePrincipalVersion}");
            switch (OciResourcePrincipalVersion)
            {
                case RP_VERSION_2_2:
                    return Build_2_2();
                case RP_VERSION_1_1:
                    throw new NotImplementedException($"$Resource Principals version {RP_VERSION_1_1} is not supported yet!");
                default:
                    throw new ArgumentException($"Invalid Resource Principals version {OciResourcePrincipalVersion} was set in environment variable {OCI_RESOURCE_PRINCIPAL_VERSION}");
            }
        }

        /// <summary>
        /// Build the Resource Principals Version 2.2 authentication provider
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        private static ResourcePrincipalAuthenticationDetailsProvider Build_2_2()
        {
            ISessionKeySupplier sessionKeySupplier;
            IFederationClient federationClient;

            string ociResourcePrincipalPrivateKey = Environment.GetEnvironmentVariable(OCI_RESOURCE_PRINCIPAL_PRIVATE_PEM);
            if (ociResourcePrincipalPrivateKey == null)
            {
                throw new ArgumentNullException($"Environment variable {OCI_RESOURCE_PRINCIPAL_PRIVATE_PEM} is missing! {RP_DEBUG_INFORMATION_LOG}");
            }
            string ociResourcePrincipalPassphrase = Environment.GetEnvironmentVariable(OCI_RESOURCE_PRINCIPAL_PRIVATE_PEM_PASSPHRASE);

            // Set the sessionKeySupplier for Resource Principals Provider
            // Check if a File path was provided for ociResourcePrincipalPrivateKey
            if (Path.IsPathRooted(ociResourcePrincipalPrivateKey))
            {
                if (ociResourcePrincipalPassphrase != null && !Path.IsPathRooted(ociResourcePrincipalPassphrase))
                {
                    throw new ArgumentException($"Cannot mix path and constant settings for {OCI_RESOURCE_PRINCIPAL_PRIVATE_PEM} and {OCI_RESOURCE_PRINCIPAL_PRIVATE_PEM_PASSPHRASE}");
                }
                sessionKeySupplier = new FileBasedKeySupplier(ociResourcePrincipalPrivateKey, ociResourcePrincipalPassphrase);
            }
            // Private Key was provided directly
            else
            {
                sessionKeySupplier = new FixedContentKeySupplier(ociResourcePrincipalPrivateKey, ociResourcePrincipalPassphrase);
            }

            // Set the Federation client for Resource Principals Provider
            string ociResourcePrincipalRPST = Environment.GetEnvironmentVariable(OCI_RESOURCE_PRINCIPAL_RPST);
            if (ociResourcePrincipalRPST == null)
            {
                throw new ArgumentNullException($"Environment variable {OCI_RESOURCE_PRINCIPAL_RPST} is missing! {RP_DEBUG_INFORMATION_LOG}");
            }
            if (Path.IsPathRooted(ociResourcePrincipalRPST))
            {
                federationClient = new FileBasedResourcePrincipalFederationClient(sessionKeySupplier, ociResourcePrincipalRPST);
            }
            else
            {
                federationClient = new FixedContentResourcePrincipalFederationClient(sessionKeySupplier, ociResourcePrincipalRPST);
            }
            // Set the Region for Resource Principals
            string ociResourcePrincipalRegion = Environment.GetEnvironmentVariable(OCI_RESOURCE_PRINCIPAL_REGION_ENV_VAR_NAME);
            if (ociResourcePrincipalRegion == null)
            {
                throw new ArgumentNullException($"Environment variable {OCI_RESOURCE_PRINCIPAL_REGION_ENV_VAR_NAME} is missing! {RP_DEBUG_INFORMATION_LOG}");
            }
            Region region = Region.FromRegionCodeOrId(ociResourcePrincipalRegion);
            return new ResourcePrincipalAuthenticationDetailsProvider(federationClient, sessionKeySupplier, region);
        }
    }
}