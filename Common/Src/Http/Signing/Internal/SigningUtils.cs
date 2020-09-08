/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Oci.Common.Http.Signing.Internal
{
    internal class SigningUtils
    {
        internal static string CalculateAuthorization(List<string> requiredHeaders,
            string version, string keyId, string algorithm, string signature)
        {
            var headers = string.Join(" ", requiredHeaders.ToArray());

            return $@"Signature version=""{version}"",headers=""{headers}"",keyId=""{keyId}"",algorithm=""{algorithm}"",signature=""{signature}""";
        }

        internal static void AddMissingHeaders(HttpRequestMessage requestMessage, List<string> requiredHeaders)
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

        internal static string CalculateStringToSign(HttpRequestMessage requestMessage, List<string> requiredHeaders)
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

        internal static async Task<byte[]> ReadRequestBody(HttpRequestMessage requestMessage)
        {
            using var ms = new MemoryStream();
            await requestMessage.Content.CopyToAsync(ms);
            ms.Position = 0;
            var streamReader = new StreamReader(ms);
            var contentString = streamReader.ReadToEnd();

            return Encoding.UTF8.GetBytes(contentString);
        }

        internal static bool IsRequiredHeaderMissing(string headerName, HttpHeaders requestHeaders, List<string> requiredHeaders)
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

        internal static string BuildRequestTarget(HttpRequestMessage requestMessage)
        {
            // ex. get /20160918/instances
            return $"{requestMessage.Method.Method.ToLowerInvariant()} {requestMessage.RequestUri.PathAndQuery}";
        }

        internal static string ToRfc3339Format(DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd'T'HH:mm:ss.fff", DateTimeFormatInfo.InvariantInfo);
        }
    }
}
