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
    /// The details required to connect to an external Oracle Database.
    /// It takes either connectionCredentials or databaseCredential. It's recommended to provide databaseCredential
    /// 
    /// </summary>
    public class ExternalDatabaseConnectionInfo : ExternalDbSystemConnectionInfo
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConnectionString is required.")]
        [JsonProperty(PropertyName = "connectionString")]
        public DatabaseConnectionString ConnectionString { get; set; }
        
        [JsonProperty(PropertyName = "connectionCredentials")]
        public DatabaseConnectionCredentials ConnectionCredentials { get; set; }
        
        [JsonProperty(PropertyName = "databaseCredential")]
        public DatabaseCredentialDetails DatabaseCredential { get; set; }
        
        [JsonProperty(PropertyName = "componentType")]
        private readonly string componentType = "DATABASE";
    }
}
