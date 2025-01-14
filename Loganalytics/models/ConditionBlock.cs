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
    /// A condition block. This could represent a single condition, or have nested condition blocks under it.
    /// To form a single condition, specify the fieldName, labelConditionOperator and labelConditionValue(s).
    /// To form nested conditions, specify the conditions in conditionBlocks, and how to join them in conditionBlocksOperator.
    /// 
    /// </summary>
    public class ConditionBlock 
    {
                ///
        /// <value>
        /// Operator using which the conditionBlocks should be joined. Specify this for nested conditions.
        /// 
        /// </value>
        ///
        public enum ConditionBlocksOperatorEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "AND")]
            And,
            [EnumMember(Value = "OR")]
            Or,
            [EnumMember(Value = "NOT_AND")]
            NotAnd,
            [EnumMember(Value = "NOT_OR")]
            NotOr
        };

        /// <value>
        /// Operator using which the conditionBlocks should be joined. Specify this for nested conditions.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "conditionBlocksOperator")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ConditionBlocksOperatorEnum> ConditionBlocksOperator { get; set; }
        
        /// <value>
        /// The name of the field the condition is based on. Specify this if this condition block represents a single condition.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "fieldName")]
        public string FieldName { get; set; }
        
        /// <value>
        /// The condition operator. Specify this if this condition block represents a single condition.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "labelConditionOperator")]
        public string LabelConditionOperator { get; set; }
        
        /// <value>
        /// The condition value. Specify this if this condition block represents a single condition.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "labelConditionValue")]
        public string LabelConditionValue { get; set; }
        
        /// <value>
        /// A list of condition values. Specify this if this condition block represents a single condition.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "labelConditionValues")]
        public System.Collections.Generic.List<string> LabelConditionValues { get; set; }
        
        /// <value>
        /// Condition blocks to evaluate within this condition block. Specify this for nested conditions.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "conditionBlocks")]
        public System.Collections.Generic.List<ConditionBlock> ConditionBlocks { get; set; }
        
    }
}
