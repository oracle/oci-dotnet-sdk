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


namespace Oci.ObjectstorageService.Models
{
    /// <summary>
    /// The summary of a retention rule.
    /// </summary>
    public class RetentionRuleSummary 
    {
        
        /// <value>
        /// Unique identifier for the retention rule.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// User specified name for the retention rule.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        [JsonProperty(PropertyName = "duration")]
        public Duration Duration { get; set; }
        
        /// <value>
        /// The entity tag (ETag) for the retention rule.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Etag is required.")]
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }
        
        /// <value>
        /// The date and time as per [RFC 3339](https://tools.ietf.org/html/rfc3339) after which this rule becomes locked.
        /// and can only be deleted by deleting the bucket.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeRuleLocked")]
        public System.Nullable<System.DateTime> TimeRuleLocked { get; set; }
        
        /// <value>
        /// The date and time that the retention rule was created as per [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time that the retention rule was modified as per [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeModified is required.")]
        [JsonProperty(PropertyName = "timeModified")]
        public System.Nullable<System.DateTime> TimeModified { get; set; }
        
    }
}
