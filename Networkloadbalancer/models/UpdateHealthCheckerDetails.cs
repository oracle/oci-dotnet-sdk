/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.NetworkloadbalancerService.Models
{
    /// <summary>
    /// The configuration details of the health checker.
    /// </summary>
    public class UpdateHealthCheckerDetails 
    {
        
        /// <value>
        /// The protocol that the health check must use; either HTTP, UDP, or TCP.
        /// <br/>
        /// Example: HTTP
        /// </value>
        [JsonProperty(PropertyName = "protocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<HealthCheckProtocols> Protocol { get; set; }
        
        /// <value>
        /// The backend server port against which to run the health check.
        /// <br/>
        /// Example: 8080
        /// </value>
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }
        
        /// <value>
        /// The number of retries to attempt before a backend server is considered \"unhealthy\". This number also applies
        /// when recovering a server to the \"healthy\" state.
        /// <br/>
        /// Example: 3
        /// </value>
        [JsonProperty(PropertyName = "retries")]
        public System.Nullable<int> Retries { get; set; }
        
        /// <value>
        /// The maximum time, in milliseconds, to wait for a reply to a health check. A health check is successful only if a reply
        /// returns within this timeout period.
        /// <br/>
        /// Example: 3000
        /// </value>
        [JsonProperty(PropertyName = "timeoutInMillis")]
        public System.Nullable<int> TimeoutInMillis { get; set; }
        
        /// <value>
        /// The interval between health checks, in milliseconds.
        /// <br/>
        /// Example: 10000
        /// </value>
        [JsonProperty(PropertyName = "intervalInMillis")]
        public System.Nullable<int> IntervalInMillis { get; set; }
        
        /// <value>
        /// The path against which to run the health check.
        /// <br/>
        /// Example: /healthcheck
        /// </value>
        [JsonProperty(PropertyName = "urlPath")]
        public string UrlPath { get; set; }
        
        /// <value>
        /// A regular expression for parsing the response body from the backend server.
        /// <br/>
        /// Example: ^((?!false).|\\s)*$
        /// </value>
        [JsonProperty(PropertyName = "responseBodyRegex")]
        public string ResponseBodyRegex { get; set; }
        
        /// <value>
        /// The status code a healthy backend server should return. If you configure the health check policy to use the HTTP protocol,
        /// then you can use common HTTP status codes such as \"200\".
        /// <br/>
        /// Example: 200
        /// </value>
        [JsonProperty(PropertyName = "returnCode")]
        public System.Nullable<int> ReturnCode { get; set; }
        
        /// <value>
        /// Base64 encoded pattern to be sent as UDP or TCP health check probe.
        /// </value>
        [JsonProperty(PropertyName = "requestData")]
        public System.Byte[] RequestData { get; set; }
        
        /// <value>
        /// Base64 encoded pattern to be validated as UDP or TCP health check probe response.
        /// </value>
        [JsonProperty(PropertyName = "responseData")]
        public System.Byte[] ResponseData { get; set; }
        
    }
}