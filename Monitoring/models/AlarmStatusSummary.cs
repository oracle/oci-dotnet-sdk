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


namespace Oci.MonitoringService.Models
{
    /// <summary>
    /// A summary of properties for the specified alarm and its current evaluation status.
    /// For information about alarms, see
    /// [Alarms Overview](https://docs.cloud.oracle.com/iaas/Content/Monitoring/Concepts/monitoringoverview.htm#AlarmsOverview).
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you're not authorized,
    /// talk to an administrator. If you're an administrator who needs to write policies to give users access, see
    /// [Getting Started with Policies](https://docs.cloud.oracle.com/iaas/Content/Identity/Concepts/policygetstarted.htm).
    /// <br/>
    /// For information about endpoints and signing API requests, see
    /// [About the API](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm).
    /// For information about available SDKs and tools, see
    /// [SDKS and Other Tools](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/sdks.htm).
    /// 
    /// </summary>
    public class AlarmStatusSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the alarm.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The configured name of the alarm.
        /// <br/>
        /// Example: High CPU Utilization
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
                ///
        /// <value>
        /// The configured severity of the alarm.
        /// <br/>
        /// Example: CRITICAL
        /// </value>
        ///
        public enum SeverityEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CRITICAL")]
            Critical,
            [EnumMember(Value = "ERROR")]
            Error,
            [EnumMember(Value = "WARNING")]
            Warning,
            [EnumMember(Value = "INFO")]
            Info
        };

        /// <value>
        /// The configured severity of the alarm.
        /// <br/>
        /// Example: CRITICAL
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Severity is required.")]
        [JsonProperty(PropertyName = "severity")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SeverityEnum> Severity { get; set; }
        
        /// <value>
        /// Timestamp for the transition of the alarm state. For example, the time when the alarm transitioned from OK to Firing.
        /// Note: A three-minute lag for this value accounts for any late-arriving metrics.
        /// <br/>
        /// Example: 2019-02-01T01:02:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimestampTriggered is required.")]
        [JsonProperty(PropertyName = "timestampTriggered")]
        public System.Nullable<System.DateTime> TimestampTriggered { get; set; }
                ///
        /// <value>
        /// The status of this alarm.
        /// Status is collective, across all metric streams in the alarm.
        /// To list alarm status for each metric stream, use {@link #retrieveDimensionStates(RetrieveDimensionStatesRequest) retrieveDimensionStates}.
        /// Example: FIRING
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "FIRING")]
            Firing,
            [EnumMember(Value = "OK")]
            Ok,
            [EnumMember(Value = "SUSPENDED")]
            Suspended
        };

        /// <value>
        /// The status of this alarm.
        /// Status is collective, across all metric streams in the alarm.
        /// To list alarm status for each metric stream, use {@link #retrieveDimensionStates(RetrieveDimensionStatesRequest) retrieveDimensionStates}.
        /// Example: FIRING
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// The configuration details for suppressing an alarm.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "suppression")]
        public Suppression Suppression { get; set; }
        
    }
}
