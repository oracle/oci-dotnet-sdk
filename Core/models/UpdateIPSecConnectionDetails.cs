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


namespace Oci.CoreService.Models
{
    
    public class UpdateIPSecConnectionDetails 
    {
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
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
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Your identifier for your CPE device. Can be either an IP address or a hostname (specifically, the
        /// fully qualified domain name (FQDN)). The type of identifier you provide here must correspond
        /// to the value for `cpeLocalIdentifierType`.
        /// <br/>
        /// For information about why you'd provide this value, see
        /// [If Your CPE Is Behind a NAT Device](https://docs.cloud.oracle.com/iaas/Content/Network/Tasks/overviewIPsec.htm#nat).
        /// <br/>
        /// Example IP address: `10.0.3.3`
        /// <br/>
        /// Example hostname: `cpe.example.com`
        /// 
        /// </value>
        [JsonProperty(PropertyName = "cpeLocalIdentifier")]
        public string CpeLocalIdentifier { get; set; }
                ///
        /// <value>
        /// The type of identifier for your CPE device. The value you provide here must correspond to the value
        /// for `cpeLocalIdentifier`.
        /// 
        /// </value>
        ///
        public enum CpeLocalIdentifierTypeEnum {
            [EnumMember(Value = "IP_ADDRESS")]
            IpAddress,
            [EnumMember(Value = "HOSTNAME")]
            Hostname
        };

        /// <value>
        /// The type of identifier for your CPE device. The value you provide here must correspond to the value
        /// for `cpeLocalIdentifier`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "cpeLocalIdentifierType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<CpeLocalIdentifierTypeEnum> CpeLocalIdentifierType { get; set; }
        
        /// <value>
        /// Static routes to the CPE. If you provide this attribute, it replaces the entire current set of
        /// static routes. A static route's CIDR must not be a multicast address or class E address.
        /// The CIDR can be either IPv4 or IPv6.
        /// IPv6 addressing is supported for all commercial and government regions.
        /// See [IPv6 Addresses](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/ipv6.htm).
        /// <br/>
        /// Example: 10.0.1.0/24
        /// </value>
        [JsonProperty(PropertyName = "staticRoutes")]
        public System.Collections.Generic.List<string> StaticRoutes { get; set; }
        
    }
}
