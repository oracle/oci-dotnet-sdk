/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.LoadbalancerService.Models;

namespace Oci.LoadbalancerService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/loadbalancer/ListCertificates.cs.html">here</a> to see an example of how to use ListCertificates request.
    /// </example>
    public class ListCertificatesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the load balancer associated with the certificate bundles
        /// to be listed.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LoadBalancerId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "loadBalancerId")]
        public string LoadBalancerId { get; set; }
        
        /// <value>
        /// The unique Oracle-assigned identifier for the request. If you need to contact Oracle about a
        /// particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// For optimistic concurrency control. In the PUT or DELETE call for a resource, set the if-match
        /// parameter to the value of the ETag for the load balancer. This value can be obtained from a GET
        /// or POST response for any resource of that load balancer.
        /// <br/>
        /// For example, the eTag returned by getListener can be specified as the ifMatch for updateRuleSets.
        /// <br/>
        /// The resource is updated or deleted only if the ETag you provide matches the resource's current
        /// ETag value.
        /// <br/>
        /// Example: example-etag
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-match")]
        public string IfMatch { get; set; }
    }
}
