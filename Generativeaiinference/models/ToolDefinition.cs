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

namespace Oci.GenerativeaiinferenceService.Models
{
    /// <summary>
    /// A tool the model may call.
    /// </summary>
    [JsonConverter(typeof(ToolDefinitionModelConverter))]
    public class ToolDefinition 
    {
                ///
        /// <value>
        /// The type of the tool.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "FUNCTION")]
            Function
        };

        
    }

    public class ToolDefinitionModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ToolDefinition);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ToolDefinition);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "FUNCTION":
                    obj = new FunctionDefinition();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
