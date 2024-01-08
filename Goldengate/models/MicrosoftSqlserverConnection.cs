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
    /// Represents the metadata of a Microsoft SQL Server Connection.
    /// 
    /// </summary>
    public class MicrosoftSqlserverConnection : Connection
    {
                ///
        /// <value>
        /// The Microsoft SQL Server technology type.
        /// </value>
        ///
        public enum TechnologyTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "AMAZON_RDS_SQLSERVER")]
            AmazonRdsSqlserver,
            [EnumMember(Value = "AZURE_SQLSERVER_MANAGED_INSTANCE")]
            AzureSqlserverManagedInstance,
            [EnumMember(Value = "AZURE_SQLSERVER_NON_MANAGED_INSTANCE")]
            AzureSqlserverNonManagedInstance,
            [EnumMember(Value = "GOOGLE_CLOUD_SQL_SQLSERVER")]
            GoogleCloudSqlSqlserver,
            [EnumMember(Value = "MICROSOFT_SQLSERVER")]
            MicrosoftSqlserver
        };

        /// <value>
        /// The Microsoft SQL Server technology type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TechnologyType is required.")]
        [JsonProperty(PropertyName = "technologyType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TechnologyTypeEnum> TechnologyType { get; set; }
        
        /// <value>
        /// The username Oracle GoldenGate uses to connect to the Microsoft SQL Server.
        /// This username must already exist and be available by the Microsoft SQL Server to be connected to.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Username is required.")]
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        
        /// <value>
        /// The name or address of a host.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Host is required.")]
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }
        
        /// <value>
        /// The port of an endpoint usually specified for a connection.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Port is required.")]
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }
        
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
        /// An array of name-value pair attribute entries.
        /// Used as additional parameters in connection string.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "additionalAttributes")]
        public System.Collections.Generic.List<NameValuePair> AdditionalAttributes { get; set; }
                ///
        /// <value>
        /// Security Protocol for Microsoft SQL Server.
        /// </value>
        ///
        public enum SecurityProtocolEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PLAIN")]
            Plain,
            [EnumMember(Value = "TLS")]
            Tls
        };

        /// <value>
        /// Security Protocol for Microsoft SQL Server.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SecurityProtocol is required.")]
        [JsonProperty(PropertyName = "securityProtocol")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SecurityProtocolEnum> SecurityProtocol { get; set; }
        
        /// <value>
        /// Database Certificate - The base64 encoded content of a .pem or .crt file.
        /// containing the server public key (for 1-way SSL).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sslCa")]
        public string SslCa { get; set; }
        
        /// <value>
        /// If set to true, the driver validates the certificate that is sent by the database server.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "shouldValidateServerCertificate")]
        public System.Nullable<bool> ShouldValidateServerCertificate { get; set; }
        
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
        
        [JsonProperty(PropertyName = "connectionType")]
        private readonly string connectionType = "MICROSOFT_SQLSERVER";
    }
}
