/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.StackmonitoringService.Models
{
    /// <summary>
    /// Encrypted credentials [indicated by the type property in CredentialStore].
    /// 
    /// </summary>
    public class EncryptedCredentials : MonitoredResourceCredential
    {
        
        /// <value>
        /// The master key should be created in OCI Vault owned by the client of this API. 
        /// The user should have permission to access the vault key.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "KeyId is required.")]
        [JsonProperty(PropertyName = "keyId")]
        public string KeyId { get; set; }
        
        /// <value>
        /// The credential properties list. Credential property values will be encrypted format.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Properties is required.")]
        [JsonProperty(PropertyName = "properties")]
        public System.Collections.Generic.List<CredentialProperty> Properties { get; set; }
        
        [JsonProperty(PropertyName = "credentialType")]
        private readonly string credentialType = "ENCRYPTED";
    }
}
