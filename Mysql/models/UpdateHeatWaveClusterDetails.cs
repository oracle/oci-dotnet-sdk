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


namespace Oci.MysqlService.Models
{
    /// <summary>
    /// Details about the HeatWave cluster properties to be updated.
    /// 
    /// </summary>
    public class UpdateHeatWaveClusterDetails 
    {
        
        /// <value>
        /// A change to the shape of the nodes in the HeatWave cluster will
        /// result in the entire cluster being torn down and re-created with
        /// Compute instances of the new Shape. This may result in significant
        /// downtime for the analytics capability while the HeatWave cluster is
        /// re-provisioned.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "shapeName")]
        public string ShapeName { get; set; }
        
        /// <value>
        /// A change to the number of nodes in the HeatWave cluster will result
        /// in the entire cluster being torn down and re-created with the new
        /// cluster of nodes. This may result in a significant downtime for the
        /// analytics capability while the HeatWave cluster is
        /// re-provisioned.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "clusterSize")]
        public System.Nullable<int> ClusterSize { get; set; }
        
        /// <value>
        /// Enable/disable Lakehouse for the HeatWave cluster.
        /// </value>
        [JsonProperty(PropertyName = "isLakehouseEnabled")]
        public System.Nullable<bool> IsLakehouseEnabled { get; set; }
        
    }
}
