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


namespace Oci.AianomalydetectionService.Models
{
    /// <summary>
    /// The request body when byte data is provided in detect call, which is Base64 encoded.
    /// The default type of the data is CSV and can be JSON by setting the 'contentType'.
    /// 
    /// </summary>
    public class EmbeddedInputDetails : InputDetails
    {
                ///
        ///
        public enum ContentTypeEnum {
            [EnumMember(Value = "CSV")]
            Csv,
            [EnumMember(Value = "JSON")]
            Json
        };

        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ContentType is required.")]
        [JsonProperty(PropertyName = "contentType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ContentTypeEnum> ContentType { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Content is required.")]
        [JsonProperty(PropertyName = "content")]
        public System.Byte[] Content { get; set; }
        
        [JsonProperty(PropertyName = "inputType")]
        private readonly string inputType = "BASE64_ENCODED";
    }
}
