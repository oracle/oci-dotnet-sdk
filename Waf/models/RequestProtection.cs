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
    /// Module that allows to enable OCI-managed protection capabilities for incoming HTTP requests.
    /// </summary>
    public class RequestProtection 
    {
        
        /// <value>
        /// Ordered list of ProtectionRules. Rules are executed in order of appearance in this array.
        /// ProtectionRules in this array can only use protection Capabilities of REQUEST_PROTECTION_CAPABILITY type.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "rules")]
        public System.Collections.Generic.List<ProtectionRule> Rules { get; set; }
        
        /// <value>
        /// Maximum size of inspected HTTP message body in bytes. Actions to take if this limit is exceeded are defined in `bodyInspectionSizeLimitExceededActionName`.
        /// <br/>
        /// Body inspection maximum size allowed is defined with per-tenancy limit: 8192 bytes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "bodyInspectionSizeLimitInBytes")]
        public System.Nullable<int> BodyInspectionSizeLimitInBytes { get; set; }
        
        /// <value>
        /// References action by name from actions defined in WebAppFirewallPolicy. Executed if HTTP message
        /// body size exceeds limit set in field `bodyInspectionSizeLimitInBytes`.
        /// <br/>
        /// If this field is `null` HTTP message body will inspected up to `bodyInspectionSizeLimitInBytes` and the rest
        /// will not be inspected by Protection Capabilities.
        /// <br/>
        /// Allowed action types:
        /// * **RETURN_HTTP_RESPONSE** terminates further execution of modules and rules and returns defined HTTP response.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "bodyInspectionSizeLimitExceededActionName")]
        public string BodyInspectionSizeLimitExceededActionName { get; set; }
        
    }
}
