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


namespace Oci.WafService.Models
{
    /// <summary>
    /// Rule that represents Request/Response Protection.
    /// Only actions of the following types are allowed to be referenced in this rule:
    ///  * CHECK
    ///  * RETURN_HTTP_RESPONSE
    /// 
    /// </summary>
    public class ProtectionRule : WebAppFirewallPolicyRule
    {
        
        /// <value>
        /// An ordered list that references OCI-managed protection capabilities.
        /// Referenced protection capabilities are not necessarily executed in order of appearance. Their execution order
        /// is decided at runtime for improved performance.
        /// The array cannot contain entries with the same pair of capability key and version more than once.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProtectionCapabilities is required.")]
        [JsonProperty(PropertyName = "protectionCapabilities")]
        public System.Collections.Generic.List<ProtectionCapability> ProtectionCapabilities { get; set; }
        
        [JsonProperty(PropertyName = "protectionCapabilitySettings")]
        public ProtectionCapabilitySettings ProtectionCapabilitySettings { get; set; }
        
        /// <value>
        /// Enables/disables body inspection for this protection rule.
        /// Only Protection Rules in RequestProtection can have this option enabled. Response body inspection will
        /// be available at a later date.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isBodyInspectionEnabled")]
        public System.Nullable<bool> IsBodyInspectionEnabled { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "PROTECTION";
    }
}
