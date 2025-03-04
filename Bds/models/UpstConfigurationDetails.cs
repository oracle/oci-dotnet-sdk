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


namespace Oci.BdsService.Models
{
    /// <summary>
    /// Details for activating/updating UPST config on the cluster
    /// </summary>
    public class UpstConfigurationDetails 
    {
        
        /// <value>
        /// OCID of the vault to store token exchange service principal keyta, required for activating UPST config
        /// </value>
        [JsonProperty(PropertyName = "vaultId")]
        public string VaultId { get; set; }
        
        /// <value>
        /// OCID of the master encryption key in vault for encrypting token exchange service principal keytab, required for activating UPST config
        /// </value>
        [JsonProperty(PropertyName = "masterEncryptionKeyId")]
        public string MasterEncryptionKeyId { get; set; }
        
    }
}
