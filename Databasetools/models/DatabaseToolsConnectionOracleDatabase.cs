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


namespace Oci.DatabasetoolsService.Models
{
    /// <summary>
    /// Database Tools connection of an Oracle Database.
    /// </summary>
    public class DatabaseToolsConnectionOracleDatabase : DatabaseToolsConnection
    {
        
        [JsonProperty(PropertyName = "relatedResource")]
        public DatabaseToolsRelatedResource RelatedResource { get; set; }
        
        /// <value>
        /// The connect descriptor or Easy Connect Naming method used to connect to the database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConnectionString is required.")]
        [JsonProperty(PropertyName = "connectionString")]
        public string ConnectionString { get; set; }
        
        /// <value>
        /// The database user name.
        /// </value>
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }
        
        [JsonProperty(PropertyName = "userPassword")]
        public DatabaseToolsUserPassword UserPassword { get; set; }
        
        /// <value>
        /// The advanced connection properties key-value pair (for example, `oracle.net.ssl_server_dn_match`).
        /// </value>
        [JsonProperty(PropertyName = "advancedProperties")]
        public System.Collections.Generic.Dictionary<string, string> AdvancedProperties { get; set; }
        
        /// <value>
        /// The Oracle wallet or Java Keystores containing trusted certificates for authenticating the server's public certificate and
        /// the client private key and associated certificates required for client authentication.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "keyStores")]
        public System.Collections.Generic.List<DatabaseToolsKeyStore> KeyStores { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Database Tools private endpoint used to access the database in the customer VCN.
        /// </value>
        [JsonProperty(PropertyName = "privateEndpointId")]
        public string PrivateEndpointId { get; set; }
        
        [JsonProperty(PropertyName = "proxyClient")]
        public DatabaseToolsConnectionOracleDatabaseProxyClient ProxyClient { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "ORACLE_DATABASE";
    }
}
