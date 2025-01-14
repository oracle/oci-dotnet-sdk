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
    /// Autonomous Data Guard standby database details.
    /// 
    /// </summary>
    public class AutonomousDatabaseStandbySummary 
    {
        
        /// <value>
        /// The amount of time, in seconds, that the data of the standby database lags the data of the primary database. Can be used to determine the potential data loss in the event of a failover.
        /// </value>
        [JsonProperty(PropertyName = "lagTimeInSeconds")]
        public System.Nullable<int> LagTimeInSeconds { get; set; }
                ///
        /// <value>
        /// The current state of the Autonomous Database.
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
            [EnumMember(Value = "STOPPING")]
            Stopping,
            [EnumMember(Value = "STOPPED")]
            Stopped,
            [EnumMember(Value = "STARTING")]
            Starting,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "UNAVAILABLE")]
            Unavailable,
            [EnumMember(Value = "RESTORE_IN_PROGRESS")]
            RestoreInProgress,
            [EnumMember(Value = "RESTORE_FAILED")]
            RestoreFailed,
            [EnumMember(Value = "BACKUP_IN_PROGRESS")]
            BackupInProgress,
            [EnumMember(Value = "SCALE_IN_PROGRESS")]
            ScaleInProgress,
            [EnumMember(Value = "AVAILABLE_NEEDS_ATTENTION")]
            AvailableNeedsAttention,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "MAINTENANCE_IN_PROGRESS")]
            MaintenanceInProgress,
            [EnumMember(Value = "RESTARTING")]
            Restarting,
            [EnumMember(Value = "RECREATING")]
            Recreating,
            [EnumMember(Value = "ROLE_CHANGE_IN_PROGRESS")]
            RoleChangeInProgress,
            [EnumMember(Value = "UPGRADING")]
            Upgrading,
            [EnumMember(Value = "INACCESSIBLE")]
            Inaccessible,
            [EnumMember(Value = "STANDBY")]
            Standby
        };

        /// <value>
        /// The current state of the Autonomous Database.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Additional information about the current lifecycle state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The date and time the Autonomous Data Guard role was switched for the standby Autonomous Database.
        /// </value>
        [JsonProperty(PropertyName = "timeDataGuardRoleChanged")]
        public System.Nullable<System.DateTime> TimeDataGuardRoleChanged { get; set; }
        
        /// <value>
        /// The date and time the Disaster Recovery role was switched for the standby Autonomous Database.
        /// </value>
        [JsonProperty(PropertyName = "timeDisasterRecoveryRoleChanged")]
        public System.Nullable<System.DateTime> TimeDisasterRecoveryRoleChanged { get; set; }
        
        /// <value>
        /// The availability domain of a local Autonomous Data Guard standby database of an Autonomous Database Serverless instance.
        /// </value>
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
    }
}
