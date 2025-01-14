/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.OdaService.Models;

namespace Oci.OdaService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/oda/GetAuthenticationProvider.cs.html">here</a> to see an example of how to use GetAuthenticationProvider request.
    /// </example>
    public class GetAuthenticationProviderRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// Unique Digital Assistant instance identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OdaInstanceId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "odaInstanceId")]
        public string OdaInstanceId { get; set; }
        
        /// <value>
        /// Unique Authentication Provider identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AuthenticationProviderId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "authenticationProviderId")]
        public string AuthenticationProviderId { get; set; }
        
        /// <value>
        /// The If-None-Match HTTP request header makes the request conditional. For GET methods, the service will return the 
        /// requested resource, with a 200 status, only if it doesn't have an ETag matching the given ones. 
        /// When the condition fails for GET methods, then the service will return HTTP status code 304 (Not Modified).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-none-match")]
        public string IfNoneMatch { get; set; }
        
        /// <value>
        /// The client request ID for tracing. This value is included in the opc-request-id response header.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
