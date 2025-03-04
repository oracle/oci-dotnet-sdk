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
    /// The properties that define a request to create a cluster.
    /// </summary>
    public class CreateClusterDetails 
    {
        
        /// <value>
        /// The name of the cluster. Avoid entering confidential information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The OCID of the compartment in which to create the cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The network configuration for access to the Cluster control plane.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "endpointConfig")]
        public CreateClusterEndpointConfigDetails EndpointConfig { get; set; }
        
        /// <value>
        /// The OCID of the virtual cloud network (VCN) in which to create the cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VcnId is required.")]
        [JsonProperty(PropertyName = "vcnId")]
        public string VcnId { get; set; }
        
        /// <value>
        /// The version of Kubernetes to install into the cluster masters.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "KubernetesVersion is required.")]
        [JsonProperty(PropertyName = "kubernetesVersion")]
        public string KubernetesVersion { get; set; }
        
        /// <value>
        /// The OCID of the KMS key to be used as the master encryption key for Kubernetes secret encryption.
        /// When used, `kubernetesVersion` must be at least `v1.13.0`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyId")]
        public string KmsKeyId { get; set; }
        
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
        /// Optional attributes for the cluster.
        /// </value>
        [JsonProperty(PropertyName = "options")]
        public ClusterCreateOptions Options { get; set; }
        
        /// <value>
        /// The image verification policy for signature validation. Once a policy is created and enabled with
        /// one or more kms keys, the policy will ensure all images deployed has been signed with the key(s)
        /// attached to the policy.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "imagePolicyConfig")]
        public CreateImagePolicyConfigDetails ImagePolicyConfig { get; set; }
        
        /// <value>
        /// Available CNIs and network options for existing and new node pools of the cluster
        /// </value>
        [JsonProperty(PropertyName = "clusterPodNetworkOptions")]
        public System.Collections.Generic.List<ClusterPodNetworkOptionDetails> ClusterPodNetworkOptions { get; set; }
        
        /// <value>
        /// Type of cluster
        /// </value>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ClusterType> Type { get; set; }
        
    }
}
