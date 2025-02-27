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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Describe the parameters to create a new execution window after this execution window is canceled.
    /// 
    /// </summary>
    public class CancelExecutionWindowDetails 
    {
        
        /// <value>
        /// New scheduled date and time of the execution window.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeScheduledOfNewWindow is required.")]
        [JsonProperty(PropertyName = "timeScheduledOfNewWindow")]
        public System.Nullable<System.DateTime> TimeScheduledOfNewWindow { get; set; }
        
        /// <value>
        /// Duration window allows user to set a duration they plan to allocate for Scheduling window. The duration is in minutes.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WindowDurationInMinsOfNewWindow is required.")]
        [JsonProperty(PropertyName = "windowDurationInMinsOfNewWindow")]
        public System.Nullable<int> WindowDurationInMinsOfNewWindow { get; set; }
        
        /// <value>
        /// Indicates if duration the user plans to allocate for scheduling window is strictly enforced. The default value is `FALSE`.
        /// </value>
        [JsonProperty(PropertyName = "isEnforcedDurationOfNewWindow")]
        public System.Nullable<bool> IsEnforcedDurationOfNewWindow { get; set; }
        
    }
}
