/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
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
            AddMissingHeaders(requestMessage, headersToSign);

            // Calculate the Signing string.
            var signingString = CalculateStringToSign(requestMessage, headersToSign);
            var bytes = Encoding.UTF8.GetBytes(signingString);
            this.signer.BlockUpdate(bytes, 0, bytes.Length);
            var signature = Convert.ToBase64String(this.signer.GenerateSignature());

            var authorization = CalculateAuthorization(headersToSign, SIGNATURE_VERSION, this.keyId, SIGNATURE_ALGORITHM, signature);

            httpHeaders.Add(Constants.AUTHORIZATION_HEADER, authorization);
        }

        private static string CalculateAuthorization(List<string> requiredHeaders,
            string version, string keyId, string algorithm, string signature)
        {
            var headers = string.Join(" ", requiredHeaders.ToArray());

            return $@"Signature version=""{version}"",headers=""{headers}"",keyId=""{keyId}"",algorithm=""{algorithm}"",signature=""{signature}""";
        }

        private static void AddMissingHeaders(HttpRequestMessage requestMessage, List<string> requiredHeaders)
        {
            var originalHeaders = requestMessage.Headers;
            var uri = requestMessage.RequestUri;

            if (IsRequiredHeaderMissing(Constants.DATE, originalHeaders, requiredHeaders))
            {
                originalHeaders.Date = Convert.ToDateTime(ToRfc3339Format(DateTime.Now));
            }

            if (IsRequiredHeaderMissing(Constants.HOST, originalHeaders, requiredHeaders))
            {
                originalHeaders.Add(Constants.HOST, uri.Host);
            }

            // Add any of the missing content headers. This block should only be executed by PUT, POST and PATCH calls.
            // It won't be executed for ExcludeBodySigningStrategy type.
            if (requiredHeaders.Contains(Constants.CONTENT_LENGTH))
            {
                HttpContentHeaders contentHeaders = requestMessage.Content.Headers;
                byte[] bodyBytes = ReadRequestBody(requestMessage).Result;

                if (IsRequiredHeaderMissing(Constants.CONTENT_TYPE, contentHeaders, requiredHeaders))
                {
                    contentHeaders.ContentType = new MediaTypeHeaderValue(Constants.JSON_CONTENT_TYPE);
                }

                if (IsRequiredHeaderMissing(Constants.CONTENT_LENGTH, contentHeaders, requiredHeaders))
                {
                    contentHeaders.ContentLength = bodyBytes.Length;
                }

                if (IsRequiredHeaderMissing(Constants.X_CONTENT_SHA256, contentHeaders, requiredHeaders))
                {
                    originalHeaders.Add(Constants.X_CONTENT_SHA256, Convert.ToBase64String(SHA256.Create().ComputeHash(bodyBytes)));
                }
            }

        }

        private static string CalculateStringToSign(HttpRequestMessage requestMessage, List<string> requiredHeaders)
        {
            var signingStringBuilder = new StringBuilder();
            var newline = string.Empty;
            var headers = requestMessage.Headers;
            var contentHeaders = requestMessage.Content?.Headers;

            foreach (var headerName in requiredHeaders)
            {
                string headerValue = string.Empty;
                if (headers.TryGetValues(headerName, out var values))
                {
                    headerValue = values.First();
                }
                else if (contentHeaders != null && contentHeaders.TryGetValues(headerName, out values))
                {
                    headerValue = values.First();
                }
                else if (Constants.REQUEST_TARGET.Equals(headerName))
                {
                    headerValue = BuildRequestTarget(requestMessage);
                }
                else
                {
                    throw new ArgumentException($"Request did not contain required header: {headerName}");
                }
                signingStringBuilder.Append(newline).Append($"{headerName}: {headerValue}");
                newline = "\n";
            }

            return signingStringBuilder.ToString();
        }

        private static async Task<byte[]> ReadRequestBody(HttpRequestMessage requestMessage)
        {
            using var ms = new MemoryStream();
            await requestMessage.Content.CopyToAsync(ms);
            ms.Position = 0;
            var streamReader = new StreamReader(ms);
            var contentString = streamReader.ReadToEnd();

            return Encoding.UTF8.GetBytes(contentString);
        }

        private static bool IsRequiredHeaderMissing(string headerName, HttpHeaders requestHeaders, List<string> requiredHeaders)
        {
            try
            {
                return requiredHeaders.Contains(headerName) && !requestHeaders.Contains(headerName);
            }
            catch (Exception)
            {
                // ref: https://github.com/dotnet/runtime/issues/21000
                return false;
            }
        }

        private static string BuildRequestTarget(HttpRequestMessage requestMessage)
        {
            // ex. get /20160918/instances
            return $"{requestMessage.Method.Method.ToLowerInvariant()} {requestMessage.RequestUri.PathAndQuery}";
        }

        private static string ToRfc3339Format(DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd'T'HH:mm:ss.fff", DateTimeFormatInfo.InvariantInfo);
        }
    }
}
