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


namespace Oci.KeymanagementService.Models
{
    /// <summary>
    /// The response to a request to decrypt the encrypted data.
    /// </summary>
    public class DecryptedData 
    {
        
        /// <value>
        /// The decrypted data, expressed as a base64-encoded value.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Plaintext is required.")]
        [JsonProperty(PropertyName = "plaintext")]
        public string Plaintext { get; set; }
        
        /// <value>
        /// The checksum of the decrypted data.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PlaintextChecksum is required.")]
        [JsonProperty(PropertyName = "plaintextChecksum")]
        public string PlaintextChecksum { get; set; }
        
        /// <value>
        /// The OCID of the key used to encrypt the ciphertext.
        /// </value>
        [JsonProperty(PropertyName = "keyId")]
        public string KeyId { get; set; }
        
        /// <value>
        /// The OCID of the key version used to encrypt the ciphertext.
        /// </value>
        [JsonProperty(PropertyName = "keyVersionId")]
        public string KeyVersionId { get; set; }
                ///
        /// <value>
        /// The encryption algorithm to use to encrypt and decrypt data with a customer-managed key
        /// `AES_256_GCM` indicates that the key is a symmetric key that uses the Advanced Encryption Standard (AES) algorithm and
        /// that the mode of encryption is the Galois/Counter Mode (GCM). `RSA_OAEP_SHA_1` indicates that the
        /// key is an asymmetric key that uses the RSA encryption algorithm and uses Optimal Asymmetric Encryption Padding (OAEP).
        /// `RSA_OAEP_SHA_256` indicates that the key is an asymmetric key that uses the RSA encryption algorithm with a SHA-256 hash
        /// and uses OAEP.
        /// 
        /// </value>
        ///
        public enum EncryptionAlgorithmEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "AES_256_GCM")]
            Aes256Gcm,
            [EnumMember(Value = "RSA_OAEP_SHA_1")]
            RsaOaepSha1,
            [EnumMember(Value = "RSA_OAEP_SHA_256")]
            RsaOaepSha256
        };

        /// <value>
        /// The encryption algorithm to use to encrypt and decrypt data with a customer-managed key
        /// `AES_256_GCM` indicates that the key is a symmetric key that uses the Advanced Encryption Standard (AES) algorithm and
        /// that the mode of encryption is the Galois/Counter Mode (GCM). `RSA_OAEP_SHA_1` indicates that the
        /// key is an asymmetric key that uses the RSA encryption algorithm and uses Optimal Asymmetric Encryption Padding (OAEP).
        /// `RSA_OAEP_SHA_256` indicates that the key is an asymmetric key that uses the RSA encryption algorithm with a SHA-256 hash
        /// and uses OAEP.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "encryptionAlgorithm")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<EncryptionAlgorithmEnum> EncryptionAlgorithm { get; set; }
        
    }
}
