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

namespace Oci.DataintegrationService.Models
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
            [EnumMember(Value = "INPUT_PORT")]
            InputPort,
            [EnumMember(Value = "SHAPE_FIELD")]
            ShapeField,
            [EnumMember(Value = "INPUT_FIELD")]
            InputField,
            [EnumMember(Value = "DERIVED_FIELD")]
            DerivedField,
            [EnumMember(Value = "MACRO_FIELD")]
            MacroField,
            [EnumMember(Value = "OUTPUT_FIELD")]
            OutputField,
            [EnumMember(Value = "DYNAMIC_PROXY_FIELD")]
            DynamicProxyField,
            [EnumMember(Value = "OUTPUT_PORT")]
            OutputPort,
            [EnumMember(Value = "DYNAMIC_INPUT_FIELD")]
            DynamicInputField,
            [EnumMember(Value = "PROXY_FIELD")]
            ProxyField,
            [EnumMember(Value = "PARAMETER")]
            Parameter,
            [EnumMember(Value = "PIVOT_FIELD")]
            PivotField,
            [EnumMember(Value = "MACRO_PIVOT_FIELD")]
            MacroPivotField,
            [EnumMember(Value = "CONDITIONAL_OUTPUT_PORT")]
            ConditionalOutputPort,
            [EnumMember(Value = "INPUT_PROXY_FIELD")]
            InputProxyField,
            [EnumMember(Value = "MATERIALIZED_DYNAMIC_FIELD")]
            MaterializedDynamicField,
            [EnumMember(Value = "DECISION_OUTPUT_PORT")]
            DecisionOutputPort
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
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
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
                case "DYNAMIC_INPUT_FIELD":
                    obj = new DynamicInputField();
                    break;
                case "FIELD":
                    obj = new AbstractField();
                    break;
                case "INPUT_FIELD":
                    obj = new InputField();
                    break;
                case "SHAPE":
                    obj = new Shape();
                    break;
                case "INPUT_PORT":
                    obj = new InputPort();
                    break;
                case "CONDITIONAL_OUTPUT_PORT":
                    obj = new ConditionalOutputPort();
                    break;
                case "DECISION_OUTPUT_PORT":
                    obj = new DecisionOutputPort();
                    break;
                case "MATERIALIZED_DYNAMIC_FIELD":
                    obj = new MaterializedDynamicField();
                    break;
                case "PROXY_FIELD":
                    obj = new ProxyField();
                    break;
                case "DYNAMIC_PROXY_FIELD":
                    obj = new DynamicProxyField();
                    break;
                case "SHAPE_FIELD":
                    obj = new ShapeField();
                    break;
                case "INPUT_PROXY_FIELD":
                    obj = new InputProxyField();
                    break;
                case "PARAMETER":
                    obj = new Parameter();
                    break;
                case "PIVOT_FIELD":
                    obj = new PivotField();
                    break;
                case "OUTPUT_FIELD":
                    obj = new OutputField();
                    break;
                case "MACRO_FIELD":
                    obj = new MacroField();
                    break;
                case "DERIVED_FIELD":
                    obj = new DerivedField();
                    break;
                case "TYPED_EXPRESSION":
                    obj = new TypedExpression();
                    break;
                case "FLOW_PORT":
                    obj = new FlowPort();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under TypedObject! Returning null value.");
            }
            return obj;
        }
    }
}
