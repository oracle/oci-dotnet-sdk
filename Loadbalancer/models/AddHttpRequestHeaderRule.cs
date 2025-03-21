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


namespace Oci.LoadbalancerService.Models
{
    /// <summary>
    /// An object that represents the action of adding a header to a request.
    /// This rule applies only to HTTP listeners.
    /// **NOTES:**
    /// <br/>
    /// *  If a matching header already exists in the request, the system removes all of its occurrences, and then adds the
    ///    new header.
    /// <br/>
    /// *  The system does not distinquish between underscore and dash characters in headers. That is, it treats
    ///   `example_header_name` and `example-header-name` as identical. Oracle recommends that you do not rely on underscore
    ///   or dash characters to uniquely distinguish header names.
    /// 
    /// </summary>
    public class AddHttpRequestHeaderRule : Rule
    {
        
        /// <value>
        /// A header name that conforms to RFC 7230.
        /// <br/>
        /// Example: example_header_name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Header is required.")]
        [JsonProperty(PropertyName = "header")]
        public string Header { get; set; }
        
        /// <value>
        /// A header value that conforms to RFC 7230. With the following exceptions:
        /// *  value cannot contain `$`
        /// *  value cannot contain patterns like `{variable_name}`. They are reserved for future extensions. Currently, such values are invalid.
        /// <br/>
        /// Example: example_value
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Value is required.")]
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        [JsonProperty(PropertyName = "action")]
        private readonly string action = "ADD_HTTP_REQUEST_HEADER";
    }
}
