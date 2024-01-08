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
    /// The information to update a Kafka Connection.
    /// 
    /// </summary>
    public class UpdateKafkaConnectionDetails : UpdateConnectionDetails
    {
        
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
        /// The password Oracle GoldenGate uses to connect the associated system of the given technology.
        /// It must conform to the specific security requirements including length, case sensitivity, and so on.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
        
        /// <value>
        /// The base64 encoded content of the TrustStore file.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "trustStore")]
        public string TrustStore { get; set; }
        
        /// <value>
        /// The TrustStore password.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "trustStorePassword")]
        public string TrustStorePassword { get; set; }
        
        /// <value>
        /// The base64 encoded content of the KeyStore file.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "keyStore")]
        public string KeyStore { get; set; }
        
        /// <value>
        /// The KeyStore password.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "keyStorePassword")]
        public string KeyStorePassword { get; set; }
        
        /// <value>
        /// The password for the cert inside of the KeyStore.
        /// In case it differs from the KeyStore password, it should be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sslKeyPassword")]
        public string SslKeyPassword { get; set; }
        
        /// <value>
        /// The base64 encoded content of the consumer.properties file.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "consumerProperties")]
        public string ConsumerProperties { get; set; }
        
        /// <value>
        /// The base64 encoded content of the producer.properties file.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "producerProperties")]
        public string ProducerProperties { get; set; }
        
        [JsonProperty(PropertyName = "connectionType")]
        private readonly string connectionType = "KAFKA";
    }
}
