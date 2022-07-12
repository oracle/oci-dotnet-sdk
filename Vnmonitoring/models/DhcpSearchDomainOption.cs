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
    /// <summary>
    /// DHCP option for specifying a search domain name for DNS queries. For more information, see
    /// [DNS in Your Virtual Cloud Network](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/dns.htm).
    /// 
    /// </summary>
    public class DhcpSearchDomainOption : DhcpOption
    {
        
        /// <value>
        /// A single search domain name according to [RFC 952](https://tools.ietf.org/html/rfc952)
        /// and [RFC 1123](https://tools.ietf.org/html/rfc1123). During a DNS query,
        /// the OS will append this search domain name to the value being queried.
        /// <br/>
        /// If you set {@link DhcpDnsOption} to `VcnLocalPlusInternet`,
        /// and you assign a DNS label to the VCN during creation, the search domain name in the
        /// VCN's default set of DHCP options is automatically set to the VCN domain
        /// (for example, `vcn1.oraclevcn.com`).
        /// <br/>
        /// If you don't want to use a search domain name, omit this option from the
        /// set of DHCP options. Do not include this option with an empty list
        /// of search domain names, or with an empty string as the value for any search
        /// domain name.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SearchDomainNames is required.")]
        [JsonProperty(PropertyName = "searchDomainNames")]
        public System.Collections.Generic.List<string> SearchDomainNames { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "SearchDomain";
    }
}