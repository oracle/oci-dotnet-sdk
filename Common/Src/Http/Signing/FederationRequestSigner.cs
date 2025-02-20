/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Oci.Common.Http.Signing.Internal;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Crypto.Parameters;

namespace Oci.Common.Http.Signing
{
    /// <summary>
    /// This class contains the implementation of the federation signing logic that
    /// retrieves the token from Auth Service used in remote requests.
    /// </summary>
    public class FederationRequestSigner : IFederationRequestSigner
    {
        private readonly SigningStrategy signingStrategy = SigningStrategy.STANDARD;
        private readonly ISignatureSigner signer;

        private static readonly string SIGNATURE_VERSION = "1";
        private static readonly string SIGNATURE_ALGORITHM = "rsa-sha256";

        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public FederationRequestSigner() : this(new SignatureSigner())
        { }

        public FederationRequestSigner(ISignatureSigner signer)
        {
            this.signer = signer;
        }

        /// <summary>This is the main code to sign a request.</summary>
        /// <param name="requestMessage">An HttpRequestMessage to be signed.</param>
        public void SignRequest(HttpRequestMessage requestMessage, RsaKeyParameters privateKey, string keyId)
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

            // Add any missing required headers.
            SigningUtils.AddMissingHeaders(requestMessage, headersToSign);

            // Calculate the Signing string.
            var signingString = SigningUtils.CalculateStringToSign(requestMessage, headersToSign);
            logger.Debug($"signing string is {signingString}");
            var signature = Convert.ToBase64String(signer.sign(privateKey, Encoding.UTF8.GetBytes(signingString)));
            var authorization = SigningUtils.CalculateAuthorization(headersToSign, SIGNATURE_VERSION, keyId, SIGNATURE_ALGORITHM, signature);

            httpHeaders.Add(Constants.AUTHORIZATION_HEADER, authorization);
        }
    }
}
