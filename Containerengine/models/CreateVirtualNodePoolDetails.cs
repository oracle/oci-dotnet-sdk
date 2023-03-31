/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.ContainerengineService.Models
{
    /// <summary>
    /// The properties that define a request to create a virtual node pool.
    /// </summary>
    public class CreateVirtualNodePoolDetails 
    {
        
        /// <value>
        /// Compartment of the virtual node pool.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The cluster the virtual node pool is associated with. A virtual node pool can only be associated with one cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClusterId is required.")]
        [JsonProperty(PropertyName = "clusterId")]
        public string ClusterId { get; set; }
        
        /// <value>
        /// Display name of the virtual node pool. This is a non-unique value.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Initial labels that will be added to the Kubernetes Virtual Node object when it registers.
        /// </value>
        [JsonProperty(PropertyName = "initialVirtualNodeLabels")]
        public System.Collections.Generic.List<InitialVirtualNodeLabel> InitialVirtualNodeLabels { get; set; }
        
        /// <value>
        /// A taint is a collection of <key, value, effect>. These taints will be applied to the Virtual Nodes of this Virtual Node Pool for Kubernetes scheduling.
        /// </value>
        [JsonProperty(PropertyName = "taints")]
        public System.Collections.Generic.List<Taint> Taints { get; set; }
        
        /// <value>
        /// The number of Virtual Nodes that should be in the Virtual Node Pool. The placement configurations determine where these virtual nodes are placed.
        /// </value>
        [JsonProperty(PropertyName = "size")]
        public System.Nullable<int> Size { get; set; }
        
        /// <value>
        /// The list of placement configurations which determines where Virtual Nodes will be provisioned across as it relates to the subnet and availability domains. The size attribute determines how many we evenly spread across these placement configurations
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PlacementConfigurations is required.")]
        [JsonProperty(PropertyName = "placementConfigurations")]
        public System.Collections.Generic.List<PlacementConfiguration> PlacementConfigurations { get; set; }
        
        /// <value>
        /// List of network security group id's applied to the Virtual Node VNIC.
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
        
        /// <value>
        /// The pod configuration for pods run on virtual nodes of this virtual node pool.
        /// </value>
        [JsonProperty(PropertyName = "podConfiguration")]
        public PodConfiguration PodConfiguration { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        [JsonProperty(PropertyName = "virtualNodeTags")]
        public VirtualNodeTags VirtualNodeTags { get; set; }
        
    }
}