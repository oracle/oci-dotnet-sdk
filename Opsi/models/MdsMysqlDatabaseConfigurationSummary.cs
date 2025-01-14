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
    /// Configuration Summary of a MDS MYSQL database.
    /// </summary>
    public class MdsMysqlDatabaseConfigurationSummary : DatabaseConfigurationSummary
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseId is required.")]
        [JsonProperty(PropertyName = "databaseId")]
        public string DatabaseId { get; set; }
        
        /// <value>
        /// Specifies if MYSQL DB System has heatwave cluster attached.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsHeatWaveClusterAttached is required.")]
        [JsonProperty(PropertyName = "isHeatWaveClusterAttached")]
        public System.Nullable<bool> IsHeatWaveClusterAttached { get; set; }
        
        /// <value>
        /// Specifies if MYSQL DB System is highly available.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsHighlyAvailable is required.")]
        [JsonProperty(PropertyName = "isHighlyAvailable")]
        public System.Nullable<bool> IsHighlyAvailable { get; set; }
        
        /// <value>
        /// The shape of the primary instances of MYSQL DB system. The shape determines resources allocated to a DB System - CPU cores
        /// and memory for VM shapes; CPU cores, memory and storage for non-VM shapes.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ShapeName is required.")]
        [JsonProperty(PropertyName = "shapeName")]
        public string ShapeName { get; set; }
        
        [JsonProperty(PropertyName = "entitySource")]
        private readonly string entitySource = "MDS_MYSQL_DATABASE_SYSTEM";
    }
}
