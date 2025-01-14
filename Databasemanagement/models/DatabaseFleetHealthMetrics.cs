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
    /// The details of the fleet health metrics.
    /// </summary>
    public class DatabaseFleetHealthMetrics 
    {
        
        /// <value>
        /// The baseline date and time in UTC in ISO-8601 format, which is \"yyyy-MM-dd'T'hh:mm:ss.sss'Z'\".
        /// This is the date and time against which percentage change is calculated.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompareBaselineTime is required.")]
        [JsonProperty(PropertyName = "compareBaselineTime")]
        public string CompareBaselineTime { get; set; }
        
        /// <value>
        /// The target date and time in UTC in ISO-8601 format, which is \"yyyy-MM-dd'T'hh:mm:ss.sss'Z'\".
        /// All the metrics are returned for the target date and time and the percentage change
        /// is calculated against the baseline date and time.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompareTargetTime is required.")]
        [JsonProperty(PropertyName = "compareTargetTime")]
        public string CompareTargetTime { get; set; }
        
        /// <value>
        /// The time window used for metrics comparison.
        /// </value>
        [JsonProperty(PropertyName = "compareType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CompareType> CompareType { get; set; }
        
        [JsonProperty(PropertyName = "fleetSummary")]
        public FleetSummary FleetSummary { get; set; }
        
        /// <value>
        /// A list of the databases present in the fleet and their usage metrics.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FleetDatabases is required.")]
        [JsonProperty(PropertyName = "fleetDatabases")]
        public System.Collections.Generic.List<DatabaseUsageMetrics> FleetDatabases { get; set; }
        
    }
}
