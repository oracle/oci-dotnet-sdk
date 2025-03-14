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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// A `DataType` object is a simple primitive type that describes the type of a single atomic unit of data.  For example, `INT`, `VARCHAR`, `NUMBER`, and so on.
    /// </summary>
    public class DataType : BaseType
    {
                ///
        /// <value>
        /// The data type.
        /// </value>
        ///
        public enum DtTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PRIMITIVE")]
            Primitive,
            [EnumMember(Value = "STRUCTURED")]
            Structured
        };

        /// <value>
        /// The data type.
        /// </value>
        [JsonProperty(PropertyName = "dtType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DtTypeEnum> DtType { get; set; }
        
        /// <value>
        /// The data type system name.
        /// </value>
        [JsonProperty(PropertyName = "typeSystemName")]
        public string TypeSystemName { get; set; }
        
        [JsonProperty(PropertyName = "configDefinition")]
        public ConfigDefinition ConfigDefinition { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "DATA_TYPE";
    }
}
