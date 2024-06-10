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
    /// The inventory count of HeatWave clusters in the fleet and a summary of the metrics that provide the aggregated usage of CPU, storage, and so on of all the clusters.
    /// </summary>
    public class HeatWaveFleetSummary 
    {
        
        /// <value>
        /// The usage metrics for the HeatWave clusters in the fleet.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AggregatedMetrics is required.")]
        [JsonProperty(PropertyName = "aggregatedMetrics")]
        public System.Collections.Generic.List<HeatWaveFleetMetricSummaryDefinition> AggregatedMetrics { get; set; }
        
        /// <value>
        /// The number of HeatWave clusters in the fleet, grouped by cluster type or other properties.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Inventory is required.")]
        [JsonProperty(PropertyName = "inventory")]
        public System.Collections.Generic.List<HeatWaveFleetByCategory> Inventory { get; set; }
        
    }
}