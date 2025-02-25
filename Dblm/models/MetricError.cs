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


namespace Oci.DblmService.Models
{
    /// <summary>
    /// Metric error content.
    /// </summary>
    public class MetricError 
    {
        
        /// <value>
        /// Time the error record was generated
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeGenerated is required.")]
        [JsonProperty(PropertyName = "timeGenerated")]
        public System.Nullable<System.DateTime> TimeGenerated { get; set; }
        
        /// <value>
        /// Error type
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ErrorType is required.")]
        [JsonProperty(PropertyName = "errorType")]
        public string ErrorType { get; set; }
        
        /// <value>
        /// Content type
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ContentType is required.")]
        [JsonProperty(PropertyName = "contentType")]
        public string ContentType { get; set; }
        
        /// <value>
        /// Data
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Data is required.")]
        [JsonProperty(PropertyName = "data")]
        public string Data { get; set; }
        
        /// <value>
        /// Subject
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Subject is required.")]
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }
        
        /// <value>
        /// Level
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Level is required.")]
        [JsonProperty(PropertyName = "level")]
        public string Level { get; set; }
        
    }
}
