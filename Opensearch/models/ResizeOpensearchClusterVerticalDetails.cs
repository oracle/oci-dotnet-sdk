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
    /// The OCPU and memory configuration to update on an existing OpenSearch cluster for [vertical resizing](https://docs.cloud.oracle.com/iaas/Content/search-opensearch/Tasks/resizingacluster.htm#vertical).
    /// </summary>
    public class ResizeOpensearchClusterVerticalDetails 
    {
        
        /// <value>
        /// The number of OCPUs to configure for the cluster's master nodes.
        /// </value>
        [JsonProperty(PropertyName = "masterNodeHostOcpuCount")]
        public System.Nullable<int> MasterNodeHostOcpuCount { get; set; }
        
        /// <value>
        /// The amount of memory in GB, to configure for the cluster's master nodes.
        /// </value>
        [JsonProperty(PropertyName = "masterNodeHostMemoryGB")]
        public System.Nullable<int> MasterNodeHostMemoryGB { get; set; }
        
        /// <value>
        /// The node shape for the cluster's master nodes.
        /// </value>
        [JsonProperty(PropertyName = "masterNodeHostShape")]
        public string MasterNodeHostShape { get; set; }
        
        /// <value>
        /// The number of OCPUs to configure for the cluster's data nodes.
        /// </value>
        [JsonProperty(PropertyName = "dataNodeHostOcpuCount")]
        public System.Nullable<int> DataNodeHostOcpuCount { get; set; }
        
        /// <value>
        /// The amount of memory in GB, to configure for the cluster's data nodes.
        /// </value>
        [JsonProperty(PropertyName = "dataNodeHostMemoryGB")]
        public System.Nullable<int> DataNodeHostMemoryGB { get; set; }
        
        /// <value>
        /// The amount of storage in GB, to configure per node for the cluster's data nodes.
        /// </value>
        [JsonProperty(PropertyName = "dataNodeStorageGB")]
        public System.Nullable<int> DataNodeStorageGB { get; set; }
        
        /// <value>
        /// The node shape for the cluster's data nodes.
        /// </value>
        [JsonProperty(PropertyName = "dataNodeHostShape")]
        public string DataNodeHostShape { get; set; }
        
        /// <value>
        /// The number of OCPUs to configure for the cluster's OpenSearch Dashboard nodes.
        /// </value>
        [JsonProperty(PropertyName = "opendashboardNodeHostOcpuCount")]
        public System.Nullable<int> OpendashboardNodeHostOcpuCount { get; set; }
        
        /// <value>
        /// The amount of memory in GB, to configure for the cluster's OpenSearch Dashboard nodes.
        /// </value>
        [JsonProperty(PropertyName = "opendashboardNodeHostMemoryGB")]
        public System.Nullable<int> OpendashboardNodeHostMemoryGB { get; set; }
        
        /// <value>
        /// The node shape for the cluster's OpenSearch Dashboard nodes.
        /// </value>
        [JsonProperty(PropertyName = "opendashboardNodeHostShape")]
        public string OpendashboardNodeHostShape { get; set; }
        
        /// <value>
        /// The node shape for the cluster's search nodes.
        /// </value>
        [JsonProperty(PropertyName = "searchNodeHostShape")]
        public string SearchNodeHostShape { get; set; }
        
        /// <value>
        /// The number of OCPUs configured for the cluster's search nodes.
        /// </value>
        [JsonProperty(PropertyName = "searchNodeHostOcpuCount")]
        public System.Nullable<int> SearchNodeHostOcpuCount { get; set; }
        
        /// <value>
        /// The amount of memory in GB, for the cluster's search nodes.
        /// </value>
        [JsonProperty(PropertyName = "searchNodeHostMemoryGB")]
        public System.Nullable<int> SearchNodeHostMemoryGB { get; set; }
        
        /// <value>
        /// The amount of storage in GB, to configure per node for the cluster's search nodes.
        /// </value>
        [JsonProperty(PropertyName = "searchNodeStorageGB")]
        public System.Nullable<int> SearchNodeStorageGB { get; set; }
        
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
        
    }
}
