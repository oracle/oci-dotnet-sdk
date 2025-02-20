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
    /// The response to a request to sign the message.
    /// </summary>
    public class SignedData 
    {
        
        /// <value>
        /// The OCID of the key used to sign the message.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "KeyId is required.")]
        [JsonProperty(PropertyName = "keyId")]
        public string KeyId { get; set; }
        
        /// <value>
        /// The OCID of the key version used to sign the message.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "KeyVersionId is required.")]
        [JsonProperty(PropertyName = "keyVersionId")]
        public string KeyVersionId { get; set; }
        
        /// <value>
        /// The base64-encoded binary data object denoting the cryptographic signature generated for the message or message digest.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Signature is required.")]
        [JsonProperty(PropertyName = "signature")]
        public string Signature { get; set; }
                ///
        /// <value>
        /// The algorithm to use to sign the message or message digest.
        /// For RSA keys, supported signature schemes include PKCS #1 and RSASSA-PSS, along with
        /// different hashing algorithms.
        /// For ECDSA keys, ECDSA is the supported signature scheme with different hashing algorithms.
        /// When you pass a message digest for signing, ensure that you specify the same hashing algorithm
        /// as used when creating the message digest.
        /// 
        /// </value>
        ///
        public enum SigningAlgorithmEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SHA_224_RSA_PKCS_PSS")]
            Sha224RsaPkcsPss,
            [EnumMember(Value = "SHA_256_RSA_PKCS_PSS")]
            Sha256RsaPkcsPss,
            [EnumMember(Value = "SHA_384_RSA_PKCS_PSS")]
            Sha384RsaPkcsPss,
            [EnumMember(Value = "SHA_512_RSA_PKCS_PSS")]
            Sha512RsaPkcsPss,
            [EnumMember(Value = "SHA_224_RSA_PKCS1_V1_5")]
            Sha224RsaPkcs1V15,
            [EnumMember(Value = "SHA_256_RSA_PKCS1_V1_5")]
            Sha256RsaPkcs1V15,
            [EnumMember(Value = "SHA_384_RSA_PKCS1_V1_5")]
            Sha384RsaPkcs1V15,
            [EnumMember(Value = "SHA_512_RSA_PKCS1_V1_5")]
            Sha512RsaPkcs1V15,
            [EnumMember(Value = "ECDSA_SHA_256")]
            EcdsaSha256,
            [EnumMember(Value = "ECDSA_SHA_384")]
            EcdsaSha384,
            [EnumMember(Value = "ECDSA_SHA_512")]
            EcdsaSha512
        };

        /// <value>
        /// The algorithm to use to sign the message or message digest.
        /// For RSA keys, supported signature schemes include PKCS #1 and RSASSA-PSS, along with
        /// different hashing algorithms.
        /// For ECDSA keys, ECDSA is the supported signature scheme with different hashing algorithms.
        /// When you pass a message digest for signing, ensure that you specify the same hashing algorithm
        /// as used when creating the message digest.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SigningAlgorithm is required.")]
        [JsonProperty(PropertyName = "signingAlgorithm")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SigningAlgorithmEnum> SigningAlgorithm { get; set; }
        
    }
}
