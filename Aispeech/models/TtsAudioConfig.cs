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

namespace Oci.AispeechService.Models
{
    /// <summary>
    /// Use this schema to specify handling of audio response. 
    /// If audioConfig is not provided, raw response is handed over for the user to handle.
    /// 
    /// </summary>
    [JsonConverter(typeof(TtsAudioConfigModelConverter))]
    public class TtsAudioConfig 
    {
                ///
        /// <value>
        /// The audio config type to use for handling the audio output.
        /// Supported config types are:
        /// - BASE_AUDIO_CONFIG
        /// 
        /// </value>
        ///
        public enum ConfigTypeEnum {
            [EnumMember(Value = "BASE_AUDIO_CONFIG")]
            BaseAudioConfig
        };

        
    }

    public class TtsAudioConfigModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(TtsAudioConfig);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(TtsAudioConfig);
            var discriminator = jsonObject["configType"].Value<string>();
            switch (discriminator)
            {
                case "BASE_AUDIO_CONFIG":
                    obj = new TtsBaseAudioConfig();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
