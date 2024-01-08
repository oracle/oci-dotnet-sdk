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


namespace Oci.UsageapiService.Models
{
    /// <summary>
    /// The schedule.
    /// </summary>
    public class Schedule 
    {
        
        /// <value>
        /// The OCID representing a unique shedule.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The unique name of the schedule created by the user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The customer tenancy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResultLocation is required.")]
        [JsonProperty(PropertyName = "resultLocation")]
        public ResultLocation ResultLocation { get; set; }
        
        /// <value>
        /// The description of the schedule.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The date and time of the next job execution.
        /// </value>
        [JsonProperty(PropertyName = "timeNextRun")]
        public System.Nullable<System.DateTime> TimeNextRun { get; set; }
                ///
        /// <value>
        /// Specifies the supported output file format.
        /// </value>
        ///
        public enum OutputFileFormatEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CSV")]
            Csv,
            [EnumMember(Value = "PDF")]
            Pdf
        };

        /// <value>
        /// Specifies the supported output file format.
        /// </value>
        [JsonProperty(PropertyName = "outputFileFormat")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OutputFileFormatEnum> OutputFileFormat { get; set; }
        
        /// <value>
        /// The saved report ID which can also be used to generate a query.
        /// </value>
        [JsonProperty(PropertyName = "savedReportId")]
        public string SavedReportId { get; set; }
        
        /// <value>
        /// Specifies the frequency according to when the schedule will be run, 
        /// in the x-obmcs-recurring-time format described in [RFC 5545 section 3.3.10](https://datatracker.ietf.org/doc/html/rfc5545#section-3.3.10).
        /// Supported values are : ONE_TIME, DAILY, WEEKLY and MONTHLY.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ScheduleRecurrences is required.")]
        [JsonProperty(PropertyName = "scheduleRecurrences")]
        public string ScheduleRecurrences { get; set; }
        
        /// <value>
        /// The date and time of the first time job execution.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeScheduled is required.")]
        [JsonProperty(PropertyName = "timeScheduled")]
        public System.Nullable<System.DateTime> TimeScheduled { get; set; }
        
        [JsonProperty(PropertyName = "queryProperties")]
        public QueryProperties QueryProperties { get; set; }
        
        /// <value>
        /// The date and time the schedule was created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
                ///
        /// <value>
        /// The schedule lifecycle state.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INACTIVE")]
            Inactive
        };

        /// <value>
        /// The schedule lifecycle state.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm). Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm). Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces. See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm). Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
