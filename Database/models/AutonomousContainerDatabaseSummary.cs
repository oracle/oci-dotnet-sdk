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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// An Autonomous Container Database is a container database service that enables the customer to host one or more databases within the container database. A basic container database runs on a single Autonomous Exadata Infrastructure from an availability domain without the Extreme Availability features enabled.
    /// 
    /// </summary>
    public class AutonomousContainerDatabaseSummary 
    {
        
        /// <value>
        /// The OCID of the Autonomous Container Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The user-provided name for the Autonomous Container Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// **Deprecated.** The `DB_UNIQUE_NAME` value is set by Oracle Cloud Infrastructure.  Do not specify a value for this parameter. Specifying a value for this field will cause Terraform operations to fail.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dbUniqueName")]
        public string DbUniqueName { get; set; }
        
        /// <value>
        /// The Database name for the Autonomous Container Database. The name must be unique within the Cloud Autonomous VM Cluster, starting with an alphabetic character, followed by 1 to 7 alphanumeric characters.
        /// </value>
        [JsonProperty(PropertyName = "dbName")]
        public string DbName { get; set; }
                ///
        /// <value>
        /// The service level agreement type of the container database. The default is STANDARD.
        /// </value>
        ///
        public enum ServiceLevelAgreementTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "STANDARD")]
            Standard,
            [EnumMember(Value = "MISSION_CRITICAL")]
            MissionCritical,
            [EnumMember(Value = "AUTONOMOUS_DATAGUARD")]
            AutonomousDataguard
        };

        /// <value>
        /// The service level agreement type of the container database. The default is STANDARD.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ServiceLevelAgreementType is required.")]
        [JsonProperty(PropertyName = "serviceLevelAgreementType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ServiceLevelAgreementTypeEnum> ServiceLevelAgreementType { get; set; }
        
        /// <value>
        /// **No longer used.** For Autonomous Database on dedicated Exadata infrastructure, the container database is created within a specified `cloudAutonomousVmCluster`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "autonomousExadataInfrastructureId")]
        public string AutonomousExadataInfrastructureId { get; set; }
        
        /// <value>
        /// The OCID of the Autonomous VM Cluster.
        /// </value>
        [JsonProperty(PropertyName = "autonomousVmClusterId")]
        public string AutonomousVmClusterId { get; set; }
                ///
        /// <value>
        /// The infrastructure type this resource belongs to.
        /// </value>
        ///
        public enum InfrastructureTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CLOUD")]
            Cloud,
            [EnumMember(Value = "CLOUD_AT_CUSTOMER")]
            CloudAtCustomer
        };

        /// <value>
        /// The infrastructure type this resource belongs to.
        /// </value>
        [JsonProperty(PropertyName = "infrastructureType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<InfrastructureTypeEnum> InfrastructureType { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the cloud Autonomous Exadata VM Cluster.
        /// </value>
        [JsonProperty(PropertyName = "cloudAutonomousVmClusterId")]
        public string CloudAutonomousVmClusterId { get; set; }
        
        /// <value>
        /// The OCID of the key container that is used as the master encryption key in database transparent data encryption (TDE) operations.
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyId")]
        public string KmsKeyId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Oracle Cloud Infrastructure [vault](https://docs.cloud.oracle.com/Content/KeyManagement/Concepts/keyoverview.htm#concepts). This parameter and `secretId` are required for Customer Managed Keys.
        /// </value>
        [JsonProperty(PropertyName = "vaultId")]
        public string VaultId { get; set; }
        
        /// <value>
        /// The OCID of the key container version that is used in database transparent data encryption (TDE) operations KMS Key can have multiple key versions. If none is specified, the current key version (latest) of the Key Id is used for the operation. Autonomous Database Serverless does not use key versions, hence is not applicable for Autonomous Database Serverless instances.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyVersionId")]
        public string KmsKeyVersionId { get; set; }
        
        /// <value>
        /// Key History Entry.
        /// </value>
        [JsonProperty(PropertyName = "keyHistoryEntry")]
        public System.Collections.Generic.List<AutonomousDatabaseKeyHistoryEntry> KeyHistoryEntry { get; set; }
                ///
        /// <value>
        /// The current state of the Autonomous Container Database.
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
            [EnumMember(Value = "BACKUP_IN_PROGRESS")]
            BackupInProgress,
            [EnumMember(Value = "RESTORING")]
            Restoring,
            [EnumMember(Value = "RESTORE_FAILED")]
            RestoreFailed,
            [EnumMember(Value = "RESTARTING")]
            Restarting,
            [EnumMember(Value = "MAINTENANCE_IN_PROGRESS")]
            MaintenanceInProgress,
            [EnumMember(Value = "ROLE_CHANGE_IN_PROGRESS")]
            RoleChangeInProgress,
            [EnumMember(Value = "ENABLING_AUTONOMOUS_DATA_GUARD")]
            EnablingAutonomousDataGuard,
            [EnumMember(Value = "UNAVAILABLE")]
            Unavailable
        };

        /// <value>
        /// The current state of the Autonomous Container Database.
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
        /// The date and time the Autonomous Container Database was created.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the Autonomous Container Database will be reverted to Standby from Snapshot Standby.
        /// </value>
        [JsonProperty(PropertyName = "timeSnapshotStandbyRevert")]
        public System.Nullable<System.DateTime> TimeSnapshotStandbyRevert { get; set; }
                ///
        /// <value>
        /// Database patch model preference.
        /// </value>
        ///
        public enum PatchModelEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "RELEASE_UPDATES")]
            ReleaseUpdates,
            [EnumMember(Value = "RELEASE_UPDATE_REVISIONS")]
            ReleaseUpdateRevisions
        };

        /// <value>
        /// Database patch model preference.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PatchModel is required.")]
        [JsonProperty(PropertyName = "patchModel")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PatchModelEnum> PatchModel { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the last patch applied on the system.
        /// </value>
        [JsonProperty(PropertyName = "patchId")]
        public string PatchId { get; set; }
        
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
        
        [JsonProperty(PropertyName = "maintenanceWindow")]
        public MaintenanceWindow MaintenanceWindow { get; set; }
        
        /// <value>
        /// The scheduling detail for the quarterly maintenance window of the standby Autonomous Container Database.
        /// This value represents the number of days before scheduled maintenance of the primary database.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "standbyMaintenanceBufferInDays")]
        public System.Nullable<int> StandbyMaintenanceBufferInDays { get; set; }
                ///
        /// <value>
        /// The next maintenance version preference.
        /// 
        /// </value>
        ///
        public enum VersionPreferenceEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NEXT_RELEASE_UPDATE")]
            NextReleaseUpdate,
            [EnumMember(Value = "LATEST_RELEASE_UPDATE")]
            LatestReleaseUpdate
        };

        /// <value>
        /// The next maintenance version preference.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "versionPreference")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<VersionPreferenceEnum> VersionPreference { get; set; }
        
        /// <value>
        /// Indicates if an automatic DST Time Zone file update is enabled for the Autonomous Container Database. If enabled along with Release Update, patching will be done in a Non-Rolling manner.
        /// </value>
        [JsonProperty(PropertyName = "isDstFileUpdateEnabled")]
        public System.Nullable<bool> IsDstFileUpdateEnabled { get; set; }
        
        /// <value>
        /// DST Time-Zone File version of the Autonomous Container Database.
        /// </value>
        [JsonProperty(PropertyName = "dstFileVersion")]
        public string DstFileVersion { get; set; }
        
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
                ///
        /// <value>
        /// The Data Guard role of the Autonomous Container Database or Autonomous Database, if Autonomous Data Guard is enabled.
        /// 
        /// </value>
        ///
        public enum RoleEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PRIMARY")]
            Primary,
            [EnumMember(Value = "STANDBY")]
            Standby,
            [EnumMember(Value = "DISABLED_STANDBY")]
            DisabledStandby,
            [EnumMember(Value = "BACKUP_COPY")]
            BackupCopy,
            [EnumMember(Value = "SNAPSHOT_STANDBY")]
            SnapshotStandby
        };

        /// <value>
        /// The Data Guard role of the Autonomous Container Database or Autonomous Database, if Autonomous Data Guard is enabled.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "role")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RoleEnum> Role { get; set; }
        
        /// <value>
        /// The availability domain of the Autonomous Container Database.
        /// </value>
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// Oracle Database version of the Autonomous Container Database.
        /// </value>
        [JsonProperty(PropertyName = "dbVersion")]
        public string DbVersion { get; set; }
        
        [JsonProperty(PropertyName = "backupConfig")]
        public AutonomousContainerDatabaseBackupConfig BackupConfig { get; set; }
        
        /// <value>
        /// This list describes the backup destination properties associated with the Autonomous Container Database (ACD) 's preferred backup destination. The object at a given index is associated with the destination present at the same index in the backup destination details list of the ACD Backup Configuration.
        /// </value>
        [JsonProperty(PropertyName = "backupDestinationPropertiesList")]
        public System.Collections.Generic.List<BackupDestinationProperties> BackupDestinationPropertiesList { get; set; }
        
        /// <value>
        /// A backup config object holds information about preferred backup destinations only. This object holds information about the associated backup destinations, such as secondary backup destinations created for local backups or remote replicated backups.
        /// </value>
        [JsonProperty(PropertyName = "associatedBackupConfigurationDetails")]
        public System.Collections.Generic.List<BackupDestinationConfigurationSummary> AssociatedBackupConfigurationDetails { get; set; }
        
        [JsonProperty(PropertyName = "recoveryApplianceDetails")]
        public RecoveryApplianceDetails RecoveryApplianceDetails { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the key store of Oracle Vault.
        /// </value>
        [JsonProperty(PropertyName = "keyStoreId")]
        public string KeyStoreId { get; set; }
        
        /// <value>
        /// The wallet name for Oracle Key Vault.
        /// </value>
        [JsonProperty(PropertyName = "keyStoreWalletName")]
        public string KeyStoreWalletName { get; set; }
        
        /// <value>
        /// The amount of memory (in GBs) enabled per ECPU or OCPU in the Autonomous VM Cluster.
        /// </value>
        [JsonProperty(PropertyName = "memoryPerOracleComputeUnitInGBs")]
        public System.Nullable<int> MemoryPerOracleComputeUnitInGBs { get; set; }
        
        /// <value>
        /// Sum of CPUs available on the Autonomous VM Cluster + Sum of reclaimable CPUs available in the Autonomous Container Database.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "availableCpus")]
        public System.Nullable<float> AvailableCpus { get; set; }
        
        /// <value>
        /// The number of CPUs allocated to the Autonomous VM cluster.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "totalCpus")]
        public System.Nullable<int> TotalCpus { get; set; }
        
        /// <value>
        /// CPUs that continue to be included in the count of CPUs available to the Autonomous Container Database even after one of its Autonomous Database is terminated or scaled down. You can release them to the available CPUs at its parent Autonomous VM Cluster level by restarting the Autonomous Container Database.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "reclaimableCpus")]
        public System.Nullable<float> ReclaimableCpus { get; set; }
        
        /// <value>
        /// An array of CPU values that can be used to successfully provision a single Autonomous Database.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "provisionableCpus")]
        public System.Collections.Generic.List<float> ProvisionableCpus { get; set; }
        
        /// <value>
        /// List of One-Off patches that has been successfully applied to Autonomous Container Database
        /// </value>
        [JsonProperty(PropertyName = "listOneOffPatches")]
        public System.Collections.Generic.List<string> ListOneOffPatches { get; set; }
                ///
        /// <value>
        /// The compute model of the Autonomous Container Database. For Autonomous Database on Dedicated Exadata Infrastructure, the CPU type (ECPUs or OCPUs) is determined by the parent Autonomous Exadata VM Cluster's compute model. ECPU compute model is the recommended model and OCPU compute model is legacy. See [Compute Models in Autonomous Database on Dedicated Exadata Infrastructure](https://docs.oracle.com/en/cloud/paas/autonomous-database/dedicated/adbak) for more details.
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
        /// The compute model of the Autonomous Container Database. For Autonomous Database on Dedicated Exadata Infrastructure, the CPU type (ECPUs or OCPUs) is determined by the parent Autonomous Exadata VM Cluster's compute model. ECPU compute model is the recommended model and OCPU compute model is legacy. See [Compute Models in Autonomous Database on Dedicated Exadata Infrastructure](https://docs.oracle.com/en/cloud/paas/autonomous-database/dedicated/adbak) for more details.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "computeModel")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ComputeModelEnum> ComputeModel { get; set; }
        
        /// <value>
        /// The number of CPUs provisioned in an Autonomous Container Database.
        /// </value>
        [JsonProperty(PropertyName = "provisionedCpus")]
        public System.Nullable<float> ProvisionedCpus { get; set; }
        
        /// <value>
        /// The number of CPUs reserved in an Autonomous Container Database.
        /// </value>
        [JsonProperty(PropertyName = "reservedCpus")]
        public System.Nullable<float> ReservedCpus { get; set; }
        
        /// <value>
        /// The largest Autonomous Database (CPU) that can be created in a new Autonomous Container Database.
        /// </value>
        [JsonProperty(PropertyName = "largestProvisionableAutonomousDatabaseInCpus")]
        public System.Nullable<float> LargestProvisionableAutonomousDatabaseInCpus { get; set; }
        
        /// <value>
        /// The timestamp of last successful backup. Here NULL value represents either there are no successful backups or backups are not configured for this Autonomous Container Database.
        /// </value>
        [JsonProperty(PropertyName = "timeOfLastBackup")]
        public System.Nullable<System.DateTime> TimeOfLastBackup { get; set; }
        
        /// <value>
        /// The CPU value beyond which an Autonomous Database will be opened across multiple nodes. The default value of this attribute is 16 for OCPUs and 64 for ECPUs.
        /// </value>
        [JsonProperty(PropertyName = "dbSplitThreshold")]
        public System.Nullable<int> DbSplitThreshold { get; set; }
        
        /// <value>
        /// The percentage of CPUs reserved across nodes to support node failover. Allowed values are 0%, 25%, and 50%, with 50% being the default option.
        /// </value>
        [JsonProperty(PropertyName = "vmFailoverReservation")]
        public System.Nullable<int> VmFailoverReservation { get; set; }
                ///
        /// <value>
        /// Determines whether an Autonomous Database must be opened across the maximum number of nodes or the least number of nodes. By default, Minimum nodes is selected.
        /// </value>
        ///
        public enum DistributionAffinityEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "MINIMUM_DISTRIBUTION")]
            MinimumDistribution,
            [EnumMember(Value = "MAXIMUM_DISTRIBUTION")]
            MaximumDistribution
        };

        /// <value>
        /// Determines whether an Autonomous Database must be opened across the maximum number of nodes or the least number of nodes. By default, Minimum nodes is selected.
        /// </value>
        [JsonProperty(PropertyName = "distributionAffinity")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DistributionAffinityEnum> DistributionAffinity { get; set; }
                ///
        /// <value>
        /// Enabling SHARED server architecture enables a database server to allow many client processes to share very few server processes, thereby increasing the number of supported users.
        /// </value>
        ///
        public enum NetServicesArchitectureEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "DEDICATED")]
            Dedicated,
            [EnumMember(Value = "SHARED")]
            Shared
        };

        /// <value>
        /// Enabling SHARED server architecture enables a database server to allow many client processes to share very few server processes, thereby increasing the number of supported users.
        /// </value>
        [JsonProperty(PropertyName = "netServicesArchitecture")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<NetServicesArchitectureEnum> NetServicesArchitecture { get; set; }
        
        /// <value>
        /// Whether it is multiple standby Autonomous Dataguard
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isMultipleStandby")]
        public System.Nullable<bool> IsMultipleStandby { get; set; }
        
        /// <value>
        /// **Deprecated.** Indicates whether the Autonomous Database has local (in-region) Data Guard enabled. Not applicable to cross-region Autonomous Data Guard associations, or to Autonomous Databases using dedicated Exadata infrastructure or Exadata Cloud@Customer infrastructure.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isDataGuardEnabled")]
        public System.Nullable<bool> IsDataGuardEnabled { get; set; }
        
        [JsonProperty(PropertyName = "dataguard")]
        public AutonomousContainerDatabaseDataguard Dataguard { get; set; }
        
        /// <value>
        /// Array of Dg associations.
        /// </value>
        [JsonProperty(PropertyName = "dataguardGroupMembers")]
        public System.Collections.Generic.List<AutonomousContainerDatabaseDataguard> DataguardGroupMembers { get; set; }
        
    }
}
