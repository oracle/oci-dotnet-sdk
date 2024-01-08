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
    /// Configurations of a Disaster Recovery.
    /// </summary>
    public class DisasterRecoveryConfiguration 
    {
                ///
        /// <value>
        /// Indicates the disaster recovery (DR) type of the Autonomous Database Serverless instance.
        /// Autonomous Data Guard (ADG) DR type provides business critical DR with a faster recovery time objective (RTO) during failover or switchover.
        /// Backup-based DR type provides lower cost DR with a slower RTO during failover or switchover.
        /// 
        /// </value>
        ///
        public enum DisasterRecoveryTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ADG")]
            Adg,
            [EnumMember(Value = "BACKUP_BASED")]
            BackupBased
        };

        /// <value>
        /// Indicates the disaster recovery (DR) type of the Autonomous Database Serverless instance.
        /// Autonomous Data Guard (ADG) DR type provides business critical DR with a faster recovery time objective (RTO) during failover or switchover.
        /// Backup-based DR type provides lower cost DR with a slower RTO during failover or switchover.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "disasterRecoveryType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DisasterRecoveryTypeEnum> DisasterRecoveryType { get; set; }
        
        /// <value>
        /// Time and date stored as an RFC 3339 formatted timestamp string. For example, 2022-01-01T12:00:00.000Z would set a limit for the snapshot standby to be converted back to a cross-region standby database.
        /// </value>
        [JsonProperty(PropertyName = "timeSnapshotStandbyEnabledTill")]
        public System.Nullable<System.DateTime> TimeSnapshotStandbyEnabledTill { get; set; }
        
        /// <value>
        /// Indicates if user wants to convert to a snapshot standby. For example, true would set a standby database to snapshot standby database. False would set a snapshot standby database back to regular standby database.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSnapshotStandby")]
        public System.Nullable<bool> IsSnapshotStandby { get; set; }
        
    }
}
