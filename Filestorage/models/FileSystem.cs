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


namespace Oci.FilestorageService.Models
{
    /// <summary>
    /// An NFS file system. To allow access to a file system, add it
    /// to an export set and associate the export set with a mount
    /// target. The same file system can be in multiple export sets and
    /// associated with multiple mount targets.
    /// <br/>
    /// To use any of the API operations, you must be authorized in an
    /// IAM policy. If you're not authorized, talk to an
    /// administrator. If you're an administrator who needs to write
    /// policies to give users access, see [Getting Started with
    /// Policies](https://docs.cloud.oracle.com/Content/Identity/Concepts/policygetstarted.htm).
    /// 
    /// </summary>
    public class FileSystem 
    {
        
        /// <value>
        /// The availability domain the file system is in. May be unset
        /// as a blank or NULL value.
        /// <br/>
        /// Example: Uocm:PHX-AD-1
        /// </value>
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The number of bytes consumed by the file system, including
        /// any snapshots. This number reflects the metered size of the file
        /// system and is updated asynchronously with respect to
        /// updates to the file system.
        /// For more information, see [File System Usage and Metering](https://docs.cloud.oracle.com/Content/File/Concepts/FSutilization.htm).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MeteredBytes is required.")]
        [JsonProperty(PropertyName = "meteredBytes")]
        public System.Nullable<long> MeteredBytes { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment that contains the file system.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A user-friendly name. It does not have to be unique, and it is changeable.
        /// Avoid entering confidential information.
        /// <br/>
        /// Example: My file system
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the file system.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
                ///
        /// <value>
        /// The current state of the file system.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current state of the file system.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time the file system was created, expressed in
        /// [RFC 3339](https://tools.ietf.org/rfc/rfc3339) timestamp format.
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair
        ///  with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// System tags for this resource.
        /// System tags are applied to resources by internal OCI services.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the KMS key which is the master encryption key for the file system.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyId")]
        public string KmsKeyId { get; set; }
        
        [JsonProperty(PropertyName = "sourceDetails")]
        public SourceDetails SourceDetails { get; set; }
        
        /// <value>
        /// Specifies whether the file system has been cloned.
        /// See [Cloning a File System](https://docs.cloud.oracle.com/iaas/Content/File/Tasks/cloningFS.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isCloneParent")]
        public System.Nullable<bool> IsCloneParent { get; set; }
        
        /// <value>
        /// Specifies whether the data has finished copying from the source to the clone.
        /// Hydration can take up to several hours to complete depending on the size of the source.
        /// The source and clone remain available during hydration, but there may be some performance impact.
        /// See [Cloning a File System](https://docs.cloud.oracle.com/iaas/Content/File/Tasks/cloningFS.htm#hydration).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isHydrated")]
        public System.Nullable<bool> IsHydrated { get; set; }
        
        /// <value>
        /// Specifies the total number of children of a file system.
        /// </value>
        [JsonProperty(PropertyName = "cloneCount")]
        public System.Nullable<int> CloneCount { get; set; }
                ///
        /// <value>
        /// Specifies whether the file system is attached to its parent file system.
        /// </value>
        ///
        public enum CloneAttachStatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ATTACHED")]
            Attached,
            [EnumMember(Value = "DETACHING")]
            Detaching,
            [EnumMember(Value = "DETACHED")]
            Detached
        };

        /// <value>
        /// Specifies whether the file system is attached to its parent file system.
        /// </value>
        [JsonProperty(PropertyName = "cloneAttachStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CloneAttachStatusEnum> CloneAttachStatus { get; set; }
        
        /// <value>
        /// Locks associated with this resource.
        /// </value>
        [JsonProperty(PropertyName = "locks")]
        public System.Collections.Generic.List<ResourceLock> Locks { get; set; }
        
        /// <value>
        /// Additional information about the current 'lifecycleState'.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// Specifies whether the file system can be used as a target file system for replication. The system sets this value to `true` if the file system is unexported, hasn't yet been specified as a target file system in any replication resource, and has no user snapshots. After the file system has been specified as a target in a replication, or if the file system contains user snapshots, the system sets this value to `false`.
        /// For more information, see [Using Replication](https://docs.cloud.oracle.com/iaas/Content/File/Tasks/using-replication.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isTargetable")]
        public System.Nullable<bool> IsTargetable { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the replication target associated with the file system.
        /// Empty if the file system is not being used as target in a replication.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "replicationTargetId")]
        public string ReplicationTargetId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the associated file system snapshot policy, which
        /// controls the frequency of snapshot creation and retention period of the taken snapshots.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "filesystemSnapshotPolicyId")]
        public string FilesystemSnapshotPolicyId { get; set; }
        
    }
}
