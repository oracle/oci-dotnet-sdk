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


namespace Oci.CloudguardService.Models
{
    /// <summary>
    /// Composite condition resource with nested condition.
    /// </summary>
    public class CompositeCondition : Condition
    {
        
        [JsonProperty(PropertyName = "leftOperand")]
        public Condition LeftOperand { get; set; }
                ///
        /// <value>
        /// Composite condition operator
        /// </value>
        ///
        public enum CompositeOperatorEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "AND")]
            And,
            [EnumMember(Value = "OR")]
            Or
        };

        /// <value>
        /// Composite condition operator
        /// </value>
        [JsonProperty(PropertyName = "compositeOperator")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CompositeOperatorEnum> CompositeOperator { get; set; }
        
        [JsonProperty(PropertyName = "rightOperand")]
        public Condition RightOperand { get; set; }
        
        [JsonProperty(PropertyName = "kind")]
        private readonly string kind = "COMPOSITE";
    }
}
