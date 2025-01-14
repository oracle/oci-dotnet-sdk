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
    /// Backup destination details.
    /// </summary>
    public class BackupDestination 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the backup destination.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The user-provided name of the backup destination.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
                ///
        /// <value>
        /// Type of the backup destination.
        /// </value>
        ///
        public enum TypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NFS")]
            Nfs,
            [EnumMember(Value = "RECOVERY_APPLIANCE")]
            RecoveryAppliance
        };

        /// <value>
        /// Type of the backup destination.
        /// </value>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        /// <value>
        /// List of databases associated with the backup destination.
        /// </value>
        [JsonProperty(PropertyName = "associatedDatabases")]
        public System.Collections.Generic.List<AssociatedDatabaseDetails> AssociatedDatabases { get; set; }
        
        /// <value>
        /// For a RECOVERY_APPLIANCE backup destination, the connection string for connecting to the Recovery Appliance.
        /// </value>
        [JsonProperty(PropertyName = "connectionString")]
        public string ConnectionString { get; set; }
        
        /// <value>
        /// For a RECOVERY_APPLIANCE backup destination, the Virtual Private Catalog (VPC) users that are used to access the Recovery Appliance.
        /// </value>
        [JsonProperty(PropertyName = "vpcUsers")]
        public System.Collections.Generic.List<string> VpcUsers { get; set; }
        
        /// <value>
        /// The local directory path on each VM cluster node where the NFS server location is mounted. The local directory path and the NFS server location must each be the same across all of the VM cluster nodes. Ensure that the NFS mount is maintained continuously on all of the VM cluster nodes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "localMountPointPath")]
        public string LocalMountPointPath { get; set; }
                ///
        /// <value>
        /// NFS Mount type for backup destination.
        /// </value>
        ///
        public enum NfsMountTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SELF_MOUNT")]
            SelfMount,
            [EnumMember(Value = "AUTOMATED_MOUNT")]
            AutomatedMount
        };

        /// <value>
        /// NFS Mount type for backup destination.
        /// </value>
        [JsonProperty(PropertyName = "nfsMountType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<NfsMountTypeEnum> NfsMountType { get; set; }
        
        /// <value>
        /// Host names or IP addresses for NFS Auto mount.
        /// </value>
        [JsonProperty(PropertyName = "nfsServer")]
        public System.Collections.Generic.List<string> NfsServer { get; set; }
        
        /// <value>
        /// Specifies the directory on which to mount the file system
        /// </value>
        [JsonProperty(PropertyName = "nfsServerExport")]
        public string NfsServerExport { get; set; }
                ///
        /// <value>
        /// The current lifecycle state of the backup destination.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "DELETED")]
            Deleted
        };

        /// <value>
        /// The current lifecycle state of the backup destination.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time the backup destination was created.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// A descriptive text associated with the lifecycleState.
        /// Typically contains additional displayable text
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
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
        
    }
}
