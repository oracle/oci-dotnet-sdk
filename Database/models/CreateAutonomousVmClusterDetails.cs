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
    /// Details for the create Autonomous VM cluster operation.
    /// 
    /// </summary>
    public class CreateAutonomousVmClusterDetails 
    {
        
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
        /// The time zone to use for the Autonomous VM cluster. For details, see [DB System Time Zones](https://docs.cloud.oracle.com/Content/Database/References/timezones.htm).
        /// </value>
        [JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; set; }
        
        /// <value>
        /// If true, database backup on local Exadata storage is configured for the Autonomous VM cluster. If false, database backup on local Exadata storage is not available in the Autonomous VM cluster.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isLocalBackupEnabled")]
        public System.Nullable<bool> IsLocalBackupEnabled { get; set; }
                ///
        /// <value>
        /// The Oracle license model that applies to the Autonomous VM cluster. The default is BRING_YOUR_OWN_LICENSE.
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
        /// The Oracle license model that applies to the Autonomous VM cluster. The default is BRING_YOUR_OWN_LICENSE.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "licenseModel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LicenseModelEnum> LicenseModel { get; set; }
        
        /// <value>
        /// The total number of Autonomous Container Databases that can be created.
        /// </value>
        [JsonProperty(PropertyName = "totalContainerDatabases")]
        public System.Nullable<int> TotalContainerDatabases { get; set; }
        
        /// <value>
        /// The number of CPU cores to enable per VM cluster node.
        /// </value>
        [JsonProperty(PropertyName = "cpuCoreCountPerNode")]
        public System.Nullable<int> CpuCoreCountPerNode { get; set; }
                ///
        /// <value>
        /// The compute model of the Autonomous VM Cluster. ECPU compute model is the recommended model and OCPU compute model is legacy.
        /// 
        /// </value>
        ///
        public enum ComputeModelEnum {
            [EnumMember(Value = "ECPU")]
            Ecpu,
            [EnumMember(Value = "OCPU")]
            Ocpu
        };

        /// <value>
        /// The compute model of the Autonomous VM Cluster. ECPU compute model is the recommended model and OCPU compute model is legacy.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "computeModel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ComputeModelEnum> ComputeModel { get; set; }
        
        /// <value>
        /// The amount of memory (in GBs) to be enabled per OCPU or ECPU. 
        /// 
        /// </value>
        [JsonProperty(PropertyName = "memoryPerOracleComputeUnitInGBs")]
        public System.Nullable<int> MemoryPerOracleComputeUnitInGBs { get; set; }
        
        /// <value>
        /// The data disk group size to be allocated for Autonomous Databases, in TBs.
        /// </value>
        [JsonProperty(PropertyName = "autonomousDataStorageSizeInTBs")]
        public System.Double AutonomousDataStorageSizeInTBs { get; set; }
        
        [JsonProperty(PropertyName = "maintenanceWindowDetails")]
        public MaintenanceWindow MaintenanceWindowDetails { get; set; }
        
        /// <value>
        /// The list of [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Db servers.
        /// </value>
        [JsonProperty(PropertyName = "dbServers")]
        public System.Collections.Generic.List<string> DbServers { get; set; }
        
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
        
    }
}
