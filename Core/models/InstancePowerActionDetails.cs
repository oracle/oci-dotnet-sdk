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

namespace Oci.CoreService.Models
{
    /// <summary>
    /// A base object for all types of instance power action requests.
    /// </summary>
    [JsonConverter(typeof(InstancePowerActionDetailsModelConverter))]
    public class InstancePowerActionDetails 
    {
        
        
    }

    public class InstancePowerActionDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(InstancePowerActionDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(InstancePowerActionDetails);
            var discriminator = jsonObject["actionType"].Value<string>();
            switch (discriminator)
            {
                case "reset":
                    obj = new ResetActionDetails();
                    break;
                case "rebootMigrate":
                    obj = new RebootMigrateActionDetails();
                    break;
                case "softreset":
                    obj = new SoftResetActionDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
