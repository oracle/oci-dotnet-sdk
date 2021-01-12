/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using Oci.Common.Auth;
using Oci.Common.Http.Signing.Internal;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;

namespace Oci.Common.Http.Signing
{
    /// <summary>
    /// This class contains the implementation of the default signing logic.
    /// </summary>
    public class DefaultRequestSigner : RequestSigner
    {
        private readonly SigningStrategy signingStrategy;
        private readonly ISigner signer;
        private readonly string keyId;

        private static readonly string SIGNATURE_VERSION = "1";
        private static readonly string SIGNATURE_ALGORITHM = "rsa-sha256";

        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public DefaultRequestSigner(IBasicAuthenticationDetailsProvider authDetailsProvider)
            : this(authDetailsProvider, SigningStrategy.STANDARD)
        { }

        public DefaultRequestSigner(IBasicAuthenticationDetailsProvider authDetailsProvider, SigningStrategy signingStrategy) :
            this(authDetailsProvider, signingStrategy, SignerUtilities.GetSigner("SHA-256withRSA"))
        { }

        public DefaultRequestSigner(IBasicAuthenticationDetailsProvider authDetailsProvider, ISigner signer) :
            this(authDetailsProvider, SigningStrategy.STANDARD, signer)
        { }

        public DefaultRequestSigner(IBasicAuthenticationDetailsProvider authDetailsProvider, SigningStrategy signingStrategy, ISigner signer) : base(authDetailsProvider)
        {
            this.keyId = authDetailsProvider.KeyId;
            this.signer = signer;
            this.signer.Init(true, authDetailsProvider.GetPrivateKey());
            this.signingStrategy = signingStrategy;
        }

        /// <summary>This is the main code to sign a request.</summary>
        /// <param name="requestMessage">An HttpRequestMessage to be signed.</param>
        public override void SignRequest(HttpRequestMessage requestMessage)
        {
            HttpMethod httpMethod = requestMessage.Method;
            HttpRequestHeaders httpHeaders = requestMessage.Headers;
            HttpContent body = requestMessage.Content;
            string requestMethodKey = httpMethod.Method.ToLowerInvariant();

            // Verify if the http request Method is supported.
            if (!signingStrategy.RequiredHeaders.TryGetValue(requestMethodKey, out var requiredHeaders))
            {
                throw new ArgumentException($"Http Request Method not found: {requestMethodKey}");
            }

            var headersToSign = requiredHeaders.ToList();
            //Add the Instance OBO User delegation token to request headers if the auth details provider implements IUserDelegationDetailsProvider and
            //if a token is available.
            var delegationToken = (AuthDetailsProvider as IUserDelegationDetailsProvider)?.GetDelegationToken();
            if (delegationToken != null)
            {
                logger.Debug($"Adding {Constants.OPC_OBO_TOKEN} to request headers");
                requestMessage.Headers.TryAddWithoutValidation(Constants.OPC_OBO_TOKEN, delegationToken);
            }

            // For PUT and POST, if the body is empty we still must explicitly set content-length = 0 and x-content-sha256.
            // The caller may already do this, but we shouldn't require it since we can determine it here.
            if (body == null && (string.Equals(requestMethodKey, "post") || string.Equals(requestMethodKey, "put")))
            {
                requestMessage.Content = new StringContent("");
                requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                requestMessage.Content.Headers.TryAddWithoutValidation(Constants.CONTENT_LENGTH, "0");
                requestMessage.Content.Headers.TryAddWithoutValidation(Constants.X_CONTENT_SHA256, Convert.ToBase64String(SHA256.Create().ComputeHash(new byte[0])));
            }

            // Few requests accept Constants.OPTIONAL_HEADERS_NAMES headers. In such cases, if the request contains any of the optional headers,
            // we need to include them in request signature.
            if (signingStrategy.OptionalHeaders.TryGetValue(requestMethodKey, out var optionalHeaders))
            {
                foreach (var optionalHeaderName in optionalHeaders)
                {
                    if (httpHeaders.Contains(optionalHeaderName))
                    {
                        headersToSign.Add(optionalHeaderName);
                    }
                }
            }

            // Add any missing required headers.
            SigningUtils.AddMissingHeaders(requestMessage, headersToSign);

            // Calculate the Signing string.
            var signingString = SigningUtils.CalculateStringToSign(requestMessage, headersToSign);
            var bytes = Encoding.UTF8.GetBytes(signingString);
            this.signer.BlockUpdate(bytes, 0, bytes.Length);
            var signature = Convert.ToBase64String(this.signer.GenerateSignature());

            var authorization = SigningUtils.CalculateAuthorization(headersToSign, SIGNATURE_VERSION, this.keyId, SIGNATURE_ALGORITHM, signature);

            httpHeaders.Add(Constants.AUTHORIZATION_HEADER, authorization);
        }
    }
}
