/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.ComputeinstanceagentService.Models
{
    /// <summary>
    /// Execution details for a command.
    /// </summary>
    public class InstanceAgentCommandExecutionSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the command.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstanceAgentCommandId is required.")]
        [JsonProperty(PropertyName = "instanceAgentCommandId")]
        public string InstanceAgentCommandId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the instance.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstanceId is required.")]
        [JsonProperty(PropertyName = "instanceId")]
        public string InstanceId { get; set; }
                ///
        /// <value>
        /// The command delivery state.
        ///  * `VISIBLE` - The command is visible to the instance.
        ///  * `PENDING` - The command is pending acknowledgment from the instance.
        ///  * `ACKED` - The command has been received and acknowledged by the instance.
        ///  * `ACKED_CANCELED` - The canceled command has been received and acknowledged by the instance.
        ///  * `EXPIRED` - The instance has not requested for commands and the command's delivery has expired.
        /// 
        /// </value>
        ///
        public enum DeliveryStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "VISIBLE")]
            Visible,
            [EnumMember(Value = "PENDING")]
            Pending,
            [EnumMember(Value = "ACKED")]
            Acked,
            [EnumMember(Value = "ACKED_CANCELED")]
            AckedCanceled,
            [EnumMember(Value = "EXPIRED")]
            Expired
        };

        /// <value>
        /// The command delivery state.
        ///  * `VISIBLE` - The command is visible to the instance.
        ///  * `PENDING` - The command is pending acknowledgment from the instance.
        ///  * `ACKED` - The command has been received and acknowledged by the instance.
        ///  * `ACKED_CANCELED` - The canceled command has been received and acknowledged by the instance.
        ///  * `EXPIRED` - The instance has not requested for commands and the command's delivery has expired.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DeliveryState is required.")]
        [JsonProperty(PropertyName = "deliveryState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DeliveryStateEnum> DeliveryState { get; set; }
                ///
        /// <value>
        /// The command execution lifecycle state.
        /// * `ACCEPTED` - The command has been accepted to run.
        /// * `IN_PROGRESS` - The command is in progress.
        /// * `SUCCEEDED` - The command was successfully executed.
        /// * `FAILED` - The command failed to execute.
        /// * `TIMED_OUT` - The command execution timed out.
        /// * `CANCELED` - The command execution was canceled.
        /// 
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ACCEPTED")]
            Accepted,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "TIMED_OUT")]
            TimedOut,
            [EnumMember(Value = "CANCELED")]
            Canceled
        };

        /// <value>
        /// The command execution lifecycle state.
        /// * `ACCEPTED` - The command has been accepted to run.
        /// * `IN_PROGRESS` - The command is in progress.
        /// * `SUCCEEDED` - The command was successfully executed.
        /// * `FAILED` - The command failed to execute.
        /// * `TIMED_OUT` - The command execution timed out.
        /// * `CANCELED` - The command execution was canceled.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time the command was created, in the format defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the command was last updated, in the format defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// A large, non-consecutive number that Oracle Cloud Agent assigns to each created command.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SequenceNumber is required.")]
        [JsonProperty(PropertyName = "sequenceNumber")]
        public System.Nullable<long> SequenceNumber { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The execution output from a command.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Content is required.")]
        [JsonProperty(PropertyName = "content")]
        public InstanceAgentCommandExecutionOutputContent Content { get; set; }
        
    }
}
