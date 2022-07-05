/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.OptimizerService.Models
{
    /// <summary>
    /// The metadata associated with the resource action summary.
    /// 
    /// </summary>
    public class ResourceActionSummary 
    {
        
        /// <value>
        /// The unique OCID associated with the resource action.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The unique OCID associated with the category.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CategoryId is required.")]
        [JsonProperty(PropertyName = "categoryId")]
        public string CategoryId { get; set; }
        
        /// <value>
        /// The unique OCID associated with the recommendation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RecommendationId is required.")]
        [JsonProperty(PropertyName = "recommendationId")]
        public string RecommendationId { get; set; }
        
        /// <value>
        /// The unique OCID associated with the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceId is required.")]
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
        
        /// <value>
        /// The name assigned to the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The kind of resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceType is required.")]
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }
        
        /// <value>
        /// The OCID of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The name associated with the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentName is required.")]
        [JsonProperty(PropertyName = "compartmentName")]
        public string CompartmentName { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Action is required.")]
        [JsonProperty(PropertyName = "action")]
        public Action Action { get; set; }
        
        /// <value>
        /// The resource action's current state.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// The estimated cost savings, in dollars, for the resource action.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EstimatedCostSaving is required.")]
        [JsonProperty(PropertyName = "estimatedCostSaving")]
        public System.Double EstimatedCostSaving { get; set; }
        
        /// <value>
        /// The current status of the resource action.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<Status> Status { get; set; }
        
        /// <value>
        /// The date and time that the resource action entered its current status. The format is defined by RFC3339.
        /// <br/>
        /// For example, \"The status of the resource action changed from `pending` to `current(ignored)` on this date and time.\"
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeStatusBegin is required.")]
        [JsonProperty(PropertyName = "timeStatusBegin")]
        public System.Nullable<System.DateTime> TimeStatusBegin { get; set; }
        
        /// <value>
        /// The date and time the current status will change. The format is defined by RFC3339.
        /// <br/>
        /// For example, \"The current `postponed` status of the resource action will end and change to `pending` on this
        /// date and time.\"
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeStatusEnd")]
        public System.Nullable<System.DateTime> TimeStatusEnd { get; set; }
        
        /// <value>
        /// Custom metadata key/value pairs for the resource action.
        /// <br/>
        ///  **Metadata Example**
        /// <br/>
        ///       \"metadata\" : {
        ///          \"cpuRecommendedShape\": \"VM.Standard1.1\",
        ///          \"computeMemoryUtilization\": \"26.05734124418388\",
        ///          \"currentShape\": \"VM.Standard1.2\",
        ///          \"instanceRecommendedShape\": \"VM.Standard1.1\",
        ///          \"computeCpuUtilization\": \"7.930035319720132\",
        ///          \"memoryRecommendedShape\": \"None\"
        ///       }
        /// 
        /// </value>
        [JsonProperty(PropertyName = "metadata")]
        public System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }
        
        /// <value>
        /// Additional metadata key/value pairs that you provide.
        /// They serve the same purpose and functionality as fields in the `metadata` object.
        /// <br/>
        /// They are distinguished from `metadata` fields in that these can be nested JSON objects (whereas `metadata` fields are string/string maps only).
        /// <br/>
        /// For Example: {&quot;CurrentShape&quot;: {&quot;name&quot;:&quot;VM.Standard2.16&quot;}, &quot;RecommendedShape&quot;: {&quot;name&quot;:&quot;VM.Standard2.8&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "extendedMetadata")]
        public System.Collections.Generic.Dictionary<string, System.Object> ExtendedMetadata { get; set; }
        
        /// <value>
        /// The date and time the resource action details were created, in the format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the resource action details were last updated, in the format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
    }
}
