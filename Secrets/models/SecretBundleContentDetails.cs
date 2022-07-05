/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Oci.SecretsService.Models
{
    /// <summary>
    /// The contents of the secret.
    /// </summary>
    [JsonConverter(typeof(SecretBundleContentDetailsModelConverter))]
    public class SecretBundleContentDetails 
    {
                ///
        /// <value>
        /// The formatting type of the secret contents.
        /// </value>
        ///
        public enum ContentTypeEnum {
            [EnumMember(Value = "BASE64")]
            Base64
        };

        
    }

    public class SecretBundleContentDetailsModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(SecretBundleContentDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(SecretBundleContentDetails);
            var discriminator = jsonObject["contentType"].Value<string>();
            switch (discriminator)
            {
                case "BASE64":
                    obj = new Base64SecretBundleContentDetails();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under SecretBundleContentDetails! Returning null value.");
            }
            return obj;
        }
    }
}
