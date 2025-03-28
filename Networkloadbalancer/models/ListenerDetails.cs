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


namespace Oci.NetworkloadbalancerService.Models
{
    /// <summary>
    /// The listener's configuration.
    /// For more information about listener configuration, see
    /// [Listeners for Network Load Balancers](https://docs.cloud.oracle.com/Content/NetworkLoadBalancer/Listeners/listener-management.htm).
    /// 
    /// </summary>
    public class ListenerDetails 
    {
        
        /// <value>
        /// A friendly name for the listener. It must be unique and it cannot be changed.
        /// <br/>
        /// Example: example_listener
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The name of the associated backend set.
        /// <br/>
        /// Example: example_backend_set
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DefaultBackendSetName is required.")]
        [JsonProperty(PropertyName = "defaultBackendSetName")]
        public string DefaultBackendSetName { get; set; }
        
        /// <value>
        /// IP version associated with the listener.
        /// </value>
        [JsonProperty(PropertyName = "ipVersion")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<IpVersion> IpVersion { get; set; }
        
        /// <value>
        /// The communication port for the listener.
        /// <br/>
        /// Example: 80
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Port is required.")]
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }
        
        /// <value>
        /// The protocol on which the listener accepts connection requests.
        /// For public network load balancers, ANY protocol refers to TCP/UDP with the wildcard port.
        /// For private network load balancers, ANY protocol refers to TCP/UDP/ICMP (note that ICMP requires isPreserveSourceDestination to be set to true).
        /// \"ListNetworkLoadBalancersProtocols\" API is deprecated and it will not return the updated values. Use the allowed values for the protocol instead.
        /// <br/>
        /// Example: TCP
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Protocol is required.")]
        [JsonProperty(PropertyName = "protocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ListenerProtocols> Protocol { get; set; }
        
        /// <value>
        /// Property to enable/disable PPv2 feature for this listener.
        /// </value>
        [JsonProperty(PropertyName = "isPpv2Enabled")]
        public System.Nullable<bool> IsPpv2Enabled { get; set; }
        
        /// <value>
        /// The duration for TCP idle timeout in seconds.
        /// Example: 300
        /// </value>
        [JsonProperty(PropertyName = "tcpIdleTimeout")]
        public System.Nullable<int> TcpIdleTimeout { get; set; }
        
        /// <value>
        /// The duration for UDP idle timeout in seconds.
        /// Example: 120
        /// </value>
        [JsonProperty(PropertyName = "udpIdleTimeout")]
        public System.Nullable<int> UdpIdleTimeout { get; set; }
        
        /// <value>
        /// The duration for L3IP idle timeout in seconds.
        /// Example: 200
        /// </value>
        [JsonProperty(PropertyName = "l3IpIdleTimeout")]
        public System.Nullable<int> L3IpIdleTimeout { get; set; }
        
    }
}
