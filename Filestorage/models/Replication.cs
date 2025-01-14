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
    /// Replications are the primary resource that governs the policy of cross-region replication between source
    /// and target file systems. Replications are associated with a secondary resource called a {@link ReplicationTarget}
    /// located in another availability domain in the same or different region.
    /// The replication retrieves the delta of data between two snapshots of a source file system
    /// and sends it to the associated `ReplicationTarget`, which applies it to the target
    /// file system. For more information, see [File System Replication](https://docs.cloud.oracle.com/iaas/Content/File/Tasks/FSreplication.htm).
    /// 
    /// </summary>
    public class Replication 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment that contains the replication.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The availability domain that contains the replication. May be unset as a blank or `NULL` value.
        /// Example: Uocm:PHX-AD-2
        /// </value>
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the replication.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
                ///
        /// <value>
        /// The current lifecycle state of the replication.
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
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current lifecycle state of the replication.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// A user-friendly name. It does not have to be unique, and it is changeable.
        /// Avoid entering confidential information.
        /// <br/>
        /// Example: My replication
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The date and time the replication was created
        /// in [RFC 3339](https://tools.ietf.org/rfc/rfc3339) timestamp format.
        /// <br/>
        /// Example: 2021-01-04T20:01:29.100Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the source file system.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceId is required.")]
        [JsonProperty(PropertyName = "sourceId")]
        public string SourceId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the target file system.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetId is required.")]
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the {@link ReplicationTarget}.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ReplicationTargetId is required.")]
        [JsonProperty(PropertyName = "replicationTargetId")]
        public string ReplicationTargetId { get; set; }
        
        /// <value>
        /// Duration in minutes between replication snapshots.
        /// </value>
        [JsonProperty(PropertyName = "replicationInterval")]
        public System.Nullable<long> ReplicationInterval { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the last snapshot that has been replicated completely.
        /// Empty if the copy of the initial snapshot is not complete.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lastSnapshotId")]
        public string LastSnapshotId { get; set; }
        
        /// <value>
        /// The {@link #snapshotTime(SnapshotTimeRequest) snapshotTime} of the most recent recoverable replication snapshot
        /// in [RFC 3339](https://tools.ietf.org/rfc/rfc3339) timestamp format.
        /// Example: 2021-04-04T20:01:29.100Z
        /// </value>
        [JsonProperty(PropertyName = "recoveryPointTime")]
        public System.Nullable<System.DateTime> RecoveryPointTime { get; set; }
                ///
        /// <value>
        /// The current state of the snapshot during replication operations.
        /// </value>
        ///
        public enum DeltaStatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "IDLE")]
            Idle,
            [EnumMember(Value = "CAPTURING")]
            Capturing,
            [EnumMember(Value = "APPLYING")]
            Applying,
            [EnumMember(Value = "SERVICE_ERROR")]
            ServiceError,
            [EnumMember(Value = "USER_ERROR")]
            UserError,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "TRANSFERRING")]
            Transferring
        };

        /// <value>
        /// The current state of the snapshot during replication operations.
        /// </value>
        [JsonProperty(PropertyName = "deltaStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DeltaStatusEnum> DeltaStatus { get; set; }
        
        /// <value>
        /// Additional information about the current 'lifecycleState'.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// Percentage progress of the current replication cycle.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "deltaProgress")]
        public System.Nullable<long> DeltaProgress { get; set; }
        
        /// <value>
        /// Locks associated with this resource.
        /// </value>
        [JsonProperty(PropertyName = "locks")]
        public System.Collections.Generic.List<ResourceLock> Locks { get; set; }
        
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
        
    }
}
