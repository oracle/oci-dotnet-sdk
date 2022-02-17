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


namespace Oci.DataconnectivityService.Models
{
    /// <summary>
    /// The endpoint details for a private endpoint.
    /// </summary>
    public class DpEndpointFromPrivate : DpEndpoint
    {
        
        /// <value>
        /// The endpoint ID provided by control plane.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DcmsEndpointId is required.")]
        [JsonProperty(PropertyName = "dcmsEndpointId")]
        public string DcmsEndpointId { get; set; }
        
        /// <value>
        /// The ocid of private endpoint resource.
        /// </value>
        [JsonProperty(PropertyName = "peId")]
        public string PeId { get; set; }
        
        /// <value>
        /// The compartmentId of private endpoint resource.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The IP address of dns proxy.
        /// </value>
        [JsonProperty(PropertyName = "dnsProxyIp")]
        public string DnsProxyIp { get; set; }
        
        /// <value>
        /// The ocid of private endpoint resource.
        /// </value>
        [JsonProperty(PropertyName = "privateEndpointIp")]
        public string PrivateEndpointIp { get; set; }
        
        /// <value>
        /// Array of dns zones to be use during private endpoint resolution.
        /// </value>
        [JsonProperty(PropertyName = "dnsZones")]
        public System.Collections.Generic.List<string> DnsZones { get; set; }
                ///
        /// <value>
        /// Specifies the private endpoint state.
        /// </value>
        ///
        public enum StateEnum {
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INACTIVE")]
            Inactive
        };

        /// <value>
        /// Specifies the private endpoint state.
        /// </value>
        [JsonProperty(PropertyName = "state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<StateEnum> State { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "PRIVATE_END_POINT";
    }
}
