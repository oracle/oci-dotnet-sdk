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


namespace Oci.ApmsyntheticsService.Models
{
    /// <summary>
    /// Details of the request body used to create a new monitor.
    /// </summary>
    public class CreateMonitorDetails 
    {
        
        /// <value>
        /// Unique name that can be edited. The name should not contain any confidential information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Type of monitor.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MonitorType is required.")]
        [JsonProperty(PropertyName = "monitorType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MonitorTypes> MonitorType { get; set; }
        
        /// <value>
        /// A list of public and dedicated vantage points from which to execute the monitor.
        /// Use /publicVantagePoints to fetch public vantage points, and /dedicatedVantagePoints to fetch dedicated vantage points.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VantagePoints is required.")]
        [JsonProperty(PropertyName = "vantagePoints")]
        public System.Collections.Generic.List<string> VantagePoints { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the script.
        /// scriptId is mandatory for creation of SCRIPTED_BROWSER and SCRIPTED_REST monitor types. For other monitor types, it should be set to null.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "scriptId")]
        public string ScriptId { get; set; }
        
        /// <value>
        /// Enables or disables the monitor.
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MonitorStatus> Status { get; set; }
        
        /// <value>
        /// Interval in seconds after the start time when the job should be repeated.
        /// Minimum repeatIntervalInSeconds should be 300 seconds for Scripted REST, Scripted Browser and Browser monitors, and 60 seconds for REST monitor.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RepeatIntervalInSeconds is required.")]
        [JsonProperty(PropertyName = "repeatIntervalInSeconds")]
        public System.Nullable<int> RepeatIntervalInSeconds { get; set; }
        
        /// <value>
        /// If runOnce is enabled, then the monitor will run once.
        /// </value>
        [JsonProperty(PropertyName = "isRunOnce")]
        public System.Nullable<bool> IsRunOnce { get; set; }
        
        /// <value>
        /// Timeout in seconds. If isFailureRetried is true, then timeout cannot be more than 30% of repeatIntervalInSeconds time for monitors.
        /// If isFailureRetried is false, then timeout cannot be more than 50% of repeatIntervalInSeconds time for monitors.
        /// Also, timeoutInSeconds should be a multiple of 60 for Scripted REST, Scripted Browser and Browser monitors.
        /// Monitor will be allowed to run only for timeoutInSeconds time. It would be terminated after that.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeoutInSeconds")]
        public System.Nullable<int> TimeoutInSeconds { get; set; }
        
        /// <value>
        /// Specify the endpoint on which to run the monitor.
        /// For BROWSER, REST, NETWORK, DNS and FTP monitor types, target is mandatory.
        /// If target is specified in the SCRIPTED_BROWSER monitor type, then the monitor will run the selected script (specified by scriptId in monitor) against the specified target endpoint.
        /// If target is not specified in the SCRIPTED_BROWSER monitor type, then the monitor will run the selected script as it is.
        /// For NETWORK monitor with TCP protocol, a port needs to be provided along with target. Example: 192.168.0.1:80.
        /// </value>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }
        
        /// <value>
        /// List of script parameters in the monitor.
        /// This is valid only for SCRIPTED_BROWSER and SCRIPTED_REST monitor types. For other monitor types, it should be set to null.
        /// Example: [{&quot;paramName&quot;: &quot;userid&quot;, &quot;paramValue&quot;:&quot;testuser&quot;}]
        /// </value>
        [JsonProperty(PropertyName = "scriptParameters")]
        public System.Collections.Generic.List<MonitorScriptParameter> ScriptParameters { get; set; }
        
        [JsonProperty(PropertyName = "configuration")]
        public MonitorConfiguration Configuration { get; set; }
        
        [JsonProperty(PropertyName = "availabilityConfiguration")]
        public AvailabilityConfiguration AvailabilityConfiguration { get; set; }
        
        [JsonProperty(PropertyName = "maintenanceWindowSchedule")]
        public MaintenanceWindowSchedule MaintenanceWindowSchedule { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// If isRunNow is enabled, then the monitor will run immediately.
        /// </value>
        [JsonProperty(PropertyName = "isRunNow")]
        public System.Nullable<bool> IsRunNow { get; set; }
        
        /// <value>
        /// Scheduling policy to decide the distribution of monitor executions on vantage points.
        /// </value>
        [JsonProperty(PropertyName = "schedulingPolicy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SchedulingPolicy> SchedulingPolicy { get; set; }
        
        /// <value>
        /// Time interval between two runs in round robin batch mode (SchedulingPolicy - BATCHED_ROUND_ROBIN).
        /// </value>
        [JsonProperty(PropertyName = "batchIntervalInSeconds")]
        public System.Nullable<int> BatchIntervalInSeconds { get; set; }
        
        /// <value>
        /// If enabled, domain name will resolve to an IPv6 address.
        /// </value>
        [JsonProperty(PropertyName = "isIPv6")]
        public System.Nullable<bool> IsIPv6 { get; set; }
        
    }
}
