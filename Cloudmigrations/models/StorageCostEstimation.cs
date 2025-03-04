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
    /// Cost estimation for storage
    /// </summary>
    public class StorageCostEstimation 
    {
        
        /// <value>
        /// Volume estimation
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Volumes is required.")]
        [JsonProperty(PropertyName = "volumes")]
        public System.Collections.Generic.List<VolumeCostEstimation> Volumes { get; set; }
        
        /// <value>
        /// Gigabyte storage capacity per month.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalGbPerMonth is required.")]
        [JsonProperty(PropertyName = "totalGbPerMonth")]
        public System.Nullable<decimal> TotalGbPerMonth { get; set; }
        
        /// <value>
        /// Gigabyte storage capacity per month by subscription.
        /// </value>
        [JsonProperty(PropertyName = "totalGbPerMonthBySubscription")]
        public System.Nullable<decimal> TotalGbPerMonthBySubscription { get; set; }
        
    }
}
