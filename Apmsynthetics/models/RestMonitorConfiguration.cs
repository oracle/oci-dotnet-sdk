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


namespace Oci.ApmsyntheticsService.Models
{
    /// <summary>
    /// Request configuration details for the REST monitor type.
    /// </summary>
    public class RestMonitorConfiguration : MonitorConfiguration
    {
        
        /// <value>
        /// If redirection is enabled, then redirects will be allowed while accessing target URL.
        /// </value>
        [JsonProperty(PropertyName = "isRedirectionEnabled")]
        public System.Nullable<bool> IsRedirectionEnabled { get; set; }
        
        /// <value>
        /// If certificate validation is enabled, then call will fail for certificate errors.
        /// </value>
        [JsonProperty(PropertyName = "isCertificateValidationEnabled")]
        public System.Nullable<bool> IsCertificateValidationEnabled { get; set; }
        
        /// <value>
        /// Request HTTP method.
        /// </value>
        [JsonProperty(PropertyName = "requestMethod")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RequestMethods> RequestMethod { get; set; }
        
        /// <value>
        /// Request HTTP authentication scheme.
        /// </value>
        [JsonProperty(PropertyName = "reqAuthenticationScheme")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RequestAuthenticationSchemes> ReqAuthenticationScheme { get; set; }
        
        [JsonProperty(PropertyName = "reqAuthenticationDetails")]
        public RequestAuthenticationDetails ReqAuthenticationDetails { get; set; }
        
        [JsonProperty(PropertyName = "clientCertificateDetails")]
        public ClientCertificateDetails ClientCertificateDetails { get; set; }
        
        /// <value>
        /// List of request headers. Example: [{&quot;headerName&quot;: &quot;content-type&quot;, &quot;headerValue&quot;:&quot;json&quot;}]
        /// </value>
        [JsonProperty(PropertyName = "requestHeaders")]
        public System.Collections.Generic.List<Header> RequestHeaders { get; set; }
        
        /// <value>
        /// List of request query params. Example: [{&quot;paramName&quot;: &quot;sortOrder&quot;, &quot;paramValue&quot;: &quot;asc&quot;}]
        /// </value>
        [JsonProperty(PropertyName = "requestQueryParams")]
        public System.Collections.Generic.List<RequestQueryParam> RequestQueryParams { get; set; }
        
        /// <value>
        /// Request post body content.
        /// </value>
        [JsonProperty(PropertyName = "requestPostBody")]
        public string RequestPostBody { get; set; }
        
        /// <value>
        /// Verify response content against regular expression based string.
        /// If response content does not match the verifyResponseContent value, then it will be considered a failure.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "verifyResponseContent")]
        public string VerifyResponseContent { get; set; }
        
        /// <value>
        /// Expected HTTP response codes. For status code range, set values such as 2xx, 3xx.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "verifyResponseCodes")]
        public System.Collections.Generic.List<string> VerifyResponseCodes { get; set; }
        
        [JsonProperty(PropertyName = "networkConfiguration")]
        public NetworkConfiguration NetworkConfiguration { get; set; }
        
        [JsonProperty(PropertyName = "configType")]
        private readonly string configType = "REST_CONFIG";
    }
}
