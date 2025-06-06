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
    /// Describes an event configuration, for a given object type and property. Primarily, whether a property change will result in an event being emitted.
    /// </summary>
    public class EventConfig 
    {
        
        /// <value>
        /// Unique type key identifier.
        /// </value>
        [JsonProperty(PropertyName = "typeId")]
        public string TypeId { get; set; }
        
        /// <value>
        /// Name of the type.
        /// </value>
        [JsonProperty(PropertyName = "typeName")]
        public string TypeName { get; set; }
        
        /// <value>
        /// Unique property key identifier.
        /// </value>
        [JsonProperty(PropertyName = "propertyId")]
        public string PropertyId { get; set; }
        
        /// <value>
        /// Name of the property.
        /// </value>
        [JsonProperty(PropertyName = "propertyName")]
        public string PropertyName { get; set; }
        
        /// <value>
        /// Status of the configuration.
        /// </value>
        [JsonProperty(PropertyName = "eventConfigStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<EventConfigStatus> EventConfigStatus { get; set; }
        
        /// <value>
        /// The date and time the event was configured, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2019-03-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The last time that any change was made to the configuration. An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// OCID of the user who created the configuration.
        /// </value>
        [JsonProperty(PropertyName = "createdById")]
        public string CreatedById { get; set; }
        
        /// <value>
        /// OCID of the user who last modified the configuration.
        /// </value>
        [JsonProperty(PropertyName = "updatedById")]
        public string UpdatedById { get; set; }
        
    }
}
