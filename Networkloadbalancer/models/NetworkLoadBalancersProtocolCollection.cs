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


namespace Oci.NetworkloadbalancerService.Models
{
    /// <summary>
    /// This object is deprecated.
    /// Wrapper object for array of ProtocolSummary objects.
    /// 
    /// </summary>
    public class NetworkLoadBalancersProtocolCollection 
    {
        
        /// <value>
        /// Array of NetworkLoadBalancersProtocolSummary objects.
        /// </value>
        [JsonProperty(PropertyName = "items")]
        public System.Collections.Generic.List<NetworkLoadBalancersProtocolSummary> Items { get; set; }
        
    }
}
