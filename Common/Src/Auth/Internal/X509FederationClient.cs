/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading;
using Newtonsoft.Json;
using Org.BouncyCastle.Crypto.Parameters;
using Oci.Common.Auth.Utils;
using Oci.Common.CircuitBreaker;
using Oci.Common.Http.Internal;
using Oci.Common.Http.Signing;
using Oci.Common.Model;
using Oci.Common.Utils;
using Polly;

namespace Oci.Common.Auth.Internal
{
    /// <summary> This class gets a security token from the auth service by signing the request with a
    /// PKI issued leaf certificate, passing along a temporary public key that is bounded to the
    /// security token, and the leaf certificate.
    /// </summary>
    public class X509FederationClient : IFederationClient
    {
        private static string DEFAULT_PURPOSE = "DEFAULT";
        private IX509CertificateSupplier leafCertificateSupplier;
        private string tenancyId;
        private HashSet<IX509CertificateSupplier> intermediateCertificateSuppliers;
        private ISessionKeySupplier sessionKeySupplier;
        private string purpose;
        private string federationEndpoint;
        private volatile SecurityTokenAdapter securityTokenAdapter = null;
        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public HttpClient Client { get; set; }
        public IFederationRequestSigner FederationSigner { get; set; }
        public Polly.CircuitBreaker.AsyncCircuitBreakerPolicy DefaultAuthClientCircuitBreakerPolicy = CircuitBreakerFactory.GetCircuitBreakerPolicy(
            exceptionsAllowedBeforeBreaking: Constants.DEFAULT_AUTH_CIRCUIT_BREAKER_THRESHOLD,
            durationOfBreak: TimeSpan.FromSeconds(30),
            onBreak: (exception, breakDelay) =>
                    {
                        logger.Info($"Circuit broken! Exception: {exception.Message}. Break time: {breakDelay.TotalSeconds} seconds.");
                    },
                    onReset: () =>
                    {
                        logger.Info("Circuit reset.");
                    },
                    onHalfOpen: () =>
                    {
                        logger.Info("Circuit is half-open, allowing trial execution.");
                    }
            );

        public X509FederationClient(
                string federationEndpoint,
                string tenancyId,
                IX509CertificateSupplier leafCertificateSupplier,
                ISessionKeySupplier sessionKeySupplier,
                HashSet<IX509CertificateSupplier> intermediateCertificateSuppliers)
            : this(
                federationEndpoint,
                tenancyId,
                leafCertificateSupplier,
                sessionKeySupplier,
                intermediateCertificateSuppliers,
                DEFAULT_PURPOSE,
                new FederationRequestSigner())
        { }

        public X509FederationClient(
                string federationEndpoint,
                string tenancyId,
                IX509CertificateSupplier leafCertificateSupplier,
                ISessionKeySupplier sessionKeySupplier,
                HashSet<IX509CertificateSupplier> intermediateCertificateSuppliers,
                string purpose,
                IFederationRequestSigner federationRequestSigner)
        {
            this.federationEndpoint = federationEndpoint;
            this.leafCertificateSupplier = leafCertificateSupplier ?? throw new NullReferenceException();
            this.sessionKeySupplier = sessionKeySupplier ?? throw new NullReferenceException();
            this.intermediateCertificateSuppliers = intermediateCertificateSuppliers;
            this.tenancyId = tenancyId ?? throw new NullReferenceException();
            this.securityTokenAdapter = new SecurityTokenAdapter(null, null);
            this.purpose = purpose ?? throw new NullReferenceException();
            this.FederationSigner = federationRequestSigner;
        }

        /// <summary>Gets a security token. If there is already a valid token cached, it will be returned.
        /// Else this will make a call to the auth service to get a new token, using the provided suppliers.
        /// This method is thread-safe.
        /// </summary>
        /// <returns>The security token.</returns>
        public string GetSecurityToken()
        {
            if (securityTokenAdapter.IsValid())
            {
                return securityTokenAdapter.SecurityToken;
            }
            return RefreshAndGetSecurityTokenInner(true);
        }

        /// <summary>Return a claim embedded in the security token.</summary>
        /// <param name="key">key the name of the claim.</param>
        /// <returns>The value of the claim.</returns>
        public string GetStringClaim(string key)
        {
            RefreshAndGetSecurityTokenInner(true);
            return securityTokenAdapter.GetStringClaim(key);
        }

        /// <summary>
        /// Gets a security token from the federation endpoint. This will always retreive
        /// a new token from the federation endpoint and does not use a cached token.
        /// </summary>
        /// <returns> A security token that can be used to authenticate requests. </returns>
        public string RefreshAndGetSecurityToken()
        {
            return RefreshAndGetSecurityTokenInner(false);
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        private string RefreshAndGetSecurityTokenInner(bool doFinalTokenValidityCheck)
        {
            // Check again to see if the JWT is still invalid, unless we want to skip that check
            if (!doFinalTokenValidityCheck || !this.securityTokenAdapter.IsValid())
            {
                logger.Info("Refreshing session keys");
                sessionKeySupplier.RefreshKeys();

                if (leafCertificateSupplier != null)
                {
                    try
                    {
                        this.leafCertificateSupplier.Refresh();
                    }
                    catch (Exception e)
                    {
                        throw new OciException($"Failed to refresh the leaf Certificate: ", e);
                    }

                    // When using default purpose (ex, instance principals), the token request should always be signed with the same tenant id as the certificate.
                    // For other purposes, the tenant id can be different.
                    if (this.purpose.Equals(DEFAULT_PURPOSE))
                    {
                        string newTenancyId = AuthUtils.GetTenantIdFromCertificate(this.leafCertificateSupplier.GetCertificateAndKeyPair().Certificate);

                        if (!tenancyId.Equals(newTenancyId))
                        {
                            throw new InvalidDataException("The tenancy id should never be changed in cert file!");
                        }
                    }
                }

                foreach (var supplier in intermediateCertificateSuppliers)
                {
                    try
                    {
                        supplier.Refresh();
                    }
                    catch (Exception e)
                    {
                        throw new OciException($"Failed to refresh the intermediate certificate: ", e);
                    }
                }
                securityTokenAdapter = GetSecurityTokenFromServer();
                return securityTokenAdapter.SecurityToken;
            }
            return securityTokenAdapter.SecurityToken;
        }

        /// <summary>
        /// Gets a security token from the federation server.
        /// </summary>
        /// <returns>
        /// The security token, which is basically a JWT token string.
        /// </returns>
        private SecurityTokenAdapter GetSecurityTokenFromServer()
        {
            logger.Info("Getting security token from the auth server");

            var keyPair = sessionKeySupplier.GetKeyPair();
            if (keyPair == null)
            {
                throw new InvalidOperationException("Keypair is not generated, it is null");
            }

            var publicKey = (RsaKeyParameters)keyPair.Public;
            if (publicKey == null)
            {
                throw new InvalidOperationException("Public key is missing in the key pair");
            }

            string publicKeyDerBase64 = AuthUtils.GetBase64EncodedKey(publicKey);

            var certificateAndKeyPair = leafCertificateSupplier.GetCertificateAndKeyPair();
            if (certificateAndKeyPair == null)
            {
                throw new InvalidOperationException("Certificate and key pair are not present");
            }

            var leafCertificate = certificateAndKeyPair.Certificate;
            if (leafCertificate == null)
            {
                throw new InvalidOperationException("Leaf certificate is not present");
            }

            if (certificateAndKeyPair.PrivateKey == null)
            {
                throw new InvalidOperationException("Leaf certificate's private key is missing");
            }

            HashSet<string> intermediateStrings = null;
            if (intermediateCertificateSuppliers != null &&
                intermediateCertificateSuppliers.Count > 0)
            {
                logger.Debug("Intermediate certificate(s) were supplied");

                intermediateStrings = new HashSet<string>();
                foreach (var supplier in intermediateCertificateSuppliers)
                {
                    var supplierCertificateAndKeyPair = supplier.GetCertificateAndKeyPair();
                    if (supplierCertificateAndKeyPair != null &&
                        supplierCertificateAndKeyPair.Certificate != null)
                    {
                        intermediateStrings.Add(Convert.ToBase64String(supplierCertificateAndKeyPair.Certificate.RawData));
                    }
                }
            }

            // create request body to be sent to the auth service
            var url = this.federationEndpoint + Constants.AUTH_SERVICE_PATH;
            var requestBody = new X509FederationRequest(publicKeyDerBase64, Convert.ToBase64String(leafCertificate.RawData), intermediateStrings, purpose);
            var httpRequestMsg = new HttpRequestMessage(HttpMethod.Post, new Uri(url));
            httpRequestMsg.Content = ContentHelper.CreateHttpContent(requestBody);

            var keyId = this.tenancyId + Constants.FED_KEY_PATH + AuthUtils.GetFingerPrint(leafCertificate.Thumbprint);
            FederationSigner.SignRequest(httpRequestMsg, (RsaKeyParameters)certificateAndKeyPair.PrivateKey, keyId);
            var requestContent = httpRequestMsg.Content.ReadAsStringAsync().Result;
            logger.Debug($"request content to Auth service is {requestContent}");

            var retryPolicy = Policy
                .Handle<HttpRequestException>()
                .Or<TimeoutException>()
                .OrResult<HttpResponseMessage>(response =>
                {
                    // Don't retry for success (200 OK) or any other success status
                    if (response.IsSuccessStatusCode)
                    {
                        return false;
                    }
                    // Don't retry on 4xx
                    if ((int)response.StatusCode >= 400 && (int)response.StatusCode < 500)
                    {
                        logger.Info($"Not retrying for 4xx error: {(int)response.StatusCode} {response.ReasonPhrase}");
                        return false;
                    }
                    return true;
                })
                .WaitAndRetryAsync
                (
                    retryCount: Constants.DEFAULT_AUTH_CLIENT_RETRIES,
                    sleepDurationProvider: attempt => TimeSpan.FromMilliseconds(Constants.RETRY_MILLIS),
                    onRetry: (response, timeSpan, attempt, context) =>
                    {
                        if (response.Exception != null)
                        {
                            logger.Info($"Retry {attempt} after {timeSpan.Seconds} seconds due to exception: {response.Exception.Message}");
                        }
                        else
                        {
                            logger.Info($"Retry {attempt} after {timeSpan.Seconds} seconds for HTTP status: {(int)response.Result.StatusCode} {response.Result.ReasonPhrase}");
                        }
                    }
                );

            var authCircuitBreakerEnabled = !string.Equals(Environment.GetEnvironmentVariable(Constants.OCI_SDK_AUTH_CLIENT_CIRCUIT_BREAKER_ENABLED)?.Trim(), "false", StringComparison.OrdinalIgnoreCase);
            if (authCircuitBreakerEnabled)
            {
                // Combine retry and circuit breaker policies
                retryPolicy.WrapAsync(DefaultAuthClientCircuitBreakerPolicy);
            }

            HttpResponseMessage response = null;
            try
            {
                Client ??= new HttpClient();
                response = retryPolicy.ExecuteAsync(async () =>
                {
                    // A new copy of the request message needs to be created because it is disposed each time it is sent, and
                    // resending the same request will result in the following error message:
                    // "The request message was already sent. Cannot send the same request message multiple times."
                    var newRequestMessage = HttpUtils.CloneHttpRequestMessage(httpRequestMsg).GetAwaiter().GetResult();
                    return await Client.SendAsync(newRequestMessage);
                }).Result;

                if (response == null || !response.IsSuccessStatusCode)
                {
                    logger.Debug("Received non successful response while trying to get the AUTH token");
                    ResponseHelper.HandleNonSuccessfulResponse(response);
                }
            }
            finally
            {
                Client.Dispose();
                Client = null;
            }

            var securityTokenContent = response.Content.ReadAsStringAsync().Result;
            var securityToken = JsonConvert.DeserializeObject<SecurityToken>(securityTokenContent, OciJsonSerializerSettings.GetDefaultJsonSerializerSettings());
            logger.Info($"Security Token received from the Auth Service");
            return new SecurityTokenAdapter(securityToken.Token, sessionKeySupplier);
        }
    }

    internal class SecurityToken
    {
        public string Token { get; set; }
    }

    internal class X509FederationRequest
    {
        public HashSet<String> intermediateCertificates;
        public String certificate;
        public String publicKey;
        public String purpose;

        public X509FederationRequest(
                String publicKey,
                String certificate,
                HashSet<String> intermediateCertificates,
                String purpose)
        {
            this.certificate = certificate ?? throw new NullReferenceException();
            this.publicKey = publicKey ?? throw new NullReferenceException();
            this.intermediateCertificates = intermediateCertificates;
            this.purpose = purpose;
        }
    }
}
