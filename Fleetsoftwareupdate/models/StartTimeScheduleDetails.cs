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


namespace Oci.FleetsoftwareupdateService.Models
{
    /// <summary>
    /// Start time details for the Exadata Fleet Update Action.
    /// The specified time should not conflict with existing Exadata Infrastructure maintenance windows.
    /// If Stage and Apply Actions are created with a timeToStart specified during Exadata Fleet Update Cycle
    /// creation, Apply should be scheduled at least 24 hours after the start time of the Stage Action.
    /// 
    /// </summary>
    public class StartTimeScheduleDetails : ScheduleDetails
    {
        
        /// <value>
        /// The date and time the Exadata Fleet Update Action is expected to start.
        /// [RFC 3339](https://tools.ietf.org/rfc/rfc3339), section 14.29.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeToStart is required.")]
        [JsonProperty(PropertyName = "timeToStart")]
        public System.Nullable<System.DateTime> TimeToStart { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "START_TIME";
    }
}
