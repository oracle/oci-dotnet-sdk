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


namespace Oci.ComputecloudatcustomerService.Models
{
    /// <summary>
    /// A period where upgrades may be applied to Compute Cloud@Customer infrastructures
    /// associated with the schedule. All upgrade windows may not be used.
    /// 
    /// </summary>
    public class CccScheduleEvent 
    {
        
        /// <value>
        /// Generated name associated with the event.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// A description of the Compute Cloud@Customer upgrade schedule time block.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Description is required.")]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The date and time when the Compute Cloud@Customer upgrade schedule event starts,
        /// inclusive. An RFC3339 formatted UTC datetime string. For an event with recurrences,
        /// this is the date that a recurrence can start being applied.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeStart is required.")]
        [JsonProperty(PropertyName = "timeStart")]
        public System.Nullable<System.DateTime> TimeStart { get; set; }
        
        /// <value>
        /// The duration of this block of time. The duration must be specified and be of the
        /// ISO-8601 format for durations.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ScheduleEventDuration is required.")]
        [JsonProperty(PropertyName = "scheduleEventDuration")]
        public string ScheduleEventDuration { get; set; }
        
        /// <value>
        /// Frequency of recurrence of schedule block. When this field is not included, the event
        /// is assumed to be a one time occurrence. The frequency field is strictly parsed and must
        /// conform to RFC-5545 formatting for recurrences.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "scheduleEventRecurrences")]
        public string ScheduleEventRecurrences { get; set; }
        
    }
}
