/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
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
    
    public class CreateSubnetDetails 
    {
        
        /// <value>
        /// The availability domain to contain the subnet.
        /// <br/>
        /// Example: Uocm:PHX-AD-1
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AvailabilityDomain is required.")]
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The CIDR IP address range of the subnet. The CIDR must maintain the following rules -
        /// <br/>
        /// a. The CIDR block is valid and correctly formatted.
        /// b. The new range is within one of the parent VCN ranges.
        /// <br/>
        /// Example: 10.0.1.0/24
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CidrBlock is required.")]
        [JsonProperty(PropertyName = "cidrBlock")]
        public string CidrBlock { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment to contain the subnet.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the set of DHCP options the subnet will use. If you don't
        /// provide a value, the subnet uses the VCN's default set of DHCP options.
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
        /// A DNS label for the subnet, used in conjunction with the VNIC's hostname and
        /// VCN's DNS label to form a fully qualified domain name (FQDN) for each VNIC
        /// within this subnet (for example, `bminstance-1.subnet123.vcn1.oraclevcn.com`).
        /// Must be an alphanumeric string that begins with a letter and is unique within the VCN.
        /// The value cannot be changed.
        /// <br/>
        /// This value must be set if you want to use the Internet and VCN Resolver to resolve the
        /// hostnames of instances in the subnet. It can only be set if the VCN itself
        /// was created with a DNS label.
        /// <br/>
        /// For more information, see
        /// [DNS in Your Virtual Cloud Network](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/dns.htm).
        /// <br/>
        /// Example: subnet123
        /// </value>
        [JsonProperty(PropertyName = "dnsLabel")]
        public string DnsLabel { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Use this to enable IPv6 addressing for this subnet. The VCN must be enabled for IPv6.
        /// You can't change this subnet characteristic later. All subnets are /64 in size. The subnet
        /// portion of the IPv6 address is the fourth hextet from the left (1111 in the following example).
        /// <br/>
        /// For important details about IPv6 addressing in a VCN, see [IPv6 Addresses](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/ipv6.htm).
        /// <br/>
        /// Example: 2001:0db8:0123:1111::/64
        /// </value>
        [JsonProperty(PropertyName = "ipv6CidrBlock")]
        public string Ipv6CidrBlock { get; set; }
        
        /// <value>
        /// Whether VNICs within this subnet can have public IP addresses.
        /// Defaults to false, which means VNICs created in this subnet will
        /// automatically be assigned public IP addresses unless specified
        /// otherwise during instance launch or VNIC creation (with the
        /// `assignPublicIp` flag in {@link CreateVnicDetails}).
        /// If `prohibitPublicIpOnVnic` is set to true, VNICs created in this
        /// subnet cannot have public IP addresses (that is, it's a private
        /// subnet).
        /// <br/>
        /// For IPv6, if `prohibitPublicIpOnVnic` is set to `true`, internet access is not allowed for any
        /// IPv6s assigned to VNICs in the subnet.
        /// <br/>
        /// Example: true
        /// </value>
        [JsonProperty(PropertyName = "prohibitPublicIpOnVnic")]
        public System.Nullable<bool> ProhibitPublicIpOnVnic { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the route table the subnet will use. If you don't provide a value,
        /// the subnet uses the VCN's default route table.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "routeTableId")]
        public string RouteTableId { get; set; }
        
        /// <value>
        /// The OCIDs of the security list or lists the subnet will use. If you don't
        /// provide a value, the subnet uses the VCN's default security list.
        /// Remember that security lists are associated *with the subnet*, but the
        /// rules are applied to the individual VNICs in the subnet.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "securityListIds")]
        public System.Collections.Generic.List<string> SecurityListIds { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the VCN to contain the subnet.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VcnId is required.")]
        [JsonProperty(PropertyName = "vcnId")]
        public string VcnId { get; set; }
        
    }
}
