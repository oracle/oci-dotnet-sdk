/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
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
    /// Details to update an Oracle Autonomous Database.
    /// <br/>
    /// **Notes**
    /// - To specify OCPU core count, you must use either `ocpuCount` or `cpuCoreCount`. You cannot use both parameters at the same time.
    /// - To specify a storage allocation, you must use  either `dataStorageSizeInGBs` or `dataStorageSizeInTBs`.
    /// - See the individual parameter discriptions for more information on the OCPU and storage value parameters.
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    public class UpdateAutonomousDatabaseDetails 
    {
        
        /// <value>
        /// The number of OCPU cores to be made available to the Autonomous Database.
        /// <br/>
        /// **Note:** This parameter cannot be used with the `ocpuCount` parameter.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "cpuCoreCount")]
        public System.Nullable<int> CpuCoreCount { get; set; }
        
        /// <value>
        /// The number of OCPU cores to be made available to the Autonomous Database. 
        /// <br/>
        /// For databases on dedicated Exadata infrastructure, you can specify a fractional value for this parameter. Fractional values are not supported for Autonomous Database on shared Exadata infrastructure.
        /// <br/>
        /// To provision less than 1 core, enter a fractional value in an increment of 0.1. To provision 1 or more cores, you must enter an integer between 1 and the maximum number of cores available to the infrastructure shape. For example, you can provision 0.3 or 0.4 cores, but not 0.35 cores. Likewise, you can provision 2 cores or 3 cores, but not 2.5 cores. The maximum number of cores is determined by the infrastructure shape. See [Characteristics of Infrastructure Shapes](https://www.oracle.com/pls/topic/lookup?ctx=en/cloud/paas/autonomous-database&id=ATPFG-GUID-B0F033C1-CC5A-42F0-B2E7-3CECFEDA1FD1) for shape details.
        /// <br/>
        /// **Note:** This parameter cannot be used with the `cpuCoreCount` parameter. 
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ocpuCount")]
        public System.Nullable<float> OcpuCount { get; set; }
        
        /// <value>
        /// The size, in terabytes, of the data volume that will be created and attached to the database. For Autonomous Databases on dedicated Exadata infrastructure, the maximum storage value is determined by the infrastructure shape. See [Characteristics of Infrastructure Shapes](https://www.oracle.com/pls/topic/lookup?ctx=en/cloud/paas/autonomous-database&id=ATPFG-GUID-B0F033C1-CC5A-42F0-B2E7-3CECFEDA1FD1) for shape details. 
        /// <br/>
        /// **Note:** This parameter cannot be used with the `dataStorageSizeInGBs` parameter.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dataStorageSizeInTBs")]
        public System.Nullable<int> DataStorageSizeInTBs { get; set; }
        
        /// <value>
        /// Applies to dedicated Exadata infrastructure only.
        /// <br/>
        /// The size, in gigabytes, of the data volume that will be created and attached to the database. The maximum storage value depends on the system shape. See [Characteristics of Infrastructure Shapes](https://www.oracle.com/pls/topic/lookup?ctx=en/cloud/paas/autonomous-database&id=ATPFG-GUID-B0F033C1-CC5A-42F0-B2E7-3CECFEDA1FD1) for shape details.
        /// <br/>
        /// **Note:** This parameter cannot be used with the `dataStorageSizeInTBs` parameter.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dataStorageSizeInGBs")]
        public System.Nullable<int> DataStorageSizeInGBs { get; set; }
        
        /// <value>
        /// The user-friendly name for the Autonomous Database. The name does not have to be unique. The display name can only be updated for Autonomous Databases
        /// using dedicated Exadata infrastructure.           
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Indicates if this is an Always Free resource. The default value is false. Note that Always Free Autonomous Databases have 1 CPU and 20GB of memory. For Always Free databases, memory and CPU cannot be scaled.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isFreeTier")]
        public System.Nullable<bool> IsFreeTier { get; set; }
        
        /// <value>
        /// The password must be between 12 and 30 characters long, and must contain at least 1 uppercase, 1 lowercase, and 1 numeric character. It cannot contain the double quote symbol (\") or the username \"admin\", regardless of casing. It must be different from the last four passwords and it must not be a password used within the last 24 hours.
        /// </value>
        [JsonProperty(PropertyName = "adminPassword")]
        public string AdminPassword { get; set; }
        
        /// <value>
        /// New name for this Autonomous Database.
        /// For databases using dedicated Exadata infrastructure, the name must begin with an alphabetic character, and can contain a maximum of eight alphanumeric characters. Special characters are not permitted.
        /// For databases using shared Exadata infrastructure, the name must begin with an alphabetic character, and can contain a maximum of 14 alphanumeric characters. Special characters are not permitted. The database name must be unique in the tenancy.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dbName")]
        public string DbName { get; set; }
        
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
        /// The Autonomous Database workload type. The following values are valid:
        /// <br/>
        /// - OLTP - indicates an Autonomous Transaction Processing database
        /// - DW - indicates an Autonomous Data Warehouse database
        /// - AJD - indicates an Autonomous JSON Database
        /// - APEX - indicates an Autonomous Database with the Oracle APEX Application Development workload type.
        /// 
        /// </value>
        ///
        public enum DbWorkloadEnum {
            [EnumMember(Value = "OLTP")]
            Oltp,
            [EnumMember(Value = "DW")]
            Dw,
            [EnumMember(Value = "AJD")]
            Ajd,
            [EnumMember(Value = "APEX")]
            Apex
        };

        /// <value>
        /// The Autonomous Database workload type. The following values are valid:
        /// <br/>
        /// - OLTP - indicates an Autonomous Transaction Processing database
        /// - DW - indicates an Autonomous Data Warehouse database
        /// - AJD - indicates an Autonomous JSON Database
        /// - APEX - indicates an Autonomous Database with the Oracle APEX Application Development workload type.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dbWorkload")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DbWorkloadEnum> DbWorkload { get; set; }
                ///
        /// <value>
        /// The Oracle license model that applies to the Oracle Autonomous Database. Bring your own license (BYOL) allows you to apply your current on-premises Oracle software licenses to equivalent, highly automated Oracle PaaS and IaaS services in the cloud.
        /// License Included allows you to subscribe to new Oracle Database software licenses and the Database service.
        /// Note that when provisioning an Autonomous Database on [dedicated Exadata infrastructure](https://docs.oracle.com/en/cloud/paas/autonomous-database/index.html), this attribute must be null because the attribute is already set at the
        /// Autonomous Exadata Infrastructure level. When using [shared Exadata infrastructure](https://docs.oracle.com/en/cloud/paas/autonomous-database/index.html), if a value is not specified, the system will supply the value of `BRING_YOUR_OWN_LICENSE`.
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
        /// The Oracle license model that applies to the Oracle Autonomous Database. Bring your own license (BYOL) allows you to apply your current on-premises Oracle software licenses to equivalent, highly automated Oracle PaaS and IaaS services in the cloud.
        /// License Included allows you to subscribe to new Oracle Database software licenses and the Database service.
        /// Note that when provisioning an Autonomous Database on [dedicated Exadata infrastructure](https://docs.oracle.com/en/cloud/paas/autonomous-database/index.html), this attribute must be null because the attribute is already set at the
        /// Autonomous Exadata Infrastructure level. When using [shared Exadata infrastructure](https://docs.oracle.com/en/cloud/paas/autonomous-database/index.html), if a value is not specified, the system will supply the value of `BRING_YOUR_OWN_LICENSE`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "licenseModel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LicenseModelEnum> LicenseModel { get; set; }
        
        /// <value>
        /// Indicates if the database-level access control is enabled.
        /// If disabled, database access is defined by the network security rules.
        /// If enabled, database access is restricted to the IP addresses defined by the rules specified with the `whitelistedIps` property. While specifying `whitelistedIps` rules is optional,
        ///  if database-level access control is enabled and no rules are specified, the database will become inaccessible. The rules can be added later using the `UpdateAutonomousDatabase` API operation or edit option in console.
        /// When creating a database clone, the desired access control setting should be specified. By default, database-level access control will be disabled for the clone.
        /// <br/>
        /// This property is applicable only to Autonomous Databases on the Exadata Cloud@Customer platform.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAccessControlEnabled")]
        public System.Nullable<bool> IsAccessControlEnabled { get; set; }
        
        /// <value>
        /// The client IP access control list (ACL). This feature is available for autonomous databases on [shared Exadata infrastructure](https://docs.oracle.com/en/cloud/paas/autonomous-database/index.html) and on Exadata Cloud@Customer.
        /// Only clients connecting from an IP address included in the ACL may access the Autonomous Database instance.
        /// <br/>
        /// For shared Exadata infrastructure, this is an array of CIDR (Classless Inter-Domain Routing) notations for a subnet or VCN OCID.
        /// Use a semicolon (;) as a deliminator between the VCN-specific subnets or IPs.
        /// Example: [&quot;1.1.1.1&quot;,&quot;1.1.1.0/24&quot;,&quot;ocid1.vcn.oc1.sea.<unique_id>&quot;,&quot;ocid1.vcn.oc1.sea.<unique_id1>;1.1.1.1&quot;,&quot;ocid1.vcn.oc1.sea.<unique_id2>;1.1.0.0/16&quot;]For Exadata Cloud@Customer, this is an array of IP addresses or CIDR (Classless Inter-Domain Routing) notations.
        /// </value>
        [JsonProperty(PropertyName = "whitelistedIps")]
        public System.Collections.Generic.List<string> WhitelistedIps { get; set; }
        
        /// <value>
        /// This field will be null if the Autonomous Database is not Data Guard enabled or Access Control is disabled.
        /// `TRUE` if the Autonomous Database has Data Guard and Access Control enabled, and the Autonomous Database uses the primary's IP access control list (ACL) for standby.
        /// `FALSE` if the Autonomous Database has Data Guard and Access Control enabled, and the Autonomous Database uses a different IP access control list (ACL) for standby compared to primary.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "arePrimaryWhitelistedIpsUsed")]
        public System.Nullable<bool> ArePrimaryWhitelistedIpsUsed { get; set; }
        
        /// <value>
        /// The client IP access control list (ACL). This feature is available for autonomous databases on [shared Exadata infrastructure](https://docs.oracle.com/en/cloud/paas/autonomous-database/index.html) and on Exadata Cloud@Customer.
        /// Only clients connecting from an IP address included in the ACL may access the Autonomous Database instance.
        /// <br/>
        /// For shared Exadata infrastructure, this is an array of CIDR (Classless Inter-Domain Routing) notations for a subnet or VCN OCID.
        /// Use a semicolon (;) as a deliminator between the VCN-specific subnets or IPs.
        /// Example: [&quot;1.1.1.1&quot;,&quot;1.1.1.0/24&quot;,&quot;ocid1.vcn.oc1.sea.<unique_id>&quot;,&quot;ocid1.vcn.oc1.sea.<unique_id1>;1.1.1.1&quot;,&quot;ocid1.vcn.oc1.sea.<unique_id2>;1.1.0.0/16&quot;]For Exadata Cloud@Customer, this is an array of IP addresses or CIDR (Classless Inter-Domain Routing) notations.
        /// </value>
        [JsonProperty(PropertyName = "standbyWhitelistedIps")]
        public System.Collections.Generic.List<string> StandbyWhitelistedIps { get; set; }
        
        /// <value>
        /// Indicates whether auto scaling is enabled for the Autonomous Database OCPU core count. Setting to `TRUE` enables auto scaling. Setting to `FALSE` disables auto scaling. The default value is true. Auto scaling is available for databases on [shared Exadata infrastructure](https://docs.oracle.com/en/cloud/paas/autonomous-database/index.html) only.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAutoScalingEnabled")]
        public System.Nullable<bool> IsAutoScalingEnabled { get; set; }
        
        /// <value>
        /// Indicates whether the Autonomous Database is a refreshable clone.
        /// </value>
        [JsonProperty(PropertyName = "isRefreshableClone")]
        public System.Nullable<bool> IsRefreshableClone { get; set; }
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
        /// Indicates whether the Autonomous Database has a local (in-region) standby database. Not applicable when creating a cross-region Autonomous Data Guard associations, or to 
        /// Autonomous Databases using dedicated Exadata infrastructure or Exadata Cloud@Customer infrastructure.
        /// <br/>
        /// To create a local standby, set to `TRUE`. To delete a local standby, set to `FALSE`. For more information on using Autonomous Data Guard on shared Exadata infrastructure (local and cross-region) , see [About Standby Databases](https://docs.oracle.com/en/cloud/paas/autonomous-database/adbsa/autonomous-data-guard-about.html#GUID-045AD017-8120-4BDC-AF58-7430FFE28D2B) 
        /// <br/>
        /// To enable cross-region Autonomous Data Guard on shared Exadata infrastructure, see {@link #createCrossRegionAutonomousDatabaseDataGuardDetails(CreateCrossRegionAutonomousDatabaseDataGuardDetailsRequest) createCrossRegionAutonomousDatabaseDataGuardDetails}.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isLocalDataGuardEnabled")]
        public System.Nullable<bool> IsLocalDataGuardEnabled { get; set; }
        
        /// <value>
        /// ** Deprecated. ** Indicates whether the Autonomous Database has a local (in-region) standby database. Not applicable when creating a cross-region Autonomous Data Guard associations, or to 
        /// Autonomous Databases using dedicated Exadata infrastructure or Exadata Cloud@Customer infrastructure.
        /// <br/>
        /// To create a local standby, set to `TRUE`. To delete a local standby, set to `FALSE`. For more information on using Autonomous Data Guard on shared Exadata infrastructure (local and cross-region) , see [About Standby Databases](https://docs.oracle.com/en/cloud/paas/autonomous-database/adbsa/autonomous-data-guard-about.html#GUID-045AD017-8120-4BDC-AF58-7430FFE28D2B) 
        /// <br/>
        /// To enable cross-region Autonomous Data Guard on shared Exadata infrastructure, see {@link #createCrossRegionAutonomousDatabaseDataGuardDetails(CreateCrossRegionAutonomousDatabaseDataGuardDetailsRequest) createCrossRegionAutonomousDatabaseDataGuardDetails}.
        /// <br/>
        /// To delete a cross-region standby database, provide the `peerDbId` for the standby database in a remote region, and set `isDataGuardEnabled` to `FALSE`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isDataGuardEnabled")]
        public System.Nullable<bool> IsDataGuardEnabled { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Autonomous Data Guard standby database located in a different (remote) region from the source primary Autonomous Database.
        /// <br/>
        /// To create or delete a local (in-region) standby, see the `isDataGuardEnabled` parameter.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "peerDbId")]
        public string PeerDbId { get; set; }
        
        /// <value>
        /// A valid Oracle Database version for Autonomous Database.
        /// </value>
        [JsonProperty(PropertyName = "dbVersion")]
        public string DbVersion { get; set; }
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
        /// The private endpoint label for the resource. Setting this to an empty string, after the private endpoint database gets created, will change the same private endpoint database to the public endpoint database.
        /// </value>
        [JsonProperty(PropertyName = "privateEndpointLabel")]
        public string PrivateEndpointLabel { get; set; }
        
        /// <value>
        /// The list of [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) for the network security groups (NSGs) to which this resource belongs. Setting this to an empty list removes all resources from all NSGs. For more information about NSGs, see [Security Rules](https://docs.cloud.oracle.com/Content/Network/Concepts/securityrules.htm).
        /// **NsgIds restrictions:**
        /// - A network security group (NSG) is optional for Autonomous Databases with private access. The nsgIds list can be empty.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
        
        /// <value>
        /// Customer Contacts. Setting this to an empty list removes all customer contacts of an Oracle Autonomous Database.
        /// </value>
        [JsonProperty(PropertyName = "customerContacts")]
        public System.Collections.Generic.List<CustomerContact> CustomerContacts { get; set; }
        
        /// <value>
        /// Indicates whether the Autonomous Database requires mTLS connections.
        /// </value>
        [JsonProperty(PropertyName = "isMtlsConnectionRequired")]
        public System.Nullable<bool> IsMtlsConnectionRequired { get; set; }
        
        /// <value>
        /// list of scheduled operations
        /// </value>
        [JsonProperty(PropertyName = "scheduledOperations")]
        public System.Collections.Generic.List<ScheduledOperationDetails> ScheduledOperations { get; set; }
        
        /// <value>
        /// Indicates if auto scaling is enabled for the Autonomous Database storage. The default value is `FALSE`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAutoScalingForStorageEnabled")]
        public System.Nullable<bool> IsAutoScalingForStorageEnabled { get; set; }
        
        /// <value>
        /// The number of Max OCPU cores to be made available to the autonomous database with auto scaling of cpu enabled.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maxCpuCoreCount")]
        public System.Nullable<int> MaxCpuCoreCount { get; set; }
        
        /// <value>
        /// The Oracle Database Edition that applies to the Autonomous databases.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "databaseEdition")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AutonomousDatabaseSummary.DatabaseEditionEnum> DatabaseEdition { get; set; }
        
    }
}
