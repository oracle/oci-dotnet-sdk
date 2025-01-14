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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The user credential information.
    /// </summary>
    public class RestCredential 
    {
        
        /// <value>
        /// The name of the user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Username is required.")]
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        
        /// <value>
        /// The password of the user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Password is required.")]
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
                ///
        /// <value>
        /// The SSL truststore type.
        /// </value>
        ///
        public enum SslTrustStoreTypeEnum {
            [EnumMember(Value = "JKS")]
            Jks,
            [EnumMember(Value = "BCFKS")]
            Bcfks
        };

        /// <value>
        /// The SSL truststore type.
        /// </value>
        [JsonProperty(PropertyName = "sslTrustStoreType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SslTrustStoreTypeEnum> SslTrustStoreType { get; set; }
        
        /// <value>
        /// The full path of the SSL truststore location in the agent.
        /// </value>
        [JsonProperty(PropertyName = "sslTrustStoreLocation")]
        public string SslTrustStoreLocation { get; set; }
        
        /// <value>
        /// The password of the SSL truststore location in the agent.
        /// </value>
        [JsonProperty(PropertyName = "sslTrustStorePassword")]
        public string SslTrustStorePassword { get; set; }
        
    }
}
