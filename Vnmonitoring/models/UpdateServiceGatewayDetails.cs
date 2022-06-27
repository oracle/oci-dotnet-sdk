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


namespace Oci.VnmonitoringService.Models
{
    
    public class UpdateServiceGatewayDetails 
    {
        
        /// <value>
        /// Whether the service gateway blocks all traffic through it. The default is `false`. When
        /// this is `true`, traffic is not routed to any services, regardless of route rules.
        /// <br/>
        /// Example: true
        /// </value>
        [JsonProperty(PropertyName = "blockTraffic")]
        public System.Nullable<bool> BlockTraffic { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// List of all the `Service` objects you want enabled on this service gateway. Sending an empty list
        /// means you want to disable all services. Omitting this parameter entirely keeps the
        /// existing list of services intact.
        /// <br/>
        /// You can also enable or disable a particular `Service` by using
        /// {@link #attachServiceId(AttachServiceIdRequest) attachServiceId} or
        /// {@link #detachServiceId(DetachServiceIdRequest) detachServiceId}.
        /// <br/>
        /// For each enabled `Service`, make sure there's a route rule with the `Service` object's `cidrBlock`
        /// as the rule's destination and the service gateway as the rule's target. See
        /// {@link RouteTable}.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "services")]
        public System.Collections.Generic.List<ServiceIdRequestDetails> Services { get; set; }
        
    }
}
