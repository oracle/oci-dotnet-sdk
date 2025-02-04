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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// A referential relation is a resource corresponding to database columns.
    /// It is always associated with a masking policy.
    /// 
    /// </summary>
    public class MaskingPolicyReferentialRelationSummary 
    {
        
        /// <value>
        /// The OCID of the masking policy that contains the column.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MaskingPolicyId is required.")]
        [JsonProperty(PropertyName = "maskingPolicyId")]
        public string MaskingPolicyId { get; set; }
                ///
        /// <value>
        /// The type of referential relationship the column has with its parent. DB_DEFINED indicates that the relationship is defined in the database
        /// dictionary. APP_DEFINED indicates that the relationship is defined at the application level and not in the database dictionary.
        /// 
        /// </value>
        ///
        public enum RelationTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NONE")]
            None,
            [EnumMember(Value = "APP_DEFINED")]
            AppDefined,
            [EnumMember(Value = "DB_DEFINED")]
            DbDefined
        };

        /// <value>
        /// The type of referential relationship the column has with its parent. DB_DEFINED indicates that the relationship is defined in the database
        /// dictionary. APP_DEFINED indicates that the relationship is defined at the application level and not in the database dictionary.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RelationType is required.")]
        [JsonProperty(PropertyName = "relationType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RelationTypeEnum> RelationType { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Parent is required.")]
        [JsonProperty(PropertyName = "parent")]
        public MaskingPolicyColumnsInfo Parent { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Child is required.")]
        [JsonProperty(PropertyName = "child")]
        public MaskingPolicyColumnsInfo Child { get; set; }
        
        /// <value>
        /// The masking format associated with the parent column.
        /// </value>
        [JsonProperty(PropertyName = "maskingFormat")]
        public System.Collections.Generic.List<string> MaskingFormat { get; set; }
        
    }
}
