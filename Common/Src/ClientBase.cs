/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Runtime.CompilerServices;
using Oci.Common.Auth;
using Oci.Common.Http;
using Oci.Common.Http.Signing;
using Oci.Common.Utils;
namespace Oci.Common
{
    /// <summary>An abstract class for a generic service client.</summary>
    public abstract class ClientBase : IDisposable
    {
        bool disposed = false;
        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        protected readonly RestClient restClient;
        protected Service service;
        protected string userAgent = null;

        /// <summary> Constructor of a service client.</summary>
        /// <param name="authProvider">The authentication details provider.</param>
        public ClientBase(IBasicAuthenticationDetailsProvider authProvider) : this(authProvider,
            new ClientConfiguration(), new DefaultRequestSigner(authProvider))
        { }

        /// <summary> Constructor of a service client.</summary>
        /// <param name="authProvider">The authentication details provider.</param>
        /// <param name="requestSigner">A request signer that will be used to sign requests.</param>
        public ClientBase(IBasicAuthenticationDetailsProvider authProvider, RequestSigner requestSigner) :
            this(authProvider, new ClientConfiguration(), requestSigner)
        { }

        /// <summary> Constructor of a service client.</summary>
        /// <param name="authProvider">The authentication details provider.</param>
        /// <param name="clientConfiguration">A client configuration to customize client.</param>
        public ClientBase(IBasicAuthenticationDetailsProvider authProvider, ClientConfiguration clientConfiguration) :
            this(authProvider, clientConfiguration, new DefaultRequestSigner(authProvider))
        { }

        /// <summary> Constructor of a service client.</summary>
        /// <param name="authProvider">The authentication details provider.</param>
        /// <param name="clientConfiguration">A client configuration to customize client.</param>
        /// <param name="requestSigner">A request signer that will be used to sign requests.</param>
        public ClientBase(IBasicAuthenticationDetailsProvider authProvider, ClientConfiguration clientConfiguration, RequestSigner requestSigner)
        {
            ClientConfiguration clientConfigurationToUse = clientConfiguration ?? new ClientConfiguration();
            this.restClient = new RestClient(authProvider, clientConfigurationToUse, requestSigner);
            this.restClient.SetDefaultUserAgent(BuildUserAgent(clientConfigurationToUse.ClientUserAgent));
        }

        /// <summary>Disposes the rest client.</summary>
        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed == true)
            {
                return;
            }
            if (disposing)
            {
                logger.Info("Disposing rest client.");
                this.restClient.Dispose();
                GC.SuppressFinalize(this);
            }
            disposed = true;
        }

        /// <summary>Sets the endpoint in the rest client.</summary>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public void SetEndpoint(string endpoint)
        {
            logger.Info($"Setting endpoint to {endpoint}");
            this.restClient.SetEndpoint(endpoint);
        }

        /// <summary>Retrieves the endpoint Uri.</summary>
        public Uri GetEndpoint() => this.restClient.GetEndpoint();

        private string BuildUserAgent(string clientUserAgent)
        {
            // User agent string will only be configured once and cannot be modified after that.
            if (userAgent == null)
            {
                userAgent = HttpUtils.BuildUserAgent(clientUserAgent);
            }
            return userAgent;
        }

        public string GetUserAgent() => userAgent;

        /// <summary>Sets the RealmSpecificEndpointTemplate in the rest client.</summary>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public void SetRealmSpecificEndpointTemplate(string endpoint)
        {
            logger.Info($"Setting SetRealmSpecificEndpointTemplate to {endpoint}");
            this.restClient.RealmSpecificEndpointTemplate = endpoint;
        }
    }
}