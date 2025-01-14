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
    /// Custom Property Definition
    /// 
    /// </summary>
    public class CustomProperty 
    {
        
        /// <value>
        /// Unique data asset key that is immutable.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// Display name of the custom property
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Data type of the custom property
        /// </value>
        [JsonProperty(PropertyName = "dataType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CustomPropertyDataType> DataType { get; set; }
        
        /// <value>
        /// Description for the custom property
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Namespace name of the custom property
        /// </value>
        [JsonProperty(PropertyName = "namespaceName")]
        public string NamespaceName { get; set; }
        
        /// <value>
        /// Is this property allowed to have list of values
        /// </value>
        [JsonProperty(PropertyName = "isListType")]
        public System.Nullable<bool> IsListType { get; set; }
        
        /// <value>
        /// If this field allows to sort from UI
        /// </value>
        [JsonProperty(PropertyName = "isSortable")]
        public System.Nullable<bool> IsSortable { get; set; }
        
        /// <value>
        /// If this field allows to filter or create facets from UI
        /// </value>
        [JsonProperty(PropertyName = "isFilterable")]
        public System.Nullable<bool> IsFilterable { get; set; }
        
        /// <value>
        /// If this field allows multiple values to be set
        /// </value>
        [JsonProperty(PropertyName = "isMultiValued")]
        public System.Nullable<bool> IsMultiValued { get; set; }
        
        /// <value>
        /// If this field is a hidden field
        /// </value>
        [JsonProperty(PropertyName = "isHidden")]
        public System.Nullable<bool> IsHidden { get; set; }
        
        /// <value>
        /// If this field is a editable field
        /// </value>
        [JsonProperty(PropertyName = "isEditable")]
        public System.Nullable<bool> IsEditable { get; set; }
        
        /// <value>
        /// If this field is displayed in a list view of applicable objects.
        /// </value>
        [JsonProperty(PropertyName = "isShownInList")]
        public System.Nullable<bool> IsShownInList { get; set; }
        
        /// <value>
        /// If this field is defined by service or by a user
        /// </value>
        [JsonProperty(PropertyName = "isServiceDefined")]
        public System.Nullable<bool> IsServiceDefined { get; set; }
        
        /// <value>
        /// If this field is allowed to pop in search results
        /// </value>
        [JsonProperty(PropertyName = "isHiddenInSearch")]
        public System.Nullable<bool> IsHiddenInSearch { get; set; }
        
        /// <value>
        /// The current state of the custom property.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time the custom property was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2019-03-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The last time that any change was made to the custom property. An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// OCID of the user who created the custom property.
        /// </value>
        [JsonProperty(PropertyName = "createdById")]
        public string CreatedById { get; set; }
        
        /// <value>
        /// OCID of the user who last modified the custom property.
        /// </value>
        [JsonProperty(PropertyName = "updatedById")]
        public string UpdatedById { get; set; }
        
        /// <value>
        /// Total number of first class objects using this custom property
        /// </value>
        [JsonProperty(PropertyName = "usageCount")]
        public System.Nullable<int> UsageCount { get; set; }
        
        /// <value>
        /// If an OCI Event will be emitted when the custom property is modified.
        /// </value>
        [JsonProperty(PropertyName = "isEventEnabled")]
        public System.Nullable<bool> IsEventEnabled { get; set; }
        
        /// <value>
        /// The set of object types to which the custom property applies.
        /// </value>
        [JsonProperty(PropertyName = "scope")]
        public System.Collections.Generic.List<CustomPropertyTypeUsage> Scope { get; set; }
        
        /// <value>
        /// Allowed values for the custom property if any
        /// </value>
        [JsonProperty(PropertyName = "allowedValues")]
        public System.Collections.Generic.List<string> AllowedValues { get; set; }
        
        /// <value>
        /// Event configuration for this custom property, against the desired subset of object types to which the property applies.
        /// </value>
        [JsonProperty(PropertyName = "events")]
        public System.Collections.Generic.List<EventConfig> Events { get; set; }
        
        /// <value>
        /// A map of maps that contains the properties which are specific to the asset type. Each data asset type
        /// definition defines it's set of required and optional properties. The map keys are category names and the
        /// values are maps of property name to property value. Every property is contained inside of a category. Most
        /// data assets have required properties within the \"default\" category.
        /// Example: {&quot;properties&quot;: { &quot;default&quot;: { &quot;host&quot;: &quot;host1&quot;, &quot;port&quot;: &quot;1521&quot;, &quot;database&quot;: &quot;orcl&quot;}}}
        /// </value>
        [JsonProperty(PropertyName = "properties")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> Properties { get; set; }
        
    }
}
