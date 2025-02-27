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

namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// A field map is a way to map a source row shape to a target row shape that may be different.
    /// </summary>
    [JsonConverter(typeof(FieldMapModelConverter))]
    public class FieldMap 
    {
                ///
        /// <value>
        /// The model type for the field map.
        /// </value>
        ///
        public enum ModelTypeEnum {
            [EnumMember(Value = "DIRECT_NAMED_FIELD_MAP")]
            DirectNamedFieldMap,
            [EnumMember(Value = "COMPOSITE_FIELD_MAP")]
            CompositeFieldMap,
            [EnumMember(Value = "DIRECT_FIELD_MAP")]
            DirectFieldMap,
            [EnumMember(Value = "RULE_BASED_FIELD_MAP")]
            RuleBasedFieldMap,
            [EnumMember(Value = "CONDITIONAL_COMPOSITE_FIELD_MAP")]
            ConditionalCompositeFieldMap,
            [EnumMember(Value = "NAMED_ENTITY_MAP")]
            NamedEntityMap,
            [EnumMember(Value = "RULE_BASED_ENTITY_MAP")]
            RuleBasedEntityMap
        };

        
        /// <value>
        /// Detailed description for the object.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
    }

    public class FieldMapModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(FieldMap);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(FieldMap);
            var discriminator = jsonObject["modelType"].Value<string>();
            switch (discriminator)
            {
                case "RULE_BASED_FIELD_MAP":
                    obj = new RuleBasedFieldMap();
                    break;
                case "RULE_BASED_ENTITY_MAP":
                    obj = new RuleBasedEntityMap();
                    break;
                case "NAMED_ENTITY_MAP":
                    obj = new NamedEntityMap();
                    break;
                case "DIRECT_FIELD_MAP":
                    obj = new DirectFieldMap();
                    break;
                case "COMPOSITE_FIELD_MAP":
                    obj = new CompositeFieldMap();
                    break;
                case "CONDITIONAL_COMPOSITE_FIELD_MAP":
                    obj = new ConditionalCompositeFieldMap();
                    break;
                case "DIRECT_NAMED_FIELD_MAP":
                    obj = new DirectNamedFieldMap();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under FieldMap! Returning null value.");
            }
            return obj;
        }
    }
}
