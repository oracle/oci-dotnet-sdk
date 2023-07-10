/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.OcicontrolcenterService.Models
{
    /// <summary>
    /// The recorded metric value at a specific timestamp.
    /// 
    /// </summary>
    public class SummarizedMetricData 
    {
        
        /// <value>
        /// The time at which the metric data was recorded.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sampleTime")]
        public System.Nullable<System.DateTime> SampleTime { get; set; }
        
        /// <value>
        /// The duration over which the metric data is aggregated. Supported values: `1m`-`60m`, `1h`-`24h`, `1d`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "resolution")]
        public string Resolution { get; set; }
        
        /// <value>
        /// Qualifiers provided in the definition of the returned metric. Available dimensions vary by metric namespace.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dimensions")]
        public System.Collections.Generic.Dictionary<string, DimensionValue> Dimensions { get; set; }
        
        /// <value>
        /// The aggregation method used for aggregating the metric values.  The aggregation method depends on the metric itself.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "aggregationMethod")]
        public string AggregationMethod { get; set; }
        
        /// <value>
        /// The aggregated metric value for the specified request.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "aggregatedValue")]
        public System.Nullable<float> AggregatedValue { get; set; }
        
    }
}