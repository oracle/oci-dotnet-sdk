/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.WafService.Models
{
    /// <summary>
    /// Rule that represents RequestRateLimitingConfigurations.
    /// Only actions of the following types are allowed to be referenced in this rule:
    ///  * CHECK
    ///  * RETURN_HTTP_RESPONSE
    /// 
    /// </summary>
    public class RequestRateLimitingRule : WebAppFirewallPolicyRule
    {
        
        /// <value>
        /// Rate Limiting Configurations.
        /// Each configuration counts requests towards its own `requestsLimit`.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Configurations is required.")]
        [JsonProperty(PropertyName = "configurations")]
        public System.Collections.Generic.List<RequestRateLimitingConfiguration> Configurations { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "REQUEST_RATE_LIMITING";
    }
}
