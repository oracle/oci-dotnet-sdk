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

namespace Oci.GenerativeaiagentService.Models
{
    /// <summary>
    /// The input location definition for Api schema.
    /// </summary>
    [JsonConverter(typeof(ApiSchemaInputLocationModelConverter))]
    public class ApiSchemaInputLocation 
    {
                ///
        /// <value>
        /// Type of Api Schema InputLocation.
        /// 
        /// </value>
        ///
        public enum ApiSchemaInputLocationTypeEnum {
            [EnumMember(Value = "INLINE")]
            Inline,
            [EnumMember(Value = "OBJECT_STORAGE_LOCATION")]
            ObjectStorageLocation
        };

        
    }

    public class ApiSchemaInputLocationModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ApiSchemaInputLocation);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ApiSchemaInputLocation);
            var discriminator = jsonObject["apiSchemaInputLocationType"].Value<string>();
            switch (discriminator)
            {
                case "OBJECT_STORAGE_LOCATION":
                    obj = new ApiSchemaObjectStorageInputLocation();
                    break;
                case "INLINE":
                    obj = new ApiSchemaInlineInputLocation();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under ApiSchemaInputLocation! Returning null value.");
            }
            return obj;
        }
    }
}
