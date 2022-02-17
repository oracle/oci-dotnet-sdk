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

namespace Oci.DataconnectivityService.Models
{
    /// <summary>
    /// The `TypedObject` class is a base class for any model object that has a type.
    /// </summary>
    [JsonConverter(typeof(TypedObjectModelConverter))]
    public class TypedObject 
    {
                ///
        /// <value>
        /// The type of the types object.
        /// </value>
        ///
        public enum ModelTypeEnum {
            [EnumMember(Value = "SHAPE")]
            Shape,
            [EnumMember(Value = "SHAPE_FIELD")]
            ShapeField,
            [EnumMember(Value = "NATIVE_SHAPE_FIELD")]
            NativeShapeField
        };

        
        /// <value>
        /// The key of the object.
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The model version of an object.
        /// </value>
        [JsonProperty(PropertyName = "modelVersion")]
        public string ModelVersion { get; set; }
        
        [JsonProperty(PropertyName = "parentRef")]
        public ParentReference ParentRef { get; set; }
        
        [JsonProperty(PropertyName = "configValues")]
        public ConfigValues ConfigValues { get; set; }
        
        /// <value>
        /// The status of an object that can be set to value 1 for shallow references across objects, other values reserved.
        /// </value>
        [JsonProperty(PropertyName = "objectStatus")]
        public System.Nullable<int> ObjectStatus { get; set; }
        
        /// <value>
        /// Free form text without any restriction on permitted characters. Name can have letters, numbers, and special characters. The value is editable and is restricted to 1000 characters.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Detailed description for the object.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
    }

    public class TypedObjectModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(TypedObject);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(TypedObject);
            var discriminator = jsonObject["modelType"].Value<string>();
            switch (discriminator)
            {
                case "OUTPUT_PORT":
                    obj = new OutputPort();
                    break;
                case "SHAPE":
                    obj = new Shape();
                    break;
                case "SHAPE_FIELD":
                    obj = new ShapeField();
                    break;
                case "INPUT_PORT":
                    obj = new InputPort();
                    break;
                case "PARAMETER":
                    obj = new Parameter();
                    break;
                case "NATIVE_SHAPE_FIELD":
                    obj = new NativeShapeField();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
