/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.WafService.Models
{
    /// <summary>
    /// The information to be updated for NetworkAddressListVcnAddresses.
    /// </summary>
    public class UpdateNetworkAddressListVcnAddressesDetails : UpdateNetworkAddressListDetails
    {
        
        /// <value>
        /// A list of private address prefixes, each associated with a particular VCN.
        /// To specify all addresses in a VCN, use \"0.0.0.0/0\" for IPv4 and \"::/0\" for IPv6.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vcnAddresses")]
        public System.Collections.Generic.List<PrivateAddresses> VcnAddresses { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "VCN_ADDRESSES";
    }
}
