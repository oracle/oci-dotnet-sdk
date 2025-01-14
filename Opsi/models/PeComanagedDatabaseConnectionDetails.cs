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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Connection details of the private endpoints.
    /// </summary>
    public class PeComanagedDatabaseConnectionDetails 
    {
        
        /// <value>
        /// List of hosts and port for private endpoint accessed database resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Hosts is required.")]
        [JsonProperty(PropertyName = "hosts")]
        public System.Collections.Generic.List<PeComanagedDatabaseHostDetails> Hosts { get; set; }
                ///
        /// <value>
        /// Protocol used for connection requests for private endpoint accssed database resource.
        /// </value>
        ///
        public enum ProtocolEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "TCP")]
            Tcp,
            [EnumMember(Value = "TCPS")]
            Tcps
        };

        /// <value>
        /// Protocol used for connection requests for private endpoint accssed database resource.
        /// </value>
        [JsonProperty(PropertyName = "protocol")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ProtocolEnum> Protocol { get; set; }
        
        /// <value>
        /// Database service name used for connection requests.
        /// </value>
        [JsonProperty(PropertyName = "serviceName")]
        public string ServiceName { get; set; }
        
    }
}
