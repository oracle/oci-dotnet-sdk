/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.CompilerServices;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

using Newtonsoft.Json;
using Org.BouncyCastle.Crypto.Parameters;

using Oci.Common.Auth.Utils;
using Oci.Common.Utils;
using Oci.Common.Model;

namespace Oci.Common.Auth.Internal
{
    /// <summary>
    /// OkeWorkloadIdentityResourcePrincipalsFederationClient class is used for the federation client for the OkeWorkloadIdentityAuthenticationDetailsProvider
    /// </summary>
    public class OkeWorkloadIdentityResourcePrincipalsFederationClient : IFederationClient
    {
        private const string PROXYMUX_SERVER_PORT = "12250";
        private const string KUBERNETES_SERVICE_HOST = "KUBERNETES_SERVICE_HOST";
        // Default path for reading Kubernetes service account cert.
        private const string DEFAULT_OCI_KUBERNETES_SERVICE_ACCOUNT_CERT_PATH = "/var/run/secrets/kubernetes.io/serviceaccount/ca.crt";
        // Environment variable of the path for Kubernetes service account cert
        private const string OCI_KUBERNETES_SERVICE_ACCOUNT_CERT_PATH = "OCI_KUBERNETES_SERVICE_ACCOUNT_CERT_PATH";
        private SecurityTokenAdapter securityTokenAdapter;
        private readonly ISessionKeySupplier sessionKeySupplier;
        private readonly IServiceAccountTokenSupplier serviceAccountTokenSupplier;
        private readonly string resourcePrincipalTokenEndpoint;
        private readonly string kubernetesCaCertPath;
        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public string GetSecurityToken()
        {
            double time = 0;
            if (securityTokenAdapter.IsValid())
            {
                if (securityTokenAdapter.GetTokenValidDuration() > 1)
                {
                    time = securityTokenAdapter.GetTokenValidDuration() / 2;
                }
            }
            return RefreshAndGetSecurityTokenIfExpiringWithin(true, time);
        }

        public string RefreshAndGetSecurityTokenIfExpiringWithin(bool doFinalTokenValidityCheck, double time)
        {
            return RefreshAndGetSecurityTokenInner(doFinalTokenValidityCheck, time);
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        private string RefreshAndGetSecurityTokenInner(bool doFinalTokenValidityCheck, double time = 0d)
        {
            // Check again to see if the JWT is still invalid, unless we want to skip that check
            if (!doFinalTokenValidityCheck || !securityTokenAdapter.IsValid(time))
            {
                logger.Info("Refreshing session keys");
                sessionKeySupplier.RefreshKeys();
                securityTokenAdapter = GetSecurityTokenFromServer();
                return securityTokenAdapter.SecurityToken;
            }
            return securityTokenAdapter.SecurityToken;
        }

        private HttpClientHandler buildOkeHttpClientHandler()
        {
            try
            {
                X509Certificate2 customRootCACert = new X509Certificate2(kubernetesCaCertPath);
                HttpClientHandler handler = new HttpClientHandler
                {
                    ClientCertificateOptions = ClientCertificateOption.Automatic,
                    SslProtocols = System.Security.Authentication.SslProtocols.Tls12,
                    // Implemented from https://stackoverflow.com/a/33637819
                    ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) =>
                    {
                        if ((sslPolicyErrors & (SslPolicyErrors.None)) > 0) { return true; }

                        if (
                            (sslPolicyErrors & (SslPolicyErrors.RemoteCertificateNameMismatch)) > 0 ||
                            (sslPolicyErrors & (SslPolicyErrors.RemoteCertificateNotAvailable)) > 0
                        )
                        {
                            return false;
                        }
                        // get last chain element that should contain root CA certificate
                        // but this may not be the case in partial chains
                        X509Certificate2 projectedRootCert = chain.ChainElements[chain.ChainElements.Count - 1].Certificate;
                        // execute certificate chaining engine and ignore only "UntrustedRoot" error
                        X509Chain customChain = new X509Chain
                        {
                            ChainPolicy = {
                                    VerificationFlags = X509VerificationFlags.AllowUnknownCertificateAuthority
                            }
                        };
                        Boolean retValue = customChain.Build(chain.ChainElements[0].Certificate);
                        // RELEASE unmanaged resources behind X509Chain class.
                        customChain.Reset();
                        return retValue;
                    }
                };
                return handler;

            }
            catch (CryptographicException)
            {
                logger.Info($"Exception in Reading X509 certificate from file: {kubernetesCaCertPath} or adding it to trust store");
                throw;
            }
        }

        private SecurityTokenAdapter GetSecurityTokenFromServer()
        {
            logger.Info("Getting security token from the proxymux server");
            // Get service account token and retrieve the public key
            var token = serviceAccountTokenSupplier.ServiceAccountToken;
            var keyPair = sessionKeySupplier.GetKeyPair() ?? throw new ArgumentNullException("Key pair for session was not provided");
            var publicKey = (RsaKeyParameters)keyPair.Public ?? throw new ArgumentNullException("Public key is not present");

            // generating a full 3 part opc-request-id for rpst call
            var opcRequestId = HttpUtils.GenerateRequestID();
            logger.Debug($"Request id for resourcePrincipalSessionTokens request: {opcRequestId}");

            var publicKeyDer = AuthUtils.GetBase64EncodedKey(publicKey);

            // Build HTTP Request
            var request = new GetOkeResourcePrincipalSessionTokenRequest
            {
                GetOkeResourcePrincipalSessionTokenDetails = new GetOkeResourcePrincipalSessionTokenDetails(publicKeyDer),
                OpcClientRequestId = opcRequestId
            };
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(new Uri($"{resourcePrincipalTokenEndpoint}/resourcePrincipalSessionTokens"), new HttpMethod("POST"), request);

            var client = new HttpClient(buildOkeHttpClientHandler());
            try
            {
                // Send Request to Proxymux server
                requestMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", $"{token}");
                requestMessage.Headers.UserAgent.ParseAdd(HttpUtils.BuildUserAgent(""));

                // Send request to get response from server
                var response = client.SendAsync(requestMessage).Result;
                if (response.IsSuccessStatusCode)
                {
                    // The string response from proxymux server contains " at beginning and end, so we need to remove those
                    var tokenResponse = response.Content.ReadAsStringAsync().Result?.Trim('"');
                    logger.Debug($"Response from Proxymux server: {tokenResponse}");
                    if (!string.IsNullOrEmpty(tokenResponse))
                    {
                        // Decode the token
                        byte[] data = Convert.FromBase64String(tokenResponse);
                        string decodedTokenResponse = System.Text.Encoding.UTF8.GetString(data);
                        var decodedToken = JsonConvert.DeserializeObject<OkeResourcePrincipalSessionToken>(decodedTokenResponse).token;
                        logger.Debug($"Decoded token from Proxymux server: {decodedToken}");

                        // Remove dupilcate ST$ from token
                        string jwtToken = decodedToken.Substring(3);
                        return new SecurityTokenAdapter(jwtToken, sessionKeySupplier);
                    }
                    throw new OciException("Response from proxymux server was empty", new ArgumentNullException());
                }
                else
                {
                    throw new OciException(response.StatusCode, "Request to get OKE Resource Principals Token failed", response.ReasonPhrase, opcRequestId);
                }
            }
            catch (Exception)
            {
                logger.Error($"Exception while getting Token from proxymux server");
                throw;
            }
            finally
            {
                client.Dispose();
            }
        }

        public string GetStringClaim(string key)
        {
            RefreshAndGetSecurityTokenInner(true);
            return securityTokenAdapter.GetStringClaim(key);
        }

        public string RefreshAndGetSecurityToken()
        {
            return RefreshAndGetSecurityTokenInner(false);
        }

        private OkeWorkloadIdentityResourcePrincipalsFederationClient(ISessionKeySupplier keySupplier, string kubernetesCaCertPath, IServiceAccountTokenSupplier tokenSupplier)
        {
            sessionKeySupplier = keySupplier;
            serviceAccountTokenSupplier = tokenSupplier;
            securityTokenAdapter = new SecurityTokenAdapter(null, sessionKeySupplier);
            this.kubernetesCaCertPath = kubernetesCaCertPath;
            resourcePrincipalTokenEndpoint = getRptEndpoint();
        }

        private static string getRptEndpoint()
        {
            // Read proxymux ip address from environment variable.
            string host = Environment.GetEnvironmentVariable(KUBERNETES_SERVICE_HOST) ?? throw new ArgumentException($"Invalid environment variable {KUBERNETES_SERVICE_HOST}, please contact OKE Foundation team for help.");
            // Set proxymux resourcePrincipalSessionTokens endpoint for requesting rpst token
            return $"https://{host}:{PROXYMUX_SERVER_PORT}";
        }

        public static OkeWorkloadIdentityResourcePrincipalsFederationClient CreateFederationClient(ISessionKeySupplier sessionKeySupplier, IServiceAccountTokenSupplier serviceAccountTokenSupplier)
        {
            string kubernetesCaCertPath = Environment.GetEnvironmentVariable(OCI_KUBERNETES_SERVICE_ACCOUNT_CERT_PATH) ?? DEFAULT_OCI_KUBERNETES_SERVICE_ACCOUNT_CERT_PATH;
            kubernetesCaCertPath = FileUtils.ExpandUserHome(kubernetesCaCertPath);
            if (File.Exists(kubernetesCaCertPath))
            {
                return new OkeWorkloadIdentityResourcePrincipalsFederationClient(sessionKeySupplier, kubernetesCaCertPath, serviceAccountTokenSupplier);
            }
            else
            {
                throw new ArgumentException("Kubernetes service account ca cert doesn't exist.");
            }
        }
    }

    internal class GetOkeResourcePrincipalSessionTokenDetails
    {
        public string podKey { get; }

        public GetOkeResourcePrincipalSessionTokenDetails(string key)
        {
            podKey = key;
        }
    }

    internal class GetOkeResourcePrincipalSessionTokenRequest : IOciRequest
    {
        /// <value>
        /// The GetOkeResourcePrincipalSessionTokenDetails for getting the Resource Principal Token.
        /// </value>
        [Required(ErrorMessage = "GetOkeResourcePrincipalSessionTokenDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public GetOkeResourcePrincipalSessionTokenDetails GetOkeResourcePrincipalSessionTokenDetails { get; set; }

        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-client-request-id")]
        public string OpcClientRequestId { get; set; }
    }

    internal class OkeResourcePrincipalSessionToken
    {
        /// <value>
        /// Oke Resource Principal Sesstion token to be used
        /// </value>
        public string token { get; set; }
    }
}
