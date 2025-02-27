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
    /// An object containing details to make a REST request.
    /// </summary>
    public class EndpointRequest 
    {
                ///
        /// <value>
        /// The endpoint method - GET or POST.
        /// </value>
        ///
        public enum MethodEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "GET")]
            Get,
            [EnumMember(Value = "POST")]
            Post
        };

        /// <value>
        /// The endpoint method - GET or POST.
        /// </value>
        [JsonProperty(PropertyName = "method")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MethodEnum> Method { get; set; }
        
        /// <value>
        /// The request URL.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Url is required.")]
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        
        /// <value>
        /// The request content type.
        /// </value>
        [JsonProperty(PropertyName = "contentType")]
        public string ContentType { get; set; }
        
        /// <value>
        /// The request payload, applicable for POST requests.
        /// </value>
        [JsonProperty(PropertyName = "payload")]
        public string Payload { get; set; }
        
        /// <value>
        /// The request headers represented as a list of name-value pairs.
        /// </value>
        [JsonProperty(PropertyName = "headers")]
        public System.Collections.Generic.List<NameValuePair> Headers { get; set; }
        
        /// <value>
        /// The request form parameters represented as a list of name-value pairs.
        /// </value>
        [JsonProperty(PropertyName = "formParameters")]
        public System.Collections.Generic.List<NameValuePair> FormParameters { get; set; }
        
    }
}
