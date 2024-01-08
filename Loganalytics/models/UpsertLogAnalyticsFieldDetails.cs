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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// Upsert LogAnalytics Field Details
    /// </summary>
    public class UpsertLogAnalyticsFieldDetails 
    {
        
        /// <value>
        /// The data type.
        /// </value>
        [JsonProperty(PropertyName = "dataType")]
        public string DataType { get; set; }
        
        /// <value>
        /// A flag indicating whether or not the field is multi-valued.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isMultiValued")]
        public System.Nullable<bool> IsMultiValued { get; set; }
        
        /// <value>
        /// The field description.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The field display name.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The field internal name.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
    }
}
