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


namespace Oci.GenerativeaiagentService.Models
{
    /// <summary>
    /// The configuration for HTTP endpoint Tool.
    /// 
    /// </summary>
    public class HttpEndpointToolConfig : ToolConfig
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ApiSchema is required.")]
        [JsonProperty(PropertyName = "apiSchema")]
        public ApiSchemaInputLocation ApiSchema { get; set; }
        
        /// <value>
        /// The subnet ID from agent developer tenancy through which the egress is going to be routed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HttpEndpointAuthConfig is required.")]
        [JsonProperty(PropertyName = "httpEndpointAuthConfig")]
        public HttpEndpointAuthConfig HttpEndpointAuthConfig { get; set; }
        
        [JsonProperty(PropertyName = "toolConfigType")]
        private readonly string toolConfigType = "HTTP_ENDPOINT_TOOL_CONFIG";
    }
}
