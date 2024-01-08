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

namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The data entity summary object.
    /// </summary>
    [JsonConverter(typeof(DataEntitySummaryModelConverter))]
    public class DataEntitySummary 
    {
                ///
        /// <value>
        /// The data entity type.
        /// </value>
        ///
        public enum ModelTypeEnum {
            [EnumMember(Value = "VIEW_ENTITY")]
            ViewEntity,
            [EnumMember(Value = "TABLE_ENTITY")]
            TableEntity,
            [EnumMember(Value = "FILE_ENTITY")]
            FileEntity,
            [EnumMember(Value = "SQL_ENTITY")]
            SqlEntity,
            [EnumMember(Value = "OBJECT_ENTITY")]
            ObjectEntity,
            [EnumMember(Value = "DATA_STORE_ENTITY")]
            DataStoreEntity
        };

        
        [JsonProperty(PropertyName = "metadata")]
        public ObjectMetadata Metadata { get; set; }
        
    }

    public class DataEntitySummaryModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(DataEntitySummary);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(DataEntitySummary);
            var discriminator = jsonObject["modelType"].Value<string>();
            switch (discriminator)
            {
                case "FILE_ENTITY":
                    obj = new DataEntitySummaryFromFile();
                    break;
                case "OBJECT_ENTITY":
                    obj = new DataEntitySummaryFromObject();
                    break;
                case "TABLE_ENTITY":
                    obj = new DataEntitySummaryFromTable();
                    break;
                case "DATA_STORE_ENTITY":
                    obj = new DataEntitySummaryFromDataStore();
                    break;
                case "SQL_ENTITY":
                    obj = new DataEntitySummaryFromSql();
                    break;
                case "VIEW_ENTITY":
                    obj = new DataEntitySummaryFromView();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under DataEntitySummary! Returning null value.");
            }
            return obj;
        }
    }
}
