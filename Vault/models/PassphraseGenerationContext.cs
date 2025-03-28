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


namespace Oci.VaultService.Models
{
    /// <summary>
    /// Generates Passphrase type secrets. By default, passphrase type secrets have no structure. The generated content is stored in Base64 format. 
    /// The SecretTemplate must have the %GENERATED_PASSPHRASE% keyword, which is later replaced with the generated content, if provided.
    /// 
    /// </summary>
    public class PassphraseGenerationContext : SecretGenerationContext
    {
                ///
        /// <value>
        /// Name of passphrase generation template to generate passphrase type secret.
        /// </value>
        ///
        public enum GenerationTemplateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SECRETS_DEFAULT_PASSWORD")]
            SecretsDefaultPassword,
            [EnumMember(Value = "DBAAS_DEFAULT_PASSWORD")]
            DbaasDefaultPassword
        };

        /// <value>
        /// Name of passphrase generation template to generate passphrase type secret.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "GenerationTemplate is required.")]
        [JsonProperty(PropertyName = "generationTemplate")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<GenerationTemplateEnum> GenerationTemplate { get; set; }
        
        /// <value>
        /// Length of the passphrase to be generated
        /// </value>
        [JsonProperty(PropertyName = "passphraseLength")]
        public System.Nullable<int> PassphraseLength { get; set; }
        
        [JsonProperty(PropertyName = "generationType")]
        private readonly string generationType = "PASSPHRASE";
    }
}
