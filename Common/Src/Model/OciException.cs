/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
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

        public OciException(string message, Exception innerException) : base(message, innerException) { }

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
    }
}
