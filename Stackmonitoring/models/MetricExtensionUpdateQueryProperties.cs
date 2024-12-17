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

namespace Oci.StackmonitoringService.Models
{
    /// <summary>
    /// Collection method and query properties details of metric extension during update
    /// </summary>
    [JsonConverter(typeof(MetricExtensionUpdateQueryPropertiesModelConverter))]
    public class MetricExtensionUpdateQueryProperties 
    {
        
        
    }

    public class MetricExtensionUpdateQueryPropertiesModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(MetricExtensionUpdateQueryProperties);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(MetricExtensionUpdateQueryProperties);
            var discriminator = jsonObject["collectionMethod"].Value<string>();
            switch (discriminator)
            {
                case "SQL":
                    obj = new SqlUpdateQueryProperties();
                    break;
                case "JMX":
                    obj = new JmxUpdateQueryProperties();
                    break;
                case "OS_COMMAND":
                    obj = new OsCommandUpdateQueryProperties();
                    break;
                case "HTTP":
                    obj = new HttpUpdateQueryProperties();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
