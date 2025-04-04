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

namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// Base Gateway response cache.
    /// 
    /// </summary>
    [JsonConverter(typeof(ResponseCacheDetailsModelConverter))]
    public class ResponseCacheDetails 
    {
                ///
        /// <value>
        /// Type of the Response Cache.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "EXTERNAL_RESP_CACHE")]
            ExternalRespCache,
            [EnumMember(Value = "NONE")]
            None
        };

        
    }

    public class ResponseCacheDetailsModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ResponseCacheDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ResponseCacheDetails);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "EXTERNAL_RESP_CACHE":
                    obj = new ExternalRespCache();
                    break;
                case "NONE":
                    obj = new NoCache();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under ResponseCacheDetails! Returning null value.");
            }
            return obj;
        }
    }
}
