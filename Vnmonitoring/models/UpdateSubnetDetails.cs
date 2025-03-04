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
    
    public class UpdateSubnetDetails 
    {
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the set of DHCP options the subnet will use.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dhcpOptionsId")]
        public string DhcpOptionsId { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the route table the subnet will use.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "routeTableId")]
        public string RouteTableId { get; set; }
        
        /// <value>
        /// The OCIDs of the security list or lists the subnet will use. This
        /// replaces the entire current set of security lists. Remember that
        /// security lists are associated *with the subnet*, but the rules are
        /// applied to the individual VNICs in the subnet.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "securityListIds")]
        public System.Collections.Generic.List<string> SecurityListIds { get; set; }
        
        /// <value>
        /// The CIDR block of the subnet. The new CIDR block must meet the following criteria:
        /// <br/>
        /// - Must be valid.
        /// - The CIDR block's IP range must be completely within one of the VCN's CIDR block ranges.
        /// - The old and new CIDR block ranges must use the same network address. Example: 10.0.0.0/25 and 10.0.0.0/24.- Must contain all IP addresses in use in the old CIDR range.- The new CIDR range's broadcast address (last IP address of CIDR range) must not be an IP address in use in the old CIDR range.**Note:** If you are changing the CIDR block, you cannot create VNICs or private IPs for this resource while the update is in progress.
        /// </value>
        [JsonProperty(PropertyName = "cidrBlock")]
        public string CidrBlock { get; set; }
        
        /// <value>
        /// This is the IPv6 CIDR block for the subnet's IP address space.
        /// The subnet size is always /64.
        /// See [IPv6 Addresses](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/ipv6.htm).
        /// The provided CIDR must maintain the following rules -
        /// <br/>
        /// a. The IPv6 CIDR block is valid and correctly formatted.
        /// b. The IPv6 CIDR is within the parent VCN IPv6 range.
        /// <br/>
        /// Example: 2001:0db8:0123:1111::/64
        /// </value>
        [JsonProperty(PropertyName = "ipv6CidrBlock")]
        public string Ipv6CidrBlock { get; set; }
        
        /// <value>
        /// The list of all IPv6 CIDR blocks (Oracle allocated IPv6 GUA, ULA or private IPv6 CIDR blocks, BYOIPv6 CIDR blocks) for the subnet that meets the following criteria:
        /// - The CIDR blocks must be valid.
        /// - Multiple CIDR blocks must not overlap each other or the on-premises network CIDR block.
        /// - The number of CIDR blocks must not exceed the limit of IPv6 CIDR blocks allowed to a subnet.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ipv6CidrBlocks")]
        public System.Collections.Generic.List<string> Ipv6CidrBlocks { get; set; }
        
    }
}
