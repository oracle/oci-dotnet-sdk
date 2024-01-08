/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
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
    /// The summary of the Optimizer Statistics Collection, which includes the aggregated number of tasks grouped by status.
    /// </summary>
    public class OptimizerStatisticsCollectionAggregationSummary 
    {
        
        /// <value>
        /// The optimizer statistics tasks grouped by type.
        /// </value>
        [JsonProperty(PropertyName = "groupBy")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OptimizerStatisticsGroupByTypes> GroupBy { get; set; }
        
        /// <value>
        /// Indicates the start of the hour as the statistics are aggregated per hour.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeStart is required.")]
        [JsonProperty(PropertyName = "timeStart")]
        public System.Nullable<System.DateTime> TimeStart { get; set; }
        
        /// <value>
        /// Indicates the end of the hour as the statistics are aggregated per hour.
        /// </value>
        [JsonProperty(PropertyName = "timeEnd")]
        public System.Nullable<System.DateTime> TimeEnd { get; set; }
        
        /// <value>
        /// The number of tasks or objects for which statistics are yet to be gathered.
        /// </value>
        [JsonProperty(PropertyName = "pending")]
        public System.Nullable<int> Pending { get; set; }
        
        /// <value>
        /// The number of tasks or objects for which statistics gathering is in progress.
        /// </value>
        [JsonProperty(PropertyName = "inProgress")]
        public System.Nullable<int> InProgress { get; set; }
        
        /// <value>
        /// The number of tasks or objects for which statistics gathering is completed.
        /// </value>
        [JsonProperty(PropertyName = "completed")]
        public System.Nullable<int> Completed { get; set; }
        
        /// <value>
        /// The number of tasks or objects for which statistics gathering failed.
        /// </value>
        [JsonProperty(PropertyName = "failed")]
        public System.Nullable<int> Failed { get; set; }
        
        /// <value>
        /// The number of tasks or objects for which statistics gathering was skipped.
        /// </value>
        [JsonProperty(PropertyName = "skipped")]
        public System.Nullable<int> Skipped { get; set; }
        
        /// <value>
        /// The number of tasks or objects for which statistics gathering timed out.
        /// </value>
        [JsonProperty(PropertyName = "timedOut")]
        public System.Nullable<int> TimedOut { get; set; }
        
        /// <value>
        /// The number of tasks or objects for which the status of statistics gathering is unknown.
        /// </value>
        [JsonProperty(PropertyName = "unknown")]
        public System.Nullable<int> Unknown { get; set; }
        
        /// <value>
        /// The total number of tasks or objects for which statistics collection is finished. This number is the
        /// sum of all the tasks or objects with various statuses: pending, inProgress, completed, failed, skipped,
        /// timedOut, and unknown.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "total")]
        public System.Nullable<int> Total { get; set; }
        
    }
}
