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
    public class UpdateOracleMigrationDetails : UpdateMigrationDetails
    {
        
        [JsonProperty(PropertyName = "dataTransferMediumDetails")]
        public UpdateOracleDataTransferMediumDetails DataTransferMediumDetails { get; set; }
        
        [JsonProperty(PropertyName = "initialLoadSettings")]
        public UpdateOracleInitialLoadSettings InitialLoadSettings { get; set; }
        
        [JsonProperty(PropertyName = "advisorSettings")]
        public UpdateOracleAdvisorSettings AdvisorSettings { get; set; }
        
        [JsonProperty(PropertyName = "hubDetails")]
        public UpdateGoldenGateHubDetails HubDetails { get; set; }
        
        [JsonProperty(PropertyName = "ggsDetails")]
        public UpdateOracleGgsDeploymentDetails GgsDetails { get; set; }
        
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
        
        [JsonProperty(PropertyName = "databaseCombination")]
        private readonly string databaseCombination = "ORACLE";
    }
}
