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
    /// An object that represents the action of returning a specified response code when the requested HTTP method is not in
    /// the list of allowed methods for the listener. The load balancer does not forward a disallowed request to the back end
    /// servers. The default response code is `405 Method Not Allowed`.
    /// <br/>
    /// If you set the response code to `405` or leave it blank, the system adds an \"allow\" response header that contains a
    /// list of the allowed methods for the listener. If you set the response code to anything other than `405` (or blank),
    /// the system does not add the \"allow\" response header with a list of allowed methods.
    /// <br/>
    /// This rule applies only to HTTP listeners. No more than one `ControlAccessUsingHttpMethodsRule` object can be present in
    /// a given listener.
    /// 
    /// </summary>
    public class ControlAccessUsingHttpMethodsRule : Rule
    {
        
        /// <value>
        /// The list of HTTP methods allowed for this listener.
        /// <br/>
        /// By default, you can specify only the standard HTTP methods defined in the
        /// [HTTP Method Registry](http://www.iana.org/assignments/http-methods/http-methods.xhtml). You can also
        /// see a list of supported standard HTTP methods in the Load Balancing service documentation at
        /// [Managing Rule Sets](https://docs.cloud.oracle.com/Content/Balance/Tasks/managingrulesets.htm).
        /// <br/>
        /// Your backend application must be able to handle the methods specified in this list.
        /// <br/>
        /// The list of HTTP methods is extensible. If you need to configure custom HTTP methods, contact
        /// [My Oracle Support](http://support.oracle.com/) to remove the restriction for your tenancy.
        /// <br/>
        /// Example: [&quot;GET&quot;, &quot;PUT&quot;, &quot;POST&quot;, &quot;PROPFIND&quot;]
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AllowedMethods is required.")]
        [JsonProperty(PropertyName = "allowedMethods")]
        public System.Collections.Generic.List<string> AllowedMethods { get; set; }
        
        /// <value>
        /// The HTTP status code to return when the requested HTTP method is not in the list of allowed methods.
        /// The associated status line returned with the code is mapped from the standard HTTP specification. The
        /// default value is `405 (Method Not Allowed)`.
        /// <br/>
        /// Example: 403
        /// </value>
        [JsonProperty(PropertyName = "statusCode")]
        public System.Nullable<int> StatusCode { get; set; }
        
        [JsonProperty(PropertyName = "action")]
        private readonly string action = "CONTROL_ACCESS_USING_HTTP_METHODS";
    }
}
