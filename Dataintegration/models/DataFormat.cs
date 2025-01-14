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
    /// The data format object.
    /// </summary>
    public class DataFormat 
    {
        
        [JsonProperty(PropertyName = "formatAttribute")]
        public AbstractFormatAttribute FormatAttribute { get; set; }
                ///
        /// <value>
        /// type
        /// </value>
        ///
        public enum TypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "XML")]
            Xml,
            [EnumMember(Value = "JSON")]
            Json,
            [EnumMember(Value = "CSV")]
            Csv,
            [EnumMember(Value = "ORC")]
            Orc,
            [EnumMember(Value = "PARQUET")]
            Parquet,
            [EnumMember(Value = "AVRO")]
            Avro
        };

        /// <value>
        /// type
        /// </value>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        [JsonProperty(PropertyName = "compressionConfig")]
        public Compression CompressionConfig { get; set; }
        
    }
}
