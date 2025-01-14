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
    /// The configuration of a network load balancer backend set.
    /// For more information about backend set configuration, see
    /// [Managing Backend Sets](https://docs.cloud.oracle.com/Content/Balance/Tasks/managingbackendsets.htm).
    /// <br/>
    /// **Caution:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    public class BackendSetDetails 
    {
        
        /// <value>
        /// The network load balancer policy for the backend set.
        /// <br/>
        /// Example: FIVE_TUPLE
        /// </value>
        [JsonProperty(PropertyName = "policy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<NetworkLoadBalancingPolicy> Policy { get; set; }
        
        /// <value>
        /// IP version associated with the backend set.
        /// </value>
        [JsonProperty(PropertyName = "ipVersion")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<IpVersion> IpVersion { get; set; }
        
        /// <value>
        /// If this parameter is enabled, then the network load balancer preserves the source IP of the packet when it is forwarded to backends.
        /// Backends see the original source IP. If the isPreserveSourceDestination parameter is enabled for the network load balancer resource, then this parameter cannot be disabled.
        /// The value is true by default.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isPreserveSource")]
        public System.Nullable<bool> IsPreserveSource { get; set; }
        
        /// <value>
        /// If enabled, the network load balancer will continue to distribute traffic in the configured distribution in the event all backends are unhealthy.
        /// The value is false by default.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isFailOpen")]
        public System.Nullable<bool> IsFailOpen { get; set; }
        
        /// <value>
        /// If enabled existing connections will be forwarded to an alternative healthy backend as soon as current backend becomes unhealthy.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isInstantFailoverEnabled")]
        public System.Nullable<bool> IsInstantFailoverEnabled { get; set; }
        
        /// <value>
        /// An array of backends.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "backends")]
        public System.Collections.Generic.List<Backend> Backends { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HealthChecker is required.")]
        [JsonProperty(PropertyName = "healthChecker")]
        public HealthChecker HealthChecker { get; set; }
        
    }
}
