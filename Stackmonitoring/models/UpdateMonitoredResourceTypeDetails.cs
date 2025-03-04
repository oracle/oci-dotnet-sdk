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


namespace Oci.StackmonitoringService.Models
{
    /// <summary>
    /// The information to be updated for the monitored resource type.
    /// </summary>
    public class UpdateMonitoredResourceTypeDetails 
    {
        
        /// <value>
        /// Monitored resource type display name.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A friendly description.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Metric namespace for resource type.
        /// </value>
        [JsonProperty(PropertyName = "metricNamespace")]
        public string MetricNamespace { get; set; }
        
        /// <value>
        /// Source type to indicate if the resource is stack monitoring discovered, OCI native resource, etc.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sourceType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SourceType> SourceType { get; set; }
        
        /// <value>
        /// Resource Category to indicate the kind of resource type.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "resourceCategory")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ResourceCategory> ResourceCategory { get; set; }
        
        [JsonProperty(PropertyName = "metadata")]
        public ResourceTypeMetadataDetails Metadata { get; set; }
        
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
