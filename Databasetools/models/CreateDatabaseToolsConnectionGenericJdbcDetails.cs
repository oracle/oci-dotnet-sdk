/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
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
    /// Details of the new Database Tools connection for a Generic JDBC database system.
    /// </summary>
    public class CreateDatabaseToolsConnectionGenericJdbcDetails : CreateDatabaseToolsConnectionDetails
    {
        
        /// <value>
        /// The JDBC URL used to connect to the Generic JDBC database system.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Url is required.")]
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        
        /// <value>
        /// The user name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UserName is required.")]
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UserPassword is required.")]
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
