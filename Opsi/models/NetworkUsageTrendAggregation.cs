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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Usage data per network interface.
    /// </summary>
    public class NetworkUsageTrendAggregation 
    {
        
        /// <value>
        /// Name of interface.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InterfaceName is required.")]
        [JsonProperty(PropertyName = "interfaceName")]
        public string InterfaceName { get; set; }
        
        /// <value>
        /// Address that is connected to a computer network that uses the Internet Protocol for communication.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IpAddress is required.")]
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }
        
        /// <value>
        /// Unique identifier assigned to a network interface.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MacAddress is required.")]
        [JsonProperty(PropertyName = "macAddress")]
        public string MacAddress { get; set; }
        
        /// <value>
        /// List of usage data samples for a network interface.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UsageData is required.")]
        [JsonProperty(PropertyName = "usageData")]
        public System.Collections.Generic.List<NetworkUsageTrend> UsageData { get; set; }
        
    }
}
