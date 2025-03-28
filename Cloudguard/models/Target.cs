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


namespace Oci.CloudguardService.Models
{
    /// <summary>
    /// A target defines the scope of resources that Cloud Guard
    /// monitors and the rules to be enforced in that monitoring. A Target resource
    /// contains the settings for a specific target.
    /// 
    /// </summary>
    public class Target 
    {
        
        /// <value>
        /// Unique identifier that can't be changed after creation
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Target display name
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Compartment OCID where the resource is created
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The target description
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Type of target
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetResourceType is required.")]
        [JsonProperty(PropertyName = "targetResourceType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TargetResourceType> TargetResourceType { get; set; }
        
        /// <value>
        /// Resource ID which the target uses to monitor
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetResourceId is required.")]
        [JsonProperty(PropertyName = "targetResourceId")]
        public string TargetResourceId { get; set; }
        
        /// <value>
        /// Total number of recipes attached to target
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RecipeCount is required.")]
        [JsonProperty(PropertyName = "recipeCount")]
        public System.Nullable<int> RecipeCount { get; set; }
        
        /// <value>
        /// List of detector recipes attached to target
        /// </value>
        [JsonProperty(PropertyName = "targetDetectorRecipes")]
        public System.Collections.Generic.List<TargetDetectorRecipe> TargetDetectorRecipes { get; set; }
        
        /// <value>
        /// List of responder recipes attached to target
        /// </value>
        [JsonProperty(PropertyName = "targetResponderRecipes")]
        public System.Collections.Generic.List<TargetResponderRecipe> TargetResponderRecipes { get; set; }
        
        [JsonProperty(PropertyName = "targetDetails")]
        public TargetDetails TargetDetails { get; set; }
        
        /// <value>
        /// List of inherited compartments
        /// </value>
        [JsonProperty(PropertyName = "inheritedByCompartments")]
        public System.Collections.Generic.List<string> InheritedByCompartments { get; set; }
        
        /// <value>
        /// The date and time the target was created. Format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the target was last updated. Format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The current lifecycle state of the target
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the current lifecycle state in more detail. For example, can be used to provide actionable information for a resource in Failed state. [DEPRECATE]
        /// </value>
        [JsonProperty(PropertyName = "lifecyleDetails")]
        public string LifecyleDetails { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}Avoid entering confidential information.
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
        /// System tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// System tags can be viewed by users, but can only be created by the system.
        /// <br/>
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
