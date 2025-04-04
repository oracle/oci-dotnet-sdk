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


namespace Oci.ServicemeshService.Models
{
    /// <summary>
    /// Listener configuration for a virtual deployment.
    /// </summary>
    public class VirtualDeploymentListener 
    {
                ///
        /// <value>
        /// Type of protocol used in virtual deployment.
        /// </value>
        ///
        public enum ProtocolEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "HTTP")]
            Http,
            [EnumMember(Value = "TLS_PASSTHROUGH")]
            TlsPassthrough,
            [EnumMember(Value = "TCP")]
            Tcp,
            [EnumMember(Value = "HTTP2")]
            Http2,
            [EnumMember(Value = "GRPC")]
            Grpc
        };

        /// <value>
        /// Type of protocol used in virtual deployment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Protocol is required.")]
        [JsonProperty(PropertyName = "protocol")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ProtocolEnum> Protocol { get; set; }
        
        /// <value>
        /// Port in which virtual deployment is running.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Port is required.")]
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }
        
        /// <value>
        /// The maximum duration in milliseconds for the deployed service to respond to an incoming request through the listener. 
        /// If provided, the timeout value overrides the default timeout of 15 seconds for the HTTP/HTTP2 listeners, and disabled (no timeout) for the GRPC listeners. The value 0 (zero) indicates that the timeout is disabled. 
        /// The timeout cannot be configured for the TCP and TLS_PASSTHROUGH listeners. 
        /// For streaming responses from the deployed service, consider either keeping the timeout disabled or set a sufficiently high value.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "requestTimeoutInMs")]
        public System.Nullable<long> RequestTimeoutInMs { get; set; }
        
        /// <value>
        /// The maximum duration in milliseconds for which the request's stream may be idle. The value 0 (zero) indicates that the timeout is disabled.
        /// </value>
        [JsonProperty(PropertyName = "idleTimeoutInMs")]
        public System.Nullable<long> IdleTimeoutInMs { get; set; }
        
    }
}
