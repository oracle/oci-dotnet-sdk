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


namespace Oci.NetworkfirewallService.Models
{
    /// <summary>
    /// The request details to be updated in the address List for the policy.
    /// </summary>
    public class UpdateIpAddressListDetails : UpdateAddressListDetails
    {
        
        /// <value>
        /// List of IP addresses which could be IPv4 or IPv6 addresses or CIDR blocks.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Addresses is required.")]
        [JsonProperty(PropertyName = "addresses")]
        public System.Collections.Generic.List<string> Addresses { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "IP";
    }
}
