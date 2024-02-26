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
    /// Details of the cloud Autonomous VM cluster.
    /// 
    /// </summary>
    public class CloudAutonomousVmClusterSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Cloud Autonomous VM cluster.
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
        /// User defined description of the cloud Autonomous VM cluster.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The name of the availability domain that the cloud Autonomous VM cluster is located in.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AvailabilityDomain is required.")]
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the subnet the cloud Autonomous VM Cluster is associated with.
        /// <br/>
        /// **Subnet Restrictions:**
        /// - For Exadata and virtual machine 2-node RAC DB systems, do not use a subnet that overlaps with 192.168.128.0/20.
        /// <br/>
        /// These subnets are used by the Oracle Clusterware private interconnect on the database instance.
        /// Specifying an overlapping subnet will cause the private interconnect to malfunction.
        /// This restriction applies to both the client subnet and backup subnet.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// The list of [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) for the network security groups (NSGs) to which this resource belongs. Setting this to an empty list removes all resources from all NSGs. For more information about NSGs, see [Security Rules](https://docs.cloud.oracle.com/Content/Network/Concepts/securityrules.htm).
        /// **NsgIds restrictions:**
        /// - A network security group (NSG) is optional for Autonomous Databases with private access. The nsgIds list can be empty.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the last maintenance update history. This value is updated when a maintenance update starts.
        /// </value>
        [JsonProperty(PropertyName = "lastUpdateHistoryEntryId")]
        public string LastUpdateHistoryEntryId { get; set; }
                ///
        /// <value>
        /// The current state of the cloud Autonomous VM cluster.
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
        /// The current state of the cloud Autonomous VM cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The user-friendly name for the cloud Autonomous VM cluster. The name does not need to be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The date and time that the cloud Autonomous VM cluster was created.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The last date and time that the cloud Autonomous VM cluster was updated.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The time zone of the Cloud Autonomous VM Cluster.
        /// </value>
        [JsonProperty(PropertyName = "clusterTimeZone")]
        public string ClusterTimeZone { get; set; }
        
        /// <value>
        /// Additional information about the current lifecycle state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The hostname for the cloud Autonomous VM cluster.
        /// </value>
        [JsonProperty(PropertyName = "hostname")]
        public string Hostname { get; set; }
        
        /// <value>
        /// The domain name for the cloud Autonomous VM cluster.
        /// </value>
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the cloud Exadata infrastructure.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CloudExadataInfrastructureId is required.")]
        [JsonProperty(PropertyName = "cloudExadataInfrastructureId")]
        public string CloudExadataInfrastructureId { get; set; }
        
        /// <value>
        /// The model name of the Exadata hardware running the cloud Autonomous VM cluster.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }
        
        /// <value>
        /// The number of database servers in the cloud VM cluster.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nodeCount")]
        public System.Nullable<int> NodeCount { get; set; }
        
        /// <value>
        /// The total data storage allocated, in terabytes (TB).
        /// </value>
        [JsonProperty(PropertyName = "dataStorageSizeInTBs")]
        public System.Double DataStorageSizeInTBs { get; set; }
        
        /// <value>
        /// The total data storage allocated, in gigabytes (GB).
        /// </value>
        [JsonProperty(PropertyName = "dataStorageSizeInGBs")]
        public System.Double DataStorageSizeInGBs { get; set; }
        
        /// <value>
        /// The number of CPU cores on the cloud Autonomous VM cluster.
        /// </value>
        [JsonProperty(PropertyName = "cpuCoreCount")]
        public System.Nullable<int> CpuCoreCount { get; set; }
        
        /// <value>
        /// The number of CPU cores on the cloud Autonomous VM cluster. Only 1 decimal place is allowed for the fractional part.
        /// </value>
        [JsonProperty(PropertyName = "ocpuCount")]
        public System.Nullable<float> OcpuCount { get; set; }
                ///
        /// <value>
        /// The compute model of the Cloud Autonomous VM Cluster. ECPU compute model is the recommended model and OCPU compute model is legacy. See [Compute Models in Autonomous Database on Dedicated Exadata #Infrastructure](https://docs.oracle.com/en/cloud/paas/autonomous-database/dedicated/adbak) for more details.
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
        /// The compute model of the Cloud Autonomous VM Cluster. ECPU compute model is the recommended model and OCPU compute model is legacy. See [Compute Models in Autonomous Database on Dedicated Exadata #Infrastructure](https://docs.oracle.com/en/cloud/paas/autonomous-database/dedicated/adbak) for more details.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "computeModel")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ComputeModelEnum> ComputeModel { get; set; }
        
        /// <value>
        /// Enable mutual TLS(mTLS) authentication for database at time of provisioning a VMCluster. This is applicable to database TLS Certificates only. Default is TLS
        /// </value>
        [JsonProperty(PropertyName = "isMtlsEnabledVmCluster")]
        public System.Nullable<bool> IsMtlsEnabledVmCluster { get; set; }
        
        /// <value>
        /// The number of CPU cores enabled per VM cluster node.
        /// </value>
        [JsonProperty(PropertyName = "cpuCoreCountPerNode")]
        public System.Nullable<int> CpuCoreCountPerNode { get; set; }
        
        /// <value>
        /// The memory allocated in GBs.
        /// </value>
        [JsonProperty(PropertyName = "memorySizeInGBs")]
        public System.Nullable<int> MemorySizeInGBs { get; set; }
                ///
        /// <value>
        /// The Oracle license model that applies to the Oracle Autonomous Database. Bring your own license (BYOL) allows you to apply your current on-premises Oracle software licenses to equivalent, highly automated Oracle services in the cloud.
        /// License Included allows you to subscribe to new Oracle Database software licenses and the Oracle Database service.
        /// Note that when provisioning an [Autonomous Database on dedicated Exadata infrastructure](https://docs.oracle.com/en/cloud/paas/autonomous-database/index.html), this attribute must be null. It is already set at the
        /// Autonomous Exadata Infrastructure level. When provisioning an [Autonomous Database Serverless] (https://docs.oracle.com/en/cloud/paas/autonomous-database/index.html) database, if a value is not specified, the system defaults the value to `BRING_YOUR_OWN_LICENSE`. Bring your own license (BYOL) also allows you to select the DB edition using the optional parameter.
        /// <br/>
        /// This cannot be updated in parallel with any of the following: cpuCoreCount, computeCount, dataStorageSizeInTBs, adminPassword, isMTLSConnectionRequired, dbWorkload, privateEndpointLabel, nsgIds, dbVersion, dbName, scheduledOperations, dbToolsDetails, or isFreeTier.
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
        /// The Oracle license model that applies to the Oracle Autonomous Database. Bring your own license (BYOL) allows you to apply your current on-premises Oracle software licenses to equivalent, highly automated Oracle services in the cloud.
        /// License Included allows you to subscribe to new Oracle Database software licenses and the Oracle Database service.
        /// Note that when provisioning an [Autonomous Database on dedicated Exadata infrastructure](https://docs.oracle.com/en/cloud/paas/autonomous-database/index.html), this attribute must be null. It is already set at the
        /// Autonomous Exadata Infrastructure level. When provisioning an [Autonomous Database Serverless] (https://docs.oracle.com/en/cloud/paas/autonomous-database/index.html) database, if a value is not specified, the system defaults the value to `BRING_YOUR_OWN_LICENSE`. Bring your own license (BYOL) also allows you to select the DB edition using the optional parameter.
        /// <br/>
        /// This cannot be updated in parallel with any of the following: cpuCoreCount, computeCount, dataStorageSizeInTBs, adminPassword, isMTLSConnectionRequired, dbWorkload, privateEndpointLabel, nsgIds, dbVersion, dbName, scheduledOperations, dbToolsDetails, or isFreeTier.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "licenseModel")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LicenseModelEnum> LicenseModel { get; set; }
        
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
        /// The SCAN Listenenr TLS port. Default is 2484.
        /// </value>
        [JsonProperty(PropertyName = "scanListenerPortTls")]
        public System.Nullable<int> ScanListenerPortTls { get; set; }
        
        /// <value>
        /// The SCAN Listener Non TLS port. Default is 1521.
        /// </value>
        [JsonProperty(PropertyName = "scanListenerPortNonTls")]
        public System.Nullable<int> ScanListenerPortNonTls { get; set; }
        
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
        /// The date and time of Database SSL certificate expiration.
        /// </value>
        [JsonProperty(PropertyName = "timeDatabaseSslCertificateExpires")]
        public System.Nullable<System.DateTime> TimeDatabaseSslCertificateExpires { get; set; }
        
        /// <value>
        /// The date and time of ORDS certificate expiration.
        /// </value>
        [JsonProperty(PropertyName = "timeOrdsCertificateExpires")]
        public System.Nullable<System.DateTime> TimeOrdsCertificateExpires { get; set; }
        
        /// <value>
        /// CPU cores available for allocation to Autonomous Databases.
        /// </value>
        [JsonProperty(PropertyName = "availableCpus")]
        public System.Nullable<float> AvailableCpus { get; set; }
        
        /// <value>
        /// CPUs that continue to be included in the count of CPUs available to the Autonomous Container Database even after one of its Autonomous Database is terminated or scaled down. You can release them to the available CPUs at its parent Autonomous VM Cluster level by restarting the Autonomous Container Database.          
        /// 
        /// </value>
        [JsonProperty(PropertyName = "reclaimableCpus")]
        public System.Nullable<float> ReclaimableCpus { get; set; }
        
        /// <value>
        /// The number of Autonomous Container Databases that can be created with the currently available local storage.
        /// </value>
        [JsonProperty(PropertyName = "availableContainerDatabases")]
        public System.Nullable<int> AvailableContainerDatabases { get; set; }
        
        /// <value>
        /// The total number of Autonomous Container Databases that can be created with the allocated local storage.
        /// </value>
        [JsonProperty(PropertyName = "totalContainerDatabases")]
        public System.Nullable<int> TotalContainerDatabases { get; set; }
        
        /// <value>
        /// The data disk group size available for Autonomous Databases, in TBs.
        /// </value>
        [JsonProperty(PropertyName = "availableAutonomousDataStorageSizeInTBs")]
        public System.Double AvailableAutonomousDataStorageSizeInTBs { get; set; }
        
        /// <value>
        /// The data disk group size allocated for Autonomous Databases, in TBs.
        /// </value>
        [JsonProperty(PropertyName = "autonomousDataStorageSizeInTBs")]
        public System.Double AutonomousDataStorageSizeInTBs { get; set; }
        
        /// <value>
        /// The local node storage allocated in GBs.
        /// </value>
        [JsonProperty(PropertyName = "dbNodeStorageSizeInGBs")]
        public System.Nullable<int> DbNodeStorageSizeInGBs { get; set; }
        
        /// <value>
        /// The amount of memory (in GBs) enabled per OCPU or ECPU.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "memoryPerOracleComputeUnitInGBs")]
        public System.Nullable<int> MemoryPerOracleComputeUnitInGBs { get; set; }
        
        /// <value>
        /// The list of [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Db servers.
        /// </value>
        [JsonProperty(PropertyName = "dbServers")]
        public System.Collections.Generic.List<string> DbServers { get; set; }
        
        /// <value>
        /// The percentage of total number of CPUs used in an Autonomous VM Cluster.
        /// </value>
        [JsonProperty(PropertyName = "cpuPercentage")]
        public System.Nullable<float> CpuPercentage { get; set; }
        
        /// <value>
        /// The percentage of the data storage used for the Autonomous Databases in an Autonomous VM Cluster.
        /// </value>
        [JsonProperty(PropertyName = "autonomousDataStoragePercentage")]
        public System.Nullable<float> AutonomousDataStoragePercentage { get; set; }
        
        /// <value>
        /// The number of CPUs provisioned in an Autonomous VM Cluster.
        /// </value>
        [JsonProperty(PropertyName = "provisionedCpus")]
        public System.Nullable<float> ProvisionedCpus { get; set; }
        
        /// <value>
        /// The total number of CPUs in an Autonomous VM Cluster.
        /// </value>
        [JsonProperty(PropertyName = "totalCpus")]
        public System.Nullable<float> TotalCpus { get; set; }
        
        /// <value>
        /// The total data disk group size for Autonomous Databases, in TBs.
        /// </value>
        [JsonProperty(PropertyName = "totalAutonomousDataStorageInTBs")]
        public System.Nullable<float> TotalAutonomousDataStorageInTBs { get; set; }
        
        /// <value>
        /// The number of CPUs reserved in an Autonomous VM Cluster.
        /// </value>
        [JsonProperty(PropertyName = "reservedCpus")]
        public System.Nullable<float> ReservedCpus { get; set; }
        
        /// <value>
        /// The number of provisionable Autonomous Container Databases in an Autonomous VM Cluster.
        /// </value>
        [JsonProperty(PropertyName = "provisionableAutonomousContainerDatabases")]
        public System.Nullable<int> ProvisionableAutonomousContainerDatabases { get; set; }
        
        /// <value>
        /// The number of provisioned Autonomous Container Databases in an Autonomous VM Cluster.
        /// </value>
        [JsonProperty(PropertyName = "provisionedAutonomousContainerDatabases")]
        public System.Nullable<int> ProvisionedAutonomousContainerDatabases { get; set; }
        
        /// <value>
        /// The number of non-provisionable Autonomous Container Databases in an Autonomous VM Cluster.
        /// </value>
        [JsonProperty(PropertyName = "nonProvisionableAutonomousContainerDatabases")]
        public System.Nullable<int> NonProvisionableAutonomousContainerDatabases { get; set; }
        
        /// <value>
        /// The lowest value to which exadataStorage (in TBs) can be scaled down.
        /// </value>
        [JsonProperty(PropertyName = "exadataStorageInTBsLowestScaledValue")]
        public System.Double ExadataStorageInTBsLowestScaledValue { get; set; }
        
        /// <value>
        /// The lowest value to which ocpus can be scaled down.
        /// </value>
        [JsonProperty(PropertyName = "ocpusLowestScaledValue")]
        public System.Nullable<int> OcpusLowestScaledValue { get; set; }
        
        /// <value>
        /// The lowest value to which maximum number of ACDs can be scaled down.
        /// </value>
        [JsonProperty(PropertyName = "maxAcdsLowestScaledValue")]
        public System.Nullable<int> MaxAcdsLowestScaledValue { get; set; }
        
    }
}
