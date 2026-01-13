/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Oci.Common.Auth;
using Oci.Common.Http.Internal;
using Oci.Common.Http.Signing;
using Oci.Common.Model;
using Oci.Common.Utils;

namespace Oci.Common.Http
{
    /// <summary>A REST client implementation.</summary>
    public class RestClient
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private static readonly int MAX_RETRIES_FOR_TOKEN_REFRESH = 2;
        private readonly Dictionary<SigningStrategy, RequestSigner> availableRequestSigners;
        private RequestSigner requestSigner;
        private readonly IBasicAuthenticationDetailsProvider authProvider;
        public string RealmSpecificEndpointTemplate { get; set; }

        private void RefreshSigner()
        {
            ((AbstractRequestingAuthenticationDetailsProvider)this.authProvider).Refresh();
            if (this.requestSigner is DefaultRequestSigner)
            {
                this.requestSigner = new DefaultRequestSigner(this.authProvider);
            }
        }

        /// This is DEPRECATED. Please use the RestClient constructor using IBasicAuthenticationDetailsProvider.
        public RestClient(RestClientHandler handler)
        {
            this.httpClient = new HttpClient(handler);
        }

        /// This is DEPRECATED. Please use the RestClient constructor using IBasicAuthenticationDetailsProvider.
        public RestClient(RestClientHandler handler, ClientConfiguration clientConfiguration)
        {
            this.httpClient = new HttpClient(handler);
            this.httpClient.Timeout = TimeSpan.FromMilliseconds(clientConfiguration.TimeoutMillis);
            this.httpClient.MaxResponseContentBufferSize = clientConfiguration.ResponseContentBufferBytes;
        }

        public RestClient(IBasicAuthenticationDetailsProvider authProvider, RequestSigner requestSigner)
        {
            this.authProvider = authProvider;
            this.restClientHandler = new RestClientHandler(RequestReceptor);
            this.httpClient = new HttpClient(restClientHandler);
            this.requestSigner = requestSigner;
            this.availableRequestSigners = GetAvailableRequestSigners(this.authProvider);
        }

        public RestClient(IBasicAuthenticationDetailsProvider authProvider, ClientConfiguration clientConfiguration, RequestSigner requestSigner)
        {
            this.authProvider = authProvider;
            this.restClientHandler = new RestClientHandler(RequestReceptor, clientConfiguration);
            this.httpClient = new HttpClient(restClientHandler);
            this.httpClient.Timeout = TimeSpan.FromMilliseconds(clientConfiguration.TimeoutMillis);
            this.httpClient.MaxResponseContentBufferSize = clientConfiguration.ResponseContentBufferBytes;
            this.requestSigner = requestSigner;
            this.availableRequestSigners = GetAvailableRequestSigners(this.authProvider);
        }

        public RestClient() : this(null as IBasicAuthenticationDetailsProvider, null as RequestSigner) { }

        /// <summary>Disposes the HTTP client</summary>
        public void Dispose()
        {
            if (this.httpClient != null)
            {
                this.httpClient.Dispose();
            }
        }

        /// <summary>Sets the base address for the HTTP client.</summary>
        /// <param name="endpoint">The service endpoint.</param>
        public void SetEndpoint(string endpoint)
        {
            logger.Debug($"Setting endpoint to: {endpoint}");
            this.httpClient.BaseAddress = new Uri(endpoint);
        }

        /// <summary>Retrieves the endpoint Uri.</summary>
        /// <returns>The base address of the HTTP client.</returns>
        public Uri GetEndpoint()
        {
            return this.httpClient.BaseAddress;
        }

        /// <summary>Sets the default user agent in HTTP client.</summary>
        /// <param name="userAgent">A user agent string.</param>
        public void SetDefaultUserAgent(string userAgent)
        {
            this.httpClient.DefaultRequestHeaders.UserAgent.TryParseAdd(userAgent);
        }

        /// <summary>Sends HTTP request.</summary>
        /// <param name="httpRequest">The HttpRequestMessage to be sent.</param>
        /// <param name="cancellationToken">The CancellationToken to be used.</param>
        /// <returns>A Task of HttpResponseMessage returned.</returns>
        public async Task<HttpResponseMessage> HttpSend(HttpRequestMessage httpRequest, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead, CancellationToken cancellationToken = default)
        {
            if (this.authProvider is AbstractRequestingAuthenticationDetailsProvider)
            {
                int attempts = 0;
                HttpResponseMessage responseMessage = null;
                while (attempts < MAX_RETRIES_FOR_TOKEN_REFRESH)
                {
                    ++attempts;
                    // A new copy of the request message needs to be created because it is disposed each time it is sent, and
                    // resending the same request will result in the following error message:
                    // "The request message was already sent. Cannot send the same request message multiple times."
                    var newRequestMessage = await HttpUtils.CloneHttpRequestMessage(httpRequest);
                    responseMessage = await this.httpClient.SendAsync(newRequestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                    if (!responseMessage.IsSuccessStatusCode && responseMessage.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        this.RefreshSigner();
                    }
                    else
                    {
                        break;
                    }
                }
                return responseMessage;
            }
            else
            {
                return await this.httpClient.SendAsync(httpRequest, completionOption, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>Check if the HttpResponseMessage is a successful response.</summary>
        /// <param name="httpRequest">The HttpRequestMessage sent.</param>
        /// <param name="HttpResponseMessage">The HttpResponseMessage to be checked.</param>
        /// <exception>Throws OciException, HttpRequestException, InvalidOperationException, or OperationCanceledException depending on the type of error.</exception>
        public void CheckHttpResponseMessage(HttpRequestMessage httpRequest, HttpResponseMessage httpResponse, ApiDetails apiDetails = null)
        {
            var opcRequestId = httpRequest.Headers.Contains("opc-request-id") ?
                httpRequest.Headers.GetValues("opc-request-id").FirstOrDefault() : string.Empty;

            try
            {
                logger.Debug("Dumping HttpResponse:\n{0}", httpResponse.ToString());
                // Check for success immediately to avoid unnecessary processing of failure responses.
                if (!httpResponse.IsSuccessStatusCode && httpResponse?.StatusCode != System.Net.HttpStatusCode.NotModified)
                {
                    ResponseHelper.HandleNonSuccessfulResponse(httpResponse, apiDetails);
                }
            }
            catch (HttpRequestException ex)
            {
                logger.Warn($"HttpRequestException has occured while processing the request: {ex.Message}");
                throw new OciException(ex.Message, "Unknown", opcRequestId, ex);
            }
            catch (InvalidOperationException ex)
            {
                logger.Warn($"InvalidOperationException has occured while processing the request: {ex.Message}");
                throw new OciException(ex.Message, "Unknown", opcRequestId, ex);
            }
            catch (OperationCanceledException e)
            {
                logger.Warn($"Request has been cancelled using CancellationToken, errorMessage: {e.Message}");
                throw;
            }
        }

        internal void RequestReceptor(HttpRequestMessage requestMessage)
        {
            RequestSigner requestSignerToUse = this.requestSigner;
            if (requestMessage.Properties.TryGetValue(SigningStrategy.SIGNING_STRATEGY_PROPERTY_NAME_KEY, out var signingStrategy))
            {
                requestSignerToUse = this.availableRequestSigners.TryGetValue((SigningStrategy)signingStrategy, out var desiredSigner) ?
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
        private readonly HttpClient httpClient = null;
        private readonly RestClientHandler restClientHandler = null;
    }
}
