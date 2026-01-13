/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
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
        private const string IP_DEBUG_INFORMATION_LOG = "Instance principals authentication can only be used on OCI compute instances. Please confirm this code is running on an OCI compute instance. See https://docs.oracle.com/en-us/iaas/Content/Identity/Tasks/callingservicesfrominstances.htm for more info.";
        public Region Region { get; set; }
        protected IFederationClient federationClient;
        protected ISessionKeySupplier sessionKeySupplier;
        //passphrase is not needed for instance pricipal provider; removing set accessor
        public char[] PassPhraseCharacters { get; }

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

        /// <summary>
        ///
        /// </summary>
        /// <param name="federationClient"></param>
        /// <param name="sessionKeySupplier"></param>
        /// <param name="region"></param>
        public AbstractRequestingAuthenticationDetailsProvider(IFederationClient federationClient, ISessionKeySupplier sessionKeySupplier)
        {
            this.federationClient = federationClient;
            this.sessionKeySupplier = sessionKeySupplier;
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
                try
                {
                    using (var httpClient = new HttpClient())
                    {
                        response = httpClient.SendAsync(httpRequestMsg).Result;
                    }
                }
                catch (Exception ex) when (ex is HttpRequestException || ex is AggregateException)
                {
                    logger.Debug($"Received Exception: {ex}");
                    AggregateException ae = ex is AggregateException ? (AggregateException) ex : new AggregateException(ex);
                    ae.Handle((e) =>
                    {
                        if (e is HttpRequestException)
                        {
                            response = new HttpResponseMessage();
                            response.StatusCode = System.Net.HttpStatusCode.BadRequest;
                            return true;
                        }
                        return false;
                    });
                }
                if (response == null || !response.IsSuccessStatusCode)
                {
                    logger.Debug($"Received non successful response while trying to get the region of the instance. {IP_DEBUG_INFORMATION_LOG}");
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
                    throw new ArgumentNullException($"Either the service, regionId, realm, template, regionId, endpointPrefix, or secondLevelDomain value is empty. {IP_DEBUG_INFORMATION_LOG}", e);
                }
            }
        }

        // Reads the leaf certificate, intermediate certificate and tenancyId from a known location
        protected void AutoDetectCertificatesUsingMetadataUrl()
        {
            logger.Info("Extracting the leaf certificate, tenantId and intermediate certificates");
            leafCertificateSupplier = new URLBasedX509CertificateSupplier(
                GetMetadataResourceDetails(Constants.INSTANCE_CERT),
                GetMetadataResourceDetails(Constants.PRIVATE_KEY_CERT),
                null
            );
            ((URLBasedX509CertificateSupplier)leafCertificateSupplier).Refresh();

            if (string.IsNullOrEmpty(tenancyId))
            {
                tenancyId = AuthUtils.GetTenantIdFromCertificate(leafCertificateSupplier.GetCertificateAndKeyPair().Certificate);
                if (string.IsNullOrEmpty(tenancyId))
                {
                    throw new ArgumentNullException($"TenancyId not found in the leaf certificate. {IP_DEBUG_INFORMATION_LOG}");
                }
                logger.Info($"Tenancy id is {tenancyId}");
            }

            intermediateCertificateSuppliers = new HashSet<IX509CertificateSupplier>();
            var certificate = new URLBasedX509CertificateSupplier(
                GetMetadataResourceDetails(Constants.INTERMEDIATE_KEY_CERT),
                null,
                null
            );
            certificate.Refresh();
            intermediateCertificateSuppliers.Add(certificate);
        }

        private ResourceDetails GetMetadataResourceDetails(string path)
        {
            return new ResourceDetails
            {
                Uri = new Uri(METADATA_SERVICE_BASE_URL + path),
                Headers = new Dictionary<string, string> { { Constants.AUTHORIZATION_HEADER, AUTHORIZATION_HEADER_VALUE } }
            };
        }
    }
}
