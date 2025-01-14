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


namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// Defines the maintenance window for update operation, when automatic actions can be performed.
    /// 
    /// </summary>
    public class UpdateMaintenanceWindowDetails 
    {
        
        /// <value>
        /// Days of the week.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Day is required.")]
        [JsonProperty(PropertyName = "day")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Day> Day { get; set; }
        
        /// <value>
        /// Start hour for maintenance period. Hour is in UTC.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StartHour is required.")]
        [JsonProperty(PropertyName = "startHour")]
        public System.Nullable<int> StartHour { get; set; }
        
    }
}
