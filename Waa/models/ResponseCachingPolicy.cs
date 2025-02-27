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


namespace Oci.WaaService.Models
{
    /// <summary>
    /// An object that specifies an HTTP response caching policy.
    /// 
    /// </summary>
    public class ResponseCachingPolicy 
    {
        
        /// <value>
        /// When false, responses will not be cached by the backend based on response headers.
        /// <br/>
        /// When true, responses that contain one of the supported cache control headers will be cached according to the
        /// values specified in the cache control headers.
        /// <br/>
        /// The \"X-Accel-Expires\" header field sets caching time of a response in seconds. The zero value disables
        /// caching for a response. If the value starts with the @ prefix, it sets an absolute time in seconds since
        /// Epoch, up to which the response may be cached.
        /// <br/>
        /// If the header does not include the \"X-Accel-Expires\" field, parameters of caching may be set in the header
        /// fields \"Expires\" or \"Cache-Control\".
        /// <br/>
        /// If the header includes the \"Set-Cookie\" field, such a response will not be cached.
        /// <br/>
        /// If the header includes the \"Vary\" field with the special value \"*\", such a response will not be cached. If the
        /// header includes the \"Vary\" field with another value, such a response will be cached taking into account the
        /// corresponding request header fields.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isResponseHeaderBasedCachingEnabled")]
        public System.Nullable<bool> IsResponseHeaderBasedCachingEnabled { get; set; }
        
    }
}
