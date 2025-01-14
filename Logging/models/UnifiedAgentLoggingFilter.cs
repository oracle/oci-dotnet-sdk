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

namespace Oci.LoggingService.Models
{
    /// <summary>
    /// Logging filter object.
    /// </summary>
    [JsonConverter(typeof(UnifiedAgentLoggingFilterModelConverter))]
    public class UnifiedAgentLoggingFilter 
    {
        
        /// <value>
        /// Unique name for the filter.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
                ///
        /// <value>
        /// Unified schema logging filter type.
        /// </value>
        ///
        public enum FilterTypeEnum {
            [EnumMember(Value = "PARSER_FILTER")]
            ParserFilter,
            [EnumMember(Value = "GREP_FILTER")]
            GrepFilter,
            [EnumMember(Value = "RECORD_TRANSFORMER_FILTER")]
            RecordTransformerFilter,
            [EnumMember(Value = "CUSTOM_FILTER")]
            CustomFilter
        };

        
    }

    public class UnifiedAgentLoggingFilterModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(UnifiedAgentLoggingFilter);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(UnifiedAgentLoggingFilter);
            var discriminator = jsonObject["filterType"].Value<string>();
            switch (discriminator)
            {
                case "CUSTOM_FILTER":
                    obj = new UnifiedAgentCustomFilter();
                    break;
                case "PARSER_FILTER":
                    obj = new UnifiedAgentParserFilter();
                    break;
                case "GREP_FILTER":
                    obj = new UnifiedAgentLoggingGrepFilter();
                    break;
                case "RECORD_TRANSFORMER_FILTER":
                    obj = new UnifiedAgentLoggingRecordTransformerFilter();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under UnifiedAgentLoggingFilter! Returning null value.");
            }
            return obj;
        }
    }
}
