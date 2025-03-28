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
    /// Websocket messages sent between client and service.
    /// </summary>
    [JsonConverter(typeof(RealtimeMessageModelConverter))]
    public class RealtimeMessage 
    {
                ///
        /// <value>
        /// Incoming Types of message event sent from Service -> Client
        /// - RESULT - result
        /// - ACKAUDIO - ackAudio
        /// - ERROR - error
        /// - CONNECT - connect
        /// Outgoing Types of message event sent from Client -> Service
        /// - SEND_FINAL_RESULT - sendFinalResult
        /// 
        /// </value>
        ///
        public enum EventEnum {
            [EnumMember(Value = "RESULT")]
            Result,
            [EnumMember(Value = "ACKAUDIO")]
            Ackaudio,
            [EnumMember(Value = "ERROR")]
            Error,
            [EnumMember(Value = "CONNECT")]
            Connect
        };

        
        /// <value>
        /// Session ID for the connected session.
        /// </value>
        [JsonProperty(PropertyName = "sessionId")]
        public string SessionId { get; set; }
        
    }

    public class RealtimeMessageModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(RealtimeMessage);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(RealtimeMessage);
            var discriminator = jsonObject["event"].Value<string>();
            switch (discriminator)
            {
                case "ERROR":
                    obj = new RealtimeMessageError();
                    break;
                case "ACKAUDIO":
                    obj = new RealtimeMessageAckAudio();
                    break;
                case "CONNECT":
                    obj = new RealtimeMessageConnect();
                    break;
                case "RESULT":
                    obj = new RealtimeMessageResult();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
