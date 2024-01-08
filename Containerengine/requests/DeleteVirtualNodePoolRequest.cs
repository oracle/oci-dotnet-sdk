/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.ContainerengineService.Models;

namespace Oci.ContainerengineService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/containerengine/DeleteVirtualNodePool.cs.html">here</a> to see an example of how to use DeleteVirtualNodePool request.
    /// </example>
    public class DeleteVirtualNodePoolRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the virtual node pool.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VirtualNodePoolId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "virtualNodePoolId")]
        public string VirtualNodePoolId { get; set; }
        
        /// <value>
        /// For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match`
        /// parameter to the value of the etag from a previous GET or POST response for that resource.  The resource
        /// will be updated or deleted only if the etag you provide matches the resource's current etag value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-match")]
        public string IfMatch { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact
        /// Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// Duration after which Sk8s will give up eviction of the pods on the node.
        /// PT0M will indicate you want to delete the virtual node without cordon and drain. Default PT60M, Min PT0M, Max: PT60M. Format ISO 8601 e.g PT30M
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "overrideEvictionGraceDurationVnp")]
        public string OverrideEvictionGraceDurationVnp { get; set; }
        
        /// <value>
        /// If the underlying compute instance should be deleted if you cannot evict all the pods in grace period
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isForceDeletionAfterOverrideGraceDurationVnp")]
        public System.Nullable<bool> IsForceDeletionAfterOverrideGraceDurationVnp { get; set; }
    }
}
