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

namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Optional additional properties for data transfer.
    /// </summary>
    [JsonConverter(typeof(OracleDataTransferMediumDetailsModelConverter))]
    public class OracleDataTransferMediumDetails 
    {
                ///
        /// <value>
        /// Type of the data transfer medium to use.
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

    public class OracleDataTransferMediumDetailsModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(OracleDataTransferMediumDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(OracleDataTransferMediumDetails);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "DBLINK":
                    obj = new OracleDbLinkDataTransferMediumDetails();
                    break;
                case "OBJECT_STORAGE":
                    obj = new OracleObjectStorageDataTransferMediumDetails();
                    break;
                case "AWS_S3":
                    obj = new OracleAwsS3DataTransferMediumDetails();
                    break;
                case "NFS":
                    obj = new OracleNfsDataTransferMediumDetails();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under OracleDataTransferMediumDetails! Returning null value.");
            }
            return obj;
        }
    }
}
