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


namespace Oci.OptimizerService.Models
{
    /// <summary>
    /// A tag key definition used in the current profile override, including the tag namespace, tag key, tag value type, and tag values.
    /// Only defined tags are supported.
    /// For more information about tagging, see [Tagging Overview](https://docs.cloud.oracle.com/iaas/Content/Tagging/Concepts/taggingoverview.htm)
    /// 
    /// </summary>
    public class TargetTag 
    {
        
        /// <value>
        /// The name of the tag namespace.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TagNamespaceName is required.")]
        [JsonProperty(PropertyName = "tagNamespaceName")]
        public string TagNamespaceName { get; set; }
        
        /// <value>
        /// The name you use to refer to the tag, also known as the tag key.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TagDefinitionName is required.")]
        [JsonProperty(PropertyName = "tagDefinitionName")]
        public string TagDefinitionName { get; set; }
        
        /// <value>
        /// Specifies which tag value types in the `tagValues` field result in overrides of the recommendation criteria.
        /// <br/>
        /// When the value for this field is `ANY`, the `tagValues` field should be empty, which enforces overrides to the recommendation
        /// for resources with any tag values attached to them.
        /// <br/>
        /// When the value for this field value is `VALUE`, the `tagValues` field must include a specific value or list of values.
        /// Overrides to the recommendation criteria only occur for resources that match the values in the `tagValues` fields.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TagValueType is required.")]
        [JsonProperty(PropertyName = "tagValueType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TagValueType> TagValueType { get; set; }
        
        /// <value>
        /// The list of tag values. The tag value is the value that the user applying the tag adds to the tag key.
        /// </value>
        [JsonProperty(PropertyName = "tagValues")]
        public System.Collections.Generic.List<string> TagValues { get; set; }
        
    }
}
