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


namespace Oci.StackmonitoringService.Models
{
    /// <summary>
    /// The Monitoring Template Alarm Condition.
    /// </summary>
    public class Condition 
    {
        
        /// <value>
        /// Severity - Critical/Warning
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Severity is required.")]
        [JsonProperty(PropertyName = "severity")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AlarmConditionSeverity> Severity { get; set; }
        
        /// <value>
        /// The Monitoring Query Language (MQL) expression to evaluate for the alarm.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Query is required.")]
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }
        
        /// <value>
        /// The human-readable content of the delivered alarm notification. Oracle recommends providing guidance to operators for resolving the alarm condition. Consider adding links to standard runbook practices. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }
        
        /// <value>
        /// Whether the note need to add into bottom of the body for mapping the alarms information with template or not.
        /// </value>
        [JsonProperty(PropertyName = "shouldAppendNote")]
        public System.Nullable<bool> ShouldAppendNote { get; set; }
        
        /// <value>
        /// Whether the URL need to add into bottom of the body for mapping the alarms information with template or not.
        /// </value>
        [JsonProperty(PropertyName = "shouldAppendUrl")]
        public System.Nullable<bool> ShouldAppendUrl { get; set; }
        
        /// <value>
        /// The period of time that the condition defined in the alarm must persist before the alarm state changes from \"OK\" to \"FIRING\".
        /// </value>
        [JsonProperty(PropertyName = "triggerDelay")]
        public string TriggerDelay { get; set; }
        
    }
}
