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


namespace Oci.ObjectstorageService.Models
{
    /// <summary>
    /// The object representing FQDN details formed using prefix and additionalPrefixes.
    /// 
    /// </summary>
    public class Fqdns 
    {
        
        [JsonProperty(PropertyName = "prefixFqdns")]
        public PrefixFqdns PrefixFqdns { get; set; }
        
        /// <value>
        /// An object containing FQDNs formed using additionalPrefixes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "additionalPrefixesFqdns")]
        public System.Collections.Generic.Dictionary<string, PrefixFqdns> AdditionalPrefixesFqdns { get; set; }
        
    }
}
