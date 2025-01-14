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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The pipeline summary type contains the audit summary information and the definition of the pipeline.
    /// </summary>
    public class PipelineSummary 
    {
        
        /// <value>
        /// Generated key that can be used in API calls to identify pipeline. On scenarios where reference to the pipeline is needed, a value can be passed in create.
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// This is a version number that is used by the service to upgrade objects if needed through releases of the service.
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
        /// The type of the object.
        /// </value>
        [JsonProperty(PropertyName = "modelType")]
        public string ModelType { get; set; }
        
        /// <value>
        /// This is used by the service for optimistic locking of the object, to prevent multiple users from simultaneously updating the object.
        /// </value>
        [JsonProperty(PropertyName = "objectVersion")]
        public System.Nullable<int> ObjectVersion { get; set; }
        
        /// <value>
        /// The status of an object that can be set to value 1 for shallow references across objects, other values reserved.
        /// </value>
        [JsonProperty(PropertyName = "objectStatus")]
        public System.Nullable<int> ObjectStatus { get; set; }
        
        /// <value>
        /// Value can only contain upper case letters, underscore, and numbers. It should begin with upper case letter or underscore. The value can be modified.
        /// </value>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
        
        /// <value>
        /// A list of nodes attached to the pipeline.
        /// </value>
        [JsonProperty(PropertyName = "nodes")]
        public System.Collections.Generic.List<FlowNode> Nodes { get; set; }
        
        /// <value>
        /// A list of parameters for the pipeline, this allows certain aspects of the pipeline to be configured when the pipeline is executed.
        /// </value>
        [JsonProperty(PropertyName = "parameters")]
        public System.Collections.Generic.List<Parameter> Parameters { get; set; }
        
        [JsonProperty(PropertyName = "flowConfigValues")]
        public ConfigValues FlowConfigValues { get; set; }
        
        /// <value>
        /// The list of variables required in pipeline, variables can be used to store values that can be used as inputs to tasks in the pipeline.
        /// </value>
        [JsonProperty(PropertyName = "variables")]
        public System.Collections.Generic.List<Variable> Variables { get; set; }
        
        [JsonProperty(PropertyName = "metadata")]
        public ObjectMetadata Metadata { get; set; }
        
    }
}
