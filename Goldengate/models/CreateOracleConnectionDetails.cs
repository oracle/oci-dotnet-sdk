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
    /// The information about a new Oracle Database Connection.
    /// 
    /// </summary>
    public class CreateOracleConnectionDetails : CreateConnectionDetails
    {
        
        /// <value>
        /// The Oracle technology type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TechnologyType is required.")]
        [JsonProperty(PropertyName = "technologyType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OracleConnection.TechnologyTypeEnum> TechnologyType { get; set; }
        
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
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Password is required.")]
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
        
        /// <value>
        /// Connect descriptor or Easy Connect Naming method used to connect to a database.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "connectionString")]
        public string ConnectionString { get; set; }
        
        /// <value>
        /// Authentication mode. It can be provided at creation of Oracle Autonomous Database Serverless connections,
        /// when a databaseId is provided. The default value is MTLS.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "authenticationMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OracleConnection.AuthenticationModeEnum> AuthenticationMode { get; set; }
        
        /// <value>
        /// The wallet contents Oracle GoldenGate uses to make connections to a database.  This
        /// attribute is expected to be base64 encoded.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "wallet")]
        public string Wallet { get; set; }
        
        /// <value>
        /// The mode of the database connection session to be established by the data client.
        /// 'REDIRECT' - for a RAC database, 'DIRECT' - for a non-RAC database.
        /// Connection to a RAC database involves a redirection received from the SCAN listeners
        /// to the database node to connect to. By default the mode would be DIRECT.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sessionMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OracleConnection.SessionModeEnum> SessionMode { get; set; }
        
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
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the database being referenced.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "databaseId")]
        public string DatabaseId { get; set; }
        
        [JsonProperty(PropertyName = "connectionType")]
        private readonly string connectionType = "ORACLE";
    }
}
