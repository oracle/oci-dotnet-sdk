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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Summarizes a specific ADDM finding
    /// </summary>
    public class AddmDbFindingAggregation 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the Database insight.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Unique finding id
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FindingId is required.")]
        [JsonProperty(PropertyName = "findingId")]
        public string FindingId { get; set; }
        
        /// <value>
        /// Category name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CategoryName is required.")]
        [JsonProperty(PropertyName = "categoryName")]
        public string CategoryName { get; set; }
        
        /// <value>
        /// Category display name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CategoryDisplayName is required.")]
        [JsonProperty(PropertyName = "categoryDisplayName")]
        public string CategoryDisplayName { get; set; }
        
        /// <value>
        /// Finding name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Finding message
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Message is required.")]
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        
        /// <value>
        /// Overall impact in terms of percentage of total activity
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ImpactOverallPercent is required.")]
        [JsonProperty(PropertyName = "impactOverallPercent")]
        public System.Double ImpactOverallPercent { get; set; }
        
        /// <value>
        /// Maximum impact in terms of percentage of total activity
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ImpactMaxPercent is required.")]
        [JsonProperty(PropertyName = "impactMaxPercent")]
        public System.Double ImpactMaxPercent { get; set; }
        
        /// <value>
        /// Impact in terms of average active sessions
        /// </value>
        [JsonProperty(PropertyName = "impactAvgActiveSessions")]
        public System.Double ImpactAvgActiveSessions { get; set; }
        
        /// <value>
        /// Number of occurrences for this finding
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FrequencyCount is required.")]
        [JsonProperty(PropertyName = "frequencyCount")]
        public System.Nullable<int> FrequencyCount { get; set; }
        
        /// <value>
        /// Number of recommendations for this finding
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RecommendationCount is required.")]
        [JsonProperty(PropertyName = "recommendationCount")]
        public System.Nullable<int> RecommendationCount { get; set; }
        
    }
}
