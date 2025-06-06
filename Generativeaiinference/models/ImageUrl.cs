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


namespace Oci.GenerativeaiinferenceService.Models
{
    /// <summary>
    /// Provide a base64 encoded image.
    /// </summary>
    public class ImageUrl 
    {
        
        /// <value>
        /// The base64 encoded image data.
        /// <br/>
        /// Example for a png image:
        ///   `{
        ///     \"type\": \"IMAGE\",
        ///     \"imageUrl\": {
        ///       \"url\": \"data:image/png;base64,<base64 encoded image content>\"
        ///     }
        ///   }`
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Url is required.")]
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
                ///
        /// <value>
        /// The default value is AUTO and only AUTO is supported. This option controls how to convert the base64 encoded image to tokens.
        /// </value>
        ///
        public enum DetailEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "AUTO")]
            Auto,
            [EnumMember(Value = "HIGH")]
            High,
            [EnumMember(Value = "LOW")]
            Low
        };

        /// <value>
        /// The default value is AUTO and only AUTO is supported. This option controls how to convert the base64 encoded image to tokens.
        /// </value>
        [JsonProperty(PropertyName = "detail")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DetailEnum> Detail { get; set; }
        
    }
}
