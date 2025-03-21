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
    /// The update details for a Database Tools Generic JDBC database system connection.
    /// </summary>
    public class UpdateDatabaseToolsConnectionGenericJdbcDetails : UpdateDatabaseToolsConnectionDetails
    {
        
        /// <value>
        /// The JDBC URL used to connect to the Generic JDBC database system.
        /// </value>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        
        /// <value>
        /// The user name.
        /// </value>
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }
        
        [JsonProperty(PropertyName = "userPassword")]
        public DatabaseToolsUserPasswordDetails UserPassword { get; set; }
        
        /// <value>
        /// The advanced connection properties key-value pair.
        /// </value>
        [JsonProperty(PropertyName = "advancedProperties")]
        public System.Collections.Generic.Dictionary<string, string> AdvancedProperties { get; set; }
        
        /// <value>
        /// The CA certificate to verify the server's certificate and
        /// the client private key and associated certificate required for client authentication.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "keyStores")]
        public System.Collections.Generic.List<DatabaseToolsKeyStoreGenericJdbcDetails> KeyStores { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "GENERIC_JDBC";
    }
}
