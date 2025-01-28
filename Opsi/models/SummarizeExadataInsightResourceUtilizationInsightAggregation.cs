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
    /// Insights response containing utilization values for exadata systems.
    /// 
    /// </summary>
    public class SummarizeExadataInsightResourceUtilizationInsightAggregation 
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
        /// Percent value in which a resource metric is considered highly utilized.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HighUtilizationThreshold is required.")]
        [JsonProperty(PropertyName = "highUtilizationThreshold")]
        public System.Nullable<int> HighUtilizationThreshold { get; set; }
        
        /// <value>
        /// Percent value in which a resource metric is considered lowly utilized.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LowUtilizationThreshold is required.")]
        [JsonProperty(PropertyName = "lowUtilizationThreshold")]
        public System.Nullable<int> LowUtilizationThreshold { get; set; }
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
                ///
        /// <value>
        /// Defines the resource type for an exadata  (Example: DATABASE, STORAGE_SERVER, HOST, DISKGROUP)
        /// </value>
        ///
        public enum ExadataResourceTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "DATABASE")]
            Database,
            [EnumMember(Value = "HOST")]
            Host,
            [EnumMember(Value = "STORAGE_SERVER")]
            StorageServer,
            [EnumMember(Value = "DISKGROUP")]
            Diskgroup
        };

        /// <value>
        /// Defines the resource type for an exadata  (Example: DATABASE, STORAGE_SERVER, HOST, DISKGROUP)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExadataResourceType is required.")]
        [JsonProperty(PropertyName = "exadataResourceType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ExadataResourceTypeEnum> ExadataResourceType { get; set; }
        
        /// <value>
        /// Collection of Exadata system utilization
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Utilization is required.")]
        [JsonProperty(PropertyName = "utilization")]
        public System.Collections.Generic.List<ExadataInsightResourceInsightUtilizationItem> Utilization { get; set; }
        
    }
}
