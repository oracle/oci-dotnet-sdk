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


namespace Oci.WafService.Models
{
    /// <summary>
    /// Allows returning dynamically generated HTTP response body based on the provided template.
    /// The template allows variable interpolation by specifying variable name between the '${' and '}' delimiters.
    /// Escape sequences using '\\' are supported to allow usage of '\\\\' and '\\${' in the template to return '\\' and '\\${' in final response.
    /// <br/>
    /// The following variables are supported:
    /// <br/>
    /// * http.request.id - the HTTP request ID. For Example: &quot;d5fa953f75ef417e4c8008ef9336d779&quot;. 
    /// </summary>
    public class DynamicHttpResponseBody : HttpResponseBody
    {
        
        /// <value>
        /// Dynamic response body
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Template is required.")]
        [JsonProperty(PropertyName = "template")]
        public string Template { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "DYNAMIC";
    }
}
