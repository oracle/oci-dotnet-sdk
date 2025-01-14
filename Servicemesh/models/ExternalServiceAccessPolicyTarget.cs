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
    /// External service target that internal virtual services direct traffic to.
    /// </summary>
    public class ExternalServiceAccessPolicyTarget : AccessPolicyTarget
    {
        
        /// <value>
        /// The hostnames of the external service. Only applicable for HTTP and HTTPS protocols.
        /// Wildcard hostnames are supported in the prefix form.
        /// Examples of valid hostnames are \"www.example.com\", \"*.example.com\", \"*.com\", \"*\".
        /// Hostname \"*\" can be used to allow all hosts.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "hostnames")]
        public System.Collections.Generic.List<string> Hostnames { get; set; }
        
        /// <value>
        /// The ipAddresses of the external service in CIDR notation. Only applicable for TCP protocol.
        /// All requests matching the given CIDR notation will pass through.
        /// In case a wildcard CIDR \"0.0.0.0/0\" is provided, the same port cannot be used for a virtual service communication.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ipAddresses")]
        public System.Collections.Generic.List<string> IpAddresses { get; set; }
        
        /// <value>
        /// Ports exposed by an external service. If left empty all ports will be allowed.
        /// </value>
        [JsonProperty(PropertyName = "ports")]
        public System.Collections.Generic.List<int> Ports { get; set; }
                ///
        /// <value>
        /// Protocol of the external service
        /// </value>
        ///
        public enum ProtocolEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "HTTP")]
            Http,
            [EnumMember(Value = "HTTPS")]
            Https,
            [EnumMember(Value = "TCP")]
            Tcp
        };

        /// <value>
        /// Protocol of the external service
        /// </value>
        [JsonProperty(PropertyName = "protocol")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ProtocolEnum> Protocol { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "EXTERNAL_SERVICE";
    }
}
