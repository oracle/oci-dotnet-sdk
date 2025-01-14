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


namespace Oci.DatascienceService.Models
{
    /// <summary>
    /// An expression built using CPU or Memory metrics for triggering an autoscaling action on the model deployment.
    /// 
    /// </summary>
    public class PredefinedMetricExpressionRule : MetricExpressionRule
    {
                ///
        /// <value>
        /// Metric type
        /// 
        /// </value>
        ///
        public enum MetricTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CPU_UTILIZATION")]
            CpuUtilization,
            [EnumMember(Value = "MEMORY_UTILIZATION")]
            MemoryUtilization
        };

        /// <value>
        /// Metric type
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MetricType is required.")]
        [JsonProperty(PropertyName = "metricType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MetricTypeEnum> MetricType { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ScaleInConfiguration is required.")]
        [JsonProperty(PropertyName = "scaleInConfiguration")]
        public PredefinedExpressionThresholdScalingConfiguration ScaleInConfiguration { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ScaleOutConfiguration is required.")]
        [JsonProperty(PropertyName = "scaleOutConfiguration")]
        public PredefinedExpressionThresholdScalingConfiguration ScaleOutConfiguration { get; set; }
        
        [JsonProperty(PropertyName = "metricExpressionRuleType")]
        private readonly string metricExpressionRuleType = "PREDEFINED_EXPRESSION";
    }
}
