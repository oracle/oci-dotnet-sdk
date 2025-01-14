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
    /// The cryptographic properties of a key.
    /// </summary>
    public class KeyShape 
    {
                ///
        /// <value>
        /// The algorithm used by a key's key versions to encrypt or decrypt. Only AES algorithm is supported for `External` keys.
        /// </value>
        ///
        public enum AlgorithmEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "AES")]
            Aes,
            [EnumMember(Value = "RSA")]
            Rsa,
            [EnumMember(Value = "ECDSA")]
            Ecdsa
        };

        /// <value>
        /// The algorithm used by a key's key versions to encrypt or decrypt. Only AES algorithm is supported for `External` keys.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Algorithm is required.")]
        [JsonProperty(PropertyName = "algorithm")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AlgorithmEnum> Algorithm { get; set; }
        
        /// <value>
        /// The length of the key in bytes, expressed as an integer. Supported values include the following:
        ///   - AES: 16, 24, or 32
        ///   - RSA: 256, 384, or 512
        ///   - ECDSA: 32, 48, or 66
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Length is required.")]
        [JsonProperty(PropertyName = "length")]
        public System.Nullable<int> Length { get; set; }
                ///
        /// <value>
        /// Supported curve IDs for ECDSA keys.
        /// </value>
        ///
        public enum CurveIdEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NIST_P256")]
            NistP256,
            [EnumMember(Value = "NIST_P384")]
            NistP384,
            [EnumMember(Value = "NIST_P521")]
            NistP521
        };

        /// <value>
        /// Supported curve IDs for ECDSA keys.
        /// </value>
        [JsonProperty(PropertyName = "curveId")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CurveIdEnum> CurveId { get; set; }
        
    }
}
