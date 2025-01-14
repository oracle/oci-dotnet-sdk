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
    /// The details of data source.
    /// 
    /// </summary>
    [JsonConverter(typeof(DataSourceConfigModelConverter))]
    public class DataSourceConfig 
    {
        
        /// <value>
        /// Flag to enable or disable multi modality such as image processing while ingestion of data. True enable the processing and false exclude the multi modality contents during ingestion.
        /// </value>
        [JsonProperty(PropertyName = "shouldEnableMultiModality")]
        public System.Nullable<bool> ShouldEnableMultiModality { get; set; }
                ///
        /// <value>
        /// The type of the tool.
        /// The allowed values are:
        /// - `OCI_OBJECT_STORAGE`: The data source is OCI Object Storage.
        /// 
        /// </value>
        ///
        public enum DataSourceConfigTypeEnum {
            [EnumMember(Value = "OCI_OBJECT_STORAGE")]
            OciObjectStorage
        };

        
    }

    public class DataSourceConfigModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(DataSourceConfig);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(DataSourceConfig);
            var discriminator = jsonObject["dataSourceConfigType"].Value<string>();
            switch (discriminator)
            {
                case "OCI_OBJECT_STORAGE":
                    obj = new OciObjectStorageDataSourceConfig();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under DataSourceConfig! Returning null value.");
            }
            return obj;
        }
    }
}
