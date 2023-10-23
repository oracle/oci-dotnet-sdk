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


namespace Oci.NosqlService.Models
{
    /// <summary>
    /// TableUsageSummary represents a single usage record, or slice, that includes
    /// information about read and write throughput consumed during that period
    /// as well as the current information regarding storage capacity. In
    /// addition the count of throttling exceptions for the period is reported.
    /// 
    /// </summary>
    public class TableUsageSummary 
    {
        
        /// <value>
        /// The length of the sampling period.
        /// </value>
        [JsonProperty(PropertyName = "secondsInPeriod")]
        public System.Nullable<int> SecondsInPeriod { get; set; }
        
        /// <value>
        /// Read throughput during the sampling period.
        /// </value>
        [JsonProperty(PropertyName = "readUnits")]
        public System.Nullable<int> ReadUnits { get; set; }
        
        /// <value>
        /// Write throughput during the sampling period.
        /// </value>
        [JsonProperty(PropertyName = "writeUnits")]
        public System.Nullable<int> WriteUnits { get; set; }
        
        /// <value>
        /// The size of the table, in GB.
        /// </value>
        [JsonProperty(PropertyName = "storageInGBs")]
        public System.Nullable<int> StorageInGBs { get; set; }
        
        /// <value>
        /// The number of times reads were throttled due to exceeding
        /// the read throughput limit.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "readThrottleCount")]
        public System.Nullable<int> ReadThrottleCount { get; set; }
        
        /// <value>
        /// The number of times writes were throttled due to exceeding
        /// the write throughput limit.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "writeThrottleCount")]
        public System.Nullable<int> WriteThrottleCount { get; set; }
        
        /// <value>
        /// The number of times writes were throttled because the table
        /// exceeded its size limit.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "storageThrottleCount")]
        public System.Nullable<int> StorageThrottleCount { get; set; }
        
        /// <value>
        /// The percentage of allowed per-shard usage for the table shard with the highest usage.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maxShardSizeUsageInPercent")]
        public System.Nullable<int> MaxShardSizeUsageInPercent { get; set; }
        
        /// <value>
        /// The time stamp of this usage record.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
    }
}
