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
    /// Properties used in task create operations.
    /// </summary>
    [JsonConverter(typeof(UpdateTaskDetailsModelConverter))]
    public class UpdateTaskDetails 
    {
                ///
        /// <value>
        /// The type of the task.
        /// </value>
        ///
        public enum ModelTypeEnum {
            [EnumMember(Value = "INTEGRATION_TASK")]
            IntegrationTask,
            [EnumMember(Value = "DATA_LOADER_TASK")]
            DataLoaderTask,
            [EnumMember(Value = "PIPELINE_TASK")]
            PipelineTask,
            [EnumMember(Value = "SQL_TASK")]
            SqlTask,
            [EnumMember(Value = "OCI_DATAFLOW_TASK")]
            OciDataflowTask,
            [EnumMember(Value = "REST_TASK")]
            RestTask
        };

        
        /// <value>
        /// Generated key that can be used in API calls to identify task. On scenarios where reference to the task is needed, a value can be passed in create.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The object's model version.
        /// </value>
        [JsonProperty(PropertyName = "modelVersion")]
        public string ModelVersion { get; set; }
        
        [JsonProperty(PropertyName = "parentRef")]
        public ParentReference ParentRef { get; set; }
        
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
        
        /// <value>
        /// The status of an object that can be set to value 1 for shallow references across objects, other values reserved.
        /// </value>
        [JsonProperty(PropertyName = "objectStatus")]
        public System.Nullable<int> ObjectStatus { get; set; }
        
        /// <value>
        /// The version of the object that is used to track changes in the object instance.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ObjectVersion is required.")]
        [JsonProperty(PropertyName = "objectVersion")]
        public System.Nullable<int> ObjectVersion { get; set; }
        
        /// <value>
        /// Value can only contain upper case letters, underscore and numbers. It should begin with upper case letter or underscore. The value can be modified.
        /// </value>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
        
        /// <value>
        /// An array of input ports.
        /// </value>
        [JsonProperty(PropertyName = "inputPorts")]
        public System.Collections.Generic.List<InputPort> InputPorts { get; set; }
        
        /// <value>
        /// An array of output ports.
        /// </value>
        [JsonProperty(PropertyName = "outputPorts")]
        public System.Collections.Generic.List<OutputPort> OutputPorts { get; set; }
        
        /// <value>
        /// An array of parameters.
        /// </value>
        [JsonProperty(PropertyName = "parameters")]
        public System.Collections.Generic.List<Parameter> Parameters { get; set; }
        
        [JsonProperty(PropertyName = "opConfigValues")]
        public ConfigValues OpConfigValues { get; set; }
        
        [JsonProperty(PropertyName = "configProviderDelegate")]
        public ConfigProvider ConfigProviderDelegate { get; set; }
        
        /// <value>
        /// Whether the same task can be executed concurrently.
        /// </value>
        [JsonProperty(PropertyName = "isConcurrentAllowed")]
        public System.Nullable<bool> IsConcurrentAllowed { get; set; }
        
        [JsonProperty(PropertyName = "registryMetadata")]
        public RegistryMetadata RegistryMetadata { get; set; }
        
    }

    public class UpdateTaskDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(UpdateTaskDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(UpdateTaskDetails);
            var discriminator = jsonObject["modelType"].Value<string>();
            switch (discriminator)
            {
                case "REST_TASK":
                    obj = new UpdateTaskFromRestTask();
                    break;
                case "PIPELINE_TASK":
                    obj = new UpdateTaskFromPipelineTask();
                    break;
                case "OCI_DATAFLOW_TASK":
                    obj = new UpdateTaskFromOCIDataflowTask();
                    break;
                case "SQL_TASK":
                    obj = new UpdateTaskFromSQLTask();
                    break;
                case "DATA_LOADER_TASK":
                    obj = new UpdateTaskFromDataLoaderTask();
                    break;
                case "INTEGRATION_TASK":
                    obj = new UpdateTaskFromIntegrationTask();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
