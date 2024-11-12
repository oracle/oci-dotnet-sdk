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


namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// Summary of the Kafka Connection.
    /// 
    /// </summary>
    public class KafkaConnectionSummary : ConnectionSummary
    {
        
        /// <value>
        /// The Kafka technology type.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TechnologyType is required.")]
        [JsonProperty(PropertyName = "technologyType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<KafkaConnection.TechnologyTypeEnum> TechnologyType { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the stream pool being referenced.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "streamPoolId")]
        public string StreamPoolId { get; set; }
        
        /// <value>
        /// Kafka bootstrap. Equivalent of bootstrap.servers configuration property in Kafka:
        /// list of KafkaBootstrapServer objects specified by host/port.
        /// Used for establishing the initial connection to the Kafka cluster.
        /// Example: &quot;server1.example.com:9092,server2.example.com:9092&quot;
        /// </value>
        [JsonProperty(PropertyName = "bootstrapServers")]
        public System.Collections.Generic.List<KafkaBootstrapServer> BootstrapServers { get; set; }
        
        /// <value>
        /// Security Type for Kafka.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "securityProtocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<KafkaConnection.SecurityProtocolEnum> SecurityProtocol { get; set; }
        
        /// <value>
        /// The username Oracle GoldenGate uses to connect the associated system of the given technology.
        /// This username must already exist and be available by the system/application to be connected to
        /// and must conform to the case sensitivty requirments defined in it.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Secret where the password is stored.
        /// The password Oracle GoldenGate uses to connect the associated system of the given technology.
        /// It must conform to the specific security requirements including length, case sensitivity, and so on.
        /// If secretId is used plaintext field must not be provided.
        /// Note: When provided, 'password' field must not be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "passwordSecretId")]
        public string PasswordSecretId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Secret where the content of the TrustStore file is stored.
        /// Note: When provided, 'trustStore' field must not be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "trustStoreSecretId")]
        public string TrustStoreSecretId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Secret where the kafka TrustStore password is stored.
        /// Note: When provided, 'trustStorePassword' field must not be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "trustStorePasswordSecretId")]
        public string TrustStorePasswordSecretId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Secret where the content of the KeyStore file is stored.
        /// Note: When provided, 'keyStore' field must not be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "keyStoreSecretId")]
        public string KeyStoreSecretId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Secret where the kafka KeyStore password is stored.
        /// Note: When provided, 'keyStorePassword' field must not be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "keyStorePasswordSecretId")]
        public string KeyStorePasswordSecretId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Secret where the kafka Ssl Key password is stored.
        /// Note: When provided, 'sslKeyPassword' field must not be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sslKeyPasswordSecretId")]
        public string SslKeyPasswordSecretId { get; set; }
        
        [JsonProperty(PropertyName = "connectionType")]
        private readonly string connectionType = "KAFKA";
    }
}
