/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Oci.Common.Model;
using Oci.Common.Utils;

namespace Oci.Common.Http.Internal
{
    /// <summary>A utility class to read response content.</summary>
    public class ResponseHelper
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public static string DEFAULT_OCI_EXCEPTION_MESSAGE = "Unknown Message";
        public static string DEFAULT_OCI_EXCEPTION_SERVICE_CODE = "Unknown Service Code";
        public static string INSTANCE_PRINCIPAL_FAILURE_MESSAGE = "Failed to initiate Instance Principal call";
        public static string NOT_APPLICABLE = "N/A";
        public static int INSTANCE_PRINCIPAL_FAILURE_CODE = 502;

        /// <summary>Reads content from HttpResponseMessage and converts it into SDK response object.</summary>
        /// <param name="response">An HttpResponseMessage.</param>
        /// <returns>An SDK response object.</returns>
        /// <exception>Throws any exception from ReadEntityInternal.</exception>
        public static T ReadEntity<T>(HttpResponseMessage response)
        {
            var opcRequestId = HeaderUtils.GetFirstorDefaultHeaderValue(response.Headers, "opc-request-id");

            try
            {
                if (typeof(T) == typeof(System.IO.Stream))
                {
                    // Handle binary response
                    return (T)(object)response.Content.ReadAsStreamAsync().Result;
                }

                // Handle JSONResponse.
                return ReadEntityInternal<T>(response, opcRequestId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// HandleNonSuccessfulResponse will only be called to process responses return from service that are not 2xx.
        /// If this happens, throw OciException.
        /// </summary>
        /// <param name="responseMessage">An HttpResponseMessage.</param>
        /// <exception>Throws OciException if error code and message are retrieved, or throws any exception from ReadEntityInternal.</exception>
        public static void HandleNonSuccessfulResponse(HttpResponseMessage responseMessage, ApiDetails apiDetails = null, [System.Runtime.CompilerServices.CallerMemberName] string caller = null)
        {
            if(caller == "AutoDetectEndpointUsingMetadataUrl")
            {
                if( responseMessage == null
                    || INSTANCE_PRINCIPAL_FAILURE_CODE == (int)responseMessage.StatusCode
                    || System.Net.HttpStatusCode.BadRequest == responseMessage.StatusCode)
                {
                    throw new OciException(
                        responseMessage.StatusCode,
                        INSTANCE_PRINCIPAL_FAILURE_MESSAGE,
                        NOT_APPLICABLE,
                        NOT_APPLICABLE);
                }
            }

            var responseOpcRequestId = HeaderUtils.GetFirstorDefaultHeaderValue(responseMessage.Headers, "opc-request-id");
            try
            {
                ErrorCodeAndMessage errorCodeAndMessage = ReadEntityInternal<ErrorCodeAndMessage>(responseMessage, responseOpcRequestId);
                throw new OciException(
                    responseMessage.StatusCode,
                    errorCodeAndMessage?.Message ?? responseMessage.ReasonPhrase ?? DEFAULT_OCI_EXCEPTION_MESSAGE,
                    errorCodeAndMessage?.Code ?? DEFAULT_OCI_EXCEPTION_SERVICE_CODE,
                    responseOpcRequestId,
                    apiDetails);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private static T ReadEntityInternal<T>(HttpResponseMessage response, string opcRequestId)
        {
            // Skip De-serialization if SSE event
            response.Content.Headers.TryGetValues("Content-Type", out var values);
            if(values != null && values.FirstOrDefault().Contains("text/event-stream"))
            {
                return default(T);
            }
            // Directly return if the expected type is strings
            var content = response.Content.ReadAsStringAsync().Result;
            if (values != null && values.FirstOrDefault().Contains("text/plain"))
            {
                return (T)(Object)content;
            }
            try
            {
                var jsonSerializerSettings = new JsonSerializerSettings
                {
                    ContractResolver = new CustomResolver(),
                    NullValueHandling = NullValueHandling.Ignore,
                    MaxDepth = OciJsonSerializerSettings.GetDefaultJsonSerializerMaxDepth()
                };
                return JsonConvert.DeserializeObject<T>(content, jsonSerializerSettings);
            }
            catch (Exception e)
            {
                logger.Warn($"Failed to parse response body: \n{e.StackTrace}");
                // Throw the exception instead of wrapping it with OciException.
                // This is to differentiate errors coming from service side and errors from SDK serialization/deserialization.
                throw e;

            }
        }

        private static void HandleJsonParseErrors(
            ErrorEventArgs args,
            HttpStatusCode statusCode,
            string content,
            string opcRequestId)
        {
            logger.Warn("Unable to parse response body");
            throw new OciException(
                statusCode,
                $"Unable to parse the response to a desired OCI Model: {content}",
                DEFAULT_OCI_EXCEPTION_SERVICE_CODE,
                opcRequestId,
                args.ErrorContext.Error
                );
        }

        private class ErrorCodeAndMessage
        {
            [JsonProperty("code")]
            public readonly string Code;

            [JsonProperty("message")]
            public readonly string Message;

            public ErrorCodeAndMessage(string code, string message)
            {
                this.Code = code;
                this.Message = message;
            }
        }
    }
}
