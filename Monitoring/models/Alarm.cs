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


namespace Oci.MonitoringService.Models
{
    /// <summary>
    /// The properties that define an alarm.
    /// For information about alarms, see [Alarms Overview](https://docs.cloud.oracle.com/iaas/Content/Monitoring/Concepts/monitoringoverview.htm#AlarmsOverview).
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you're not authorized,
    /// talk to an administrator. If you're an administrator who needs to write policies to give users access, see
    /// [Getting Started with Policies](https://docs.cloud.oracle.com/iaas/Content/Identity/Concepts/policygetstarted.htm).
    /// <br/>
    /// For information about endpoints and signing API requests, see
    /// [About the API](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm). For information about available SDKs and tools, see
    /// [SDKS and Other Tools](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/sdks.htm).
    /// 
    /// </summary>
    public class Alarm 
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
        /// A user-friendly name for the alarm. It does not have to be unique, and it's changeable.
        /// <br/>
        /// This name is sent as the title for notifications related to this alarm.
        /// <br/>
        /// Example: High CPU Utilization
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment containing the alarm.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment containing the metric
        /// being evaluated by the alarm.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MetricCompartmentId is required.")]
        [JsonProperty(PropertyName = "metricCompartmentId")]
        public string MetricCompartmentId { get; set; }
        
        /// <value>
        /// When true, the alarm evaluates metrics from all compartments and subcompartments. The parameter can
        /// only be set to true when metricCompartmentId is the tenancy OCID (the tenancy is the root compartment).
        /// A true value requires the user to have tenancy-level permissions. If this requirement is not met,
        /// then the call is rejected. When false, the alarm evaluates metrics from only the compartment specified
        /// in metricCompartmentId. Default is false.
        /// <br/>
        /// Example: true
        /// </value>
        [JsonProperty(PropertyName = "metricCompartmentIdInSubtree")]
        public System.Nullable<bool> MetricCompartmentIdInSubtree { get; set; }
        
        /// <value>
        /// The source service or application emitting the metric that is evaluated by the alarm.
        /// <br/>
        /// Example: oci_computeagent
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Namespace is required.")]
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }
        
        /// <value>
        /// Resource group to match for metric data retrieved by the alarm. A resource group is a custom string that you can match when retrieving custom metrics. Only one resource group can be applied per metric.
        /// A valid resourceGroup value starts with an alphabetical character and includes only alphanumeric characters, periods (.), underscores (_), hyphens (-), and dollar signs ($).
        /// <br/>
        /// Example: frontend-fleet
        /// </value>
        [JsonProperty(PropertyName = "resourceGroup")]
        public string ResourceGroup { get; set; }
        
        /// <value>
        /// The Monitoring Query Language (MQL) expression to evaluate for the alarm. The Alarms feature of
        /// the Monitoring service interprets results for each returned time series as Boolean values,
        /// where zero represents false and a non-zero value represents true. A true value means that the trigger
        /// rule condition has been met. The query must specify a metric, statistic, interval, and trigger
        /// rule (threshold or absence). Supported values for interval depend on the specified time range. More
        /// interval values are supported for smaller time ranges. You can optionally
        /// specify dimensions and grouping functions. Supported grouping functions: `grouping()`, `groupBy()`.
        /// For details about Monitoring Query Language (MQL), see [Monitoring Query Language (MQL) Reference](https://docs.cloud.oracle.com/iaas/Content/Monitoring/Reference/mql.htm).
        /// For available dimensions, review the metric definition for the supported service.
        /// See [Supported Services](https://docs.cloud.oracle.com/iaas/Content/Monitoring/Concepts/monitoringoverview.htm#SupportedServices).
        /// <br/>
        /// Example of threshold alarm:
        /// <br/>
        ///   -----
        /// <br/>
        ///     CpuUtilization[1m]{availabilityDomain=\"cumS:PHX-AD-1\"}.groupBy(availabilityDomain).percentile(0.9) > 85
        /// <br/>
        ///   -----
        /// <br/>
        /// Example of absence alarm:
        /// <br/>
        ///   -----
        /// <br/>
        ///     CpuUtilization[1m]{availabilityDomain=\"cumS:PHX-AD-1\"}.absent()
        /// <br/>
        ///   -----
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Query is required.")]
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }
        
        /// <value>
        /// The time between calculated aggregation windows for the alarm. Supported value: `1m`
        /// 
        /// </value>
        [JsonProperty(PropertyName = "resolution")]
        public string Resolution { get; set; }
        
        /// <value>
        /// The period of time that the condition defined in the alarm must persist before the alarm state
        /// changes from \"OK\" to \"FIRING\". For example, a value of 5 minutes means that the
        /// alarm must persist in breaching the condition for five minutes before the alarm updates its
        /// state to \"FIRING\".
        /// <br/>
        /// The duration is specified as a string in ISO 8601 format (`PT10M` for ten minutes or `PT1H`
        /// for one hour). Minimum: PT1M. Maximum: PT1H. Default: PT1M.
        /// <br/>
        /// Under the default value of PT1M, the first evaluation that breaches the alarm updates the
        /// state to \"FIRING\".
        /// <br/>
        /// The alarm updates its status to \"OK\" when the breaching condition has been clear for
        /// the most recent minute.
        /// <br/>
        /// Example: PT5M
        /// </value>
        [JsonProperty(PropertyName = "pendingDuration")]
        public string PendingDuration { get; set; }
                ///
        /// <value>
        /// The perceived type of response required when the alarm is in the \"FIRING\" state.
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
        /// The perceived type of response required when the alarm is in the \"FIRING\" state.
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
        /// The human-readable content of the notification delivered. Oracle recommends providing guidance
        /// to operators for resolving the alarm condition. Consider adding links to standard runbook
        /// practices.
        /// <br/>
        /// Example: High CPU usage alert. Follow runbook instructions for resolution.
        /// </value>
        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }
                ///
        /// <value>
        /// The format to use for notification messages sent from this alarm. The formats are:
        /// * `RAW` - Raw JSON blob. Default value.
        /// * `PRETTY_JSON`: JSON with new lines and indents.
        /// * `ONS_OPTIMIZED`: Simplified, user-friendly layout. Applies only to messages sent through the Notifications service to the following subscription types: Email.
        /// 
        /// </value>
        ///
        public enum MessageFormatEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "RAW")]
            Raw,
            [EnumMember(Value = "PRETTY_JSON")]
            PrettyJson,
            [EnumMember(Value = "ONS_OPTIMIZED")]
            OnsOptimized
        };

        /// <value>
        /// The format to use for notification messages sent from this alarm. The formats are:
        /// * `RAW` - Raw JSON blob. Default value.
        /// * `PRETTY_JSON`: JSON with new lines and indents.
        /// * `ONS_OPTIMIZED`: Simplified, user-friendly layout. Applies only to messages sent through the Notifications service to the following subscription types: Email.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "messageFormat")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MessageFormatEnum> MessageFormat { get; set; }
        
        /// <value>
        /// A list of destinations to which the notifications for this alarm will be delivered.
        /// Each destination is represented by an [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) related to the supported destination service.
        /// For example, a destination using the Notifications service is represented by a topic OCID.
        /// Supported destination services: Notifications Service. Limit: One destination per supported destination service.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Destinations is required.")]
        [JsonProperty(PropertyName = "destinations")]
        public System.Collections.Generic.List<string> Destinations { get; set; }
        
        /// <value>
        /// The frequency at which notifications are re-submitted, if the alarm keeps firing without
        /// interruption. Format defined by ISO 8601. For example, `PT4H` indicates four hours.
        /// Minimum: PT1M. Maximum: P30D.
        /// <br/>
        /// Default value: null (notifications are not re-submitted).
        /// <br/>
        /// Example: PT2H
        /// </value>
        [JsonProperty(PropertyName = "repeatNotificationDuration")]
        public string RepeatNotificationDuration { get; set; }
        
        /// <value>
        /// The configuration details for suppressing an alarm.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "suppression")]
        public Suppression Suppression { get; set; }
        
        /// <value>
        /// Whether the alarm is enabled.
        /// <br/>
        /// Example: true
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsEnabled is required.")]
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Usage of predefined tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
                ///
        /// <value>
        /// The current lifecycle state of the alarm.
        /// <br/>
        /// Example: DELETED
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted
        };

        /// <value>
        /// The current lifecycle state of the alarm.
        /// <br/>
        /// Example: DELETED
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time the alarm was created. Format defined by RFC3339.
        /// <br/>
        /// Example: 2019-02-01T01:02:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the alarm was last updated. Format defined by RFC3339.
        /// <br/>
        /// Example: 2019-02-03T01:02:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
    }
}
