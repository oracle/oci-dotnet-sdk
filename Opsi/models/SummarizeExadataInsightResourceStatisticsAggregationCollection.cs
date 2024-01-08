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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Returns list of the resources with resource statistics like usage,capacity,utilization and usage change percent.
    /// </summary>
    public class SummarizeExadataInsightResourceStatisticsAggregationCollection 
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
        
        /// <value>
        /// Collection of Resource Statistics items
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Items is required.")]
        [JsonProperty(PropertyName = "items")]
        public System.Collections.Generic.List<ExadataInsightResourceStatisticsAggregation> Items { get; set; }
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
                ///
        /// <value>
        /// Defines the type of exadata resource metric (Example: CPU, STORAGE)
        /// </value>
        ///
        public enum ExadataResourceMetricEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CPU")]
            Cpu,
            [EnumMember(Value = "STORAGE")]
            Storage,
            [EnumMember(Value = "IO")]
            Io,
            [EnumMember(Value = "MEMORY")]
            Memory,
            [EnumMember(Value = "IOPS")]
            Iops,
            [EnumMember(Value = "THROUGHPUT")]
            Throughput
        };

        /// <value>
        /// Defines the type of exadata resource metric (Example: CPU, STORAGE)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExadataResourceMetric is required.")]
        [JsonProperty(PropertyName = "exadataResourceMetric")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ExadataResourceMetricEnum> ExadataResourceMetric { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the Exadata insight.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExadataInsightId is required.")]
        [JsonProperty(PropertyName = "exadataInsightId")]
        public string ExadataInsightId { get; set; }
        
        /// <value>
        /// The user-friendly name for the Exadata system. The name does not have to be unique.
        /// </value>
        [JsonProperty(PropertyName = "exadataDisplayName")]
        public string ExadataDisplayName { get; set; }
        
    }
}
