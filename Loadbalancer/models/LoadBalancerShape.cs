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


namespace Oci.LoadbalancerService.Models
{
    /// <summary>
    /// A shape is a template that determines the total pre-provisioned bandwidth (ingress plus egress) for the
    /// load balancer.
    /// <br/>
    /// Note that the pre-provisioned maximum capacity applies to aggregated connections, not to a single client
    /// attempting to use the full bandwidth.
    /// 
    /// </summary>
    public class LoadBalancerShape 
    {
        
        /// <value>
        /// The name of the shape.
        /// <br/>
        /// Example: 100Mbps
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
    }
}
