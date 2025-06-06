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
    
    public class CreateIPSecTunnelBgpSessionDetails 
    {
        
        /// <value>
        /// The IP address for the Oracle end of the inside tunnel interface.
        /// <br/>
        /// If the tunnel's `routing` attribute is set to `BGP`
        /// (see {@link IPSecConnectionTunnel}), this IP address
        /// is required and used for the tunnel's BGP session.
        /// <br/>
        /// If `routing` is instead set to `STATIC`, this IP address is optional. You can set this IP
        /// address to troubleshoot or monitor the tunnel.
        /// <br/>
        /// The value must be a /30 or /31.
        /// <br/>
        /// Example: 10.0.0.4/31
        /// </value>
        [JsonProperty(PropertyName = "oracleInterfaceIp")]
        public string OracleInterfaceIp { get; set; }
        
        /// <value>
        /// The IP address for the CPE end of the inside tunnel interface.
        /// <br/>
        /// If the tunnel's `routing` attribute is set to `BGP`
        /// (see {@link IPSecConnectionTunnel}), this IP address
        /// is required and used for the tunnel's BGP session.
        /// <br/>
        /// If `routing` is instead set to `STATIC`, this IP address is optional. You can set this IP
        /// address to troubleshoot or monitor the tunnel.
        /// <br/>
        /// The value must be a /30 or /31.
        /// <br/>
        /// Example: 10.0.0.5/31
        /// </value>
        [JsonProperty(PropertyName = "customerInterfaceIp")]
        public string CustomerInterfaceIp { get; set; }
        
        /// <value>
        /// The IPv6 address for the Oracle end of the inside tunnel interface. This IP address is optional.
        /// <br/>
        /// If the tunnel's `routing` attribute is set to `BGP`
        /// (see {@link IPSecConnectionTunnel}), this IP address
        /// is used for the tunnel's BGP session.
        /// <br/>
        /// If `routing` is instead set to `STATIC`, you can set this IP
        /// address to troubleshoot or monitor the tunnel.
        /// <br/>
        /// Only subnet masks from /64 up to /127 are allowed.
        /// <br/>
        /// Example: 2001:db8::1/64
        /// </value>
        [JsonProperty(PropertyName = "oracleInterfaceIpv6")]
        public string OracleInterfaceIpv6 { get; set; }
        
        /// <value>
        /// The IPv6 address for the CPE end of the inside tunnel interface. This IP address is optional.
        /// <br/>
        /// If the tunnel's `routing` attribute is set to `BGP`
        /// (see {@link IPSecConnectionTunnel}), this IP address
        /// is used for the tunnel's BGP session.
        /// <br/>
        /// If `routing` is instead set to `STATIC`, you can set this IP
        /// address to troubleshoot or monitor the tunnel.
        /// <br/>
        /// Only subnet masks from /64 up to /127 are allowed.
        /// <br/>
        /// Example: 2001:db8::1/64
        /// </value>
        [JsonProperty(PropertyName = "customerInterfaceIpv6")]
        public string CustomerInterfaceIpv6 { get; set; }
        
        /// <value>
        /// If the tunnel's `routing` attribute is set to `BGP`
        /// (see {@link IPSecConnectionTunnel}), this ASN
        /// is required and used for the tunnel's BGP session. This is the ASN of the network on the
        /// CPE end of the BGP session. Can be a 2-byte or 4-byte ASN. Uses \"asplain\" format.
        /// <br/>
        /// If the tunnel's `routing` attribute is set to `STATIC`, the `customerBgpAsn` must be null.
        /// <br/>
        /// Example: 12345 (2-byte) or 1587232876 (4-byte)
        /// </value>
        [JsonProperty(PropertyName = "customerBgpAsn")]
        public string CustomerBgpAsn { get; set; }
        
    }
}
