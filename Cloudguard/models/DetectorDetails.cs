/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
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
    /// Detailed information for a detector.
    /// </summary>
    public class DetectorDetails 
    {
        
        /// <value>
        /// Enablement status for the rule
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsEnabled is required.")]
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        
        /// <value>
        /// The risk level for the rule
        /// </value>
        [JsonProperty(PropertyName = "riskLevel")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
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
        /// Can the rule be configured?
        /// </value>
        [JsonProperty(PropertyName = "isConfigurationAllowed")]
        public System.Nullable<bool> IsConfigurationAllowed { get; set; }
        
        /// <value>
        /// The point at which an elevated resource risk score creates a problem
        /// </value>
        [JsonProperty(PropertyName = "problemThreshold")]
        public System.Nullable<int> ProblemThreshold { get; set; }
        
        /// <value>
        /// List of target types for which the detector rule is applicable
        /// </value>
        [JsonProperty(PropertyName = "targetTypes")]
        public System.Collections.Generic.List<string> TargetTypes { get; set; }
        
        /// <value>
        /// List of sighting types
        /// </value>
        [JsonProperty(PropertyName = "sightingTypes")]
        public System.Collections.Generic.List<SightingType> SightingTypes { get; set; }
        
        /// <value>
        /// Description for detector recipe detector rule
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Recommendation for detector recipe detector rule
        /// </value>
        [JsonProperty(PropertyName = "recommendation")]
        public string Recommendation { get; set; }
        
        /// <value>
        /// The ID of the attached data source
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
