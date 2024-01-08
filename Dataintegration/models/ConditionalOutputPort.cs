/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The conditional output port details, used in operators such as split.
    /// </summary>
    public class ConditionalOutputPort : TypedObject
    {
                ///
        /// <value>
        /// The port details for the data asset.Type.
        /// </value>
        ///
        public enum PortTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "DATA")]
            Data,
            [EnumMember(Value = "CONTROL")]
            Control,
            [EnumMember(Value = "MODEL")]
            Model
        };

        /// <value>
        /// The port details for the data asset.Type.
        /// </value>
        [JsonProperty(PropertyName = "portType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PortTypeEnum> PortType { get; set; }
        
        /// <value>
        /// An array of fields.
        /// </value>
        [JsonProperty(PropertyName = "fields")]
        public System.Collections.Generic.List<TypedObject> Fields { get; set; }
        
        [JsonProperty(PropertyName = "splitCondition")]
        public Expression SplitCondition { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "CONDITIONAL_OUTPUT_PORT";
    }
}
