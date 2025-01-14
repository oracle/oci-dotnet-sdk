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
    /// Parameters to update a detector recipe attached to a target.
    /// </summary>
    public class UpdateTargetDetectorRecipe 
    {
        
        /// <value>
        /// Unique identifier for target detector recipe
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetDetectorRecipeId is required.")]
        [JsonProperty(PropertyName = "targetDetectorRecipeId")]
        public string TargetDetectorRecipeId { get; set; }
        
        /// <value>
        /// Updates to be applied to detector rules in target detector recipe
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DetectorRules is required.")]
        [JsonProperty(PropertyName = "detectorRules")]
        public System.Collections.Generic.List<UpdateTargetRecipeDetectorRuleDetails> DetectorRules { get; set; }
        
    }
}
