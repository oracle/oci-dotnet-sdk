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
    /// Verify acceleration output.
    /// </summary>
    public class VerifyOutput 
    {
        
        /// <value>
        /// Acceleration task identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ScheduledTaskId is required.")]
        [JsonProperty(PropertyName = "scheduledTaskId")]
        public string ScheduledTaskId { get; set; }
        
        /// <value>
        /// Response time in ms.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResponseTimeInMs is required.")]
        [JsonProperty(PropertyName = "responseTimeInMs")]
        public System.Nullable<long> ResponseTimeInMs { get; set; }
        
        /// <value>
        /// Total match count.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalMatchedCount is required.")]
        [JsonProperty(PropertyName = "totalMatchedCount")]
        public System.Nullable<long> TotalMatchedCount { get; set; }
        
        /// <value>
        /// Total count.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalCount is required.")]
        [JsonProperty(PropertyName = "totalCount")]
        public System.Nullable<int> TotalCount { get; set; }
        
        /// <value>
        /// Acceleration result columns, included if requested (shouldIncludeResults).
        /// </value>
        [JsonProperty(PropertyName = "columns")]
        public System.Collections.Generic.List<ResultColumn> Columns { get; set; }
        
        /// <value>
        /// Acceleration result values, included if requested (shouldIncludeResults).
        /// </value>
        [JsonProperty(PropertyName = "results")]
        public System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, System.Object>> Results { get; set; }
        
    }
}
