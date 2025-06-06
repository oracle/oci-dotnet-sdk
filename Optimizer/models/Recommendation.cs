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


namespace Oci.OptimizerService.Models
{
    /// <summary>
    /// The metadata associated with the recommendation.
    /// 
    /// </summary>
    public class Recommendation 
    {
        
        /// <value>
        /// The unique OCID associated with the recommendation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the tenancy. The tenancy is the root compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
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
        /// The name assigned to the recommendation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Text describing the recommendation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Description is required.")]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The level of importance assigned to the recommendation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Importance is required.")]
        [JsonProperty(PropertyName = "importance")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<Importance> Importance { get; set; }
        
        /// <value>
        /// An array of `ResourceCount` objects grouped by the status of the resource actions.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceCounts is required.")]
        [JsonProperty(PropertyName = "resourceCounts")]
        public System.Collections.Generic.List<ResourceCount> ResourceCounts { get; set; }
        
        /// <value>
        /// The recommendation's current state.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// The estimated cost savings, in dollars, for the recommendation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EstimatedCostSaving is required.")]
        [JsonProperty(PropertyName = "estimatedCostSaving")]
        public System.Double EstimatedCostSaving { get; set; }
        
        /// <value>
        /// The current status of the recommendation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<Status> Status { get; set; }
        
        /// <value>
        /// The date and time that the recommendation entered its current status. The format is defined by RFC3339.
        /// <br/>
        /// For example, \"The status of the recommendation changed from `pending` to `current(ignored)` on this date and time.\"
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
        /// For example, \"The current `postponed` status of the recommendation will end and change to `pending` on this
        /// date and time.\"
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeStatusEnd")]
        public System.Nullable<System.DateTime> TimeStatusEnd { get; set; }
        
        /// <value>
        /// The date and time the recommendation details were created, in the format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the recommendation details were last updated, in the format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        [JsonProperty(PropertyName = "supportedLevels")]
        public SupportedLevels SupportedLevels { get; set; }
        
        /// <value>
        /// Additional metadata key/value pairs for the recommendation.
        /// <br/>
        /// For Example: {&quot;EstimatedSaving&quot;: &quot;200&quot;}
        /// </value>
        [JsonProperty(PropertyName = "extendedMetadata")]
        public System.Collections.Generic.Dictionary<string, string> ExtendedMetadata { get; set; }
        
    }
}
