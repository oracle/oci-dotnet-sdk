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
    /// Create Migration resource parameters.
    /// </summary>
    public class CreateOracleMigrationDetails : CreateMigrationDetails
    {
        
        [JsonProperty(PropertyName = "dataTransferMediumDetails")]
        public CreateOracleDataTransferMediumDetails DataTransferMediumDetails { get; set; }
        
        [JsonProperty(PropertyName = "initialLoadSettings")]
        public CreateOracleInitialLoadSettings InitialLoadSettings { get; set; }
        
        [JsonProperty(PropertyName = "advisorSettings")]
        public CreateOracleAdvisorSettings AdvisorSettings { get; set; }
        
        [JsonProperty(PropertyName = "hubDetails")]
        public CreateGoldenGateHubDetails HubDetails { get; set; }
        
        [JsonProperty(PropertyName = "ggsDetails")]
        public CreateOracleGgsDeploymentDetails GgsDetails { get; set; }
        
        /// <value>
        /// List of Migration Parameter objects.
        /// </value>
        [JsonProperty(PropertyName = "advancedParameters")]
        public System.Collections.Generic.List<MigrationParameterDetails> AdvancedParameters { get; set; }
        
        /// <value>
        /// The OCID of the resource being referenced.
        /// </value>
        [JsonProperty(PropertyName = "sourceContainerDatabaseConnectionId")]
        public string SourceContainerDatabaseConnectionId { get; set; }
        
        /// <value>
        /// Database objects to exclude from migration, cannot be specified alongside 'includeObjects'
        /// 
        /// </value>
        [JsonProperty(PropertyName = "excludeObjects")]
        public System.Collections.Generic.List<OracleDatabaseObject> ExcludeObjects { get; set; }
        
        /// <value>
        /// Database objects to include from migration, cannot be specified alongside 'excludeObjects'
        /// </value>
        [JsonProperty(PropertyName = "includeObjects")]
        public System.Collections.Generic.List<OracleDatabaseObject> IncludeObjects { get; set; }
        
        /// <value>
        /// Specifies the database objects to be excluded from the migration in bulk.
        /// The definition accepts input in a CSV format, newline separated for each entry.
        /// More details can be found in the documentation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "bulkIncludeExcludeData")]
        public string BulkIncludeExcludeData { get; set; }
        
        [JsonProperty(PropertyName = "databaseCombination")]
        private readonly string databaseCombination = "ORACLE";
    }
}
