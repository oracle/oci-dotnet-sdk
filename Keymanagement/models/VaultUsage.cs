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


namespace Oci.KeymanagementService.Models
{
    /// <summary>
    /// The details of the number of Keys and KeyVersions usage in a Vault.
    /// </summary>
    public class VaultUsage 
    {
        
        /// <value>
        /// The number of keys in this vault that persist on a hardware security module (HSM), across all compartments, excluding keys in a `DELETED` state.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "KeyCount is required.")]
        [JsonProperty(PropertyName = "keyCount")]
        public System.Nullable<int> KeyCount { get; set; }
        
        /// <value>
        /// The number of key versions in this vault that persist on a hardware security module (HSM), across all compartments, excluding key versions in a `DELETED` state.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "KeyVersionCount is required.")]
        [JsonProperty(PropertyName = "keyVersionCount")]
        public System.Nullable<int> KeyVersionCount { get; set; }
        
        /// <value>
        /// The number of keys in this vault that persist on the server, across all compartments, excluding keys in a `DELETED` state.
        /// </value>
        [JsonProperty(PropertyName = "softwareKeyCount")]
        public System.Nullable<int> SoftwareKeyCount { get; set; }
        
        /// <value>
        /// The number of key versions in this vault that persist on the server, across all compartments, excluding key versions in a `DELETED` state.
        /// </value>
        [JsonProperty(PropertyName = "softwareKeyVersionCount")]
        public System.Nullable<int> SoftwareKeyVersionCount { get; set; }
        
    }
}
