/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.CoreService.Models
{
    /// <summary>
    /// Represents a load balancer that is to be attached to an instance pool.
    /// </summary>
    public class AttachLoadBalancerDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the load balancer to attach to the instance pool.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LoadBalancerId is required.")]
        [JsonProperty(PropertyName = "loadBalancerId")]
        public string LoadBalancerId { get; set; }
        
        /// <value>
        /// The name of the backend set on the load balancer to add instances to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BackendSetName is required.")]
        [JsonProperty(PropertyName = "backendSetName")]
        public string BackendSetName { get; set; }
        
        /// <value>
        /// The port value to use when creating the backend set.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Port is required.")]
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }
        
        /// <value>
        /// Indicates which VNIC on each instance in the pool should be used to associate with the load balancer.
        /// Possible values are \"PrimaryVnic\" or the displayName of one of the secondary VNICs on the instance configuration
        /// that is associated with the instance pool.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VnicSelection is required.")]
        [JsonProperty(PropertyName = "vnicSelection")]
        public string VnicSelection { get; set; }
        
    }
}
