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
    /// A summary of the inventory count and the metrics that describe the aggregated usage of CPU, storage, and so on of all the MySQL Databases in the fleet.
    /// </summary>
    public class MySqlFleetSummary 
    {
        
        /// <value>
        /// The usage metrics for the Managed MySQL Databases in the fleet.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AggregatedMetrics is required.")]
        [JsonProperty(PropertyName = "aggregatedMetrics")]
        public System.Collections.Generic.List<MySqlFleetMetricSummaryDefinition> AggregatedMetrics { get; set; }
        
        /// <value>
        /// A list of MySQL Databases in the fleet, grouped by database type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Inventory is required.")]
        [JsonProperty(PropertyName = "inventory")]
        public System.Collections.Generic.List<MySqlFleetByCategory> Inventory { get; set; }
        
    }
}
