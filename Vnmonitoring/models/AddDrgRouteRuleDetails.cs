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


namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// Details needed when adding a DRG route rule.
    /// 
    /// </summary>
    public class AddDrgRouteRuleDetails 
    {
                ///
        /// <value>
        /// Type of destination for the rule.
        /// Allowed values:
        ///   * `CIDR_BLOCK`: If the rule's `destination` is an IP address range in CIDR notation.
        /// 
        /// </value>
        ///
        public enum DestinationTypeEnum {
            [EnumMember(Value = "CIDR_BLOCK")]
            CidrBlock
        };

        /// <value>
        /// Type of destination for the rule.
        /// Allowed values:
        ///   * `CIDR_BLOCK`: If the rule's `destination` is an IP address range in CIDR notation.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DestinationType is required.")]
        [JsonProperty(PropertyName = "destinationType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DestinationTypeEnum> DestinationType { get; set; }
        
        /// <value>
        /// This is the range of IP addresses used for matching when routing
        /// traffic. Only CIDR_BLOCK values are allowed.
        /// <br/>
        /// Potential values:
        ///   * IP address range in CIDR notation. This can be an IPv4 or IPv6 CIDR. For Example: 192.168.1.0/24  or 2001:0db8:0123:45::/56.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Destination is required.")]
        [JsonProperty(PropertyName = "destination")]
        public string Destination { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the next hop DRG attachment. The next hop DRG attachment is responsible
        /// for reaching the network destination.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NextHopDrgAttachmentId is required.")]
        [JsonProperty(PropertyName = "nextHopDrgAttachmentId")]
        public string NextHopDrgAttachmentId { get; set; }
        
    }
}
