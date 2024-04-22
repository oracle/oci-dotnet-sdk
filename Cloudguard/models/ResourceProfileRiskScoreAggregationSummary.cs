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
    /// Summary of resource profile risk score aggregations.
    /// </summary>
    public class ResourceProfileRiskScoreAggregationSummary 
    {
        
        /// <value>
        /// OCID for the resource profile
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceProfileId is required.")]
        [JsonProperty(PropertyName = "resourceProfileId")]
        public string ResourceProfileId { get; set; }
        
        /// <value>
        /// Display name for the resource profile
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceProfileDisplayName is required.")]
        [JsonProperty(PropertyName = "resourceProfileDisplayName")]
        public string ResourceProfileDisplayName { get; set; }
        
        /// <value>
        /// Risk score value that triggers a problem
        /// </value>
        [JsonProperty(PropertyName = "riskThreshold")]
        public System.Nullable<int> RiskThreshold { get; set; }
        
        /// <value>
        /// List of ResourceRiskScoreAggregation resources
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Items is required.")]
        [JsonProperty(PropertyName = "items")]
        public System.Collections.Generic.List<ResourceRiskScoreAggregation> Items { get; set; }
        
    }
}
