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

namespace Oci.FusionappsService.Models
{
    /// <summary>
    /// A condition to apply to an access control rule.
    /// </summary>
    [JsonConverter(typeof(RuleConditionModelConverter))]
    public class RuleCondition 
    {
                ///
        /// <value>
        /// RuleCondition type
        /// </value>
        ///
        public enum AttributeNameEnum {
            [EnumMember(Value = "SOURCE_IP_ADDRESS")]
            SourceIpAddress,
            [EnumMember(Value = "SOURCE_VCN_ID")]
            SourceVcnId,
            [EnumMember(Value = "SOURCE_VCN_IP_ADDRESS")]
            SourceVcnIpAddress
        };

        
    }

    public class RuleConditionModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(RuleCondition);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(RuleCondition);
            var discriminator = jsonObject["attributeName"].Value<string>();
            switch (discriminator)
            {
                case "SOURCE_VCN_ID":
                    obj = new SourceVcnIdCondition();
                    break;
                case "SOURCE_IP_ADDRESS":
                    obj = new SourceIpAddressCondition();
                    break;
                case "SOURCE_VCN_IP_ADDRESS":
                    obj = new SourceVcnIpAddressCondition();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under RuleCondition! Returning null value.");
            }
            return obj;
        }
    }
}
