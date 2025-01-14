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


namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// Defines the details required for a NETWORK_LOAD_BALANCER-type `Endpoint`.
    /// 
    /// </summary>
    public class NetworkLoadBalancerEndpoint : Endpoint
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the network load balancer.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NetworkLoadBalancerId is required.")]
        [JsonProperty(PropertyName = "networkLoadBalancerId")]
        public string NetworkLoadBalancerId { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "NETWORK_LOAD_BALANCER";
    }
}
