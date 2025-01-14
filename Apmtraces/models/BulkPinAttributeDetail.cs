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


namespace Oci.ApmtracesService.Models
{
    /// <summary>
    /// Object that contains the details about a single attribute in the bulk request to be pinned.
    /// 
    /// </summary>
    public class BulkPinAttributeDetail 
    {
        
        /// <value>
        /// Name of the attribute to be pinned.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AttributeName is required.")]
        [JsonProperty(PropertyName = "attributeName")]
        public string AttributeName { get; set; }
                ///
        /// <value>
        /// Namespace of the attribute to be pinned.  The attributeNameSpace will default to TRACES if it is 
        /// not passed in.
        /// 
        /// </value>
        ///
        public enum AttributeNameSpaceEnum {
            [EnumMember(Value = "TRACES")]
            Traces,
            [EnumMember(Value = "SYNTHETIC")]
            Synthetic
        };

        /// <value>
        /// Namespace of the attribute to be pinned.  The attributeNameSpace will default to TRACES if it is 
        /// not passed in.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "attributeNameSpace")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AttributeNameSpaceEnum> AttributeNameSpace { get; set; }
        
    }
}
