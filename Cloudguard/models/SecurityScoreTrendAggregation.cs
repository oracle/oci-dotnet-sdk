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
    /// Provides the dimensions and their corresponding time and security score.
    /// </summary>
    public class SecurityScoreTrendAggregation 
    {
        
        /// <value>
        /// The key-value pairs of dimensions and their names
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DimensionsMap is required.")]
        [JsonProperty(PropertyName = "dimensionsMap")]
        public System.Collections.Generic.Dictionary<string, string> DimensionsMap { get; set; }
        
        /// <value>
        /// Start time in epoch seconds
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StartTimestamp is required.")]
        [JsonProperty(PropertyName = "startTimestamp")]
        public System.Nullable<decimal> StartTimestamp { get; set; }
        
        /// <value>
        /// Duration
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DurationInSeconds is required.")]
        [JsonProperty(PropertyName = "durationInSeconds")]
        public System.Nullable<int> DurationInSeconds { get; set; }
        
        /// <value>
        /// The security rating with given dimensions and time range
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SecurityRating is required.")]
        [JsonProperty(PropertyName = "securityRating")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SecurityRating> SecurityRating { get; set; }
        
        /// <value>
        /// The security score with given dimensions and time range
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SecurityScore is required.")]
        [JsonProperty(PropertyName = "securityScore")]
        public System.Nullable<int> SecurityScore { get; set; }
        
    }
}
