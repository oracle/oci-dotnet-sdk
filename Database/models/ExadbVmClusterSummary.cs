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
    /// Details of the Exadata VM cluster on Exascale Infrastructure. Applies to Exadata Database Service on Exascale Infrastructure only.
    /// 
    /// </summary>
    public class ExadbVmClusterSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Exadata VM cluster on Exascale Infrastructure.
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
        /// The name of the availability domain in which the Exadata VM cluster on Exascale Infrastructure is located.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AvailabilityDomain is required.")]
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the subnet associated with the Exadata VM cluster on Exascale Infrastructure.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the backup network subnet associated with the Exadata VM cluster on Exascale Infrastructure.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BackupSubnetId is required.")]
        [JsonProperty(PropertyName = "backupSubnetId")]
        public string BackupSubnetId { get; set; }
        
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
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the last maintenance update history entry. This value is updated when a maintenance update starts.
        /// </value>
        [JsonProperty(PropertyName = "lastUpdateHistoryEntryId")]
        public string LastUpdateHistoryEntryId { get; set; }
        
        /// <value>
        /// The port number configured for the listener on the Exadata VM cluster on Exascale Infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "listenerPort")]
        public System.Nullable<long> ListenerPort { get; set; }
                ///
        /// <value>
        /// The current state of the Exadata VM cluster on Exascale Infrastructure.
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
        /// The current state of the Exadata VM cluster on Exascale Infrastructure.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The number of nodes in the Exadata VM cluster on Exascale Infrastructure.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NodeCount is required.")]
        [JsonProperty(PropertyName = "nodeCount")]
        public System.Nullable<int> NodeCount { get; set; }
        
        /// <value>
        /// The shape of the Exadata VM cluster on Exascale Infrastructure resource
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Shape is required.")]
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }
        
        /// <value>
        /// The user-friendly name for the Exadata VM cluster on Exascale Infrastructure. The name does not need to be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The date and time that the Exadata VM cluster on Exascale Infrastructure was created.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Additional information about the current lifecycle state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The time zone to use for the Exadata VM cluster on Exascale Infrastructure. For details, see [Time Zones](https://docs.cloud.oracle.com/Content/Database/References/timezones.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; set; }
        
        /// <value>
        /// The hostname for the Exadata VM cluster on Exascale Infrastructure. The hostname must begin with an alphabetic character, and 
        /// can contain alphanumeric characters and hyphens (-). For Exadata systems, the maximum length of the hostname is 12 characters.
        /// <br/>
        /// The maximum length of the combined hostname and domain is 63 characters.
        /// <br/>
        /// **Note:** The hostname must be unique within the subnet. If it is not unique, 
        /// then the Exadata VM cluster on Exascale Infrastructure will fail to provision.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Hostname is required.")]
        [JsonProperty(PropertyName = "hostname")]
        public string Hostname { get; set; }
        
        /// <value>
        /// A domain name used for the Exadata VM cluster on Exascale Infrastructure. If the Oracle-provided internet and VCN
        /// resolver is enabled for the specified subnet, then the domain name for the subnet is used
        /// (do not provide one). Otherwise, provide a valid DNS domain name. Hyphens (-) are not permitted. 
        /// Applies to Exadata Database Service on Exascale Infrastructure only.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Domain is required.")]
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }
        
        /// <value>
        /// The cluster name for Exadata VM cluster on Exascale Infrastructure. The cluster name must begin with an alphabetic character, and may contain hyphens (-). Underscores (_) are not permitted. The cluster name can be no longer than 11 characters and is not case sensitive.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "clusterName")]
        public string ClusterName { get; set; }
        
        /// <value>
        /// A valid Oracle Grid Infrastructure (GI) software version.
        /// </value>
        [JsonProperty(PropertyName = "giVersion")]
        public string GiVersion { get; set; }
        
        /// <value>
        /// Grid Setup will be done using this grid image id.
        /// <br/>
        /// The grid image ID can be obtained using the API /20160918/giVersions/{majorVersion}/minorVersions?compartmentId=<compartmentId>&shapeFamily=EXADB_XS&availabilityDomain=<AD name>.
        /// The list of supported major versions can be obtained using the API /20160918/giVersions?compartmentId=<compartmentId>&shape=ExaDbXS&availabilityDomain=<AD name>
        /// 
        /// </value>
        [JsonProperty(PropertyName = "gridImageId")]
        public string GridImageId { get; set; }
                ///
        /// <value>
        /// The type of Grid Image
        /// </value>
        ///
        public enum GridImageTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "RELEASE_UPDATE")]
            ReleaseUpdate,
            [EnumMember(Value = "CUSTOM_IMAGE")]
            CustomImage
        };

        /// <value>
        /// The type of Grid Image
        /// </value>
        [JsonProperty(PropertyName = "gridImageType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<GridImageTypeEnum> GridImageType { get; set; }
        
        /// <value>
        /// Operating system version of the image.
        /// </value>
        [JsonProperty(PropertyName = "systemVersion")]
        public string SystemVersion { get; set; }
        
        /// <value>
        /// The public key portion of one or more key pairs used for SSH access to the Exadata VM cluster on Exascale Infrastructure.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SshPublicKeys is required.")]
        [JsonProperty(PropertyName = "sshPublicKeys")]
        public System.Collections.Generic.List<string> SshPublicKeys { get; set; }
                ///
        /// <value>
        /// The Oracle license model that applies to the Exadata VM cluster on Exascale Infrastructure. The default is BRING_YOUR_OWN_LICENSE.
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
        /// The Oracle license model that applies to the Exadata VM cluster on Exascale Infrastructure. The default is BRING_YOUR_OWN_LICENSE.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "licenseModel")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LicenseModelEnum> LicenseModel { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Single Client Access Name (SCAN) IP addresses associated with the Exadata VM cluster on Exascale Infrastructure.
        /// SCAN IP addresses are typically used for load balancing and are not assigned to any interface.
        /// Oracle Clusterware directs the requests to the appropriate nodes in the cluster.
        /// <br/>
        /// **Note:** For a single-node DB system, this list is empty.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "scanIpIds")]
        public System.Collections.Generic.List<string> ScanIpIds { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the virtual IP (VIP) addresses associated with the Exadata VM cluster on Exascale Infrastructure. 
        /// The Cluster Ready Services (CRS) creates and maintains one VIP address for each node in the Exadata Cloud Service instance to 
        /// enable failover. If one node fails, then the VIP is reassigned to another active node in the cluster.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vipIds")]
        public System.Collections.Generic.List<string> VipIds { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the DNS record for the SCAN IP addresses that are associated with the Exadata VM cluster on Exascale Infrastructure.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "scanDnsRecordId")]
        public string ScanDnsRecordId { get; set; }
        
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
        /// Security Attributes for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Oracle-ZPR&quot;: {&quot;MaxEgressCount&quot;: {&quot;value&quot;: &quot;42&quot;, &quot;mode&quot;: &quot;audit&quot;}}}
        /// </value>
        [JsonProperty(PropertyName = "securityAttributes")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SecurityAttributes { get; set; }
        
        /// <value>
        /// System tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
        /// <value>
        /// The FQDN of the DNS record for the SCAN IP addresses that are associated with the Exadata VM cluster on Exascale Infrastructure.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "scanDnsName")]
        public string ScanDnsName { get; set; }
        
        /// <value>
        /// The OCID of the zone with which the Exadata VM cluster on Exascale Infrastructure is associated.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "zoneId")]
        public string ZoneId { get; set; }
        
        /// <value>
        /// The TCP Single Client Access Name (SCAN) port. The default port is 1521.
        /// </value>
        [JsonProperty(PropertyName = "scanListenerPortTcp")]
        public System.Nullable<int> ScanListenerPortTcp { get; set; }
        
        /// <value>
        /// The Secured Communication (TCPS) protocol Single Client Access Name (SCAN) port. The default port is 2484.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "scanListenerPortTcpSsl")]
        public System.Nullable<int> ScanListenerPortTcpSsl { get; set; }
        
        /// <value>
        /// The private zone ID in which you want DNS records to be created.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "privateZoneId")]
        public string PrivateZoneId { get; set; }
        
        [JsonProperty(PropertyName = "dataCollectionOptions")]
        public DataCollectionOptions DataCollectionOptions { get; set; }
        
        /// <value>
        /// The number of Total ECPUs for an Exadata VM cluster on Exascale Infrastructure.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalECpuCount is required.")]
        [JsonProperty(PropertyName = "totalECpuCount")]
        public System.Nullable<int> TotalECpuCount { get; set; }
        
        /// <value>
        /// The number of ECPUs to enable for an Exadata VM cluster on Exascale Infrastructure.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EnabledECpuCount is required.")]
        [JsonProperty(PropertyName = "enabledECpuCount")]
        public System.Nullable<int> EnabledECpuCount { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VmFileSystemStorage is required.")]
        [JsonProperty(PropertyName = "vmFileSystemStorage")]
        public ExadbVmClusterStorageDetails VmFileSystemStorage { get; set; }
        
        [JsonProperty(PropertyName = "snapshotFileSystemStorage")]
        public ExadbVmClusterStorageDetails SnapshotFileSystemStorage { get; set; }
        
        [JsonProperty(PropertyName = "totalFileSystemStorage")]
        public ExadbVmClusterStorageDetails TotalFileSystemStorage { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Exadata Database Storage Vault.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExascaleDbStorageVaultId is required.")]
        [JsonProperty(PropertyName = "exascaleDbStorageVaultId")]
        public string ExascaleDbStorageVaultId { get; set; }
        
        /// <value>
        /// The memory that you want to be allocated in GBs. Memory is calculated based on 11 GB per VM core reserved.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "memorySizeInGBs")]
        public System.Nullable<int> MemorySizeInGBs { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the cluster placement group of the Exadata Infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "clusterPlacementGroupId")]
        public string ClusterPlacementGroupId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the subscription with which resource needs to be associated with.
        /// </value>
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; set; }
        
    }
}
