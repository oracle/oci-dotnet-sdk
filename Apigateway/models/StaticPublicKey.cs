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
    /// A static public key which is used to verify the JWT signature.
    /// </summary>
    [JsonConverter(typeof(StaticPublicKeyModelConverter))]
    public class StaticPublicKey 
    {
        
        /// <value>
        /// A unique key ID. This key will be used to verify the signature of a
        /// JWT with matching \"kid\".
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Kid is required.")]
        [JsonProperty(PropertyName = "kid")]
        public string Kid { get; set; }
                ///
        /// <value>
        /// The format of the public key.
        /// </value>
        ///
        public enum FormatEnum {
            [EnumMember(Value = "JSON_WEB_KEY")]
            JsonWebKey,
            [EnumMember(Value = "PEM")]
            Pem
        };

        
    }

    public class StaticPublicKeyModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(StaticPublicKey);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(StaticPublicKey);
            var discriminator = jsonObject["format"].Value<string>();
            switch (discriminator)
            {
                case "JSON_WEB_KEY":
                    obj = new JsonWebKey();
                    break;
                case "PEM":
                    obj = new PemEncodedPublicKey();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under StaticPublicKey! Returning null value.");
            }
            return obj;
        }
    }
}
