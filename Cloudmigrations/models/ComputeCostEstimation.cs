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
    /// Cost estimation for compute
    /// </summary>
    public class ComputeCostEstimation 
    {
        
        /// <value>
        /// OCPU per hour
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OcpuPerHour is required.")]
        [JsonProperty(PropertyName = "ocpuPerHour")]
        public System.Nullable<decimal> OcpuPerHour { get; set; }
        
        /// <value>
        /// OCPU per hour by subscription
        /// </value>
        [JsonProperty(PropertyName = "ocpuPerHourBySubscription")]
        public System.Nullable<decimal> OcpuPerHourBySubscription { get; set; }
        
        /// <value>
        /// Gigabyte per hour
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MemoryGbPerHour is required.")]
        [JsonProperty(PropertyName = "memoryGbPerHour")]
        public System.Nullable<decimal> MemoryGbPerHour { get; set; }
        
        /// <value>
        /// Gigabyte per hour by subscription
        /// </value>
        [JsonProperty(PropertyName = "memoryGbPerHourBySubscription")]
        public System.Nullable<decimal> MemoryGbPerHourBySubscription { get; set; }
        
        /// <value>
        /// GPU per hour
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "GpuPerHour is required.")]
        [JsonProperty(PropertyName = "gpuPerHour")]
        public System.Nullable<decimal> GpuPerHour { get; set; }
        
        /// <value>
        /// GPU per hour by subscription
        /// </value>
        [JsonProperty(PropertyName = "gpuPerHourBySubscription")]
        public System.Nullable<decimal> GpuPerHourBySubscription { get; set; }
        
        /// <value>
        /// Total per hour
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalPerHour is required.")]
        [JsonProperty(PropertyName = "totalPerHour")]
        public System.Nullable<decimal> TotalPerHour { get; set; }
        
        /// <value>
        /// Total usage per hour by subscription
        /// </value>
        [JsonProperty(PropertyName = "totalPerHourBySubscription")]
        public System.Nullable<decimal> TotalPerHourBySubscription { get; set; }
        
        /// <value>
        /// Total number of OCPUs
        /// </value>
        [JsonProperty(PropertyName = "ocpuCount")]
        public System.Nullable<decimal> OcpuCount { get; set; }
        
        /// <value>
        /// Total usage of memory
        /// </value>
        [JsonProperty(PropertyName = "memoryAmountGb")]
        public System.Nullable<decimal> MemoryAmountGb { get; set; }
        
        /// <value>
        /// Total number of GPU
        /// </value>
        [JsonProperty(PropertyName = "gpuCount")]
        public System.Nullable<decimal> GpuCount { get; set; }
        
    }
}
