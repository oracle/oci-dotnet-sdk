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

namespace Oci.MysqlService.Models
{
    /// <summary>
    /// Parameters detailing how to provision the initial data of the system.
    /// 
    /// </summary>
    [JsonConverter(typeof(CreateDbSystemSourceDetailsModelConverter))]
    public class CreateDbSystemSourceDetails 
    {
                ///
        /// <value>
        /// The specific source identifier.
        /// 
        /// </value>
        ///
        public enum SourceTypeEnum {
            [EnumMember(Value = "NONE")]
            None,
            [EnumMember(Value = "BACKUP")]
            Backup,
            [EnumMember(Value = "PITR")]
            Pitr,
            [EnumMember(Value = "IMPORTURL")]
            Importurl
        };

        
    }

    public class CreateDbSystemSourceDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreateDbSystemSourceDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreateDbSystemSourceDetails);
            var discriminator = jsonObject["sourceType"].Value<string>();
            switch (discriminator)
            {
                case "BACKUP":
                    obj = new CreateDbSystemSourceFromBackupDetails();
                    break;
                case "NONE":
                    obj = new CreateDbSystemSourceFromNoneDetails();
                    break;
                case "IMPORTURL":
                    obj = new CreateDbSystemSourceImportFromUrlDetails();
                    break;
                case "PITR":
                    obj = new CreateDbSystemSourceFromPitrDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
