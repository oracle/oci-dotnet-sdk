/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
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
    /// Network Configuration metric for the host
    /// 
    /// </summary>
    public class HostNetworkConfiguration : HostConfigurationMetricGroup
    {
        
        /// <value>
        /// Name of the network interface
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InterfaceName is required.")]
        [JsonProperty(PropertyName = "interfaceName")]
        public string InterfaceName { get; set; }
        
        /// <value>
        /// IP address (IPv4 or IPv6) of the network interface
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IpAddress is required.")]
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }
        
        /// <value>
        /// MAC address of the network interface. MAC address is a 12-digit hexadecimal number separated by colons or dashes or dots. Following formats are accepted: MM:MM:MM:SS:SS:SS, MM-MM-MM-SS-SS-SS, MM.MM.MM.SS.SS.SS, MMM:MMM:SSS:SSS, MMM-MMM-SSS-SSS, MMM.MMM.SSS.SSS, MMMM:MMSS:SSSS, MMMM-MMSS-SSSS, MMMM.MMSS.SSSS
        /// </value>
        [JsonProperty(PropertyName = "macAddress")]
        public string MacAddress { get; set; }
        
        [JsonProperty(PropertyName = "metricName")]
        private readonly string metricName = "HOST_NETWORK_CONFIGURATION";
    }
}
