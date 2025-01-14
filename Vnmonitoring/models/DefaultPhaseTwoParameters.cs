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
    /// Default phase two parameters.
    /// </summary>
    public class DefaultPhaseTwoParameters 
    {
        
        /// <value>
        /// Default phase two encryption algorithms.
        /// </value>
        [JsonProperty(PropertyName = "defaultEncryptionAlgorithms")]
        public System.Collections.Generic.List<string> DefaultEncryptionAlgorithms { get; set; }
        
        /// <value>
        /// Default phase two authentication algorithms.
        /// </value>
        [JsonProperty(PropertyName = "defaultAuthenticationAlgorithms")]
        public System.Collections.Generic.List<string> DefaultAuthenticationAlgorithms { get; set; }
        
        /// <value>
        /// Default perfect forward secrecy Diffie-Hellman groups.
        /// </value>
        [JsonProperty(PropertyName = "defaultPfsDhGroup")]
        public string DefaultPfsDhGroup { get; set; }
        
    }
}
