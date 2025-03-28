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
    /// The caching rule settings.
    /// </summary>
    public class CachingRuleSummary 
    {
        
        /// <value>
        /// The unique key for the caching rule.
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The name of the caching rule.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
                ///
        /// <value>
        /// The action to take when the criteria of a caching rule are met.
        /// - **CACHE:** Caches requested content when the criteria of the rule are met.
        /// <br/>
        /// - **BYPASS_CACHE:** Allows requests to bypass the cache and be directed to the origin when the criteria of the rule is met.
        /// </value>
        ///
        public enum ActionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CACHE")]
            Cache,
            [EnumMember(Value = "BYPASS_CACHE")]
            BypassCache
        };

        /// <value>
        /// The action to take when the criteria of a caching rule are met.
        /// - **CACHE:** Caches requested content when the criteria of the rule are met.
        /// <br/>
        /// - **BYPASS_CACHE:** Allows requests to bypass the cache and be directed to the origin when the criteria of the rule is met.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Action is required.")]
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ActionEnum> Action { get; set; }
        
        /// <value>
        /// The duration to cache content for the caching rule, specified in ISO 8601 extended format. Supported units: seconds, minutes, hours, days, weeks, months. The maximum value that can be set for any unit is `99`. Mixing of multiple units is not supported. Only applies when the `action` is set to `CACHE`.
        /// Example: PT1H
        /// </value>
        [JsonProperty(PropertyName = "cachingDuration")]
        public string CachingDuration { get; set; }
        
        /// <value>
        /// Enables or disables client caching.
        /// Browsers use the `Cache-Control` header value for caching content locally in the browser. This setting overrides the addition of a `Cache-Control` header in responses.
        /// </value>
        [JsonProperty(PropertyName = "isClientCachingEnabled")]
        public System.Nullable<bool> IsClientCachingEnabled { get; set; }
        
        /// <value>
        /// The duration to cache content in the user's browser, specified in ISO 8601 extended format. Supported units: seconds, minutes, hours, days, weeks, months. The maximum value that can be set for any unit is `99`. Mixing of multiple units is not supported. Only applies when the `action` is set to `CACHE`.
        /// Example: PT1H
        /// </value>
        [JsonProperty(PropertyName = "clientCachingDuration")]
        public string ClientCachingDuration { get; set; }
        
        /// <value>
        /// The array of the rule criteria with condition and value. The caching rule would be applied for the requests that matched any of the listed conditions.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Criteria is required.")]
        [JsonProperty(PropertyName = "criteria")]
        public System.Collections.Generic.List<CachingRuleCriteria> Criteria { get; set; }
        
    }
}
