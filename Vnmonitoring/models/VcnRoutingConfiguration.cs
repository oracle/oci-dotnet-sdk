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
    /// Identifies the VCN route table and rule that allowed the traffic to be forwarded.
    /// 
    /// </summary>
    public class VcnRoutingConfiguration : ForwardedRoutingConfiguration
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VCN route
        /// table that allowed the traffic.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VcnRouteTableId is required.")]
        [JsonProperty(PropertyName = "vcnRouteTableId")]
        public string VcnRouteTableId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RouteRule is required.")]
        [JsonProperty(PropertyName = "routeRule")]
        public RouteRule RouteRule { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "VCN";
    }
}
