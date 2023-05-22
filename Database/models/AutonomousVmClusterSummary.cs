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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Details of the Autonomous VM cluster.
    /// 
    /// </summary>
    public class AutonomousVmClusterSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Autonomous VM cluster.
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
        
        /// <value>
        /// The user-friendly name for the Autonomous VM cluster. The name does not need to be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The date and time that the Autonomous VM cluster was created.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
                ///
        /// <value>
        /// The current state of the Autonomous VM cluster.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PROVISIONING")]
            Provisioning,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "MAINTENANCE_IN_PROGRESS")]
            MaintenanceInProgress
        };

        /// <value>
        /// The current state of the Autonomous VM cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Additional information about the current lifecycle state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The time zone to use for the Autonomous VM cluster. For details, see [DB System Time Zones](https://docs.cloud.oracle.com/Content/Database/References/timezones.htm).
        /// </value>
        [JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Exadata infrastructure.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExadataInfrastructureId is required.")]
        [JsonProperty(PropertyName = "exadataInfrastructureId")]
        public string ExadataInfrastructureId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VM cluster network.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VmClusterNetworkId is required.")]
        [JsonProperty(PropertyName = "vmClusterNetworkId")]
        public string VmClusterNetworkId { get; set; }
        
        /// <value>
        /// If true, database backup on local Exadata storage is configured for the Autonomous VM cluster. If false, database backup on local Exadata storage is not available in the Autonomous VM cluster.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isLocalBackupEnabled")]
        public System.Nullable<bool> IsLocalBackupEnabled { get; set; }
        
        /// <value>
        /// The number of enabled CPU cores.
        /// </value>
        [JsonProperty(PropertyName = "cpusEnabled")]
        public System.Nullable<int> CpusEnabled { get; set; }
                ///
        /// <value>
        /// The compute model of the Autonomous VM Cluster. See [Compute Models in Autonomous Database on Dedicated Exadata Infrastructure](https://docs.oracle.com/en/cloud/paas/autonomous-database/dedicated/adbak) for more details.
        /// 
        /// </value>
        ///
        public enum ComputeModelEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ECPU")]
            Ecpu,
            [EnumMember(Value = "OCPU")]
            Ocpu
        };

        /// <value>
        /// The compute model of the Autonomous VM Cluster. See [Compute Models in Autonomous Database on Dedicated Exadata Infrastructure](https://docs.oracle.com/en/cloud/paas/autonomous-database/dedicated/adbak) for more details.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "computeModel")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ComputeModelEnum> ComputeModel { get; set; }
        
        /// <value>
        /// The number of enabled OCPU cores.
        /// </value>
        [JsonProperty(PropertyName = "ocpusEnabled")]
        public System.Nullable<float> OcpusEnabled { get; set; }
        
        /// <value>
        /// The numnber of CPU cores available.
        /// </value>
        [JsonProperty(PropertyName = "availableCpus")]
        public System.Nullable<int> AvailableCpus { get; set; }
        
        /// <value>
        /// The total number of Autonomous Container Databases that can be created.
        /// </value>
        [JsonProperty(PropertyName = "totalContainerDatabases")]
        public System.Nullable<int> TotalContainerDatabases { get; set; }
        
        /// <value>
        /// The amount of memory (in GBs) to be enabled per OCPU or ECPU. See [Compute Models in Autonomous Database on Dedicated Exadata Infrastructure](https://docs.oracle.com/en/cloud/paas/autonomous-database/dedicated/adbak) for more details.
        /// </value>
        [JsonProperty(PropertyName = "memoryPerOracleComputeUnitInGBs")]
        public System.Nullable<int> MemoryPerOracleComputeUnitInGBs { get; set; }
        
        /// <value>
        /// The number of CPU cores enabled per VM cluster node.
        /// </value>
        [JsonProperty(PropertyName = "cpuCoreCountPerNode")]
        public System.Nullable<int> CpuCoreCountPerNode { get; set; }
        
        /// <value>
        /// The data disk group size allocated for Autonomous Databases, in TBs.
        /// </value>
        [JsonProperty(PropertyName = "autonomousDataStorageSizeInTBs")]
        public System.Double AutonomousDataStorageSizeInTBs { get; set; }
        
        [JsonProperty(PropertyName = "maintenanceWindow")]
        public MaintenanceWindow MaintenanceWindow { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the last maintenance run.
        /// </value>
        [JsonProperty(PropertyName = "lastMaintenanceRunId")]
        public string LastMaintenanceRunId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the next maintenance run.
        /// </value>
        [JsonProperty(PropertyName = "nextMaintenanceRunId")]
        public string NextMaintenanceRunId { get; set; }
        
        /// <value>
        /// The memory allocated in GBs.
        /// </value>
        [JsonProperty(PropertyName = "memorySizeInGBs")]
        public System.Nullable<int> MemorySizeInGBs { get; set; }
        
        /// <value>
        /// The local node storage allocated in GBs.
        /// </value>
        [JsonProperty(PropertyName = "dbNodeStorageSizeInGBs")]
        public System.Nullable<int> DbNodeStorageSizeInGBs { get; set; }
        
        /// <value>
        /// The total data storage allocated in TBs
        /// </value>
        [JsonProperty(PropertyName = "dataStorageSizeInTBs")]
        public System.Double DataStorageSizeInTBs { get; set; }
        
        /// <value>
        /// The total data storage allocated in GBs.
        /// </value>
        [JsonProperty(PropertyName = "dataStorageSizeInGBs")]
        public System.Double DataStorageSizeInGBs { get; set; }
        
        /// <value>
        /// **Deprecated.** Use `availableAutonomousDataStorageSizeInTBs` for Autonomous Databases' data storage availability in TBs.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "availableDataStorageSizeInTBs")]
        public System.Double AvailableDataStorageSizeInTBs { get; set; }
        
        /// <value>
        /// The number of nodes in the Autonomous VM Cluster.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nodeCount")]
        public System.Nullable<int> NodeCount { get; set; }
                ///
        /// <value>
        /// The Oracle license model that applies to the Autonomous VM cluster. The default is LICENSE_INCLUDED.
        /// 
        /// </value>
        ///
        public enum LicenseModelEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "LICENSE_INCLUDED")]
            LicenseIncluded,
            [EnumMember(Value = "BRING_YOUR_OWN_LICENSE")]
            BringYourOwnLicense
        };

        /// <value>
        /// The Oracle license model that applies to the Autonomous VM cluster. The default is LICENSE_INCLUDED.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "licenseModel")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
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
        /// The list of [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Db servers.
        /// </value>
        [JsonProperty(PropertyName = "dbServers")]
        public System.Collections.Generic.List<string> DbServers { get; set; }
        
        /// <value>
        /// For Autonomous Databases on Dedicated Exadata Infrastructure:
        /// - These are the CPUs that continue to be included in the count of CPUs available to the Autonomous Container Database even after one of its Autonomous Database is terminated or scaled down. You can release them to the available CPUs at its parent Autonomous VM Cluster level by restarting the Autonomous Container Database.
        /// - The CPU type (OCPUs or ECPUs) is determined by the parent Autonomous Exadata VM Cluster's compute model. See [Compute Models in Autonomous Database on Dedicated Exadata Infrastructure](https://docs.oracle.com/en/cloud/paas/autonomous-database/dedicated/adbak) for more details.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "reclaimableCpus")]
        public System.Nullable<int> ReclaimableCpus { get; set; }
        
        /// <value>
        /// The number of Autonomous Container Databases that can be created with the currently available local storage.
        /// </value>
        [JsonProperty(PropertyName = "availableContainerDatabases")]
        public System.Nullable<int> AvailableContainerDatabases { get; set; }
        
        /// <value>
        /// The data disk group size available for Autonomous Databases, in TBs.
        /// </value>
        [JsonProperty(PropertyName = "availableAutonomousDataStorageSizeInTBs")]
        public System.Double AvailableAutonomousDataStorageSizeInTBs { get; set; }
        
        /// <value>
        /// The SCAN Listener TLS port number. Default value is 2484.
        /// </value>
        [JsonProperty(PropertyName = "scanListenerPortTls")]
        public System.Nullable<int> ScanListenerPortTls { get; set; }
        
        /// <value>
        /// The SCAN Listener Non TLS port number. Default value is 1521.
        /// </value>
        [JsonProperty(PropertyName = "scanListenerPortNonTls")]
        public System.Nullable<int> ScanListenerPortNonTls { get; set; }
        
        /// <value>
        /// Enable mutual TLS(mTLS) authentication for database while provisioning a VMCluster. Default is TLS.
        /// </value>
        [JsonProperty(PropertyName = "isMtlsEnabled")]
        public System.Nullable<bool> IsMtlsEnabled { get; set; }
        
        /// <value>
        /// The date and time of the Database SSL certificate expiration.
        /// </value>
        [JsonProperty(PropertyName = "timeDatabaseSslCertificateExpires")]
        public System.Nullable<System.DateTime> TimeDatabaseSslCertificateExpires { get; set; }
        
        /// <value>
        /// The date and time of the ORDS certificate expiration.
        /// </value>
        [JsonProperty(PropertyName = "timeOrdsCertificateExpires")]
        public System.Nullable<System.DateTime> TimeOrdsCertificateExpires { get; set; }
        
    }
}
