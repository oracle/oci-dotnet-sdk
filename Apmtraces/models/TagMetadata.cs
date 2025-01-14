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
    /// Definition of the tag metadata.
    /// 
    /// </summary>
    public class TagMetadata 
    {
                ///
        /// <value>
        /// Type associated with the tag key.
        /// 
        /// </value>
        ///
        public enum TagTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "STRING")]
            String,
            [EnumMember(Value = "NUMERIC")]
            Numeric
        };

        /// <value>
        /// Type associated with the tag key.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "tagType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TagTypeEnum> TagType { get; set; }
                ///
        /// <value>
        /// Unit associated with the tag key.
        /// 
        /// </value>
        ///
        public enum TagUnitEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "EPOCH_TIME_MS")]
            EpochTimeMs,
            [EnumMember(Value = "BYTES")]
            Bytes,
            [EnumMember(Value = "COUNT")]
            Count,
            [EnumMember(Value = "DURATION_MS")]
            DurationMs,
            [EnumMember(Value = "TRACE_STATUS")]
            TraceStatus,
            [EnumMember(Value = "PERCENTAGE")]
            Percentage,
            [EnumMember(Value = "NONE")]
            None
        };

        /// <value>
        /// Unit associated with the tag key.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "tagUnit")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TagUnitEnum> TagUnit { get; set; }
        
    }
}
