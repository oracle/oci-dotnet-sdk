/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.NetworkloadbalancerService.Models;

namespace Oci.NetworkloadbalancerService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/networkloadbalancer/GetBackend.cs.html">here</a> to see an example of how to use GetBackend request.
    /// </example>
    public class GetBackendRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the network load balancer to update.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NetworkLoadBalancerId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "networkLoadBalancerId")]
        public string NetworkLoadBalancerId { get; set; }
        
        /// <value>
        /// The name of the backend set that includes the backend server.
        /// <br/>
        /// Example: example_backend_set
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BackendSetName is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "backendSetName")]
        public string BackendSetName { get; set; }
        
        /// <value>
        /// The name of the backend server to retrieve.
        /// If the backend was created with an explicitly specified name, that name should be used here.
        /// If the backend was created without explicitly specifying the name, but was created using ipAddress, this is specified as <ipAddress>:<port>.
        /// If the backend was created without explicitly specifying the name, but was created using targetId, this is specified as <targetId>:<port>.
        /// <br/>
        /// Example: 10.0.0.3:8080 or ocid1.privateip..oc1.<var>&lt;unique_ID&gt;</var>:8080
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BackendName is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "backendName")]
        public string BackendName { get; set; }
        
        /// <value>
        /// The unique Oracle-assigned identifier for the request. If you must contact Oracle about a
        /// particular request, then provide the request identifier.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// The system returns the requested resource, with a 200 status, only if the resource has no etag
        /// matching the one specified. If the condition fails for the GET and HEAD methods, then the system returns the
        /// HTTP status code `304 (Not Modified)`.
        /// <br/>
        /// Example: example-etag
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-none-match")]
        public string IfNoneMatch { get; set; }
    }
}
