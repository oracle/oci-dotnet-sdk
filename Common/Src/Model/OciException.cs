/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Net;

namespace Oci.Common.Model
{
    /// <summary>Exceptions from the SDK.</summary>
    public class OciException : Exception
    {
        /// <summary>The HTTP status code.</summary>
        public HttpStatusCode StatusCode { get; }

        /// <summary>Service specific code returned.  Null if the client timed out or failed to get a response from the service.</summary>
        public string ServiceCode { get; }

        /// <summary>The opc-request-id header returned by the service that should be provided for support requests.</summary>
        public string OpcRequestId { get; }

        /// <summary>The Api Deatils for the operation being currently used.</summary>
        public ApiDetails ApiDetails { get; }
        public OciException(string message, Exception innerException) : base(message, innerException) { }
        public OciException(HttpStatusCode statusCode, string message, string serviceCode,
            string opcRequestId, ApiDetails apiDetails) : base(message)
        {
            this.StatusCode = statusCode;
            this.ServiceCode = serviceCode;
            this.OpcRequestId = opcRequestId;
            this.ApiDetails = apiDetails;
        }
        public OciException(HttpStatusCode statusCode, string message, string serviceCode,
            string opcRequestId) : base(message)
        {
            this.StatusCode = statusCode;
            this.ServiceCode = serviceCode;
            this.OpcRequestId = opcRequestId;
        }

        public OciException(string message, string serviceCode,
            string opcRequestId, Exception innerException) : base(message, innerException)
        {
            this.ServiceCode = serviceCode;
            this.OpcRequestId = opcRequestId;
        }

        public OciException(HttpStatusCode statusCode, string message, string serviceCode,
            string opcRequestId, Exception innerException) : base(message, innerException)
        {
            this.StatusCode = statusCode;
            this.ServiceCode = serviceCode;
            this.OpcRequestId = opcRequestId;
        }

        public OciException(HttpStatusCode statusCode, string message, string opcRequestId,
            Exception innerException) : base(message, innerException)
        {
            this.StatusCode = statusCode;
            this.OpcRequestId = opcRequestId;
        }

        public override string ToString()
        {
            if (ApiDetails != null)
            {
                int statusCode = (int)StatusCode;
                string troubleShootingLink = $"https://docs.oracle.com/en-us/iaas/Content/API/References/apierrors.htm#apierrors_{statusCode}__{statusCode}_{ServiceCode?.ToLower()}";
                string errorMessageHeader = $"\nError returned by {ApiDetails.ServiceName} Service. Http Status Code: {statusCode}. ServiceCode: {ServiceCode}. OpcRequestId: {OpcRequestId}. Message: {Message}"
                    + $"\nOperation Name: {ApiDetails.OperationName}"
                    + $"\nTimeStamp: {Utils.HttpDateUtils.ToRfc3339Format(DateTime.Now)}"
                    + $"\nClient Version: {ApiDetails.UserAgent}"
                    + $"\nRequest Endpoint: {ApiDetails.RequestEndpoint}"
                    + $"\nTroubleshooting Tips: See {troubleShootingLink} for more information about resolving this error.";
                string ApiReferenceLinkMessage = $"Also see {ApiDetails.ApiReferenceLink} for details on this operation's requirements.";
                string loggingMessage = "To get more info on the failing request, you can enable debug level logs as mentioned in the `Enabling Logging` section in https://docs.oracle.com/en-us/iaas/Content/API/SDKDocs/dotnetsdkgettingstarted.htm.";
                string errorMessageFooter = $"If you are unable to resolve this {ApiDetails.ServiceName} issue, please contact Oracle support and provide them this full error message.";

                if (String.IsNullOrEmpty(ApiDetails.ApiReferenceLink))
                {
                    return $"{errorMessageHeader}\n{loggingMessage}\n{errorMessageFooter}";
                }
                else
                {
                    return $"{errorMessageHeader}\n{ApiReferenceLinkMessage}\n{loggingMessage}\n{errorMessageFooter}";
                }
            }
            else
            {
                return $"Error encountered: StatusCode:{StatusCode}, Message:{Message}, ServiceCode:{ServiceCode}, OpcRequestId:{OpcRequestId}";
            }
        }
    }
}
