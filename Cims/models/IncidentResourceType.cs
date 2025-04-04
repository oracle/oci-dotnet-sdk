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


namespace Oci.CimsService.Models
{
    /// <summary>
    /// Details about the resource associated with the support request.
    /// </summary>
    public class IncidentResourceType 
    {
        
        /// <value>
        /// A unique identifier for the resource.
        /// </value>
        [JsonProperty(PropertyName = "resourceTypeKey")]
        public string ResourceTypeKey { get; set; }
        
        /// <value>
        /// The display name of the resource.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The label associated with the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Label is required.")]
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }
        
        /// <value>
        /// The description of the resource.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Indicates whether multi-subscription is supported
        /// </value>
        [JsonProperty(PropertyName = "isSubscriptionsSupported")]
        public System.Nullable<bool> IsSubscriptionsSupported { get; set; }
        
        /// <value>
        /// The service category list.
        /// </value>
        [JsonProperty(PropertyName = "serviceCategoryList")]
        public System.Collections.Generic.List<ServiceCategory> ServiceCategoryList { get; set; }
        
        /// <value>
        /// The map of services for MOS Taxonomy.
        /// </value>
        [JsonProperty(PropertyName = "service")]
        public System.Collections.Generic.Dictionary<string, string> Service { get; set; }
        
        /// <value>
        /// The service categories list for MOS Taxonomy.
        /// </value>
        [JsonProperty(PropertyName = "services")]
        public System.Collections.Generic.List<Services> Services { get; set; }
        
    }
}
