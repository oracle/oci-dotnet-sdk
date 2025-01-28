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
    /// The details of the HA metrics for a single database.
    /// </summary>
    public class DatabaseHaMetrics 
    {
        
        /// <value>
        /// Indicates whether Data Guard is enabled for the database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsDataguardEnabled is required.")]
        [JsonProperty(PropertyName = "isDataguardEnabled")]
        public System.Nullable<bool> IsDataguardEnabled { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LastBackupSummary is required.")]
        [JsonProperty(PropertyName = "lastBackupSummary")]
        public DatabaseBackupSummary LastBackupSummary { get; set; }
        
        /// <value>
        /// A list of database health metrics such as BackupDuration and BackupSize.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Metrics is required.")]
        [JsonProperty(PropertyName = "metrics")]
        public System.Collections.Generic.List<HaMetricDefinition> Metrics { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Managed Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbId is required.")]
        [JsonProperty(PropertyName = "dbId")]
        public string DbId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment where the Managed Database resides.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The type of Oracle Database installation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseType is required.")]
        [JsonProperty(PropertyName = "databaseType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DatabaseType> DatabaseType { get; set; }
        
        /// <value>
        /// The subtype of the Oracle Database. Indicates whether the database is a Container Database,
        /// Pluggable Database, Non-container Database, Autonomous Database, or Autonomous Container Database.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseSubType is required.")]
        [JsonProperty(PropertyName = "databaseSubType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DatabaseSubType> DatabaseSubType { get; set; }
        
        /// <value>
        /// The infrastructure used to deploy the Oracle Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DeploymentType is required.")]
        [JsonProperty(PropertyName = "deploymentType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DeploymentType> DeploymentType { get; set; }
        
        /// <value>
        /// The Oracle Database version.
        /// </value>
        [JsonProperty(PropertyName = "databaseVersion")]
        public string DatabaseVersion { get; set; }
        
        /// <value>
        /// The workload type of the Autonomous Database.
        /// </value>
        [JsonProperty(PropertyName = "workloadType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<WorkloadType> WorkloadType { get; set; }
        
        /// <value>
        /// The display name of the Managed Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseName is required.")]
        [JsonProperty(PropertyName = "databaseName")]
        public string DatabaseName { get; set; }
        
        /// <value>
        /// The database ID of the Managed Database. Every database had its own ID and that value is captured here.
        /// </value>
        [JsonProperty(PropertyName = "databaseId")]
        public string DatabaseId { get; set; }
        
        /// <value>
        /// The database unique name of the Managed Database.
        /// </value>
        [JsonProperty(PropertyName = "dbUniqueName")]
        public string DbUniqueName { get; set; }
        
        /// <value>
        /// The database role of the Managed Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbRole is required.")]
        [JsonProperty(PropertyName = "dbRole")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DbRole> DbRole { get; set; }
        
    }
}
