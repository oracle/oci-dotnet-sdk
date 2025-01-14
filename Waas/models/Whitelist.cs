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


namespace Oci.WaasService.Models
{
    /// <summary>
    /// An array of IP addresses that bypass the Web Application Firewall. Supports both single IP addresses or subnet masks (CIDR notation).
    /// </summary>
    public class Whitelist 
    {
        
        /// <value>
        /// The unique name of the whitelist.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// A set of IP addresses or CIDR notations to include in the whitelist.
        /// </value>
        [JsonProperty(PropertyName = "addresses")]
        public System.Collections.Generic.List<string> Addresses { get; set; }
        
        /// <value>
        /// A list of [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of IP address lists to include in the whitelist.
        /// </value>
        [JsonProperty(PropertyName = "addressLists")]
        public System.Collections.Generic.List<string> AddressLists { get; set; }
        
    }
}
