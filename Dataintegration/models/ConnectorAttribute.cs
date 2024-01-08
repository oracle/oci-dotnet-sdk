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
    /// Marker class for connector attributes.
    /// </summary>
    [JsonConverter(typeof(ConnectorAttributeModelConverter))]
    public class ConnectorAttribute 
    {
                ///
        /// <value>
        /// The type of the abstract read attribute.
        /// </value>
        ///
        public enum ModelTypeEnum {
            [EnumMember(Value = "EXTERNAL_STORAGE")]
            ExternalStorage
        };

        
    }

    public class ConnectorAttributeModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ConnectorAttribute);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ConnectorAttribute);
            var discriminator = jsonObject["modelType"].Value<string>();
            switch (discriminator)
            {
                case "EXTERNAL_STORAGE":
                    obj = new ExternalStorage();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
