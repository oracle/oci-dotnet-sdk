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


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Update Migration resource parameters.
    /// 
    /// </summary>
    public class UpdateMigrationDetails 
    {
        
        /// <value>
        /// Migration type.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MigrationTypes> Type { get; set; }
        
        /// <value>
        /// Migration Display Name
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The OCID of the registered ODMS Agent.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "agentId")]
        public string AgentId { get; set; }
        
        /// <value>
        /// The OCID of the Source Database Connection.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sourceDatabaseConnectionId")]
        public string SourceDatabaseConnectionId { get; set; }
        
        /// <value>
        /// The OCID of the Source Container Database Connection. Only used for Online migrations.
        /// Only Connections of type Non-Autonomous can be used as source container databases.
        /// An empty value would remove the stored Connection ID.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sourceContainerDatabaseConnectionId")]
        public string SourceContainerDatabaseConnectionId { get; set; }
        
        /// <value>
        /// The OCID of the Target Database Connection.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "targetDatabaseConnectionId")]
        public string TargetDatabaseConnectionId { get; set; }
        
        [JsonProperty(PropertyName = "dataTransferMediumDetailsV2")]
        public DataTransferMediumDetailsV2 DataTransferMediumDetailsV2 { get; set; }
        
        [JsonProperty(PropertyName = "dataTransferMediumDetails")]
        public UpdateDataTransferMediumDetails DataTransferMediumDetails { get; set; }
        
        [JsonProperty(PropertyName = "dumpTransferDetails")]
        public UpdateDumpTransferDetails DumpTransferDetails { get; set; }
        
        [JsonProperty(PropertyName = "datapumpSettings")]
        public UpdateDataPumpSettings DatapumpSettings { get; set; }
        
        [JsonProperty(PropertyName = "advisorSettings")]
        public UpdateAdvisorSettings AdvisorSettings { get; set; }
        
        /// <value>
        /// Database objects to exclude from migration, cannot be specified alongside 'includeObjects'.
        /// If specified, the list will be replaced entirely. Empty list will remove stored excludeObjects details.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "excludeObjects")]
        public System.Collections.Generic.List<DatabaseObject> ExcludeObjects { get; set; }
        
        /// <value>
        /// Database objects to include from migration, cannot be specified alongside 'excludeObjects'.
        /// If specified, the list will be replaced entirely. Empty list will remove stored includeObjects details.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "includeObjects")]
        public System.Collections.Generic.List<DatabaseObject> IncludeObjects { get; set; }
        
        [JsonProperty(PropertyName = "goldenGateServiceDetails")]
        public UpdateGoldenGateServiceDetails GoldenGateServiceDetails { get; set; }
        
        [JsonProperty(PropertyName = "goldenGateDetails")]
        public UpdateGoldenGateDetails GoldenGateDetails { get; set; }
        
        [JsonProperty(PropertyName = "vaultDetails")]
        public UpdateVaultDetails VaultDetails { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
