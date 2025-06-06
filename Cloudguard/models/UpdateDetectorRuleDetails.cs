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
    /// Parameters to be updated for a detector rule within a detector recipe.
    /// </summary>
    public class UpdateDetectorRuleDetails 
    {
        
        /// <value>
        /// Enablement status of the detector rule
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsEnabled is required.")]
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        
        /// <value>
        /// The risk level of the detector rule
        /// </value>
        [JsonProperty(PropertyName = "riskLevel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RiskLevel> RiskLevel { get; set; }
        
        /// <value>
        /// List of detector rule configurations
        /// </value>
        [JsonProperty(PropertyName = "configurations")]
        public System.Collections.Generic.List<DetectorConfiguration> Configurations { get; set; }
        
        [JsonProperty(PropertyName = "condition")]
        public Condition Condition { get; set; }
        
        /// <value>
        /// User-defined labels for a detector rule
        /// </value>
        [JsonProperty(PropertyName = "labels")]
        public System.Collections.Generic.List<string> Labels { get; set; }
        
        /// <value>
        /// Description for the detector rule
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Recommendation for the detector rule
        /// </value>
        [JsonProperty(PropertyName = "recommendation")]
        public string Recommendation { get; set; }
        
        /// <value>
        /// The unique identifier of the attached data source
        /// </value>
        [JsonProperty(PropertyName = "dataSourceId")]
        public string DataSourceId { get; set; }
        
        /// <value>
        /// Data source entities mapping for a detector rule
        /// </value>
        [JsonProperty(PropertyName = "entitiesMappings")]
        public System.Collections.Generic.List<EntitiesMapping> EntitiesMappings { get; set; }
        
    }
}
