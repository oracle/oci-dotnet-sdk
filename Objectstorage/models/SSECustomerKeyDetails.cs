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


namespace Oci.ObjectstorageService.Models
{
    /// <summary>
    /// Specifies the details of the customer-provided encryption key (SSE-C) associated with an object.
    /// 
    /// </summary>
    public class SSECustomerKeyDetails 
    {
                ///
        /// <value>
        /// Specifies the encryption algorithm. The only supported value is \"AES256\".
        /// 
        /// </value>
        ///
        public enum AlgorithmEnum {
            [EnumMember(Value = "AES256")]
            Aes256
        };

        /// <value>
        /// Specifies the encryption algorithm. The only supported value is \"AES256\".
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Algorithm is required.")]
        [JsonProperty(PropertyName = "algorithm")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AlgorithmEnum> Algorithm { get; set; }
        
        /// <value>
        /// Specifies the base64-encoded 256-bit encryption key to use to encrypt or decrypt the object data.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// Specifies the base64-encoded SHA256 hash of the encryption key. This value is used to check the integrity
        /// of the encryption key.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "KeySha256 is required.")]
        [JsonProperty(PropertyName = "keySha256")]
        public string KeySha256 { get; set; }
        
    }
}
