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


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// The information to update a MySQL Connection.
    /// </summary>
    public class UpdateMysqlConnectionDetails : UpdateConnectionDetails
    {
        
        /// <value>
        /// The IP Address of the host.
        /// </value>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }
        
        /// <value>
        /// The port to be used for the connection.
        /// </value>
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }
        
        /// <value>
        /// The name of the database being referenced.
        /// </value>
        [JsonProperty(PropertyName = "databaseName")]
        public string DatabaseName { get; set; }
        
        /// <value>
        /// Security Type for MySQL.
        /// </value>
        [JsonProperty(PropertyName = "securityProtocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MysqlConnection.SecurityProtocolEnum> SecurityProtocol { get; set; }
        
        /// <value>
        /// SSL modes for MySQL.
        /// </value>
        [JsonProperty(PropertyName = "sslMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MysqlConnection.SslModeEnum> SslMode { get; set; }
        
        /// <value>
        /// Database Certificate - The base64 encoded content of mysql.pem file
        /// containing the server public key (for 1 and 2-way SSL).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sslCa")]
        public string SslCa { get; set; }
        
        /// <value>
        /// Certificates revoked by certificate authorities (CA).
        /// Server certificate must not be on this list (for 1 and 2-way SSL).
        /// Note: This is an optional and that too only applicable if TLS/MTLS option is selected.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sslCrl")]
        public string SslCrl { get; set; }
        
        /// <value>
        /// Client Certificate - The base64 encoded content of client-cert.pem file 
        /// containing the client public key (for 2-way SSL).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sslCert")]
        public string SslCert { get; set; }
        
        /// <value>
        /// Client Key - The client-key.pem containing the client private key (for 2-way SSL).
        /// </value>
        [JsonProperty(PropertyName = "sslKey")]
        public string SslKey { get; set; }
        
        /// <value>
        /// An array of name-value pair attribute entries.
        /// </value>
        [JsonProperty(PropertyName = "additionalAttributes")]
        public System.Collections.Generic.List<NameValuePair> AdditionalAttributes { get; set; }
        
        /// <value>
        /// The OCID of the database system being referenced.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dbSystemId")]
        public string DbSystemId { get; set; }
        
        [JsonProperty(PropertyName = "connectionType")]
        private readonly string connectionType = "MYSQL";
    }
}
