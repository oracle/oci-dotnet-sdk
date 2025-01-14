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


namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// The information about a new PostgreSQL Connection.
    /// 
    /// </summary>
    public class CreatePostgresqlConnectionDetails : CreateConnectionDetails
    {
        
        /// <value>
        /// The PostgreSQL technology type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TechnologyType is required.")]
        [JsonProperty(PropertyName = "technologyType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PostgresqlConnection.TechnologyTypeEnum> TechnologyType { get; set; }
        
        /// <value>
        /// The name of the database.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseName is required.")]
        [JsonProperty(PropertyName = "databaseName")]
        public string DatabaseName { get; set; }
        
        /// <value>
        /// The name or address of a host.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }
        
        /// <value>
        /// The port of an endpoint usually specified for a connection.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }
        
        /// <value>
        /// The username Oracle GoldenGate uses to connect the associated system of the given technology.
        /// This username must already exist and be available by the system/application to be connected to
        /// and must conform to the case sensitivty requirments defined in it.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Username is required.")]
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
        /// An array of name-value pair attribute entries.
        /// Used as additional parameters in connection string.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "additionalAttributes")]
        public System.Collections.Generic.List<NameValuePair> AdditionalAttributes { get; set; }
        
        /// <value>
        /// Security protocol for PostgreSQL.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SecurityProtocol is required.")]
        [JsonProperty(PropertyName = "securityProtocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PostgresqlConnection.SecurityProtocolEnum> SecurityProtocol { get; set; }
        
        /// <value>
        /// SSL modes for PostgreSQL.
        /// </value>
        [JsonProperty(PropertyName = "sslMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PostgresqlConnection.SslModeEnum> SslMode { get; set; }
        
        /// <value>
        /// The base64 encoded certificate of the trusted certificate authorities (Trusted CA) for PostgreSQL. 
        /// The supported file formats are .pem and .crt.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sslCa")]
        public string SslCa { get; set; }
        
        /// <value>
        /// The base64 encoded list of certificates revoked by the trusted certificate authorities (Trusted CA).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sslCrl")]
        public string SslCrl { get; set; }
        
        /// <value>
        /// The base64 encoded certificate of the PostgreSQL server. The supported file formats are .pem and .crt.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sslCert")]
        public string SslCert { get; set; }
        
        /// <value>
        /// The base64 encoded private key of the PostgreSQL server. The supported file formats are .pem and .crt.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sslKey")]
        public string SslKey { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Secret that stores the private key of the PostgreSQL server. The supported file formats are .pem and .crt. 
        /// Note: When provided, 'sslKey' field must not be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sslKeySecretId")]
        public string SslKeySecretId { get; set; }
        
        /// <value>
        /// Deprecated: this field will be removed in future versions. Either specify the private IP in the connectionString or host 
        /// field, or make sure the host name is resolvable in the target VCN.
        /// <br/>
        /// The private IP address of the connection's endpoint in the customer's VCN, typically a
        /// database endpoint or a big data endpoint (e.g. Kafka bootstrap server).
        /// In case the privateIp is provided, the subnetId must also be provided.
        /// In case the privateIp (and the subnetId) is not provided it is assumed the datasource is publicly accessible.
        /// In case the connection is accessible only privately, the lack of privateIp will result in not being able to access the connection.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "privateIp")]
        public string PrivateIp { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the database system being referenced.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dbSystemId")]
        public string DbSystemId { get; set; }
        
        [JsonProperty(PropertyName = "connectionType")]
        private readonly string connectionType = "POSTGRESQL";
    }
}
