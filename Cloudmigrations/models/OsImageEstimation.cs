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


namespace Oci.CloudmigrationsService.Models
{
    /// <summary>
    /// Cost estimation for the OS image.
    /// </summary>
    public class OsImageEstimation 
    {
        
        /// <value>
        /// Total price per hour
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalPerHour is required.")]
        [JsonProperty(PropertyName = "totalPerHour")]
        public System.Nullable<decimal> TotalPerHour { get; set; }
        
        /// <value>
        /// Total price per hour by subscription
        /// </value>
        [JsonProperty(PropertyName = "totalPerHourBySubscription")]
        public System.Nullable<decimal> TotalPerHourBySubscription { get; set; }
        
    }
}
