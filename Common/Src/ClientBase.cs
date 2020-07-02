/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Net.Http;
using Oci.Common.Auth;
using Oci.Common.Http;
using Oci.Common.Http.Signing;

namespace Oci.Common
{
    public abstract class ClientBase
    {
        private readonly Dictionary<SigningStrategy, RequestSigner> availableRequestSigners;
        private readonly RequestSigner requestSigner;

        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        protected RestClientHandler clientHandler;
        protected readonly RestClient restClient;
        protected Service service;
        protected string userAgent = null;

        public ClientBase(IBasicAuthenticationDetailsProvider authProvider) : this(authProvider,
            new ClientConfiguration(), new DefaultRequestSigner(authProvider))
        { }

        public ClientBase(IBasicAuthenticationDetailsProvider authProvider, RequestSigner requestSigner) :
            this(authProvider, new ClientConfiguration(), requestSigner)
        { }

        public ClientBase(IBasicAuthenticationDetailsProvider authProvider, ClientConfiguration clientConfiguration) :
            this(authProvider, new ClientConfiguration(), new DefaultRequestSigner(authProvider))
        { }

        public ClientBase(IBasicAuthenticationDetailsProvider authProvider, ClientConfiguration clientConfiguration, RequestSigner requestSigner)
        {
            this.clientHandler = new RestClientHandler(RequestReceptor);
            this.restClient = new RestClient(clientHandler, clientConfiguration);
            this.requestSigner = requestSigner;
            this.availableRequestSigners = GetAvailableRequestSigners(authProvider);
            this.restClient.SetDefaultUserAgent(GetUserAgent(clientConfiguration.ClientUserAgent));
        }

        public void Dispose()
        {
            this.restClient.Dispose();
        }

        public void SetEndpoint(string endpoint)
        {
            logger.Info($"Setting endpoint to {endpoint}");
            this.restClient.SetEndpoint(endpoint);
        }

        public Uri GetEndpoint()
        {
            return this.restClient.GetEndpoint();
        }

        private string GetUserAgent(string clientUserAgent)
        {
            // User agent string will only be configured once and cannot be modified after that.
            if (userAgent == null)
            {
                var additionalUserAgent = String.IsNullOrEmpty(clientUserAgent) ? "" : $" {clientUserAgent}";
                OperatingSystem os = Environment.OSVersion;
                userAgent = $"Oracle-DotNetSDK/{Version.GetVersion()} ({os.Platform}/{os.Version}; {RuntimeInformation.FrameworkDescription}{additionalUserAgent})";
            }
            return userAgent;
        }

        internal void RequestReceptor(HttpRequestMessage requestMessage)
        {
            RequestSigner requestSignerToUse = requestSigner;
            if (requestMessage.Properties.TryGetValue(SigningStrategy.SIGNING_STRATEGY_PROPERTY_NAME_KEY, out var signingStrategy))
            {
                requestSignerToUse = availableRequestSigners.TryGetValue((SigningStrategy)signingStrategy, out var desiredSigner) ?
                    desiredSigner : requestSignerToUse;
            }

            requestSignerToUse.SignRequest(requestMessage);
        }

        private Dictionary<SigningStrategy, RequestSigner> GetAvailableRequestSigners(IBasicAuthenticationDetailsProvider authProvider)
        {
            var signers = new Dictionary<SigningStrategy, RequestSigner>();
            foreach (SigningStrategy strategy in SigningStrategy.Values)
            {
                signers.Add(strategy, new DefaultRequestSigner(authProvider, strategy));
            }
            return signers;
        }
    }
}
