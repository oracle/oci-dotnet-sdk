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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// **Deprecated.** See {@link AutonomousDatabase} for reference information about Autonomous Databases with the warehouse workload type.
    /// 
    /// </summary>
    public class AutonomousDataWarehouse 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Autonomous Data Warehouse.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
                ///
        /// <value>
        /// The current state of the database.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "PROVISIONING")]
            Provisioning,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "STOPPING")]
            Stopping,
            [EnumMember(Value = "STOPPED")]
            Stopped,
            [EnumMember(Value = "STARTING")]
            Starting,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "UNAVAILABLE")]
            Unavailable,
            [EnumMember(Value = "RESTORE_IN_PROGRESS")]
            RestoreInProgress,
            [EnumMember(Value = "BACKUP_IN_PROGRESS")]
            BackupInProgress,
            [EnumMember(Value = "SCALE_IN_PROGRESS")]
            ScaleInProgress,
            [EnumMember(Value = "AVAILABLE_NEEDS_ATTENTION")]
            AvailableNeedsAttention,
            [EnumMember(Value = "UPDATING")]
            Updating
        };

        /// <value>
        /// The current state of the database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Information about the current lifecycle state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The database name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbName is required.")]
        [JsonProperty(PropertyName = "dbName")]
        public string DbName { get; set; }
        
        /// <value>
        /// The number of CPU cores to be made available to the database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CpuCoreCount is required.")]
        [JsonProperty(PropertyName = "cpuCoreCount")]
        public System.Nullable<int> CpuCoreCount { get; set; }
        
        /// <value>
        /// The quantity of data in the database, in terabytes.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DataStorageSizeInTBs is required.")]
        [JsonProperty(PropertyName = "dataStorageSizeInTBs")]
        public System.Nullable<int> DataStorageSizeInTBs { get; set; }
        
        /// <value>
        /// The date and time the database was created.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The user-friendly name for the Autonomous Data Warehouse. The name does not have to be unique.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The URL of the Service Console for the Data Warehouse.
        /// </value>
        [JsonProperty(PropertyName = "serviceConsoleUrl")]
        public string ServiceConsoleUrl { get; set; }
        
        /// <value>
        /// The connection string used to connect to the Data Warehouse. The username for the Service Console is ADMIN. Use the password you entered when creating the Autonomous Data Warehouse for the password value.
        /// </value>
        [JsonProperty(PropertyName = "connectionStrings")]
        public AutonomousDataWarehouseConnectionStrings ConnectionStrings { get; set; }
                ///
        /// <value>
        /// The Oracle license model that applies to the Oracle Autonomous Data Warehouse. The default is BRING_YOUR_OWN_LICENSE.
        /// 
        /// </value>
        ///
        public enum LicenseModelEnum {
            [EnumMember(Value = "LICENSE_INCLUDED")]
            LicenseIncluded,
            [EnumMember(Value = "BRING_YOUR_OWN_LICENSE")]
            BringYourOwnLicense
        };

        /// <value>
        /// The Oracle license model that applies to the Oracle Autonomous Data Warehouse. The default is BRING_YOUR_OWN_LICENSE.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "licenseModel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LicenseModelEnum> LicenseModel { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A valid Oracle Database version for Autonomous Data Warehouse.
        /// </value>
        [JsonProperty(PropertyName = "dbVersion")]
        public string DbVersion { get; set; }
        
    }
}
