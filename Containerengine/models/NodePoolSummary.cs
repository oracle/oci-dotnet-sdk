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


namespace Oci.ContainerengineService.Models
{
    /// <summary>
    /// The properties that define a node pool summary.
    /// </summary>
    public class NodePoolSummary 
    {
        
        /// <value>
        /// The OCID of the node pool.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The state of the nodepool. For more information, see [Monitoring Clusters](https://docs.cloud.oracle.com/Content/ContEng/Tasks/contengmonitoringclusters.htm)
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<NodePoolLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Details about the state of the nodepool.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The OCID of the compartment in which the node pool exists.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The OCID of the cluster to which this node pool is attached.
        /// </value>
        [JsonProperty(PropertyName = "clusterId")]
        public string ClusterId { get; set; }
        
        /// <value>
        /// The name of the node pool.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The version of Kubernetes running on the nodes in the node pool.
        /// </value>
        [JsonProperty(PropertyName = "kubernetesVersion")]
        public string KubernetesVersion { get; set; }
        
        /// <value>
        /// Deprecated. see `nodeSource`. The OCID of the image running on the nodes in the node pool.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nodeImageId")]
        public string NodeImageId { get; set; }
        
        /// <value>
        /// Deprecated. see `nodeSource`. The name of the image running on the nodes in the node pool.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nodeImageName")]
        public string NodeImageName { get; set; }
        
        /// <value>
        /// The shape configuration of the nodes.
        /// </value>
        [JsonProperty(PropertyName = "nodeShapeConfig")]
        public NodeShapeConfig NodeShapeConfig { get; set; }
        
        /// <value>
        /// Deprecated. see `nodeSourceDetails`. Source running on the nodes in the node pool.
        /// </value>
        [JsonProperty(PropertyName = "nodeSource")]
        public NodeSourceOption NodeSource { get; set; }
        
        /// <value>
        /// Source running on the nodes in the node pool.
        /// </value>
        [JsonProperty(PropertyName = "nodeSourceDetails")]
        public NodeSourceDetails NodeSourceDetails { get; set; }
        
        /// <value>
        /// The name of the node shape of the nodes in the node pool.
        /// </value>
        [JsonProperty(PropertyName = "nodeShape")]
        public string NodeShape { get; set; }
        
        /// <value>
        /// A list of key/value pairs to add to nodes after they join the Kubernetes cluster.
        /// </value>
        [JsonProperty(PropertyName = "initialNodeLabels")]
        public System.Collections.Generic.List<KeyValue> InitialNodeLabels { get; set; }
        
        /// <value>
        /// The SSH public key on each node in the node pool on launch.
        /// </value>
        [JsonProperty(PropertyName = "sshPublicKey")]
        public string SshPublicKey { get; set; }
        
        /// <value>
        /// The number of nodes in each subnet.
        /// </value>
        [JsonProperty(PropertyName = "quantityPerSubnet")]
        public System.Nullable<int> QuantityPerSubnet { get; set; }
        
        /// <value>
        /// The OCIDs of the subnets in which to place nodes for this node pool.
        /// </value>
        [JsonProperty(PropertyName = "subnetIds")]
        public System.Collections.Generic.List<string> SubnetIds { get; set; }
        
        /// <value>
        /// The configuration of nodes in the node pool.
        /// </value>
        [JsonProperty(PropertyName = "nodeConfigDetails")]
        public NodePoolNodeConfigDetails NodeConfigDetails { get; set; }
        
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
        
        /// <value>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
        [JsonProperty(PropertyName = "nodeEvictionNodePoolSettings")]
        public NodeEvictionNodePoolSettings NodeEvictionNodePoolSettings { get; set; }
        
        [JsonProperty(PropertyName = "nodePoolCyclingDetails")]
        public NodePoolCyclingDetails NodePoolCyclingDetails { get; set; }
        
    }
}
