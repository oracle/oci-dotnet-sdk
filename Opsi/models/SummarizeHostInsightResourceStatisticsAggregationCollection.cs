/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Returns list of hosts with resource statistics like usage, capacity, utilization, usage change percent and load.
    /// 
    /// </summary>
    public class SummarizeHostInsightResourceStatisticsAggregationCollection 
    {
        
        /// <value>
        /// The start timestamp that was passed into the request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeIntervalStart is required.")]
        [JsonProperty(PropertyName = "timeIntervalStart")]
        public System.Nullable<System.DateTime> TimeIntervalStart { get; set; }
        
        /// <value>
        /// The end timestamp that was passed into the request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeIntervalEnd is required.")]
        [JsonProperty(PropertyName = "timeIntervalEnd")]
        public System.Nullable<System.DateTime> TimeIntervalEnd { get; set; }
                ///
        /// <value>
        /// Defines the type of resource metric (CPU, Physical Memory, Logical Memory)
        /// 
        /// </value>
        ///
        public enum ResourceMetricEnum {
            [EnumMember(Value = "CPU")]
            Cpu,
            [EnumMember(Value = "MEMORY")]
            Memory,
            [EnumMember(Value = "LOGICAL_MEMORY")]
            LogicalMemory
        };

        /// <value>
        /// Defines the type of resource metric (CPU, Physical Memory, Logical Memory)
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceMetric is required.")]
        [JsonProperty(PropertyName = "resourceMetric")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ResourceMetricEnum> ResourceMetric { get; set; }
        
        /// <value>
        /// Displays usage unit.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UsageUnit is required.")]
        [JsonProperty(PropertyName = "usageUnit")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<UsageUnit> UsageUnit { get; set; }
        
        /// <value>
        /// Collection of Resource Statistics items
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Items is required.")]
        [JsonProperty(PropertyName = "items")]
        public System.Collections.Generic.List<HostInsightResourceStatisticsAggregation> Items { get; set; }
        
    }
}