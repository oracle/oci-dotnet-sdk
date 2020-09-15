/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Net.Http;
using Org.BouncyCastle.Crypto.Parameters;
using Oci.Common.Auth.Internal;
using Oci.Common.Auth.Utils;
using Oci.Common.Internal;
using Oci.Common.Http.Internal;

namespace Oci.Common.Auth
{
    /// <summary>
    /// Base class for authentication details providers that make remote requests.
    /// </summary>
    public abstract class AbstractRequestingAuthenticationDetailsProvider : IBasicAuthenticationDetailsProvider,
                    IRegionProvider,
                    IRefreshableOnNotAuthenticatedProvider<string>
    {
        /**
        * Service instance for auth.
        */
        private static Service SERVICE = Services.Create("AUTH", "auth", "");

        /**
        * Default base url of metadata service.
        */
        private static string METADATA_SERVICE_BASE_URL = "http://169.254.169.254/opc/v2/";

        /**
        * The Authorization header value to be sent for requests to the metadata service.
        */
        private static string AUTHORIZATION_HEADER_VALUE = "Bearer Oracle";

        /**
        * The federation endpoint url.
        */
        private string federationEndpoint;

        /**
        * The leaf certificate, or null if detecting from instance metadata.
        */
        private IX509CertificateSupplier leafCertificateSupplier;

        private HashSet<IX509CertificateSupplier> intermediateCertificateSuppliers;

        /**
        * Tenancy OCI, or null if detecting from instance metadata.
        */
        private string tenancyId;
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public Region Region { get; set; }
        private IFederationClient federationClient;
        private ISessionKeySupplier sessionKeySupplier;
        public char[] PassPhraseCharacters { get; set; }

        public AbstractRequestingAuthenticationDetailsProvider()
        {
            AutoDetectUsingMetadataUrl();
            sessionKeySupplier = new SessionKey();
            federationClient = new X509FederationClient(
                federationEndpoint,
                tenancyId,
                leafCertificateSupplier,
                sessionKeySupplier,
                intermediateCertificateSuppliers);
        }

        /// <summary>The KeyId used in the authorization header for the API call to OCI services.</summary>
        /// <returns>Returns the KeyId.</returns>
        public string KeyId
        {
            get
            {
                return "ST$" + federationClient.GetSecurityToken();
            }
        }

        /// <summary>The API requests made by the instance are signed by the private key.</summary>
        /// <returns>Returns the private key.</returns>
        public RsaKeyParameters GetPrivateKey()
        {
            return (RsaKeyParameters)sessionKeySupplier.GetKeyPair().Private;
        }

        /// <summary>
        /// Refreshes the authentication data used by the provider.
        /// </summary>
        /// <returns> The refreshed authentication data.</returns>
        public string Refresh()
        {
            return this.federationClient.RefreshAndGetSecurityToken();
        }

        protected void AutoDetectUsingMetadataUrl()
        {
            AutoDetectEndpointUsingMetadataUrl();
            AutoDetectCertificatesUsingMetadataUrl();
        }

        // Detects the region in which the instance is present and forms the endpoint for the Auth Service
        protected void AutoDetectEndpointUsingMetadataUrl()
        {
            logger.Info("Detecting federation endpoint");
            if (String.IsNullOrEmpty(this.federationEndpoint))
            {
                var url = METADATA_SERVICE_BASE_URL + Constants.INSTANCE_REGION;
                var httpRequestMsg = new HttpRequestMessage(HttpMethod.Get, new Uri(url));
                httpRequestMsg.Headers.Add(Constants.ACCEPT_HEADER, Constants.ACCEPT_TYPE);
                httpRequestMsg.Headers.Add(Constants.AUTHORIZATION_HEADER, AUTHORIZATION_HEADER_VALUE);

                HttpResponseMessage response = null;
                using (var httpClient = new HttpClient())
                {
                    response = httpClient.SendAsync(httpRequestMsg).Result;
                }
                if (response == null || !response.IsSuccessStatusCode)
                {
                    logger.Debug("Received non successful response while trying to get the region of the instance");
                    ResponseHelper.HandleNonSuccessfulResponse(response);
                }

                // regionStr can be a shortCode or regionId
                var regionStr = response.Content.ReadAsStringAsync().Result;
                try
                {
                    this.Region = Region.FromRegionCodeOrId(regionStr);
                }
                catch (ArgumentException e)
                {
                    logger.Warn($"Received exception: {e}, Region not supported by this version of the SDK, registering region {regionStr} under OC1 realm");
                    this.Region = Region.Register(regionStr, Realm.OC1);
                }

                try
                {
                    this.federationEndpoint = EndpointBuilder.CreateEndpoint(SERVICE, this.Region.RegionId, this.Region.Realm);
                    logger.Info($"federation endpoint is {this.federationEndpoint}");
                }
                catch (ArgumentNullException e)
                {
                    throw new ArgumentNullException($"Either the service, regionId, realm, template, regionId, endpointPrefix, or secondLevelDomain value is empty", e);
                }
            }
        }

        // Reads the leaf certificate, intermediate certificate and tenancyId from a known location
        protected void AutoDetectCertificatesUsingMetadataUrl()
        {
            logger.Info("Extracting the leaf certificate, tenantId and intermediate certificates");
            if (leafCertificateSupplier == null)
            {
                leafCertificateSupplier = new URLBasedX509CertificateSupplier(
                    GetMetadataResourceDetails(Constants.INSTANCE_CERT),
                    GetMetadataResourceDetails(Constants.PRIVATE_KEY_CERT),
                    null
                );
                ((URLBasedX509CertificateSupplier)leafCertificateSupplier).Refresh();
            }

            if (String.IsNullOrEmpty(tenancyId))
            {
                tenancyId = AuthUtils.GetTenantIdFromCertificate(leafCertificateSupplier.GetCertificateAndKeyPair().Certificate);
                if (String.IsNullOrEmpty(tenancyId))
                {
                    throw new ArgumentNullException("TenancyId not found in the leaf certificate");
                }
                logger.Info($"Tenancy id is {tenancyId}");
            }

            if (intermediateCertificateSuppliers == null)
            {
                intermediateCertificateSuppliers = new HashSet<IX509CertificateSupplier>();
                var certificate = new URLBasedX509CertificateSupplier(
                    GetMetadataResourceDetails(Constants.INTERMEDIATE_KEY_CERT),
                    null,
                    null
                );
                certificate.Refresh();
                intermediateCertificateSuppliers.Add(certificate);
            }
        }

        private ResourceDetails GetMetadataResourceDetails(
            string path)
        {
            return new ResourceDetails
            {
                Uri = new Uri(METADATA_SERVICE_BASE_URL + path),
                Headers = new Dictionary<string, string> { { Constants.AUTHORIZATION_HEADER, AUTHORIZATION_HEADER_VALUE } }
            };
        }
    }
}
