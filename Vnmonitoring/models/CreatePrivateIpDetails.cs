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
    
    public class CreatePrivateIpDetails 
    {
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
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
        /// The hostname for the private IP. Used for DNS. The value
        /// is the hostname portion of the private IP's fully qualified domain name (FQDN)
        /// (for example, `bminstance1` in FQDN `bminstance1.subnet123.vcn1.oraclevcn.com`).
        /// Must be unique across all VNICs in the subnet and comply with
        /// [RFC 952](https://tools.ietf.org/html/rfc952) and
        /// [RFC 1123](https://tools.ietf.org/html/rfc1123).
        /// <br/>
        /// For more information, see
        /// [DNS in Your Virtual Cloud Network](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/dns.htm).
        /// <br/>
        /// Example: bminstance1
        /// </value>
        [JsonProperty(PropertyName = "hostnameLabel")]
        public string HostnameLabel { get; set; }
        
        /// <value>
        /// A private IP address of your choice. Must be an available IP address within
        /// the subnet's CIDR. If you don't specify a value, Oracle automatically
        /// assigns a private IP address from the subnet.
        /// <br/>
        /// Example: 10.0.3.3
        /// </value>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the VNIC to assign the private IP to. The VNIC and private IP
        /// must be in the same subnet.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vnicId")]
        public string VnicId { get; set; }
        
        /// <value>
        /// Use this attribute only with the Oracle Cloud VMware Solution.
        /// <br/>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the VLAN from which the private IP is to be drawn. The IP address,
        /// *if supplied*, must be valid for the given VLAN. See {@link Vlan}.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vlanId")]
        public string VlanId { get; set; }
        
    }
}
