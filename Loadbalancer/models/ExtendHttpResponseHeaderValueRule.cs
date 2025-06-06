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
    /// An object that represents the action of modifying a response header value. This rule applies only to HTTP listeners.
    /// <br/>
    /// This rule adds a prefix, a suffix, or both to the header value.
    /// <br/>
    /// **NOTES:**
    /// <br/>
    /// *  This rule requires a value for a prefix, suffix, or both.
    /// <br/>
    /// *  The system does not support this rule for headers with multiple values.
    /// <br/>
    /// *  The system does not distinquish between underscore and dash characters in headers. That is, it treats
    ///    `example_header_name` and `example-header-name` as identical.  If two such headers appear in a request, the system
    ///    applies the action to the first header it finds. The affected header cannot be determined in advance. Oracle
    ///    recommends that you do not rely on underscore or dash characters to uniquely distinguish header names.
    /// 
    /// </summary>
    public class ExtendHttpResponseHeaderValueRule : Rule
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
        /// A string to prepend to the header value. The resulting header value must still conform to RFC 7230.
        /// With the following exceptions:
        /// *  value cannot contain `$`
        /// *  value cannot contain patterns like `{variable_name}`. They are reserved for future extensions. Currently, such values are invalid.
        /// <br/>
        /// Example: example_prefix_value
        /// </value>
        [JsonProperty(PropertyName = "prefix")]
        public string Prefix { get; set; }
        
        /// <value>
        /// A string to append to the header value. The resulting header value must still conform to RFC 7230.
        /// With the following exceptions:
        /// *  value cannot contain `$`
        /// *  value cannot contain patterns like `{variable_name}`. They are reserved for future extensions. Currently, such values are invalid.
        /// <br/>
        /// Example: example_suffix_value
        /// </value>
        [JsonProperty(PropertyName = "suffix")]
        public string Suffix { get; set; }
        
        [JsonProperty(PropertyName = "action")]
        private readonly string action = "EXTEND_HTTP_RESPONSE_HEADER_VALUE";
    }
}
