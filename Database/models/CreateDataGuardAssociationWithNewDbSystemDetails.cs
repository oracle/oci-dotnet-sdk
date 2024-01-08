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
    /// The configuration details for creating a Data Guard association for a virtual machine DB system database. For this type of DB system database, the `creationType` should be `NewDbSystem`. A new DB system will be launched to create the standby database.
    /// <br/>
    /// To create a Data Guard association for a database in a bare metal or Exadata DB system, use the {@link #createDataGuardAssociationToExistingDbSystemDetails(CreateDataGuardAssociationToExistingDbSystemDetailsRequest) createDataGuardAssociationToExistingDbSystemDetails} subtype instead.
    /// 
    /// </summary>
    public class CreateDataGuardAssociationWithNewDbSystemDetails : CreateDataGuardAssociationDetails
    {
        
        /// <value>
        /// The user-friendly name of the DB system that will contain the the standby database. The display name does not have to be unique.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The name of the availability domain that the standby database DB system will be located in. For example- \"Uocm:PHX-AD-1\".
        /// </value>
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The virtual machine DB system shape to launch for the standby database in the Data Guard association. The shape determines the number of CPU cores and the amount of memory available for the DB system.
        /// Only virtual machine shapes are valid options. If you do not supply this parameter, the default shape is the shape of the primary DB system.
        /// <br/>
        /// To get a list of all shapes, use the {@link #listDbSystemShapes(ListDbSystemShapesRequest) listDbSystemShapes} operation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }
        
        /// <value>
        /// The number of OCPU cores available for AMD-based virtual machine DB systems.
        /// </value>
        [JsonProperty(PropertyName = "cpuCoreCount")]
        public System.Nullable<int> CpuCoreCount { get; set; }
                ///
        /// <value>
        /// The block storage volume performance level. Valid values are `BALANCED` and `HIGH_PERFORMANCE`. See [Block Volume Performance](https://docs.cloud.oracle.com/Content/Block/Concepts/blockvolumeperformance.htm) for more information.
        /// 
        /// </value>
        ///
        public enum StorageVolumePerformanceModeEnum {
            [EnumMember(Value = "BALANCED")]
            Balanced,
            [EnumMember(Value = "HIGH_PERFORMANCE")]
            HighPerformance
        };

        /// <value>
        /// The block storage volume performance level. Valid values are `BALANCED` and `HIGH_PERFORMANCE`. See [Block Volume Performance](https://docs.cloud.oracle.com/Content/Block/Concepts/blockvolumeperformance.htm) for more information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "storageVolumePerformanceMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<StorageVolumePerformanceModeEnum> StorageVolumePerformanceMode { get; set; }
        
        /// <value>
        /// The number of nodes to launch for the DB system of the standby in the Data Guard association. For a 2-node RAC virtual machine DB system, specify either 1 or 2. If you do not supply this parameter, the default is the node count of the primary DB system.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nodeCount")]
        public System.Nullable<int> NodeCount { get; set; }
        
        /// <value>
        /// The OCID of the subnet the DB system is associated with.
        /// **Subnet Restrictions:**
        /// - For 1- and 2-node RAC DB systems, do not use a subnet that overlaps with 192.168.16.16/28
        /// <br/>
        /// These subnets are used by the Oracle Clusterware private interconnect on the database instance.
        /// Specifying an overlapping subnet will cause the private interconnect to malfunction.
        /// This restriction applies to both the client subnet and backup subnet.
        /// 
        /// </value>
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
        /// A list of the [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the network security groups (NSGs) that the backup network of this DB system belongs to. Setting this to an empty array after the list is created removes the resource from all NSGs. For more information about NSGs, see [Security Rules](https://docs.cloud.oracle.com/Content/Network/Concepts/securityrules.htm). Applicable only to Exadata systems.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "backupNetworkNsgIds")]
        public System.Collections.Generic.List<string> BackupNetworkNsgIds { get; set; }
        
        /// <value>
        /// The hostname for the DB node.
        /// </value>
        [JsonProperty(PropertyName = "hostname")]
        public string Hostname { get; set; }
        
        /// <value>
        /// The time zone of the dataguard standby DB system. For details, see [DB System Time Zones](https://docs.cloud.oracle.com/Content/Database/References/timezones.htm).
        /// </value>
        [JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; set; }
        
        /// <value>
        /// A Fault Domain is a grouping of hardware and infrastructure within an availability domain.
        /// Fault Domains let you distribute your instances so that they are not on the same physical
        /// hardware within a single availability domain. A hardware failure or maintenance
        /// that affects one Fault Domain does not affect DB systems in other Fault Domains.
        /// <br/>
        /// If you do not specify the Fault Domain, the system selects one for you. To change the Fault
        /// Domain for a DB system, terminate it and launch a new DB system in the preferred Fault Domain.
        /// <br/>
        /// If the node count is greater than 1, you can specify which Fault Domains these nodes will be distributed into.
        /// The system assigns your nodes automatically to the Fault Domains you specify so that
        /// no Fault Domain contains more than one node.
        /// <br/>
        /// To get a list of Fault Domains, use the
        /// {@link #listFaultDomains(ListFaultDomainsRequest) listFaultDomains} operation in the
        /// Identity and Access Management Service API.
        /// <br/>
        /// Example: FAULT-DOMAIN-1
        /// </value>
        [JsonProperty(PropertyName = "faultDomains")]
        public System.Collections.Generic.List<string> FaultDomains { get; set; }
        
        /// <value>
        /// The IPv4 address from the provided OCI subnet which needs to be assigned to the VNIC. If not provided, it will
        /// be auto-assigned with an available IPv4 address from the subnet.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "privateIp")]
        public string PrivateIp { get; set; }
                ///
        /// <value>
        /// The Oracle license model that applies to all the databases on the dataguard standby DB system. The default is LICENSE_INCLUDED.
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
        /// The Oracle license model that applies to all the databases on the dataguard standby DB system. The default is LICENSE_INCLUDED.
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
        [JsonProperty(PropertyName = "dbSystemFreeformTags")]
        public System.Collections.Generic.Dictionary<string, string> DbSystemFreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dbSystemDefinedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DbSystemDefinedTags { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "databaseFreeformTags")]
        public System.Collections.Generic.Dictionary<string, string> DatabaseFreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "databaseDefinedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DatabaseDefinedTags { get; set; }
        
        [JsonProperty(PropertyName = "dataCollectionOptions")]
        public DataCollectionOptions DataCollectionOptions { get; set; }
        
        [JsonProperty(PropertyName = "creationType")]
        private readonly string creationType = "NewDbSystem";
    }
}
