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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// A resource and its category.
    /// </summary>
    public class LogAnalyticsResourceCategory 
    {
        
        /// <value>
        /// The unique identifier of the resource, usually a name or ocid.
        /// </value>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
        
        /// <value>
        /// The resource type.
        /// </value>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }
        
        /// <value>
        /// The category name to which this resource belongs.
        /// </value>
        [JsonProperty(PropertyName = "categoryName")]
        public string CategoryName { get; set; }
        
        /// <value>
        /// The system flag. A value of false denotes a user-created category assignment.
        /// A value of true denotes an Oracle-defined category assignment.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSystem")]
        public System.Nullable<bool> IsSystem { get; set; }
        
    }
}
