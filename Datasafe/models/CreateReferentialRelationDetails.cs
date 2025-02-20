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
    /// A sensitive column is a resource corresponding to a database column that is considered sensitive.
    /// It's a subresource of sensitive data model resource and is always associated with a sensitive data model.
    /// Note that referential relationships are also managed as part of sensitive columns.
    /// 
    /// </summary>
    public class CreateReferentialRelationDetails 
    {
                ///
        /// <value>
        /// The type of referential relationship the sensitive column has with its parent. 
        /// DB_DEFINED indicates that the relationship is defined in the database dictionary. 
        /// APP_DEFINED indicates that the relationship is defined at the application level and not in the database dictionary.
        /// 
        /// </value>
        ///
        public enum RelationTypeEnum {
            [EnumMember(Value = "APP_DEFINED")]
            AppDefined,
            [EnumMember(Value = "DB_DEFINED")]
            DbDefined
        };

        /// <value>
        /// The type of referential relationship the sensitive column has with its parent. 
        /// DB_DEFINED indicates that the relationship is defined in the database dictionary. 
        /// APP_DEFINED indicates that the relationship is defined at the application level and not in the database dictionary.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RelationType is required.")]
        [JsonProperty(PropertyName = "relationType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RelationTypeEnum> RelationType { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Parent is required.")]
        [JsonProperty(PropertyName = "parent")]
        public ColumnsInfo Parent { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Child is required.")]
        [JsonProperty(PropertyName = "child")]
        public ColumnsInfo Child { get; set; }
        
        /// <value>
        /// Add to sensitive data model if passed true. If false is passed, then the
        /// columns will not be added in the sensitive data model as sensitive columns and 
        /// if sensitive type OCIDs are assigned to the columns, then the sensitive type
        /// OCIDs will not be retained.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSensitive")]
        public System.Nullable<bool> IsSensitive { get; set; }
        
    }
}
