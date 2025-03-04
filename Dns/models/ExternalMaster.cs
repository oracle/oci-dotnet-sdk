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


namespace Oci.DnsService.Models
{
    /// <summary>
    /// An external master name server used as the source of zone data.
    /// 
    /// </summary>
    public class ExternalMaster 
    {
        
        /// <value>
        /// The server's IP address (IPv4 or IPv6).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Address is required.")]
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }
        
        /// <value>
        /// The server's port. Port value must be a value of 53, otherwise omit
        /// the port value.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }
        
        /// <value>
        /// The OCID of the TSIG key.
        /// </value>
        [JsonProperty(PropertyName = "tsigKeyId")]
        public string TsigKeyId { get; set; }
        
    }
}
