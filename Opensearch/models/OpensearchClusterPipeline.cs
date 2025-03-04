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


namespace Oci.OpensearchService.Models
{
    /// <summary>
    /// An OpenSearch cluster Pipeline resource. An cluster is set of instances that provide OpenSearch functionality in OCI Search Service with OpenSearch.
    /// For more information, see [Cluster Pipelines](https://docs.cloud.oracle.com/iaas/Content/search-opensearch/Concepts/ociopensearchpipeline.htm).
    /// 
    /// </summary>
    public class OpensearchClusterPipeline 
    {
        
        /// <value>
        /// The OCID of the cluster pipeline.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The name of the pipeline. Avoid entering confidential information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The OCID of the compartment where the pipeline is located.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The OCID of the pipeline's VCN.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VcnId is required.")]
        [JsonProperty(PropertyName = "vcnId")]
        public string VcnId { get; set; }
        
        /// <value>
        /// The OCID of the pipeline's subnet.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// The OCID for the compartment where the pipeline's VCN is located.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VcnCompartmentId is required.")]
        [JsonProperty(PropertyName = "vcnCompartmentId")]
        public string VcnCompartmentId { get; set; }
        
        /// <value>
        /// The OCID for the compartment where the pipwline's subnet is located.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetCompartmentId is required.")]
        [JsonProperty(PropertyName = "subnetCompartmentId")]
        public string SubnetCompartmentId { get; set; }
        
        /// <value>
        /// The maximum pipeline capacity, in OCPUs.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MaxOcpuCount is required.")]
        [JsonProperty(PropertyName = "maxOcpuCount")]
        public System.Nullable<int> MaxOcpuCount { get; set; }
        
        /// <value>
        /// The maximum pipeline capacity, in OCPUs.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MinOcpuCount is required.")]
        [JsonProperty(PropertyName = "minOcpuCount")]
        public System.Nullable<int> MinOcpuCount { get; set; }
        
        /// <value>
        /// The maximum amount of memory in GB, for the pipeline.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MaxMemoryGB is required.")]
        [JsonProperty(PropertyName = "maxMemoryGB")]
        public System.Nullable<int> MaxMemoryGB { get; set; }
        
        /// <value>
        /// The minimum amount of memory in GB, for the pipeline.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MinMemoryGB is required.")]
        [JsonProperty(PropertyName = "minMemoryGB")]
        public System.Nullable<int> MinMemoryGB { get; set; }
        
        /// <value>
        /// The pipeline configuration in YAML format. The command accepts the pipeline configuration as a string or within a .yaml file. If you provide the configuration as a string, each new line must be escaped with \\.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PipelineConfigurationBody is required.")]
        [JsonProperty(PropertyName = "pipelineConfigurationBody")]
        public string PipelineConfigurationBody { get; set; }
        
        /// <value>
        /// The fully qualified domain name (FQDN) for the cluster's API endpoint.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OpensearchPipelineFqdn is required.")]
        [JsonProperty(PropertyName = "opensearchPipelineFqdn")]
        public string OpensearchPipelineFqdn { get; set; }
        
        /// <value>
        /// The pipeline's private IP address.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OpensearchPipelinePrivateIp is required.")]
        [JsonProperty(PropertyName = "opensearchPipelinePrivateIp")]
        public string OpensearchPipelinePrivateIp { get; set; }
                ///
        /// <value>
        /// The current state of the cluster backup.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current state of the cluster backup.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time the cluster pipeline was created. Format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The amount of time in milliseconds since the pipeline was updated.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
