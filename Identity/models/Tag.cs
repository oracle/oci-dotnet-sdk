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


namespace Oci.IdentityService.Models
{
    /// <summary>
    /// A tag definition that belongs to a specific tag namespace.  \"Defined tags\" must be set up in your tenancy before
    /// you can apply them to resources.
    /// For more information, see [Managing Tags and Tag Namespaces](https://docs.cloud.oracle.com/Content/Identity/Concepts/taggingoverview.htm).
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values
    /// using the API.
    /// 
    /// </summary>
    public class Tag 
    {
        
        /// <value>
        /// The OCID of the compartment that contains the tag definition.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The OCID of the namespace that contains the tag definition.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TagNamespaceId is required.")]
        [JsonProperty(PropertyName = "tagNamespaceId")]
        public string TagNamespaceId { get; set; }
        
        /// <value>
        /// The name of the tag namespace that contains the tag definition.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TagNamespaceName is required.")]
        [JsonProperty(PropertyName = "tagNamespaceName")]
        public string TagNamespaceName { get; set; }
        
        /// <value>
        /// The OCID of the tag definition.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The name assigned to the tag during creation. This is the tag key definition.
        /// The name must be unique within the tag namespace and cannot be changed.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The description you assign to the tag.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Description is required.")]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Indicates whether the tag is retired.
        /// See [Retiring Key Definitions and Namespace Definitions](https://docs.cloud.oracle.com/Content/Tagging/Tasks/managingtagsandtagnamespaces.htm#retiringkeys).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsRetired is required.")]
        [JsonProperty(PropertyName = "isRetired")]
        public System.Nullable<bool> IsRetired { get; set; }
                ///
        /// <value>
        /// The tag's current state. After creating a tag, make sure its `lifecycleState` is ACTIVE before using it. After retiring a tag, make sure its `lifecycleState` is INACTIVE before using it. If you delete a tag, you cannot delete another tag until the deleted tag's `lifecycleState` changes from DELETING to DELETED.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted
        };

        /// <value>
        /// The tag's current state. After creating a tag, make sure its `lifecycleState` is ACTIVE before using it. After retiring a tag, make sure its `lifecycleState` is INACTIVE before using it. If you delete a tag, you cannot delete another tag until the deleted tag's `lifecycleState` changes from DELETING to DELETED.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Date and time the tag was created, in the format defined by RFC3339.
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Indicates whether the tag is enabled for cost tracking.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isCostTracking")]
        public System.Nullable<bool> IsCostTracking { get; set; }
        
        [JsonProperty(PropertyName = "validator")]
        public BaseTagDefinitionValidator Validator { get; set; }
        
    }
}
