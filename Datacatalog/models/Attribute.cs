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
    /// Details of an entity attribute. An attribute of a data entity describing an item of data,
    /// with a name and data type. Synonymous with 'column' in a database.
    /// 
    /// </summary>
    public class Attribute 
    {
        
        /// <value>
        /// Unique attribute key that is immutable.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// A user-friendly display name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Optional user friendly business name of the attribute. If set, this supplements the harvested display name of the object.
        /// </value>
        [JsonProperty(PropertyName = "businessName")]
        public string BusinessName { get; set; }
        
        /// <value>
        /// Detailed description of the attribute.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The unique key of the parent entity.
        /// </value>
        [JsonProperty(PropertyName = "entityKey")]
        public string EntityKey { get; set; }
        
        /// <value>
        /// State of the attribute.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the current state in more detail. An object not in ACTIVE state may have functional limitations,
        /// see service documentation for details.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The date and time the attribute was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2019-03-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The last time that any change was made to the attribute. An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// OCID of the user who created this attribute in the data catalog.
        /// </value>
        [JsonProperty(PropertyName = "createdById")]
        public string CreatedById { get; set; }
        
        /// <value>
        /// OCID of the user who modified this attribute in the data catalog.
        /// </value>
        [JsonProperty(PropertyName = "updatedById")]
        public string UpdatedById { get; set; }
        
        /// <value>
        /// Data type of the attribute as defined in the external system. Type mapping across systems can be achieved
        /// through term associations across domains in the ontology. The attribute can also be tagged to the datatype in
        /// the domain ontology to resolve any ambiguity arising from type name similarity that can occur with user
        /// defined types.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "externalDataType")]
        public string ExternalDataType { get; set; }
        
        /// <value>
        /// Unique external key of this attribute in the external source system.
        /// </value>
        [JsonProperty(PropertyName = "externalKey")]
        public string ExternalKey { get; set; }
        
        /// <value>
        /// Property that identifies if this attribute can be used as a watermark to extract incremental data.
        /// </value>
        [JsonProperty(PropertyName = "isIncrementalData")]
        public System.Nullable<bool> IsIncrementalData { get; set; }
        
        /// <value>
        /// Property that identifies if this attribute can be assigned null values.
        /// </value>
        [JsonProperty(PropertyName = "isNullable")]
        public System.Nullable<bool> IsNullable { get; set; }
        
        /// <value>
        /// The type of the attribute. Type keys can be found via the '/types' endpoint.
        /// </value>
        [JsonProperty(PropertyName = "typeKey")]
        public string TypeKey { get; set; }
        
        /// <value>
        /// The minimum count for the number of instances of a given type stored in this collection type attribute,applicable if this attribute is a complex type.
        /// </value>
        [JsonProperty(PropertyName = "minCollectionCount")]
        public System.Nullable<int> MinCollectionCount { get; set; }
        
        /// <value>
        /// The maximum count for the number of instances of a given type stored in this collection type attribute,applicable if this attribute is a complex type.
        /// For type specifications in systems that specify only \"capacity\" without upper or lower bound , this property can also be used to just mean \"capacity\".
        /// Some examples are Varray size in Oracle , Occurs Clause in Cobol , capacity in XmlSchemaObjectCollection , maxOccurs in  Xml , maxItems in Json
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maxCollectionCount")]
        public System.Nullable<int> MaxCollectionCount { get; set; }
        
        /// <value>
        /// Entity key that represents the datatype of this attribute , applicable if this attribute is a complex type.
        /// </value>
        [JsonProperty(PropertyName = "datatypeEntityKey")]
        public string DatatypeEntityKey { get; set; }
        
        /// <value>
        /// External entity key that represents the datatype of this attribute , applicable if this attribute is a complex type.
        /// </value>
        [JsonProperty(PropertyName = "externalDatatypeEntityKey")]
        public string ExternalDatatypeEntityKey { get; set; }
        
        /// <value>
        /// Attribute key that represents the parent attribute of this attribute , applicable if the parent attribute is of complex datatype.
        /// </value>
        [JsonProperty(PropertyName = "parentAttributeKey")]
        public string ParentAttributeKey { get; set; }
        
        /// <value>
        /// External attribute key that represents the parent attribute  of this attribute , applicable if the parent attribute is of complex type.
        /// </value>
        [JsonProperty(PropertyName = "externalParentAttributeKey")]
        public string ExternalParentAttributeKey { get; set; }
        
        /// <value>
        /// Max allowed length of the attribute value.
        /// </value>
        [JsonProperty(PropertyName = "length")]
        public System.Nullable<long> Length { get; set; }
        
        /// <value>
        /// Position of the attribute in the record definition.
        /// </value>
        [JsonProperty(PropertyName = "position")]
        public System.Nullable<int> Position { get; set; }
        
        /// <value>
        /// Precision of the attribute value usually applies to float data type.
        /// </value>
        [JsonProperty(PropertyName = "precision")]
        public System.Nullable<int> Precision { get; set; }
        
        /// <value>
        /// Scale of the attribute value usually applies to float data type.
        /// </value>
        [JsonProperty(PropertyName = "scale")]
        public System.Nullable<int> Scale { get; set; }
        
        /// <value>
        /// Last modified timestamp of this object in the external system.
        /// </value>
        [JsonProperty(PropertyName = "timeExternal")]
        public System.Nullable<System.DateTime> TimeExternal { get; set; }
        
        /// <value>
        /// The date and time the attribute was harvested, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// </value>
        [JsonProperty(PropertyName = "timeHarvested")]
        public System.Nullable<System.DateTime> TimeHarvested { get; set; }
        
        /// <value>
        /// List of objects and their relationships to this attribute.
        /// </value>
        [JsonProperty(PropertyName = "objectRelationships")]
        public System.Collections.Generic.List<ObjectRelationship> ObjectRelationships { get; set; }
        
        /// <value>
        /// Whether a column is derived or not.
        /// </value>
        [JsonProperty(PropertyName = "isDerivedAttribute")]
        public System.Nullable<bool> IsDerivedAttribute { get; set; }
        
        /// <value>
        /// URI to the attribute instance in the API.
        /// </value>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }
        
        /// <value>
        /// Full path of the attribute.
        /// </value>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }
        
        /// <value>
        /// The list of customized properties along with the values for this object
        /// </value>
        [JsonProperty(PropertyName = "customPropertyMembers")]
        public System.Collections.Generic.List<CustomPropertyGetUsage> CustomPropertyMembers { get; set; }
        
        /// <value>
        /// A map of maps that contains the properties which are specific to the attribute type. Each attribute type
        /// definition defines it's set of required and optional properties. The map keys are category names and the
        /// values are maps of property name to property value. Every property is contained inside of a category. Most
        /// attributes have required properties within the \"default\" category.
        /// Example: {&quot;properties&quot;: { &quot;default&quot;: { &quot;key1&quot;: &quot;value1&quot;}}}
        /// </value>
        [JsonProperty(PropertyName = "properties")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> Properties { get; set; }
        
        /// <value>
        /// Rule types associated with attribute.
        /// </value>
        [JsonProperty(PropertyName = "associatedRuleTypes", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<RuleType> AssociatedRuleTypes { get; set; }
        
    }
}
