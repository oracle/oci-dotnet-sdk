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

namespace Oci.NetworkfirewallService.Models
{
    /// <summary>
    /// Pattern describing a URL or set of URLs.
    /// 
    /// </summary>
    [JsonConverter(typeof(UrlPatternModelConverter))]
    public class UrlPattern 
    {
                ///
        /// <value>
        /// The type of pattern.
        ///   * SIMPLE - A simple pattern with optional subdomain and/or path suffix wildcards.
        /// 
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "SIMPLE")]
            Simple
        };

        
    }

    public class UrlPatternModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(UrlPattern);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(UrlPattern);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "SIMPLE":
                    obj = new SimpleUrlPattern();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under UrlPattern! Returning null value.");
            }
            return obj;
        }
    }
}
