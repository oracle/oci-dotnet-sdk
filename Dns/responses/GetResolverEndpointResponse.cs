/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Runtime.Serialization;
using Oci.DnsService.Models;

namespace Oci.DnsService.Responses
{
    public class GetResolverEndpointResponse : Oci.Common.OciResponse
    {

        /// <value>
        /// The current version of the resource, ending with a
        /// representation-specific suffix. This value may be used in If-Match
        /// and If-None-Match headers for later requests of the same resource.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "etag")]
        public string Etag { get; set; }


        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to
        /// contact Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }

        /// <value>
        /// The returned ResolverEndpoint instance, or null if {@link #isNotModified()} is true.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public ResolverEndpoint ResolverEndpoint { get; set; }

        /// <value>
        /// Flag to indicate whether or not the object was modified.  If this is true,
        /// the getter for the object itself will return null.  Callers should check this
        /// if they specified one of the request params that might result in a conditional
        /// response (like 'if-match'/'if-none-match').
        /// </value>
        public bool IsNotModified { get; set; }
    }
}
