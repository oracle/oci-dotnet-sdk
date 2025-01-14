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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Details of a maintenance run history.
    /// 
    /// </summary>
    public class MaintenanceRunHistory 
    {
        
        /// <value>
        /// The OCID of the maintenance run history.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        [JsonProperty(PropertyName = "maintenanceRunDetails")]
        public MaintenanceRunSummary MaintenanceRunDetails { get; set; }
        
        /// <value>
        /// List of database server history details.
        /// </value>
        [JsonProperty(PropertyName = "dbServersHistoryDetails")]
        public System.Collections.Generic.List<DbServerHistorySummary> DbServersHistoryDetails { get; set; }
        
        /// <value>
        /// The OCID of the current execution window.
        /// </value>
        [JsonProperty(PropertyName = "currentExecutionWindow")]
        public string CurrentExecutionWindow { get; set; }
        
        /// <value>
        /// The list of granular maintenance history details.
        /// </value>
        [JsonProperty(PropertyName = "granularMaintenanceHistory")]
        public System.Collections.Generic.List<GranularMaintenanceHistoryDetails> GranularMaintenanceHistory { get; set; }
        
    }
}
