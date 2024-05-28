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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The list of aggregated metrics for Managed Databases in the fleet.
    /// </summary>
    public class DatabaseUsageMetrics 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Managed Database.
        /// </value>
        [JsonProperty(PropertyName = "dbId")]
        public string DbId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment where the Managed Database resides.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The type of Oracle Database installation.
        /// </value>
        [JsonProperty(PropertyName = "databaseType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DatabaseType> DatabaseType { get; set; }
        
        /// <value>
        /// The subtype of the Oracle Database. Indicates whether the database is a Container Database,
        /// Pluggable Database, Non-container Database, Autonomous Database, or Autonomous Container Database.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "databaseSubType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DatabaseSubType> DatabaseSubType { get; set; }
        
        /// <value>
        /// The infrastructure used to deploy the Oracle Database.
        /// </value>
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
        [JsonProperty(PropertyName = "databaseName")]
        public string DatabaseName { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the parent Container Database, in the case of a Pluggable Database.
        /// </value>
        [JsonProperty(PropertyName = "databaseContainerId")]
        public string DatabaseContainerId { get; set; }
        
        /// <value>
        /// The Database id of the Managed Database. Every database had its own id and that value is captured here.
        /// </value>
        [JsonProperty(PropertyName = "databaseId")]
        public string DatabaseId { get; set; }
        
        /// <value>
        /// The Primary Database id of the Managed Database.
        /// </value>
        [JsonProperty(PropertyName = "primaryDbId")]
        public string PrimaryDbId { get; set; }
        
        /// <value>
        /// The Primary Database unique name of the Managed Database.
        /// </value>
        [JsonProperty(PropertyName = "primaryDbUniqueName")]
        public string PrimaryDbUniqueName { get; set; }
        
        /// <value>
        /// The Database unique name of the Managed Database.
        /// </value>
        [JsonProperty(PropertyName = "dbUniqueName")]
        public string DbUniqueName { get; set; }
        
        /// <value>
        /// The Database role of the Managed Database.
        /// </value>
        [JsonProperty(PropertyName = "dbRole")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DbRole> DbRole { get; set; }
        
        /// <value>
        /// A list of the database health metrics like CPU, Storage, and Memory.
        /// </value>
        [JsonProperty(PropertyName = "metrics")]
        public System.Collections.Generic.List<FleetMetricDefinition> Metrics { get; set; }
        
    }
}
