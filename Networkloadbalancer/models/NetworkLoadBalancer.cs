/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
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
    /// The properties that define a network load balancer. For more information, see
    /// [Managing a network load balancer](https://docs.cloud.oracle.com/Content/Balance/Tasks/managingloadbalancer.htm).
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you are not authorized,
    /// contact an administrator. If you are an administrator who writes policies to give users access, then see
    /// [Getting Started with Policies](https://docs.cloud.oracle.com/Content/Identity/Concepts/policygetstarted.htm).
    /// <br/>
    /// For information about endpoints and signing API requests, see
    /// [About the API](https://docs.cloud.oracle.com/Content/API/Concepts/usingapi.htm). For information about available SDKs and tools, see
    /// [SDKS and Other Tools](https://docs.cloud.oracle.com/Content/API/Concepts/sdks.htm).
    /// 
    /// </summary>
    public class NetworkLoadBalancer 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the network load balancer.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment containing the network load balancer.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A user-friendly name, which does not have to be unique, and can be changed.
        /// <br/>
        /// Example: example_load_balancer
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The current state of the network load balancer.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the current state in more detail.
        /// For example, can be used to provide actionable information for a resource in Failed state.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// IP version associated with the NLB.
        /// </value>
        [JsonProperty(PropertyName = "nlbIpVersion")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<NlbIpVersion> NlbIpVersion { get; set; }
        
        /// <value>
        /// The date and time the network load balancer was created, in the format defined by RFC3339.
        /// <br/>
        /// Example: 2020-05-01T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time the network load balancer was updated. An RFC3339 formatted date-time string.
        /// <br/>
        /// Example: 2020-05-01T22:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// An array of IP addresses.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IpAddresses is required.")]
        [JsonProperty(PropertyName = "ipAddresses")]
        public System.Collections.Generic.List<IpAddress> IpAddresses { get; set; }
        
        /// <value>
        /// Whether the network load balancer has a virtual cloud network-local (private) IP address.
        /// <br/>
        /// If \"true\", then the service assigns a private IP address to the network load balancer.
        /// <br/>
        /// If \"false\", then the service assigns a public IP address to the network load balancer.
        /// <br/>
        /// A public network load balancer is accessible from the internet, depending the
        /// [security list rules](https://docs.cloud.oracle.com/Content/network/Concepts/securitylists.htm) for your virtual cloudn network. For more information about public and
        /// private network load balancers,
        /// see [How Network Load Balancing Works](https://docs.cloud.oracle.com/Content/Balance/Concepts/balanceoverview.htm#how-network-load-balancing-works).
        /// This value is true by default.
        /// <br/>
        /// Example: true
        /// </value>
        [JsonProperty(PropertyName = "isPrivate")]
        public System.Nullable<bool> IsPrivate { get; set; }
        
        /// <value>
        /// When enabled, the skipSourceDestinationCheck parameter is automatically enabled on the load balancer VNIC.
        /// Packets are sent to the backend set without any changes to the source and destination IP.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isPreserveSourceDestination")]
        public System.Nullable<bool> IsPreserveSourceDestination { get; set; }
        
        /// <value>
        /// The subnet in which the network load balancer is spawned [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).\"
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// An array of network security groups [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) associated with the network load
        /// balancer.
        /// <br/>
        /// During the creation of the network load balancer, the service adds the new load balancer to the specified network security groups.
        /// <br/>
        /// The benefits of associating the network load balancer with network security groups include:
        /// <br/>
        /// *  Network security groups define network security rules to govern ingress and egress traffic for the network load balancer.
        /// <br/>
        /// *  The network security rules of other resources can reference the network security groups associated with the network load balancer
        ///    to ensure access.
        /// <br/>
        /// Example: [&quot;ocid1.nsg.oc1.phx.unique_ID&quot;]
        /// </value>
        [JsonProperty(PropertyName = "networkSecurityGroupIds")]
        public System.Collections.Generic.List<string> NetworkSecurityGroupIds { get; set; }
        
        /// <value>
        /// Listeners associated with the network load balancer.
        /// </value>
        [JsonProperty(PropertyName = "listeners")]
        public System.Collections.Generic.Dictionary<string, Listener> Listeners { get; set; }
        
        /// <value>
        /// Backend sets associated with the network load balancer.
        /// </value>
        [JsonProperty(PropertyName = "backendSets")]
        public System.Collections.Generic.Dictionary<string, BackendSet> BackendSets { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Key-value pair representing system tags' keys and values scoped to a namespace.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
