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


namespace Oci.NetworkloadbalancerService.Models
{
    /// <summary>
    /// The configuration of the listener.
    /// For more information about backend set configuration, see
    /// [Managing Load Balancer Listeners](https://docs.cloud.oracle.com/Content/Balance/Tasks/managinglisteners.htm).
    /// 
    /// </summary>
    public class ListenerSummary 
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
        /// For public network load balancers, ANY protocol refers to TCP/UDP.
        /// For private network load balancers, ANY protocol refers to TCP/UDP/ICMP (note that ICMP requires isPreserveSourceDestination to be set to true).
        /// To get a list of valid protocols, use the {@link #listNetworkLoadBalancersProtocols(ListNetworkLoadBalancersProtocolsRequest) listNetworkLoadBalancersProtocols}
        /// operation.
        /// <br/>
        /// Example: TCP
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Protocol is required.")]
        [JsonProperty(PropertyName = "protocol")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ListenerProtocols> Protocol { get; set; }
        
        /// <value>
        /// IP version associated with the listener.
        /// </value>
        [JsonProperty(PropertyName = "ipVersion")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<IpVersion> IpVersion { get; set; }
        
    }
}
