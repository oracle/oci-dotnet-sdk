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
    /// A TargetDetectorRecipe resource contains a specific instance of one of the
    /// supported detector types (for example, activity, configuration, or threat)
    /// in which some settings can be modified specifically for a single target.
    /// <br/>
    /// A TargetDetectorRecipe resource:
    /// * Is effectively a copy of a DetectorRecipe resource in which users can make
    /// very limited changes if it\u2019s Oracle-managed, and more changes if it\u2019s user-managed.
    /// * Is visible on the Cloud Guard Targets, Target Details page.
    /// * Is located in a specific OCI compartment.
    /// * Can be modified by users, programmatically or through the UI.
    /// * Changes that can be made here override any settings in the corresponding
    /// DetectorRecipe, of which the TargetDetectorRecipe resource is effectively a copy,
    /// created when the detector recipe is attached to the target.
    /// 
    /// </summary>
    public class TargetDetectorRecipe 
    {
        
        /// <value>
        /// OCID for the detector recipe
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Display name of the detector recipe
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Detector recipe description.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Compartment OCID of the detector recipe
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Unique identifier for of original Oracle-managed detector recipe on which the TargetDetectorRecipe is based
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DetectorRecipeId is required.")]
        [JsonProperty(PropertyName = "detectorRecipeId")]
        public string DetectorRecipeId { get; set; }
        
        /// <value>
        /// Owner of the detector recipe
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Owner is required.")]
        [JsonProperty(PropertyName = "owner")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OwnerType> Owner { get; set; }
        
        /// <value>
        /// Type of detector
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Detector is required.")]
        [JsonProperty(PropertyName = "detector")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DetectorEnum> Detector { get; set; }
        
        /// <value>
        /// List of detector rules for the detector recipe - user input
        /// </value>
        [JsonProperty(PropertyName = "detectorRules")]
        public System.Collections.Generic.List<TargetDetectorRecipeDetectorRule> DetectorRules { get; set; }
        
        /// <value>
        /// List of currently enabled detector rules for the detector type for recipe after applying defaults
        /// </value>
        [JsonProperty(PropertyName = "effectiveDetectorRules")]
        public System.Collections.Generic.List<TargetDetectorRecipeDetectorRule> EffectiveDetectorRules { get; set; }
        
        /// <value>
        /// The date and time the target detector recipe was created. Format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the target detector recipe was last updated. Format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The current lifecycle state of the resource
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Locks associated with this resource.
        /// </value>
        [JsonProperty(PropertyName = "locks")]
        public System.Collections.Generic.List<ResourceLock> Locks { get; set; }
        
        /// <value>
        /// Recipe type ( STANDARD, ENTERPRISE )
        /// </value>
        [JsonProperty(PropertyName = "detectorRecipeType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DetectorRecipeEnum> DetectorRecipeType { get; set; }
        
        /// <value>
        /// The number of days for which source data is retained
        /// </value>
        [JsonProperty(PropertyName = "sourceDataRetention")]
        public System.Nullable<int> SourceDataRetention { get; set; }
        
    }
}
