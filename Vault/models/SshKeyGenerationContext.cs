/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.VaultService.Models
{
    /// <summary>
    /// Generates ssh keys. By default, the keys are stored as - {\"publicKey\": \"%GENERATED_PUBLIC_KEY%\", \"privateKey\": \"%GENERATED_PRIVATE_KEY%\"} in PEM format. 
    /// The SecretTemplate must have both %GENERATED_PUBLIC_KEY% and %GENERATED_PRIVATE_KEY% keywords which is later replaced with the respective keys, if provided.
    /// 
    /// </summary>
    public class SshKeyGenerationContext : SecretGenerationContext
    {
                ///
        /// <value>
        /// Name of SSH key generation template to generate SSH key type secret.
        /// </value>
        ///
        public enum GenerationTemplateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "RSA_2048")]
            Rsa2048,
            [EnumMember(Value = "RSA_3072")]
            Rsa3072,
            [EnumMember(Value = "RSA_4096")]
            Rsa4096
        };

        /// <value>
        /// Name of SSH key generation template to generate SSH key type secret.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "GenerationTemplate is required.")]
        [JsonProperty(PropertyName = "generationTemplate")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<GenerationTemplateEnum> GenerationTemplate { get; set; }
        
        [JsonProperty(PropertyName = "generationType")]
        private readonly string generationType = "SSH_KEY";
    }
}
