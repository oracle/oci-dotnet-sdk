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
    /// A maintenance update details for an Exadata VM cluster on Exascale Infrastructure.
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you're not authorized,
    /// talk to an administrator. If you're an administrator who needs to write policies to give users access,
    /// see [Getting Started with Policies](https://docs.cloud.oracle.com/Content/Identity/Concepts/policygetstarted.htm).
    /// 
    /// </summary>
    public class ExadbVmClusterUpdateSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the maintenance update.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Details of the maintenance update package.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Description is required.")]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
                ///
        /// <value>
        /// The previous update action performed.
        /// </value>
        ///
        public enum LastActionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ROLLING_APPLY")]
            RollingApply,
            [EnumMember(Value = "NON_ROLLING_APPLY")]
            NonRollingApply,
            [EnumMember(Value = "PRECHECK")]
            Precheck,
            [EnumMember(Value = "ROLLBACK")]
            Rollback
        };

        /// <value>
        /// The previous update action performed.
        /// </value>
        [JsonProperty(PropertyName = "lastAction")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LastActionEnum> LastAction { get; set; }
                ///
        ///
        public enum AvailableActionsEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ROLLING_APPLY")]
            RollingApply,
            [EnumMember(Value = "NON_ROLLING_APPLY")]
            NonRollingApply,
            [EnumMember(Value = "PRECHECK")]
            Precheck,
            [EnumMember(Value = "ROLLBACK")]
            Rollback
        };

        /// <value>
        /// The possible actions performed by the update operation on the infrastructure components.
        /// </value>
        [JsonProperty(PropertyName = "availableActions", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<AvailableActionsEnum> AvailableActions { get; set; }
                ///
        /// <value>
        /// The type of cloud VM cluster maintenance update.
        /// </value>
        ///
        public enum UpdateTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "GI_UPGRADE")]
            GiUpgrade,
            [EnumMember(Value = "GI_PATCH")]
            GiPatch,
            [EnumMember(Value = "OS_UPDATE")]
            OsUpdate
        };

        /// <value>
        /// The type of cloud VM cluster maintenance update.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UpdateType is required.")]
        [JsonProperty(PropertyName = "updateType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<UpdateTypeEnum> UpdateType { get; set; }
        
        /// <value>
        /// Descriptive text providing additional details about the lifecycle state.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
                ///
        /// <value>
        /// The current state of the maintenance update. Dependent on value of `lastAction`.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "SUCCESS")]
            Success,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current state of the maintenance update. Dependent on value of `lastAction`.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time the maintenance update was released.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeReleased is required.")]
        [JsonProperty(PropertyName = "timeReleased")]
        public System.Nullable<System.DateTime> TimeReleased { get; set; }
        
        /// <value>
        /// The version of the maintenance update package.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Version is required.")]
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
    }
}