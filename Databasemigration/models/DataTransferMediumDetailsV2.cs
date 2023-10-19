/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Optional additional properties for dump transfer in source or target host. Default kind is CURL
    /// 
    /// </summary>
    [JsonConverter(typeof(DataTransferMediumDetailsV2ModelConverter))]
    public class DataTransferMediumDetailsV2 
    {
                ///
        /// <value>
        /// Type of the data transfer medium to use for the datapump
        /// 
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "DBLINK")]
            Dblink,
            [EnumMember(Value = "OBJECT_STORAGE")]
            ObjectStorage,
            [EnumMember(Value = "AWS_S3")]
            AwsS3,
            [EnumMember(Value = "NFS")]
            Nfs
        };

        
    }

    public class DataTransferMediumDetailsV2ModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(DataTransferMediumDetailsV2);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(DataTransferMediumDetailsV2);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "NFS":
                    obj = new NfsDataTransferMediumDetails();
                    break;
                case "OBJECT_STORAGE":
                    obj = new ObjectStorageDataTransferMediumDetails();
                    break;
                case "DBLINK":
                    obj = new DbLinkDataTransferMediumDetails();
                    break;
                case "AWS_S3":
                    obj = new AwsS3DataTransferMediumDetails();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under DataTransferMediumDetailsV2! Returning null value.");
            }
            return obj;
        }
    }
}