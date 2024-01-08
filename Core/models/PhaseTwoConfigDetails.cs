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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// Configuration details for IPSec phase two configuration parameters.
    /// </summary>
    public class PhaseTwoConfigDetails 
    {
        
        /// <value>
        /// Indicates whether custom configuration is enabled for phase two options.
        /// </value>
        [JsonProperty(PropertyName = "isCustomPhaseTwoConfig")]
        public System.Nullable<bool> IsCustomPhaseTwoConfig { get; set; }
                ///
        /// <value>
        /// The authentication algorithm proposed during phase two tunnel negotiation.
        /// 
        /// </value>
        ///
        public enum AuthenticationAlgorithmEnum {
            [EnumMember(Value = "HMAC_SHA2_256_128")]
            HmacSha2256128,
            [EnumMember(Value = "HMAC_SHA1_128")]
            HmacSha1128
        };

        /// <value>
        /// The authentication algorithm proposed during phase two tunnel negotiation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "authenticationAlgorithm")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AuthenticationAlgorithmEnum> AuthenticationAlgorithm { get; set; }
                ///
        /// <value>
        /// The encryption algorithm proposed during phase two tunnel negotiation.
        /// 
        /// </value>
        ///
        public enum EncryptionAlgorithmEnum {
            [EnumMember(Value = "AES_256_GCM")]
            Aes256Gcm,
            [EnumMember(Value = "AES_192_GCM")]
            Aes192Gcm,
            [EnumMember(Value = "AES_128_GCM")]
            Aes128Gcm,
            [EnumMember(Value = "AES_256_CBC")]
            Aes256Cbc,
            [EnumMember(Value = "AES_192_CBC")]
            Aes192Cbc,
            [EnumMember(Value = "AES_128_CBC")]
            Aes128Cbc
        };

        /// <value>
        /// The encryption algorithm proposed during phase two tunnel negotiation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "encryptionAlgorithm")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<EncryptionAlgorithmEnum> EncryptionAlgorithm { get; set; }
        
        /// <value>
        /// Lifetime in seconds for the IPSec session key set in phase two. The default is 3600 which is equivalent to 1 hour.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifetimeInSeconds")]
        public System.Nullable<int> LifetimeInSeconds { get; set; }
        
        /// <value>
        /// Indicates whether perfect forward secrecy (PFS) is enabled.
        /// </value>
        [JsonProperty(PropertyName = "isPfsEnabled")]
        public System.Nullable<bool> IsPfsEnabled { get; set; }
                ///
        /// <value>
        /// The Diffie-Hellman group used for PFS, if PFS is enabled.
        /// </value>
        ///
        public enum PfsDhGroupEnum {
            [EnumMember(Value = "GROUP2")]
            Group2,
            [EnumMember(Value = "GROUP5")]
            Group5,
            [EnumMember(Value = "GROUP14")]
            Group14,
            [EnumMember(Value = "GROUP19")]
            Group19,
            [EnumMember(Value = "GROUP20")]
            Group20,
            [EnumMember(Value = "GROUP24")]
            Group24
        };

        /// <value>
        /// The Diffie-Hellman group used for PFS, if PFS is enabled.
        /// </value>
        [JsonProperty(PropertyName = "pfsDhGroup")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PfsDhGroupEnum> PfsDhGroup { get; set; }
        
    }
}
