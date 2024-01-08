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

namespace Oci.CoreService.Models
{
    /// <summary>
    /// Image Capability Schema Descriptor is a type of capability for an image.
    /// 
    /// </summary>
    [JsonConverter(typeof(ImageCapabilitySchemaDescriptorModelConverter))]
    public class ImageCapabilitySchemaDescriptor 
    {
        
                ///
        ///
        public enum SourceEnum {
            [EnumMember(Value = "GLOBAL")]
            Global,
            [EnumMember(Value = "IMAGE")]
            Image
        };

        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Source is required.")]
        [JsonProperty(PropertyName = "source")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SourceEnum> Source { get; set; }
        
    }

    public class ImageCapabilitySchemaDescriptorModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ImageCapabilitySchemaDescriptor);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ImageCapabilitySchemaDescriptor);
            var discriminator = jsonObject["descriptorType"].Value<string>();
            switch (discriminator)
            {
                case "enumstring":
                    obj = new EnumStringImageCapabilitySchemaDescriptor();
                    break;
                case "enuminteger":
                    obj = new EnumIntegerImageCapabilityDescriptor();
                    break;
                case "boolean":
                    obj = new BooleanImageCapabilitySchemaDescriptor();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under ImageCapabilitySchemaDescriptor! Returning null value.");
            }
            return obj;
        }
    }
}
