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

namespace Oci.GenerativeaiagentruntimeService.Models
{
    /// <summary>
    /// The location of the data files that the agent will use.
    /// 
    /// </summary>
    [JsonConverter(typeof(SourceLocationModelConverter))]
    public class SourceLocation 
    {
                ///
        /// <value>
        /// The type of the data source that contains data files for the agent.
        /// </value>
        ///
        public enum SourceLocationTypeEnum {
            [EnumMember(Value = "OCI_OBJECT_STORAGE")]
            OciObjectStorage,
            [EnumMember(Value = "OCI_OPEN_SEARCH")]
            OciOpenSearch,
            [EnumMember(Value = "OCI_DATABASE")]
            OciDatabase
        };

        
    }

    public class SourceLocationModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(SourceLocation);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(SourceLocation);
            var discriminator = jsonObject["sourceLocationType"].Value<string>();
            switch (discriminator)
            {
                case "OCI_OBJECT_STORAGE":
                    obj = new OciObjectStorageSourceLocation();
                    break;
                case "OCI_OPEN_SEARCH":
                    obj = new OciOpenSearchSourceLocation();
                    break;
                case "OCI_DATABASE":
                    obj = new OciDatabaseSourceLocation();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under SourceLocation! Returning null value.");
            }
            return obj;
        }
    }
}
