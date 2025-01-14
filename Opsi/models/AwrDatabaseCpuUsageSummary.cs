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
    /// A summary of the AWR CPU resource limits and metrics.
    /// </summary>
    public class AwrDatabaseCpuUsageSummary 
    {
        
        /// <value>
        /// The timestamp for the CPU summary data.
        /// </value>
        [JsonProperty(PropertyName = "timestamp")]
        public System.Nullable<System.DateTime> Timestamp { get; set; }
        
        /// <value>
        /// The average CPU usage per second.
        /// </value>
        [JsonProperty(PropertyName = "avgUsageInSecs")]
        public System.Double AvgUsageInSecs { get; set; }
        
    }
}
