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


namespace Oci.BdsService.Models
{
    /// <summary>
    /// The information about the added Cloud SQL.
    /// </summary>
    public class AddCloudSqlDetails 
    {
        
        /// <value>
        /// Shape of the node.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Shape is required.")]
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }
        
        [JsonProperty(PropertyName = "shapeConfig")]
        public ShapeConfigDetails ShapeConfig { get; set; }
        
        /// <value>
        /// The size of block volume in GB to be attached to the given node. All details needed for attaching the block volume are managed by the service itself.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "blockVolumeSizeInGBs")]
        public System.Nullable<long> BlockVolumeSizeInGBs { get; set; }
        
        /// <value>
        /// Base-64 encoded password for the cluster (and Cloudera Manager) admin user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClusterAdminPassword is required.")]
        [JsonProperty(PropertyName = "clusterAdminPassword")]
        public string ClusterAdminPassword { get; set; }
        
    }
}
