/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.HealthchecksService.Models
{
    /// <summary>
    /// The results returned by running an HTTP probe.  All times and durations are
    /// returned in milliseconds. All times are relative to the POSIX epoch
    /// (1970-01-01T00:00Z). Time properties conform to W3C Resource Timing.
    /// For more information, see
    /// [PerformanceResourceTiming](https://w3c.github.io/resource-timing/#sec-resource-timing)
    /// interface.
    /// 
    /// </summary>
    public class HttpProbeResultSummary 
    {
        
        /// <value>
        /// A value identifying this specific probe result. The key is only unique within
        /// the results of its probe configuration. The key may be reused after 90 days.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The OCID of the monitor or on-demand probe responsible for creating this result.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "probeConfigurationId")]
        public string ProbeConfigurationId { get; set; }
        
        /// <value>
        /// The date and time the probe was executed, expressed in milliseconds since the
        /// POSIX epoch. This field is defined by the PerformanceResourceTiming interface
        /// of the W3C Resource Timing specification. For more information, see
        /// [Resource Timing](https://w3c.github.io/resource-timing/#sec-resource-timing).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "startTime")]
        public System.Double StartTime { get; set; }
        
        /// <value>
        /// The target hostname or IP address of the probe.
        /// </value>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }
        
        /// <value>
        /// The name of the vantage point that executed the probe.
        /// </value>
        [JsonProperty(PropertyName = "vantagePointName")]
        public string VantagePointName { get; set; }
        
        /// <value>
        /// True if the probe did not complete before the configured `timeoutInSeconds` value.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isTimedOut")]
        public System.Nullable<bool> IsTimedOut { get; set; }
        
        /// <value>
        /// True if the probe result is determined to be healthy based on probe
        /// type-specific criteria.  For HTTP probes, a probe result is considered
        /// healthy if the HTTP response code is greater than or equal to 200 and
        /// less than 300.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isHealthy")]
        public System.Nullable<bool> IsHealthy { get; set; }
                ///
        /// <value>
        /// The category of error if an error occurs executing the probe.
        /// The `errorMessage` field provides a message with the error details.
        /// * NONE - No error
        /// * DNS - DNS errors
        /// * TRANSPORT - Transport-related errors, for example a \"TLS certificate expired\" error.
        /// * NETWORK - Network-related errors, for example a \"network unreachable\" error.
        /// * SYSTEM - Internal system errors.
        /// 
        /// </value>
        ///
        public enum ErrorCategoryEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NONE")]
            None,
            [EnumMember(Value = "DNS")]
            Dns,
            [EnumMember(Value = "TRANSPORT")]
            Transport,
            [EnumMember(Value = "NETWORK")]
            Network,
            [EnumMember(Value = "SYSTEM")]
            System
        };

        /// <value>
        /// The category of error if an error occurs executing the probe.
        /// The `errorMessage` field provides a message with the error details.
        /// * NONE - No error
        /// * DNS - DNS errors
        /// * TRANSPORT - Transport-related errors, for example a \"TLS certificate expired\" error.
        /// * NETWORK - Network-related errors, for example a \"network unreachable\" error.
        /// * SYSTEM - Internal system errors.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "errorCategory")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ErrorCategoryEnum> ErrorCategory { get; set; }
        
        /// <value>
        /// The error information indicating why a probe execution failed.
        /// </value>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }
        
        [JsonProperty(PropertyName = "protocol")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<HttpProbeProtocol> Protocol { get; set; }
        
        [JsonProperty(PropertyName = "connection")]
        public TcpConnection Connection { get; set; }
        
        [JsonProperty(PropertyName = "dns")]
        public DNS Dns { get; set; }
        
        /// <value>
        /// The HTTP response status code.
        /// </value>
        [JsonProperty(PropertyName = "statusCode")]
        public System.Nullable<int> StatusCode { get; set; }
        
        /// <value>
        /// The time immediately before the vantage point starts the domain name lookup for
        /// the resource.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "domainLookupStart")]
        public System.Double DomainLookupStart { get; set; }
        
        /// <value>
        /// The time immediately before the vantage point finishes the domain name lookup for
        /// the resource.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "domainLookupEnd")]
        public System.Double DomainLookupEnd { get; set; }
        
        /// <value>
        /// The time immediately before the vantage point starts establishing the connection
        /// to the server to retrieve the resource.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "connectStart")]
        public System.Double ConnectStart { get; set; }
        
        /// <value>
        /// The time immediately before the vantage point starts the handshake process to
        /// secure the current connection.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "secureConnectionStart")]
        public System.Double SecureConnectionStart { get; set; }
        
        /// <value>
        /// The time immediately after the vantage point finishes establishing the connection
        /// to the server to retrieve the resource.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "connectEnd")]
        public System.Double ConnectEnd { get; set; }
        
        /// <value>
        /// The time immediately before the vantage point starts to fetch the resource.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "fetchStart")]
        public System.Double FetchStart { get; set; }
        
        /// <value>
        /// The time immediately before the vantage point starts requesting the resource from
        /// the server.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "requestStart")]
        public System.Double RequestStart { get; set; }
        
        /// <value>
        /// The time immediately after the vantage point's HTTP parser receives the first byte
        /// of the response.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "responseStart")]
        public System.Double ResponseStart { get; set; }
        
        /// <value>
        /// The time immediately after the vantage point receives the last byte of the response
        /// or immediately before the transport connection is closed, whichever comes first.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "responseEnd")]
        public System.Double ResponseEnd { get; set; }
        
        /// <value>
        /// The total duration from start of request until response is fully consumed or the
        /// connection is closed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "duration")]
        public System.Double Duration { get; set; }
        
        /// <value>
        /// The size, in octets, of the payload body prior to removing any applied
        /// content-codings.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "encodedBodySize")]
        public System.Nullable<int> EncodedBodySize { get; set; }
        
    }
}
