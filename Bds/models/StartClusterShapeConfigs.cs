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
    /// The shape configuration to be used to start the cluster. If the value is not set, the start cluster operation will try to start the cluster as is.
    /// </summary>
    public class StartClusterShapeConfigs 
    {
        
        /// <value>
        /// Shape configurations for each node type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NodeTypeShapeConfigs is required.")]
        [JsonProperty(PropertyName = "nodeTypeShapeConfigs")]
        public System.Collections.Generic.List<NodeTypeShapeConfig> NodeTypeShapeConfigs { get; set; }
        
    }
}