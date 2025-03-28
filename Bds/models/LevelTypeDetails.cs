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

namespace Oci.BdsService.Models
{
    /// <summary>
    /// Details of the type of level used to trigger the creation of a new node backup configuration or node replacement configuration.
    /// </summary>
    [JsonConverter(typeof(LevelTypeDetailsModelConverter))]
    public class LevelTypeDetails 
    {
                ///
        /// <value>
        /// Type of level used to trigger the creation of a new node backup configuration or node replacement configuration.
        /// </value>
        ///
        public enum LevelTypeEnum {
            [EnumMember(Value = "NODE_LEVEL")]
            NodeLevel,
            [EnumMember(Value = "NODE_TYPE_LEVEL")]
            NodeTypeLevel
        };

        
    }

    public class LevelTypeDetailsModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(LevelTypeDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(LevelTypeDetails);
            var discriminator = jsonObject["levelType"].Value<string>();
            switch (discriminator)
            {
                case "NODE_TYPE_LEVEL":
                    obj = new NodeTypeLevelDetails();
                    break;
                case "NODE_LEVEL":
                    obj = new NodeLevelDetails();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under LevelTypeDetails! Returning null value.");
            }
            return obj;
        }
    }
}
