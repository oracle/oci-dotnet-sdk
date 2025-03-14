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


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// Job metric summary.
    /// </summary>
    public class JobMetricSummary 
    {
        
        /// <value>
        /// Key of the job metric that is immutable.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// Detailed description of the metric.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The unique key of the parent job execution for which the job metric resource was created.
        /// </value>
        [JsonProperty(PropertyName = "jobExecutionKey")]
        public string JobExecutionKey { get; set; }
        
        /// <value>
        /// URI to the job metric instance in the API.
        /// </value>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }
        
        /// <value>
        /// The date and time the job metric was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2019-03-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time the metric was logged or captured in the system where the job executed.
        /// An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeInserted")]
        public System.Nullable<System.DateTime> TimeInserted { get; set; }
        
        /// <value>
        /// Category of this metric.
        /// </value>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }
        
        /// <value>
        /// A user-friendly display name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Sub category of this metric under the category. Used for aggregating values. May be null.
        /// </value>
        [JsonProperty(PropertyName = "subCategory")]
        public string SubCategory { get; set; }
        
        /// <value>
        /// Unit of this metric.
        /// </value>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }
        
        /// <value>
        /// Value of this metric.
        /// </value>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        /// <value>
        /// Batch key for grouping, may be null.
        /// </value>
        [JsonProperty(PropertyName = "batchKey")]
        public string BatchKey { get; set; }
        
    }
}
