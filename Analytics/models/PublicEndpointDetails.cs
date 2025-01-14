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


namespace Oci.AnalyticsService.Models
{
    /// <summary>
    /// Public endpoint configuration details.
    /// 
    /// </summary>
    public class PublicEndpointDetails : NetworkEndpointDetails
    {
        
        /// <value>
        /// Source IP addresses or IP address ranges in ingress rules.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "whitelistedIps")]
        public System.Collections.Generic.List<string> WhitelistedIps { get; set; }
        
        /// <value>
        /// Virtual Cloud Networks allowed to access this network endpoint.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "whitelistedVcns")]
        public System.Collections.Generic.List<VirtualCloudNetwork> WhitelistedVcns { get; set; }
        
        /// <value>
        /// Oracle Cloud Services that are allowed to access this Analytics instance.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "whitelistedServices", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<AccessControlServiceType> WhitelistedServices { get; set; }
        
        [JsonProperty(PropertyName = "networkEndpointType")]
        private readonly string networkEndpointType = "PUBLIC";
    }
}
