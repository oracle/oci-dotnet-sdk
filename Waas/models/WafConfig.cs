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
    /// The Web Application Firewall configuration for the WAAS policy.
    /// </summary>
    public class WafConfig 
    {
        
        /// <value>
        /// The access rules applied to the Web Application Firewall. Used for defining custom access policies with the combination of `ALLOW`, `DETECT`, and `BLOCK` rules, based on different criteria.
        /// </value>
        [JsonProperty(PropertyName = "accessRules")]
        public System.Collections.Generic.List<AccessRule> AccessRules { get; set; }
        
        /// <value>
        /// The IP address rate limiting settings used to limit the number of requests from an address.
        /// </value>
        [JsonProperty(PropertyName = "addressRateLimiting")]
        public AddressRateLimiting AddressRateLimiting { get; set; }
        
        /// <value>
        /// A list of CAPTCHA challenge settings. These are used to challenge requests with a CAPTCHA to block bots.
        /// </value>
        [JsonProperty(PropertyName = "captchas")]
        public System.Collections.Generic.List<Captcha> Captchas { get; set; }
        
        /// <value>
        /// The device fingerprint challenge settings. Used to detect unique devices based on the device fingerprint information collected in order to block bots.
        /// </value>
        [JsonProperty(PropertyName = "deviceFingerprintChallenge")]
        public DeviceFingerprintChallenge DeviceFingerprintChallenge { get; set; }
        
        /// <value>
        /// A list of bots allowed to access the web application.
        /// </value>
        [JsonProperty(PropertyName = "goodBots")]
        public System.Collections.Generic.List<GoodBot> GoodBots { get; set; }
        
        /// <value>
        /// The human interaction challenge settings. Used to look for natural human interactions such as mouse movements, time on site, and page scrolling to identify bots.
        /// </value>
        [JsonProperty(PropertyName = "humanInteractionChallenge")]
        public HumanInteractionChallenge HumanInteractionChallenge { get; set; }
        
        /// <value>
        /// The JavaScript challenge settings. Used to challenge requests with a JavaScript challenge and take the action if a browser has no JavaScript support in order to block bots.
        /// </value>
        [JsonProperty(PropertyName = "jsChallenge")]
        public JsChallenge JsChallenge { get; set; }
        
        /// <value>
        /// The key in the map of origins referencing the origin used for the Web Application Firewall. The origin must already be included in `Origins`. Required when creating the `WafConfig` resource, but not on update.
        /// </value>
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; set; }
        
        /// <value>
        /// A list of caching rules applied to the web application.
        /// </value>
        [JsonProperty(PropertyName = "cachingRules")]
        public System.Collections.Generic.List<CachingRule> CachingRules { get; set; }
        
        /// <value>
        /// A list of the custom protection rule OCIDs and their actions.
        /// </value>
        [JsonProperty(PropertyName = "customProtectionRules")]
        public System.Collections.Generic.List<CustomProtectionRuleSetting> CustomProtectionRules { get; set; }
        
        /// <value>
        /// The map of origin groups and their keys used to associate origins to the `wafConfig`. Origin groups allow you to apply weights to groups of origins for load balancing purposes. Origins with higher weights will receive larger proportions of client requests.
        /// To add additional origins to your WAAS policy, update the `origins` field of a `UpdateWaasPolicy` request.
        /// </value>
        [JsonProperty(PropertyName = "originGroups")]
        public System.Collections.Generic.List<string> OriginGroups { get; set; }
        
        /// <value>
        /// A list of the protection rules and their details.
        /// </value>
        [JsonProperty(PropertyName = "protectionRules")]
        public System.Collections.Generic.List<ProtectionRule> ProtectionRules { get; set; }
        
        /// <value>
        /// The settings to apply to protection rules.
        /// </value>
        [JsonProperty(PropertyName = "protectionSettings")]
        public ProtectionSettings ProtectionSettings { get; set; }
        
        /// <value>
        /// A list of threat intelligence feeds and the actions to apply to known malicious traffic based on internet intelligence.
        /// </value>
        [JsonProperty(PropertyName = "threatFeeds")]
        public System.Collections.Generic.List<ThreatFeed> ThreatFeeds { get; set; }
        
        /// <value>
        /// A list of IP addresses that bypass the Web Application Firewall.
        /// </value>
        [JsonProperty(PropertyName = "whitelists")]
        public System.Collections.Generic.List<Whitelist> Whitelists { get; set; }
        
    }
}
