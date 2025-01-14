/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.ComputecloudatcustomerService.Models;

namespace Oci.ComputecloudatcustomerService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/computecloudatcustomer/UpdateCccInfrastructure.cs.html">here</a> to see an example of how to use UpdateCccInfrastructure request.
    /// </example>
    public class UpdateCccInfrastructureRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// An [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) for a 
        /// Compute Cloud@Customer Infrastructure.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CccInfrastructureId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "cccInfrastructureId")]
        public string CccInfrastructureId { get; set; }
        
        /// <value>
        /// The information to be updated.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UpdateCccInfrastructureDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public UpdateCccInfrastructureDetails UpdateCccInfrastructureDetails { get; set; }
        
        /// <value>
        /// For optimistic concurrency control. In the PUT or DELETE call
        /// for a resource, set the `if-match` parameter to the value of the
        /// etag from a previous GET or POST response for that resource.
        /// The resource will be updated or deleted only if the etag you
        /// provide matches the resource's current etag value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-match")]
        public string IfMatch { get; set; }
        
        /// <value>
        /// The client request [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) for tracing.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
