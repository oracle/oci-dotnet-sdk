/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace Oci.Common.Utils
{
    /// <summary>A custom resolver that handles Json serialization and deserialization for Stream and DateTime values.</summary>
    public class CustomResolver : DefaultContractResolver
    {
        protected override JsonProperty CreateProperty(System.Reflection.MemberInfo member, MemberSerialization memberSerialization)
        {
            JsonProperty property = base.CreateProperty(member, memberSerialization);
            // If the property type of Nullable, get the real type inside.
            var propertyType = property.PropertyType;
            if (propertyType.IsGenericType && propertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                propertyType = propertyType.GetGenericArguments()[0];
            }
            if (typeof(Stream).IsAssignableFrom(propertyType))
            {
                // Use custom converter for Stream type
                property.Converter = new StreamJsonConverter();
            }
            if (typeof(DateTime) == propertyType)
            {
                property.Converter = new DateTimeJsonConverter();
            }
            return property;
        }
    }

    /// <summary>A customer Json converter for DateTime values.</summary>
    public class DateTimeJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(DateTime) == objectType;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return serializer.Deserialize<DateTime>(reader);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var val = HttpDateUtils.ToRfc3339Format(((DateTime)value).ToUniversalTime());
            serializer.Serialize(writer, val);
        }
    }

    /// <summary>A customer Json converter for Stream values.</summary>
    public class StreamJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(MemoryStream).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var bytes = Encoding.UTF8.GetBytes((string)reader.Value);
            return bytes != null ? new MemoryStream(bytes) : new MemoryStream();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var bytes = ((MemoryStream)value).ToArray();
            serializer.Serialize(writer, bytes);
        }
    }

    public class ResponseEnumConverter : StringEnumConverter
    {
        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            try
            {
                return base.ReadJson(reader, objectType, existingValue, serializer);
            }
            catch
            {
                Type enumType = IsNullableType(objectType) ? Nullable.GetUnderlyingType(objectType) : objectType;
                logger.Warn($"Received unknown value '{existingValue}' for enum '{objectType}', returning UnknownEnumValue");
                string unknownEnumValue = Enum.GetNames(enumType).Where(n => string.Equals(n, "UnknownEnumValue", StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
                if (unknownEnumValue == null)
                {
                    throw new ArgumentException($"UnknownEnumValue enum value not found in enum {objectType}");
                }
                return Enum.Parse(enumType, unknownEnumValue);
            }
        }
        private bool IsNullableType(Type t)
        {
            return (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>));
        }
    }

    public class OciJsonSerializerSettings
    {
        private static readonly int DEFAULT_MAX_DEPTH = 128;
        private static readonly string OCI_DOTNET_SDK_DEFAULT_SERIALIZER_MAX_DEPTH = "OCI_DOTNET_SDK_DEFAULT_SERIALIZER_MAX_DEPTH";
        public int MaxDepth { get; set; } = DEFAULT_MAX_DEPTH;

        public JsonSerializerSettings GetJsonSerializerSettings()
        {
            return new JsonSerializerSettings
            {
                MaxDepth = this.MaxDepth
            };
        }

        public static int GetDefaultJsonSerializerMaxDepth()
        {
            string defaultMaxDepth = Environment.GetEnvironmentVariable(OCI_DOTNET_SDK_DEFAULT_SERIALIZER_MAX_DEPTH);
            if (!string.IsNullOrEmpty(defaultMaxDepth))
            {
                if (int.TryParse(defaultMaxDepth, out int maxDepth))
                {
                    return maxDepth;
                }
            }
            return DEFAULT_MAX_DEPTH;
        }

        public static JsonSerializerSettings GetDefaultJsonSerializerSettings()
        {
            return new JsonSerializerSettings { MaxDepth = GetDefaultJsonSerializerMaxDepth() };
        }
    };
}
