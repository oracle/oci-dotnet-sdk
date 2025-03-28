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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The summary of a specific User.
    /// </summary>
    public class UserSummary 
    {
        
        /// <value>
        /// The name of the User.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
                ///
        /// <value>
        /// The status of the user account.
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "OPEN")]
            Open,
            [EnumMember(Value = "EXPIRED")]
            Expired,
            [EnumMember(Value = "EXPIRED_GRACE")]
            ExpiredGrace,
            [EnumMember(Value = "LOCKED")]
            Locked,
            [EnumMember(Value = "LOCKED_TIMED")]
            LockedTimed,
            [EnumMember(Value = "EXPIRED_AND_LOCKED")]
            ExpiredAndLocked,
            [EnumMember(Value = "EXPIRED_GRACE_AND_LOCKED")]
            ExpiredGraceAndLocked,
            [EnumMember(Value = "EXPIRED_AND_LOCKED_TIMED")]
            ExpiredAndLockedTimed,
            [EnumMember(Value = "EXPIRED_GRACE_AND_LOCKED_TIMED")]
            ExpiredGraceAndLockedTimed,
            [EnumMember(Value = "OPEN_AND_IN_ROLLOVER")]
            OpenAndInRollover,
            [EnumMember(Value = "EXPIRED_AND_IN_ROLLOVER")]
            ExpiredAndInRollover,
            [EnumMember(Value = "LOCKED_AND_IN_ROLLOVER")]
            LockedAndInRollover,
            [EnumMember(Value = "EXPIRED_AND_LOCKED_AND_IN_ROLLOVER")]
            ExpiredAndLockedAndInRollover,
            [EnumMember(Value = "LOCKED_TIMED_AND_IN_ROLLOVER")]
            LockedTimedAndInRollover,
            [EnumMember(Value = "EXPIRED_AND_LOCKED_TIMED_AND_IN_ROL")]
            ExpiredAndLockedTimedAndInRol
        };

        /// <value>
        /// The status of the user account.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// The date and time of the expiration of the user account.
        /// </value>
        [JsonProperty(PropertyName = "timeExpiring")]
        public System.Nullable<System.DateTime> TimeExpiring { get; set; }
        
        /// <value>
        /// The default tablespace for data.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DefaultTablespace is required.")]
        [JsonProperty(PropertyName = "defaultTablespace")]
        public string DefaultTablespace { get; set; }
        
        /// <value>
        /// The name of the default tablespace for temporary tables or the name of a tablespace group.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TempTablespace is required.")]
        [JsonProperty(PropertyName = "tempTablespace")]
        public string TempTablespace { get; set; }
        
        /// <value>
        /// The date and time the user was created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date the account was locked, if the status of the account is LOCKED.
        /// </value>
        [JsonProperty(PropertyName = "timeLocked")]
        public System.Nullable<System.DateTime> TimeLocked { get; set; }
        
        /// <value>
        /// The profile name of the user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Profile is required.")]
        [JsonProperty(PropertyName = "profile")]
        public string Profile { get; set; }
        
    }
}
