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


namespace Oci.ResourceschedulerService.Models
{
    /// <summary>
    /// This is the data to update a schedule.
    /// </summary>
    public class UpdateScheduleDetails 
    {
        
        /// <value>
        /// This is a user-friendly name for the schedule. It does not have to be unique, and it's changeable.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// This is the description of the schedule.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
                ///
        /// <value>
        /// This is the action that will be executed by the schedule.
        /// </value>
        ///
        public enum ActionEnum {
            [EnumMember(Value = "START_RESOURCE")]
            StartResource,
            [EnumMember(Value = "STOP_RESOURCE")]
            StopResource
        };

        /// <value>
        /// This is the action that will be executed by the schedule.
        /// </value>
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ActionEnum> Action { get; set; }
        
        /// <value>
        /// This is the frequency of recurrence of a schedule. The frequency field can either conform to RFC-5545 formatting
        /// or UNIX cron formatting for recurrences, based on the value specified by the recurrenceType field.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "recurrenceDetails")]
        public string RecurrenceDetails { get; set; }
                ///
        /// <value>
        /// Type of recurrence of a schedule
        /// </value>
        ///
        public enum RecurrenceTypeEnum {
            [EnumMember(Value = "CRON")]
            Cron,
            [EnumMember(Value = "ICAL")]
            Ical
        };

        /// <value>
        /// Type of recurrence of a schedule
        /// </value>
        [JsonProperty(PropertyName = "recurrenceType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RecurrenceTypeEnum> RecurrenceType { get; set; }
        
        /// <value>
        /// This is a list of resources filters.  The schedule will be applied to resources matching all of them.
        /// </value>
        [JsonProperty(PropertyName = "resourceFilters")]
        public System.Collections.Generic.List<ResourceFilter> ResourceFilters { get; set; }
        
        /// <value>
        /// This is the list of resources to which the scheduled operation is applied.
        /// </value>
        [JsonProperty(PropertyName = "resources")]
        public System.Collections.Generic.List<Resource> Resources { get; set; }
        
        /// <value>
        /// This is the date and time the schedule starts, in the format defined by [RFC 3339](https://tools.ietf.org/html/rfc3339)
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeStarts")]
        public System.Nullable<System.DateTime> TimeStarts { get; set; }
        
        /// <value>
        /// This is the date and time the schedule ends, in the format defined by [RFC 3339](https://tools.ietf.org/html/rfc3339)
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeEnds")]
        public System.Nullable<System.DateTime> TimeEnds { get; set; }
        
        /// <value>
        /// These are free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// These are defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
