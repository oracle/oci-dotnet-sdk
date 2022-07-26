/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
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
    /// The summary of the AWR metric data for a particular metric at a specific time.
    /// </summary>
    public class AwrDatabaseMetricSummary 
    {
        
        /// <value>
        /// The name of the metric.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The time of the sampling.
        /// </value>
        [JsonProperty(PropertyName = "timestamp")]
        public System.Nullable<System.DateTime> Timestamp { get; set; }
        
        /// <value>
        /// The average value of the sampling period.
        /// </value>
        [JsonProperty(PropertyName = "avgValue")]
        public System.Double AvgValue { get; set; }
        
        /// <value>
        /// The minimum value of the sampling period.
        /// </value>
        [JsonProperty(PropertyName = "minValue")]
        public System.Double MinValue { get; set; }
        
        /// <value>
        /// The maximum value of the sampling period.
        /// </value>
        [JsonProperty(PropertyName = "maxValue")]
        public System.Double MaxValue { get; set; }
        
    }
}
