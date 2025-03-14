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
using Newtonsoft.Json.Linq;

namespace Oci.WafService.Models
{
    /// <summary>
    /// Base schema for WebAppFirewallPolicyRules, including properties common to all of them.
    /// </summary>
    [JsonConverter(typeof(WebAppFirewallPolicyRuleModelConverter))]
    public class WebAppFirewallPolicyRule 
    {
                ///
        /// <value>
        /// Type of WebAppFirewallPolicyRule.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "ACCESS_CONTROL")]
            AccessControl,
            [EnumMember(Value = "PROTECTION")]
            Protection,
            [EnumMember(Value = "REQUEST_RATE_LIMITING")]
            RequestRateLimiting
        };

        
        /// <value>
        /// Rule name. Must be unique within the module.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
                ///
        /// <value>
        /// The language used to parse condition from field `condition`. Available languages:
        /// <br/>
        /// * **JMESPATH** an extended JMESPath language syntax.
        /// 
        /// </value>
        ///
        public enum ConditionLanguageEnum {
            [EnumMember(Value = "JMESPATH")]
            Jmespath
        };

        /// <value>
        /// The language used to parse condition from field `condition`. Available languages:
        /// <br/>
        /// * **JMESPATH** an extended JMESPath language syntax.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "conditionLanguage")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ConditionLanguageEnum> ConditionLanguage { get; set; }
        
        /// <value>
        /// An expression that determines whether or not the rule action should be executed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "condition")]
        public string Condition { get; set; }
        
        /// <value>
        /// References action by name from actions defined in WebAppFirewallPolicy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ActionName is required.")]
        [JsonProperty(PropertyName = "actionName")]
        public string ActionName { get; set; }
        
    }

    public class WebAppFirewallPolicyRuleModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(WebAppFirewallPolicyRule);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(WebAppFirewallPolicyRule);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "PROTECTION":
                    obj = new ProtectionRule();
                    break;
                case "REQUEST_RATE_LIMITING":
                    obj = new RequestRateLimitingRule();
                    break;
                case "ACCESS_CONTROL":
                    obj = new AccessControlRule();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under WebAppFirewallPolicyRule! Returning null value.");
            }
            return obj;
        }
    }
}
