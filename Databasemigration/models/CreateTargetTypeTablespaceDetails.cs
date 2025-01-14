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
    /// Migration tablespace settings.
    /// </summary>
    [JsonConverter(typeof(CreateTargetTypeTablespaceDetailsModelConverter))]
    public class CreateTargetTypeTablespaceDetails 
    {
        
        
    }

    public class CreateTargetTypeTablespaceDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreateTargetTypeTablespaceDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreateTargetTypeTablespaceDetails);
            var discriminator = jsonObject["targetType"].Value<string>();
            switch (discriminator)
            {
                case "NON_ADB_AUTOCREATE":
                    obj = new CreateNonADBAutoCreateTablespaceDetails();
                    break;
                case "NON_ADB_REMAP":
                    obj = new CreateNonADBRemapTablespaceDetails();
                    break;
                case "ADB_D_REMAP":
                    obj = new CreateADBDedicatedRemapTargetTablespaceDetails();
                    break;
                case "ADB_S_REMAP":
                    obj = new CreateADBServerlesTablespaceDetails();
                    break;
                case "ADB_D_AUTOCREATE":
                    obj = new CreateADBDedicatedAutoCreateTablespaceDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
