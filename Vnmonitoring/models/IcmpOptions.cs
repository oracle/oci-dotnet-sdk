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
    /// <summary>
    /// Optional and valid only for ICMP and ICMPv6. Use to specify a particular ICMP type and code
    /// as defined in:
    /// - [ICMP Parameters](http://www.iana.org/assignments/icmp-parameters/icmp-parameters.xhtml)
    /// - [ICMPv6 Parameters](https://www.iana.org/assignments/icmpv6-parameters/icmpv6-parameters.xhtml)
    /// <br/>
    /// If you specify ICMP or ICMPv6 as the protocol but omit this object, then all ICMP types and
    /// codes are allowed. If you do provide this object, the type is required and the code is optional.
    /// To enable MTU negotiation for ingress internet traffic via IPv4, make sure to allow type 3 (\"Destination
    /// Unreachable\") code 4 (\"Fragmentation Needed and Don't Fragment was Set\"). If you need to specify
    /// multiple codes for a single type, create a separate security list rule for each.
    /// 
    /// </summary>
    public class IcmpOptions 
    {
        
        /// <value>
        /// The ICMP code (optional).
        /// </value>
        [JsonProperty(PropertyName = "code")]
        public System.Nullable<int> Code { get; set; }
        
        /// <value>
        /// The ICMP type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        public System.Nullable<int> Type { get; set; }
        
    }
}
