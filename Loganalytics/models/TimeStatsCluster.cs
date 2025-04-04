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
    /// Object representing a timeseries cluster.
    /// 
    /// </summary>
    public class TimeStatsCluster 
    {
        
        /// <value>
        /// Group by field facets within the cluster.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "groupByFacets")]
        public System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, System.Object>> GroupByFacets { get; set; }
        
        /// <value>
        /// Number of timeseries within the cluster.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "count")]
        public System.Nullable<int> Count { get; set; }
        
    }
}
