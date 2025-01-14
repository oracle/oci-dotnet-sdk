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


namespace Oci.WaasService.Models
{
    /// <summary>
    /// An object that represents the `sticky-cookie` load balancing method and its properties.
    /// 
    /// </summary>
    public class StickyCookieLoadBalancingMethod : LoadBalancingMethod
    {
        
        /// <value>
        /// The name of the cookie used to track the persistence.
        /// Can contain any US-ASCII character except separator or control character.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The domain for which the cookie is set, defaults to WAAS policy domain.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }
        
        /// <value>
        /// The time for which a browser should keep the cookie in seconds.
        /// Empty value will cause the cookie to expire at the end of a browser session.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "expirationTimeInSeconds")]
        public System.Nullable<int> ExpirationTimeInSeconds { get; set; }
        
        [JsonProperty(PropertyName = "method")]
        private readonly string method = "STICKY_COOKIE";
    }
}
