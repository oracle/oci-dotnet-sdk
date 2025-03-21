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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The database metric details.
    /// </summary>
    public class FleetMetricDefinition 
    {
        
        /// <value>
        /// The name of the metric.
        /// </value>
        [JsonProperty(PropertyName = "metricName")]
        public string MetricName { get; set; }
        
        /// <value>
        /// The baseline value of the metric.
        /// </value>
        [JsonProperty(PropertyName = "baselineValue")]
        public System.Double BaselineValue { get; set; }
        
        /// <value>
        /// The target value of the metric.
        /// </value>
        [JsonProperty(PropertyName = "targetValue")]
        public System.Double TargetValue { get; set; }
        
        /// <value>
        /// The unit of the value.
        /// </value>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }
        
        /// <value>
        /// The data point date and time in UTC in ISO-8601 format, which is \"yyyy-MM-dd'T'hh:mm:ss.sss'Z'\".
        /// </value>
        [JsonProperty(PropertyName = "timestamp")]
        public System.Nullable<System.DateTime> Timestamp { get; set; }
        
        /// <value>
        /// The percentage change in the metric aggregated value compared to the baseline value.
        /// </value>
        [JsonProperty(PropertyName = "percentageChange")]
        public System.Double PercentageChange { get; set; }
        
        /// <value>
        /// The dimensions of the metric.
        /// </value>
        [JsonProperty(PropertyName = "dimensions")]
        public System.Collections.Generic.List<MetricDimensionDefinition> Dimensions { get; set; }
        
    }
}
