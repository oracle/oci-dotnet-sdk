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


namespace Oci.BdsService.Models
{
    /// <summary>
    /// Shape configuration at node type level. Start cluster will start all nodes as is if no config is specified.
    /// </summary>
    public class NodeTypeShapeConfig 
    {
        
        /// <value>
        /// The Big Data Service cluster node type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NodeType is required.")]
        [JsonProperty(PropertyName = "nodeType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Node.NodeTypeEnum> NodeType { get; set; }
        
        /// <value>
        /// Shape of the node. This has to be specified when starting the cluster. Defaults to wn0 for homogeneous clusters and remains empty for heterogeneous clusters. 
        /// If provided, all nodes in the node type will adopt the specified shape; otherwise, nodes retain their original shapes.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Shape is required.")]
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }
        
    }
}
