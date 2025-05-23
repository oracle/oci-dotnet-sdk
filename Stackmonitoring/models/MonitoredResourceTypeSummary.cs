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
    /// The summary of monitored resource type.
    /// </summary>
    public class MonitoredResourceTypeSummary 
    {
        
        /// <value>
        /// Monitored resource type identifier [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// A unique monitored resource type name. The name must be unique across tenancy. 
        /// Name can not be changed.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
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
        /// Compartment Identifier [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        [JsonProperty(PropertyName = "availabilityMetricsConfig")]
        public AvailabilityMetricsDetails AvailabilityMetricsConfig { get; set; }
        
        [JsonProperty(PropertyName = "handlerConfig")]
        public AgentExtensionHandlerConfiguration HandlerConfig { get; set; }
        
        /// <value>
        /// If boolean flag is true, then the resource type cannot be modified or deleted.
        /// </value>
        [JsonProperty(PropertyName = "isSystemDefined")]
        public System.Nullable<bool> IsSystemDefined { get; set; }
        
        /// <value>
        /// Lifecycle state of the monitored resource type.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ResourceTypeLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Source type to indicate if the resource is stack monitoring discovered, OCI native resource, etc.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sourceType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SourceType> SourceType { get; set; }
        
        /// <value>
        /// Resource Category to indicate the kind of resource type.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "resourceCategory")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ResourceCategory> ResourceCategory { get; set; }
        
        [JsonProperty(PropertyName = "metadata")]
        public ResourceTypeMetadataDetails Metadata { get; set; }
        
        /// <value>
        /// Key/Value pair for additional namespaces used by stack monitoring services for SYSTEM (SMB) resource types.
        /// </value>
        [JsonProperty(PropertyName = "additionalNamespaceMap")]
        public System.Collections.Generic.Dictionary<string, string> AdditionalNamespaceMap { get; set; }
        
        /// <value>
        /// The date and time when the monitored resource type was created, expressed in 
        /// [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time when the monitored resource was updated, expressed in 
        /// [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.
        /// 
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
