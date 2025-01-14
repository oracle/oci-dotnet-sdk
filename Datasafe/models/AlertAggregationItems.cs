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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// Details of alerts aggregation items.
    /// </summary>
    public class AlertAggregationItems 
    {
        
        /// <value>
        /// The name of the aggregation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MetricName is required.")]
        [JsonProperty(PropertyName = "metricName")]
        public string MetricName { get; set; }
        
        /// <value>
        /// The time at which the aggregation started.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeStarted is required.")]
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The time at which the aggregation ended.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeEnded is required.")]
        [JsonProperty(PropertyName = "timeEnded")]
        public System.Nullable<System.DateTime> TimeEnded { get; set; }
        
        /// <value>
        /// Total count of aggregated values.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Count is required.")]
        [JsonProperty(PropertyName = "count")]
        public System.Nullable<long> Count { get; set; }
        
        [JsonProperty(PropertyName = "dimensions")]
        public AlertsAggregationDimension Dimensions { get; set; }
        
    }
}
