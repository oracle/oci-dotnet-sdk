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


namespace Oci.FleetappsmanagementService.Models
{
    /// <summary>
    /// Details for the Credentials that use key encryption.
    /// </summary>
    public class KeyEncryptionCredentialDetails : CredentialDetails
    {
        
        /// <value>
        /// The value corresponding to the credential.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Value is required.")]
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        /// <value>
        /// OCID for the Vault Key that will be used to encrypt/decrypt the value given.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "KeyId is required.")]
        [JsonProperty(PropertyName = "keyId")]
        public string KeyId { get; set; }
        
        /// <value>
        /// The Vault Key version.
        /// </value>
        [JsonProperty(PropertyName = "keyVersion")]
        public string KeyVersion { get; set; }
        
        /// <value>
        /// OCID for the Vault that will be used to fetch the key to encrypt/decrypt the value given.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VaultId is required.")]
        [JsonProperty(PropertyName = "vaultId")]
        public string VaultId { get; set; }
        
        [JsonProperty(PropertyName = "credentialType")]
        private readonly string credentialType = "KEY_ENCRYPTION";
    }
}
