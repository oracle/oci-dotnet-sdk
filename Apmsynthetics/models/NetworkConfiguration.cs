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
    /// Details of the network configuration. For NETWORK monitor type, NetworkConfiguration is mandatory.
    /// </summary>
    public class NetworkConfiguration 
    {
        
        /// <value>
        /// Number of hops.
        /// </value>
        [JsonProperty(PropertyName = "numberOfHops")]
        public System.Nullable<int> NumberOfHops { get; set; }
        
        /// <value>
        /// Number of probes per hop.
        /// </value>
        [JsonProperty(PropertyName = "probePerHop")]
        public System.Nullable<int> ProbePerHop { get; set; }
        
        /// <value>
        /// Number of probe packets sent out simultaneously.
        /// </value>
        [JsonProperty(PropertyName = "transmissionRate")]
        public System.Nullable<int> TransmissionRate { get; set; }
        
        /// <value>
        /// Type of protocol.
        /// </value>
        [JsonProperty(PropertyName = "protocol")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<Protocol> Protocol { get; set; }
        
        /// <value>
        /// Type of probe mode when TCP protocol is selected.
        /// </value>
        [JsonProperty(PropertyName = "probeMode")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ProbeMode> ProbeMode { get; set; }
        
    }
}
