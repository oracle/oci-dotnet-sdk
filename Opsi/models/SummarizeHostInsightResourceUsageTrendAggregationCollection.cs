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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Top level response object.
    /// 
    /// </summary>
    public class SummarizeHostInsightResourceUsageTrendAggregationCollection 
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
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CPU")]
            Cpu,
            [EnumMember(Value = "MEMORY")]
            Memory,
            [EnumMember(Value = "LOGICAL_MEMORY")]
            LogicalMemory,
            [EnumMember(Value = "STORAGE")]
            Storage,
            [EnumMember(Value = "NETWORK")]
            Network,
            [EnumMember(Value = "GPU_UTILIZATION")]
            GpuUtilization,
            [EnumMember(Value = "GPU_MEMORY_USAGE")]
            GpuMemoryUsage,
            [EnumMember(Value = "IO")]
            Io
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
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ResourceMetricEnum> ResourceMetric { get; set; }
                ///
        /// <value>
        /// Displays usage unit ( CORES, GB , PERCENT, MBPS)
        /// </value>
        ///
        public enum UsageUnitEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CORES")]
            Cores,
            [EnumMember(Value = "GB")]
            Gb,
            [EnumMember(Value = "MBPS")]
            Mbps,
            [EnumMember(Value = "IOPS")]
            Iops,
            [EnumMember(Value = "PERCENT")]
            Percent
        };

        /// <value>
        /// Displays usage unit ( CORES, GB , PERCENT, MBPS)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UsageUnit is required.")]
        [JsonProperty(PropertyName = "usageUnit")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<UsageUnitEnum> UsageUnit { get; set; }
        
        /// <value>
        /// Time duration in milliseconds between data points (one hour or one day).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ItemDurationInMs is required.")]
        [JsonProperty(PropertyName = "itemDurationInMs")]
        public System.Nullable<long> ItemDurationInMs { get; set; }
        
        /// <value>
        /// Usage Data with timestamp.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UsageData is required.")]
        [JsonProperty(PropertyName = "usageData")]
        public System.Collections.Generic.List<ResourceUsageTrendAggregation> UsageData { get; set; }
        
    }
}
