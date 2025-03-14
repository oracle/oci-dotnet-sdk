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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// Result column, that contains time series data points in each row. The column includes the time stamps as additional field in column header.
    /// 
    /// </summary>
    public class TrendColumn : AbstractColumn
    {
        
        /// <value>
        /// Time gap between each data pont in the series.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "intervalGap")]
        public string IntervalGap { get; set; }
        
        /// <value>
        /// Timestamps for each series data point
        /// 
        /// </value>
        [JsonProperty(PropertyName = "intervals")]
        public System.Collections.Generic.List<long> Intervals { get; set; }
        
        /// <value>
        /// Sum across all column values for a given timestamp.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "totalIntervalCounts")]
        public System.Collections.Generic.List<long> TotalIntervalCounts { get; set; }
        
        /// <value>
        /// Sum of column values for a given timestamp after applying filter.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "totalIntervalCountsAfterFilter")]
        public System.Collections.Generic.List<long> TotalIntervalCountsAfterFilter { get; set; }
        
        /// <value>
        /// Number of aggregated groups for a given timestamp.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "intervalGroupCounts")]
        public System.Collections.Generic.List<long> IntervalGroupCounts { get; set; }
        
        /// <value>
        /// Number of aggregated groups for a given timestamp after applying filter.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "intervalGroupCountsAfterFilter")]
        public System.Collections.Generic.List<long> IntervalGroupCountsAfterFilter { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "TREND_COLUMN";
    }
}
