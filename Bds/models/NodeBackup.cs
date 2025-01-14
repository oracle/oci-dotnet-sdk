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


namespace Oci.BdsService.Models
{
    /// <summary>
    /// The information about the Node's backup.
    /// </summary>
    public class NodeBackup 
    {
        
        /// <value>
        /// The id of the node backup.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// BDS generated name for the backup. Format is nodeHostName_timeCreated
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The instance OCID of the node, which is the resource from which the node backup was acquired.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NodeInstanceId is required.")]
        [JsonProperty(PropertyName = "nodeInstanceId")]
        public string NodeInstanceId { get; set; }
        
        /// <value>
        /// Host name of the node to which this backup belongs.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NodeHostName is required.")]
        [JsonProperty(PropertyName = "nodeHostName")]
        public string NodeHostName { get; set; }
                ///
        /// <value>
        /// type based on how backup action was initiated.
        /// </value>
        ///
        public enum BackupTriggerTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "MANUAL")]
            Manual,
            [EnumMember(Value = "SCHEDULED")]
            Scheduled
        };

        /// <value>
        /// type based on how backup action was initiated.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BackupTriggerType is required.")]
        [JsonProperty(PropertyName = "backupTriggerType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<BackupTriggerTypeEnum> BackupTriggerType { get; set; }
        
        /// <value>
        /// The ID of the nodeBackupConfiguration if the NodeBackup is automatically created by applying the configuration.
        /// </value>
        [JsonProperty(PropertyName = "nodeBackupConfigId")]
        public string NodeBackupConfigId { get; set; }
                ///
        /// <value>
        /// Incremental backup type includes only the changes since the last backup. Full backup type includes all changes since the volume was created.
        /// </value>
        ///
        public enum BackupTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "FULL")]
            Full,
            [EnumMember(Value = "INCREMENTAL")]
            Incremental
        };

        /// <value>
        /// Incremental backup type includes only the changes since the last backup. Full backup type includes all changes since the volume was created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BackupType is required.")]
        [JsonProperty(PropertyName = "backupType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<BackupTypeEnum> BackupType { get; set; }
                ///
        /// <value>
        /// The state of the NodeBackup.
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
            Failed,
            [EnumMember(Value = "PARTIAL")]
            Partial
        };

        /// <value>
        /// The state of the NodeBackup.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The time the cluster was created, shown as an RFC 3339 formatted datetime string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
    }
}
