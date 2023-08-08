/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
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
    /// This resource contains the rules governing what traffic a VTAP mirrors.
    /// 
    /// </summary>
    public class VtapCaptureFilterRuleDetails 
    {
                ///
        /// <value>
        /// The traffic direction the VTAP is configured to mirror.
        /// 
        /// </value>
        ///
        public enum TrafficDirectionEnum {
            [EnumMember(Value = "INGRESS")]
            Ingress,
            [EnumMember(Value = "EGRESS")]
            Egress
        };

        /// <value>
        /// The traffic direction the VTAP is configured to mirror.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TrafficDirection is required.")]
        [JsonProperty(PropertyName = "trafficDirection")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TrafficDirectionEnum> TrafficDirection { get; set; }
                ///
        /// <value>
        /// Include or exclude packets meeting this definition from mirrored traffic.
        /// 
        /// </value>
        ///
        public enum RuleActionEnum {
            [EnumMember(Value = "INCLUDE")]
            Include,
            [EnumMember(Value = "EXCLUDE")]
            Exclude
        };

        /// <value>
        /// Include or exclude packets meeting this definition from mirrored traffic.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ruleAction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RuleActionEnum> RuleAction { get; set; }
        
        /// <value>
        /// Traffic from this CIDR block to the VTAP source will be mirrored to the VTAP target.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sourceCidr")]
        public string SourceCidr { get; set; }
        
        /// <value>
        /// Traffic sent to this CIDR block through the VTAP source will be mirrored to the VTAP target.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "destinationCidr")]
        public string DestinationCidr { get; set; }
        
        /// <value>
        /// The transport protocol used in the filter. If do not choose a protocol, all protocols will be used in the filter.
        /// Supported options are:
        ///   * 1 = ICMP
        ///   * 6 = TCP
        ///   * 17 = UDP
        /// 
        /// </value>
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }
        
        [JsonProperty(PropertyName = "icmpOptions")]
        public IcmpOptions IcmpOptions { get; set; }
        
        [JsonProperty(PropertyName = "tcpOptions")]
        public TcpOptions TcpOptions { get; set; }
        
        [JsonProperty(PropertyName = "udpOptions")]
        public UdpOptions UdpOptions { get; set; }
        
    }
}
