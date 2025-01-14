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
    /// Configuration details for the connection between the client and backend servers.
    /// 
    /// </summary>
    public class ConnectionConfiguration 
    {
        
        /// <value>
        /// The maximum idle time, in seconds, allowed between two successive receive or two successive send operations
        /// between the client and backend servers. A send operation does not reset the timer for receive operations. A
        /// receive operation does not reset the timer for send operations.
        /// <br/>
        /// For more information, see [Connection Configuration](https://docs.cloud.oracle.com/Content/Balance/Reference/connectionreuse.htm#ConnectionConfiguration).
        /// <br/>
        /// Example: 1200
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IdleTimeout is required.")]
        [JsonProperty(PropertyName = "idleTimeout")]
        public System.Nullable<long> IdleTimeout { get; set; }
        
        /// <value>
        /// The backend TCP Proxy Protocol version.
        /// <br/>
        /// Example: 1
        /// </value>
        [JsonProperty(PropertyName = "backendTcpProxyProtocolVersion")]
        public System.Nullable<int> BackendTcpProxyProtocolVersion { get; set; }
                ///
        ///
        public enum BackendTcpProxyProtocolOptionsEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PP2_TYPE_AUTHORITY")]
            Pp2TypeAuthority
        };

        /// <value>
        /// An array that represents the PPV2 Options that can be enabled on TCP Listeners.
        /// Example: [&quot;PP2_TYPE_AUTHORITY&quot;]
        /// </value>
        [JsonProperty(PropertyName = "backendTcpProxyProtocolOptions", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<BackendTcpProxyProtocolOptionsEnum> BackendTcpProxyProtocolOptions { get; set; }
        
    }
}
