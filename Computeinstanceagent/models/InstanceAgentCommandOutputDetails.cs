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

namespace Oci.ComputeinstanceagentService.Models
{
    /// <summary>
    /// The output destination for the command.
    /// </summary>
    [JsonConverter(typeof(InstanceAgentCommandOutputDetailsModelConverter))]
    public class InstanceAgentCommandOutputDetails 
    {
                ///
        /// <value>
        /// The output type for the command. The following values are supported:
        /// <br/>
        /// - `TEXT` - the command output is returned as plain text.
        /// - `OBJECT_STORAGE_URI` - the command output is saved to an Object Storage URL.
        /// - `OBJECT_STORAGE_TUPLE` - the command output is saved to an Object Storage bucket.
        /// <br/>
        /// For background information about Object Storage buckets and URLs, see
        /// [Overview of Object Storage](https://docs.cloud.oracle.com/Content/Object/Concepts/objectstorageoverview.htm).
        /// 
        /// </value>
        ///
        public enum OutputTypeEnum {
            [EnumMember(Value = "TEXT")]
            Text,
            [EnumMember(Value = "OBJECT_STORAGE_URI")]
            ObjectStorageUri,
            [EnumMember(Value = "OBJECT_STORAGE_TUPLE")]
            ObjectStorageTuple
        };

        
    }

    public class InstanceAgentCommandOutputDetailsModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(InstanceAgentCommandOutputDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(InstanceAgentCommandOutputDetails);
            var discriminator = jsonObject["outputType"].Value<string>();
            switch (discriminator)
            {
                case "OBJECT_STORAGE_URI":
                    obj = new InstanceAgentCommandOutputViaObjectStorageUriDetails();
                    break;
                case "OBJECT_STORAGE_TUPLE":
                    obj = new InstanceAgentCommandOutputViaObjectStorageTupleDetails();
                    break;
                case "TEXT":
                    obj = new InstanceAgentCommandOutputViaTextDetails();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under InstanceAgentCommandOutputDetails! Returning null value.");
            }
            return obj;
        }
    }
}
