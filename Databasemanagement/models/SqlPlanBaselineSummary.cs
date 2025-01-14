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
    /// The summary of a SQL plan baseline.
    /// </summary>
    public class SqlPlanBaselineSummary 
    {
        
        /// <value>
        /// The unique plan identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PlanName is required.")]
        [JsonProperty(PropertyName = "planName")]
        public string PlanName { get; set; }
        
        /// <value>
        /// The unique SQL identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SqlHandle is required.")]
        [JsonProperty(PropertyName = "sqlHandle")]
        public string SqlHandle { get; set; }
        
        /// <value>
        /// The SQL text (truncated to the first 50 characters).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SqlText is required.")]
        [JsonProperty(PropertyName = "sqlText")]
        public string SqlText { get; set; }
        
        /// <value>
        /// The origin of the SQL plan baseline.
        /// </value>
        [JsonProperty(PropertyName = "origin")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SqlPlanBaselineOrigin> Origin { get; set; }
        
        /// <value>
        /// The date and time when the plan baseline was created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time when the plan baseline was last modified.
        /// </value>
        [JsonProperty(PropertyName = "timeLastModified")]
        public System.Nullable<System.DateTime> TimeLastModified { get; set; }
        
        /// <value>
        /// The date and time when the plan baseline was last executed.
        /// <br/>
        /// **Note:** For performance reasons, database does not update this value
        /// immediately after each execution of the plan baseline. Therefore, the plan
        /// baseline may have been executed more recently than this value indicates.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeLastExecuted")]
        public System.Nullable<System.DateTime> TimeLastExecuted { get; set; }
                ///
        /// <value>
        /// Indicates whether the plan baseline is enabled (`YES`) or disabled (`NO`).
        /// </value>
        ///
        public enum EnabledEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "YES")]
            Yes,
            [EnumMember(Value = "NO")]
            No
        };

        /// <value>
        /// Indicates whether the plan baseline is enabled (`YES`) or disabled (`NO`).
        /// </value>
        [JsonProperty(PropertyName = "enabled")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<EnabledEnum> Enabled { get; set; }
                ///
        /// <value>
        /// Indicates whether the plan baseline is accepted (`YES`) or not (`NO`).
        /// </value>
        ///
        public enum AcceptedEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "YES")]
            Yes,
            [EnumMember(Value = "NO")]
            No
        };

        /// <value>
        /// Indicates whether the plan baseline is accepted (`YES`) or not (`NO`).
        /// </value>
        [JsonProperty(PropertyName = "accepted")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AcceptedEnum> Accepted { get; set; }
                ///
        /// <value>
        /// Indicates whether the plan baseline is fixed (`YES`) or not (`NO`).
        /// </value>
        ///
        public enum FixedEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "YES")]
            Yes,
            [EnumMember(Value = "NO")]
            No
        };

        /// <value>
        /// Indicates whether the plan baseline is fixed (`YES`) or not (`NO`).
        /// </value>
        [JsonProperty(PropertyName = "fixed")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<FixedEnum> Fixed { get; set; }
                ///
        /// <value>
        /// Indicates whether the optimizer was able to reproduce the plan (`YES`) or not (`NO`).
        /// The value is set to `YES` when a plan is initially added to the plan baseline.
        /// 
        /// </value>
        ///
        public enum ReproducedEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "YES")]
            Yes,
            [EnumMember(Value = "NO")]
            No
        };

        /// <value>
        /// Indicates whether the optimizer was able to reproduce the plan (`YES`) or not (`NO`).
        /// The value is set to `YES` when a plan is initially added to the plan baseline.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "reproduced")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ReproducedEnum> Reproduced { get; set; }
                ///
        /// <value>
        /// Indicates whether the plan baseline is auto-purged (`YES`) or not (`NO`).
        /// </value>
        ///
        public enum AutoPurgeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "YES")]
            Yes,
            [EnumMember(Value = "NO")]
            No
        };

        /// <value>
        /// Indicates whether the plan baseline is auto-purged (`YES`) or not (`NO`).
        /// </value>
        [JsonProperty(PropertyName = "autoPurge")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AutoPurgeEnum> AutoPurge { get; set; }
                ///
        /// <value>
        /// Indicates whether a plan that is automatically captured by SQL plan management is marked adaptive or not.
        /// <br/>
        /// When a new adaptive plan is found for a SQL statement that has an existing SQL plan baseline, that new plan
        /// will be added to the SQL plan baseline as an unaccepted plan, and the `ADAPTIVE` property will be marked `YES`.
        /// When this new plan is verified (either manually or via the auto evolve task), the plan will be test executed
        /// and the final plan determined at execution will become an accepted plan if its performance is better than
        /// the existing plan baseline. At this point, the value of the `ADAPTIVE` property is set to `NO` since the plan
        /// is no longer adaptive, but resolved.
        /// 
        /// </value>
        ///
        public enum AdaptiveEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "YES")]
            Yes,
            [EnumMember(Value = "NO")]
            No
        };

        /// <value>
        /// Indicates whether a plan that is automatically captured by SQL plan management is marked adaptive or not.
        /// <br/>
        /// When a new adaptive plan is found for a SQL statement that has an existing SQL plan baseline, that new plan
        /// will be added to the SQL plan baseline as an unaccepted plan, and the `ADAPTIVE` property will be marked `YES`.
        /// When this new plan is verified (either manually or via the auto evolve task), the plan will be test executed
        /// and the final plan determined at execution will become an accepted plan if its performance is better than
        /// the existing plan baseline. At this point, the value of the `ADAPTIVE` property is set to `NO` since the plan
        /// is no longer adaptive, but resolved.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "adaptive")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AdaptiveEnum> Adaptive { get; set; }
        
    }
}
