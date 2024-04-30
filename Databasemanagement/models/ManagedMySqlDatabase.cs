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
    /// The details of the Managed MySQL Database.
    /// </summary>
    public class ManagedMySqlDatabase 
    {
        
        /// <value>
        /// The OCID of the Managed MySQL Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The name of the MySQL Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbName is required.")]
        [JsonProperty(PropertyName = "dbName")]
        public string DbName { get; set; }
        
        /// <value>
        /// The version of the MySQL Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbVersion is required.")]
        [JsonProperty(PropertyName = "dbVersion")]
        public string DbVersion { get; set; }
        
        /// <value>
        /// The date and time the Managed MySQL Database was created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The name of the Managed MySQL Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The name of the HeatWave cluster.
        /// </value>
        [JsonProperty(PropertyName = "heatWaveClusterDisplayName")]
        public string HeatWaveClusterDisplayName { get; set; }
        
        /// <value>
        /// Indicates whether HeatWave is enabled for the MySQL Database System or not.
        /// </value>
        [JsonProperty(PropertyName = "isHeatWaveEnabled")]
        public System.Nullable<bool> IsHeatWaveEnabled { get; set; }
        
        /// <value>
        /// Indicates whether HeatWave Lakehouse is enabled for the MySQL Database System or not.
        /// </value>
        [JsonProperty(PropertyName = "isLakehouseEnabled")]
        public System.Nullable<bool> IsLakehouseEnabled { get; set; }
        
        /// <value>
        /// The shape of the nodes in the HeatWave cluster.
        /// </value>
        [JsonProperty(PropertyName = "heatWaveNodeShape")]
        public string HeatWaveNodeShape { get; set; }
        
        /// <value>
        /// The total memory belonging to the HeatWave cluster in GBs.
        /// </value>
        [JsonProperty(PropertyName = "heatWaveMemorySize")]
        public System.Nullable<int> HeatWaveMemorySize { get; set; }
        
        /// <value>
        /// The information about individual HeatWave nodes in the cluster.
        /// </value>
        [JsonProperty(PropertyName = "heatWaveNodes")]
        public System.Collections.Generic.List<HeatWaveNode> HeatWaveNodes { get; set; }
        
        /// <value>
        /// Indicates whether the HeatWave cluster is active or not.
        /// </value>
        [JsonProperty(PropertyName = "isHeatWaveActive")]
        public System.Nullable<bool> IsHeatWaveActive { get; set; }
        
        /// <value>
        /// The date and time the Managed MySQL Database was created.
        /// </value>
        [JsonProperty(PropertyName = "timeCreatedHeatWave")]
        public System.Nullable<System.DateTime> TimeCreatedHeatWave { get; set; }
        
    }
}
