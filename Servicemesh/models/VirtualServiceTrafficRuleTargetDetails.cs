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


namespace Oci.ServicemeshService.Models
{
    /// <summary>
    /// Traffic router target for an ingress gateway.
    /// </summary>
    public class VirtualServiceTrafficRuleTargetDetails : TrafficRuleTargetDetails
    {
        
        /// <value>
        /// The OCID of the virtual service where the request will be routed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VirtualServiceId is required.")]
        [JsonProperty(PropertyName = "virtualServiceId")]
        public string VirtualServiceId { get; set; }
        
        /// <value>
        /// The port on the virtual service to target.
        /// Mandatory if the virtual deployments are listening on multiple ports.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }
        
        /// <value>
        /// Weight of traffic target.
        /// </value>
        [JsonProperty(PropertyName = "weight")]
        public System.Nullable<int> Weight { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "VIRTUAL_SERVICE";
    }
}
