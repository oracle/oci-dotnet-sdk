/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
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
    /// The base class to use for the chat inference request.
    /// </summary>
    [JsonConverter(typeof(BaseChatRequestModelConverter))]
    public class BaseChatRequest 
    {
                ///
        /// <value>
        /// The API format for the model's family group.
        /// COHERE is for the Cohere family models such as the cohere.command-r-16k and cohere.command-r-plus models.
        /// GENERIC is for other model families such as the meta.llama-3-70b-instruct model.
        /// 
        /// </value>
        ///
        public enum ApiFormatEnum {
            [EnumMember(Value = "COHERE")]
            Cohere,
            [EnumMember(Value = "GENERIC")]
            Generic
        };

        
    }

    public class BaseChatRequestModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(BaseChatRequest);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(BaseChatRequest);
            var discriminator = jsonObject["apiFormat"].Value<string>();
            switch (discriminator)
            {
                case "GENERIC":
                    obj = new GenericChatRequest();
                    break;
                case "COHERE":
                    obj = new CohereChatRequest();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
