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


namespace Oci.StackmonitoringService.Models
{
    /// <summary>
    /// Specific metric mapping configurations for Agent Extension Handlers.
    /// </summary>
    public class AgentExtensionHandlerMetricMappingDetails 
    {
        
        /// <value>
        /// Metric name as defined by the collector.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CollectorMetricName is required.")]
        [JsonProperty(PropertyName = "collectorMetricName")]
        public string CollectorMetricName { get; set; }
        
        /// <value>
        /// Metric name to be upload to telemetry.
        /// </value>
        [JsonProperty(PropertyName = "telemetryMetricName")]
        public string TelemetryMetricName { get; set; }
        
        /// <value>
        /// Is ignoring this metric.
        /// </value>
        [JsonProperty(PropertyName = "isSkipUpload")]
        public System.Nullable<bool> IsSkipUpload { get; set; }
        
        /// <value>
        /// Metric upload interval in seconds. Any metric sent by telegraf/collectd before the 
        /// configured interval expires will be dropped.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "metricUploadIntervalInSeconds")]
        public System.Nullable<int> MetricUploadIntervalInSeconds { get; set; }
        
    }
}
