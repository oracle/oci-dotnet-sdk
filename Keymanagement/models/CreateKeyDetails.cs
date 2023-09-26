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


namespace Oci.KeymanagementService.Models
{
    /// <summary>
    /// The details of the key that you want to create.
    /// </summary>
    public class CreateKeyDetails 
    {
        
        /// <value>
        /// The OCID of the compartment where you want to create the master encryption key.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A user-friendly name for the key. It does not have to be unique, and it is changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "KeyShape is required.")]
        [JsonProperty(PropertyName = "keyShape")]
        public KeyShape KeyShape { get; set; }
                ///
        /// <value>
        /// The key's protection mode indicates how the key persists and where cryptographic operations that use the key are performed.
        /// A protection mode of `HSM` means that the key persists on a hardware security module (HSM) and all cryptographic operations are performed inside
        /// the HSM. A protection mode of `SOFTWARE` means that the key persists on the server, protected by the vault's RSA wrapping key which persists
        /// on the HSM. All cryptographic operations that use a key with a protection mode of `SOFTWARE` are performed on the server. By default,
        /// a key's protection mode is set to `HSM`. You can't change a key's protection mode after the key is created or imported.
        /// A protection mode of `EXTERNAL` mean that the key persists on the customer's external key manager which is hosted externally outside of oracle.
        /// Oracle only hold a reference to that key.
        /// All cryptographic operations that use a key with a protection mode of `EXTERNAL` are performed by external key manager.
        /// 
        /// </value>
        ///
        public enum ProtectionModeEnum {
            [EnumMember(Value = "HSM")]
            Hsm,
            [EnumMember(Value = "SOFTWARE")]
            Software,
            [EnumMember(Value = "EXTERNAL")]
            External
        };

        /// <value>
        /// The key's protection mode indicates how the key persists and where cryptographic operations that use the key are performed.
        /// A protection mode of `HSM` means that the key persists on a hardware security module (HSM) and all cryptographic operations are performed inside
        /// the HSM. A protection mode of `SOFTWARE` means that the key persists on the server, protected by the vault's RSA wrapping key which persists
        /// on the HSM. All cryptographic operations that use a key with a protection mode of `SOFTWARE` are performed on the server. By default,
        /// a key's protection mode is set to `HSM`. You can't change a key's protection mode after the key is created or imported.
        /// A protection mode of `EXTERNAL` mean that the key persists on the customer's external key manager which is hosted externally outside of oracle.
        /// Oracle only hold a reference to that key.
        /// All cryptographic operations that use a key with a protection mode of `EXTERNAL` are performed by external key manager.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "protectionMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ProtectionModeEnum> ProtectionMode { get; set; }
        
        [JsonProperty(PropertyName = "externalKeyReference")]
        public ExternalKeyReference ExternalKeyReference { get; set; }
        
    }
}
