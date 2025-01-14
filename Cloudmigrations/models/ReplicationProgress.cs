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


namespace Oci.CloudmigrationsService.Models
{
    /// <summary>
    /// Progress of a migration asset's replication process.
    /// </summary>
    public class ReplicationProgress 
    {
        
        /// <value>
        /// Percentage of the current replication progress from 0 to 100.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Percentage is required.")]
        [JsonProperty(PropertyName = "percentage")]
        public System.Nullable<int> Percentage { get; set; }
                ///
        /// <value>
        /// Status of the current replication progress. It can be None or InProgress.
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NONE")]
            None,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress
        };

        /// <value>
        /// Status of the current replication progress. It can be None or InProgress.
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// Start time of the current replication process
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// Start time of the last replication process. It can be Completed or Failed.
        /// </value>
        [JsonProperty(PropertyName = "timeOflastReplicationStart")]
        public System.Nullable<System.DateTime> TimeOflastReplicationStart { get; set; }
        
        /// <value>
        /// End time of the last replication process. It can be Completed or Failed.
        /// </value>
        [JsonProperty(PropertyName = "timeOfLastReplicationEnd")]
        public System.Nullable<System.DateTime> TimeOfLastReplicationEnd { get; set; }
        
        /// <value>
        /// End time of the last successful replication process, which has been completed.
        /// </value>
        [JsonProperty(PropertyName = "timeOfLastReplicationSuccess")]
        public System.Nullable<System.DateTime> TimeOfLastReplicationSuccess { get; set; }
                ///
        /// <value>
        /// Status of the last replication task. It can be Completed or Failed.
        /// </value>
        ///
        public enum LastReplicationStatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NONE")]
            None,
            [EnumMember(Value = "COMPLETED")]
            Completed,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// Status of the last replication task. It can be Completed or Failed.
        /// </value>
        [JsonProperty(PropertyName = "lastReplicationStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LastReplicationStatusEnum> LastReplicationStatus { get; set; }
        
        /// <value>
        /// Error message if the last finished replication failed.
        /// </value>
        [JsonProperty(PropertyName = "lastReplicationError")]
        public string LastReplicationError { get; set; }
        
    }
}
