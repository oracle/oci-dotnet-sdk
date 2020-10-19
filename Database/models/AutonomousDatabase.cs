/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
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
    /// An Oracle Autonomous Database.
    /// 
    /// </summary>
    public class AutonomousDatabase 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Autonomous Database.
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
        /// The current state of the Autonomous Database.
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
            [EnumMember(Value = "RESTORE_FAILED")]
            RestoreFailed,
            [EnumMember(Value = "BACKUP_IN_PROGRESS")]
            BackupInProgress,
            [EnumMember(Value = "SCALE_IN_PROGRESS")]
            ScaleInProgress,
            [EnumMember(Value = "AVAILABLE_NEEDS_ATTENTION")]
            AvailableNeedsAttention,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "MAINTENANCE_IN_PROGRESS")]
            MaintenanceInProgress,
            [EnumMember(Value = "RESTARTING")]
            Restarting,
            [EnumMember(Value = "RECREATING")]
            Recreating,
            [EnumMember(Value = "ROLE_CHANGE_IN_PROGRESS")]
            RoleChangeInProgress,
            [EnumMember(Value = "UPGRADING")]
            Upgrading
        };

        /// <value>
        /// The current state of the Autonomous Database.
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
        /// Indicates if this is an Always Free resource. The default value is false. Note that Always Free Autonomous Databases have 1 CPU and 20GB of memory. For Always Free databases, memory and CPU cannot be scaled.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isFreeTier")]
        public System.Nullable<bool> IsFreeTier { get; set; }

        /// <value>
        /// System tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }

        /// <value>
        /// The date and time the Always Free database will be stopped because of inactivity. If this time is reached without any database activity, the database will automatically be put into the STOPPED state.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeReclamationOfFreeAutonomousDatabase")]
        public System.Nullable<System.DateTime> TimeReclamationOfFreeAutonomousDatabase { get; set; }

        /// <value>
        /// The date and time the Always Free database will be automatically deleted because of inactivity. If the database is in the STOPPED state and without activity until this time, it will be deleted.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeDeletionOfFreeAutonomousDatabase")]
        public System.Nullable<System.DateTime> TimeDeletionOfFreeAutonomousDatabase { get; set; }

        /// <value>
        /// The number of OCPU cores to be made available to the database.
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
        ///
        /// <value>
        /// The infrastructure type this resource belongs to.
        /// </value>
        ///
        public enum InfrastructureTypeEnum {
            [EnumMember(Value = "CLOUD")]
            Cloud,
            [EnumMember(Value = "CLOUD_AT_CUSTOMER")]
            CloudAtCustomer
        };

        /// <value>
        /// The infrastructure type this resource belongs to.
        /// </value>
        [JsonProperty(PropertyName = "infrastructureType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<InfrastructureTypeEnum> InfrastructureType { get; set; }

        /// <value>
        /// True if the database uses [dedicated Exadata infrastructure](https://docs.cloud.oracle.com/Content/Database/Concepts/adbddoverview.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isDedicated")]
        public System.Nullable<bool> IsDedicated { get; set; }

        /// <value>
        /// The Autonomous Container Database [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// </value>
        [JsonProperty(PropertyName = "autonomousContainerDatabaseId")]
        public string AutonomousContainerDatabaseId { get; set; }

        /// <value>
        /// The date and time the Autonomous Database was created.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }

        /// <value>
        /// The user-friendly name for the Autonomous Database. The name does not have to be unique.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <value>
        /// The URL of the Service Console for the Autonomous Database.
        /// </value>
        [JsonProperty(PropertyName = "serviceConsoleUrl")]
        public string ServiceConsoleUrl { get; set; }

        /// <value>
        /// The connection string used to connect to the Autonomous Database. The username for the Service Console is ADMIN. Use the password you entered when creating the Autonomous Database for the password value.
        /// </value>
        [JsonProperty(PropertyName = "connectionStrings")]
        public AutonomousDatabaseConnectionStrings ConnectionStrings { get; set; }

        [JsonProperty(PropertyName = "connectionUrls")]
        public AutonomousDatabaseConnectionUrls ConnectionUrls { get; set; }
        ///
        /// <value>
        /// The Oracle license model that applies to the Oracle Autonomous Database. Note that when provisioning an Autonomous Database on [dedicated Exadata infrastructure](https://docs.cloud.oracle.com/Content/Database/Concepts/adbddoverview.htm), this attribute must be null because the attribute is already set at the
        /// Autonomous Exadata Infrastructure level. When using [shared Exadata infrastructure](https://docs.cloud.oracle.com/Content/Database/Concepts/adboverview.htm#AEI), if a value is not specified, the system will supply the value of `BRING_YOUR_OWN_LICENSE`.
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
        /// The Oracle license model that applies to the Oracle Autonomous Database. Note that when provisioning an Autonomous Database on [dedicated Exadata infrastructure](https://docs.cloud.oracle.com/Content/Database/Concepts/adbddoverview.htm), this attribute must be null because the attribute is already set at the
        /// Autonomous Exadata Infrastructure level. When using [shared Exadata infrastructure](https://docs.cloud.oracle.com/Content/Database/Concepts/adboverview.htm#AEI), if a value is not specified, the system will supply the value of `BRING_YOUR_OWN_LICENSE`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "licenseModel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LicenseModelEnum> LicenseModel { get; set; }

        /// <value>
        /// The amount of storage that has been used, in terabytes.
        /// </value>
        [JsonProperty(PropertyName = "usedDataStorageSizeInTBs")]
        public System.Nullable<int> UsedDataStorageSizeInTBs { get; set; }

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
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the subnet the resource is associated with.
        /// <br/>
        /// **Subnet Restrictions:**
        /// - For bare metal DB systems and for single node virtual machine DB systems, do not use a subnet that overlaps with 192.168.16.16/28.
        /// - For Exadata and virtual machine 2-node RAC systems, do not use a subnet that overlaps with 192.168.128.0/20.
        /// - For Autonomous Database, setting this will disable public secure access to the database.
        /// <br/>
        /// These subnets are used by the Oracle Clusterware private interconnect on the database instance.
        /// Specifying an overlapping subnet will cause the private interconnect to malfunction.
        /// This restriction applies to both the client subnet and the backup subnet.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }

        /// <value>
        /// A list of the [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the network security groups (NSGs) that this resource belongs to. Setting this to an empty array after the list is created removes the resource from all NSGs. For more information about NSGs, see [Security Rules](https://docs.cloud.oracle.com/Content/Network/Concepts/securityrules.htm).
        /// **NsgIds restrictions:**
        /// - Autonomous Databases with private access require at least 1 Network Security Group (NSG). The nsgIds array cannot be empty.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }

        /// <value>
        /// The private endpoint for the resource.
        /// </value>
        [JsonProperty(PropertyName = "privateEndpoint")]
        public string PrivateEndpoint { get; set; }

        /// <value>
        /// The private endpoint label for the resource. Setting this to an empty string, after the private endpoint database gets created, will change the same private endpoint database to the public endpoint database.
        /// </value>
        [JsonProperty(PropertyName = "privateEndpointLabel")]
        public string PrivateEndpointLabel { get; set; }

        /// <value>
        /// The private endpoint Ip address for the resource.
        /// </value>
        [JsonProperty(PropertyName = "privateEndpointIp")]
        public string PrivateEndpointIp { get; set; }

        /// <value>
        /// A valid Oracle Database version for Autonomous Database.
        /// </value>
        [JsonProperty(PropertyName = "dbVersion")]
        public string DbVersion { get; set; }

        /// <value>
        /// Indicates if the Autonomous Database version is a preview version.
        /// </value>
        [JsonProperty(PropertyName = "isPreview")]
        public System.Nullable<bool> IsPreview { get; set; }
        ///
        /// <value>
        /// The Autonomous Database workload type. The following values are valid:
        /// <br/>
        /// - OLTP - indicates an Autonomous Transaction Processing database
        /// - DW - indicates an Autonomous Data Warehouse database
        /// - AJD - indicates an Autonomous JSON Database
        /// 
        /// </value>
        ///
        public enum DbWorkloadEnum {
            [EnumMember(Value = "OLTP")]
            Oltp,
            [EnumMember(Value = "DW")]
            Dw,
            [EnumMember(Value = "AJD")]
            Ajd
        };

        /// <value>
        /// The Autonomous Database workload type. The following values are valid:
        /// <br/>
        /// - OLTP - indicates an Autonomous Transaction Processing database
        /// - DW - indicates an Autonomous Data Warehouse database
        /// - AJD - indicates an Autonomous JSON Database
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dbWorkload")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DbWorkloadEnum> DbWorkload { get; set; }

        /// <value>
        /// The client IP access control list (ACL). This feature is available for databases on [shared Exadata infrastructure](https://docs.cloud.oracle.com/Content/Database/Concepts/adboverview.htm#AEI) only.
        /// Only clients connecting from an IP address included in the ACL may access the Autonomous Database instance. This is an array of CIDR (Classless Inter-Domain Routing) notations for a subnet or VCN OCID.
        /// <br/>
        /// To add the whitelist VCN specific subnet or IP, use a semicoln ';' as a deliminator to add the VCN specific subnets or IPs.
        /// For an update operation, if you want to delete all the IPs in the ACL, use an array with a single empty string entry.
        /// Example: [&quot;1.1.1.1&quot;,&quot;1.1.1.0/24&quot;,&quot;ocid1.vcn.oc1.sea.<unique_id>&quot;,&quot;ocid1.vcn.oc1.sea.<unique_id1>;1.1.1.1&quot;,&quot;ocid1.vcn.oc1.sea.<unique_id2>;1.1.0.0/16&quot;]
        /// </value>
        [JsonProperty(PropertyName = "whitelistedIps")]
        public System.Collections.Generic.List<string> WhitelistedIps { get; set; }

        /// <value>
        /// Indicates if auto scaling is enabled for the Autonomous Database CPU core count.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAutoScalingEnabled")]
        public System.Nullable<bool> IsAutoScalingEnabled { get; set; }
        ///
        /// <value>
        /// Status of the Data Safe registration for this Autonomous Database.
        /// </value>
        ///
        public enum DataSafeStatusEnum {
            [EnumMember(Value = "REGISTERING")]
            Registering,
            [EnumMember(Value = "REGISTERED")]
            Registered,
            [EnumMember(Value = "DEREGISTERING")]
            Deregistering,
            [EnumMember(Value = "NOT_REGISTERED")]
            NotRegistered,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// Status of the Data Safe registration for this Autonomous Database.
        /// </value>
        [JsonProperty(PropertyName = "dataSafeStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DataSafeStatusEnum> DataSafeStatus { get; set; }
        ///
        /// <value>
        /// Status of the Operations Insights for this Autonomous Database.
        /// </value>
        ///
        public enum OperationsInsightsStatusEnum {
            [EnumMember(Value = "ENABLING")]
            Enabling,
            [EnumMember(Value = "ENABLED")]
            Enabled,
            [EnumMember(Value = "DISABLING")]
            Disabling,
            [EnumMember(Value = "NOT_ENABLED")]
            NotEnabled,
            [EnumMember(Value = "FAILED_ENABLING")]
            FailedEnabling,
            [EnumMember(Value = "FAILED_DISABLING")]
            FailedDisabling
        };

        /// <value>
        /// Status of the Operations Insights for this Autonomous Database.
        /// </value>
        [JsonProperty(PropertyName = "operationsInsightsStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OperationsInsightsStatusEnum> OperationsInsightsStatus { get; set; }

        /// <value>
        /// The date and time when maintenance will begin.
        /// </value>
        [JsonProperty(PropertyName = "timeMaintenanceBegin")]
        public System.Nullable<System.DateTime> TimeMaintenanceBegin { get; set; }

        /// <value>
        /// The date and time when maintenance will end.
        /// </value>
        [JsonProperty(PropertyName = "timeMaintenanceEnd")]
        public System.Nullable<System.DateTime> TimeMaintenanceEnd { get; set; }

        /// <value>
        /// Indicates whether the Autonomous Database is a refreshable clone.
        /// </value>
        [JsonProperty(PropertyName = "isRefreshableClone")]
        public System.Nullable<bool> IsRefreshableClone { get; set; }

        /// <value>
        /// The date and time when last refresh happened.
        /// </value>
        [JsonProperty(PropertyName = "timeOfLastRefresh")]
        public System.Nullable<System.DateTime> TimeOfLastRefresh { get; set; }

        /// <value>
        /// The refresh point timestamp (UTC). The refresh point is the time to which the database was most recently refreshed. Data created after the refresh point is not included in the refresh.
        /// </value>
        [JsonProperty(PropertyName = "timeOfLastRefreshPoint")]
        public System.Nullable<System.DateTime> TimeOfLastRefreshPoint { get; set; }

        /// <value>
        /// The date and time of next refresh.
        /// </value>
        [JsonProperty(PropertyName = "timeOfNextRefresh")]
        public System.Nullable<System.DateTime> TimeOfNextRefresh { get; set; }
        ///
        /// <value>
        /// The `DATABASE OPEN` mode. You can open the database in `READ_ONLY` or `READ_WRITE` mode.
        /// </value>
        ///
        public enum OpenModeEnum {
            [EnumMember(Value = "READ_ONLY")]
            ReadOnly,
            [EnumMember(Value = "READ_WRITE")]
            ReadWrite
        };

        /// <value>
        /// The `DATABASE OPEN` mode. You can open the database in `READ_ONLY` or `READ_WRITE` mode.
        /// </value>
        [JsonProperty(PropertyName = "openMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OpenModeEnum> OpenMode { get; set; }
        ///
        /// <value>
        /// The refresh status of the clone. REFRESHING indicates that the clone is currently being refreshed with data from the source Autonomous Database.
        /// </value>
        ///
        public enum RefreshableStatusEnum {
            [EnumMember(Value = "REFRESHING")]
            Refreshing,
            [EnumMember(Value = "NOT_REFRESHING")]
            NotRefreshing
        };

        /// <value>
        /// The refresh status of the clone. REFRESHING indicates that the clone is currently being refreshed with data from the source Autonomous Database.
        /// </value>
        [JsonProperty(PropertyName = "refreshableStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RefreshableStatusEnum> RefreshableStatus { get; set; }
        ///
        /// <value>
        /// The refresh mode of the clone. AUTOMATIC indicates that the clone is automatically being refreshed with data from the source Autonomous Database.
        /// </value>
        ///
        public enum RefreshableModeEnum {
            [EnumMember(Value = "AUTOMATIC")]
            Automatic,
            [EnumMember(Value = "MANUAL")]
            Manual
        };

        /// <value>
        /// The refresh mode of the clone. AUTOMATIC indicates that the clone is automatically being refreshed with data from the source Autonomous Database.
        /// </value>
        [JsonProperty(PropertyName = "refreshableMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RefreshableModeEnum> RefreshableMode { get; set; }

        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the source Autonomous Database that was cloned to create the current Autonomous Database.
        /// </value>
        [JsonProperty(PropertyName = "sourceId")]
        public string SourceId { get; set; }
        ///
        /// <value>
        /// The Autonomous Database permission level. Restricted mode allows access only to admin users.
        /// </value>
        ///
        public enum PermissionLevelEnum {
            [EnumMember(Value = "RESTRICTED")]
            Restricted,
            [EnumMember(Value = "UNRESTRICTED")]
            Unrestricted
        };

        /// <value>
        /// The Autonomous Database permission level. Restricted mode allows access only to admin users.
        /// </value>
        [JsonProperty(PropertyName = "permissionLevel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PermissionLevelEnum> PermissionLevel { get; set; }

        /// <value>
        /// The timestamp of the last switchover operation for the Autonomous Database.
        /// </value>
        [JsonProperty(PropertyName = "timeOfLastSwitchover")]
        public System.Nullable<System.DateTime> TimeOfLastSwitchover { get; set; }

        /// <value>
        /// The timestamp of the last failover operation.
        /// </value>
        [JsonProperty(PropertyName = "timeOfLastFailover")]
        public System.Nullable<System.DateTime> TimeOfLastFailover { get; set; }

        /// <value>
        /// Indicates whether the Autonomous Database has Data Guard enabled.
        /// </value>
        [JsonProperty(PropertyName = "isDataGuardEnabled")]
        public System.Nullable<bool> IsDataGuardEnabled { get; set; }

        /// <value>
        /// Indicates the number of seconds of data loss for a Data Guard failover.
        /// </value>
        [JsonProperty(PropertyName = "failedDataRecoveryInSeconds")]
        public System.Nullable<int> FailedDataRecoveryInSeconds { get; set; }

        [JsonProperty(PropertyName = "standbyDb")]
        public AutonomousDatabaseStandbySummary StandbyDb { get; set; }
        ///
        /// <value>
        /// The role of the Autonomous Data Guard-enabled Autonomous Container Database.
        /// </value>
        ///
        public enum RoleEnum {
            [EnumMember(Value = "PRIMARY")]
            Primary,
            [EnumMember(Value = "STANDBY")]
            Standby,
            [EnumMember(Value = "DISABLED_STANDBY")]
            DisabledStandby
        };

        /// <value>
        /// The role of the Autonomous Data Guard-enabled Autonomous Container Database.
        /// </value>
        [JsonProperty(PropertyName = "role")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RoleEnum> Role { get; set; }

        /// <value>
        /// List of Oracle Database versions available for a database upgrade. If there are no version upgrades available, this list is empty.
        /// </value>
        [JsonProperty(PropertyName = "availableUpgradeVersions")]
        public System.Collections.Generic.List<string> AvailableUpgradeVersions { get; set; }
    }
}
