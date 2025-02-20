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
    /// The properties used in task run create operations.
    /// </summary>
    public class CreateTaskRunDetails 
    {
        
        /// <value>
        /// The key of the object.
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The type of the object.
        /// </value>
        [JsonProperty(PropertyName = "modelType")]
        public string ModelType { get; set; }
        
        /// <value>
        /// The model version of an object.
        /// </value>
        [JsonProperty(PropertyName = "modelVersion")]
        public string ModelVersion { get; set; }
        
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
        
        [JsonProperty(PropertyName = "configProvider")]
        public CreateConfigProvider ConfigProvider { get; set; }
        
        /// <value>
        /// Value can only contain upper case letters, underscore, and numbers. It should begin with upper case letter or underscore. The value can be modified.
        /// </value>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
        
        /// <value>
        /// Optional task schedule key reference.
        /// </value>
        [JsonProperty(PropertyName = "taskScheduleKey")]
        public string TaskScheduleKey { get; set; }
        
        /// <value>
        /// Reference Task Run Id to be used for re-run
        /// </value>
        [JsonProperty(PropertyName = "refTaskRunId")]
        public string RefTaskRunId { get; set; }
                ///
        /// <value>
        /// Supported re-run types
        /// </value>
        ///
        public enum ReRunTypeEnum {
            [EnumMember(Value = "BEGINNING")]
            Beginning,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "STEP")]
            Step
        };

        /// <value>
        /// Supported re-run types
        /// </value>
        [JsonProperty(PropertyName = "reRunType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ReRunTypeEnum> ReRunType { get; set; }
        
        /// <value>
        /// Step Id for running from a certain step.
        /// </value>
        [JsonProperty(PropertyName = "stepId")]
        public string StepId { get; set; }
        
        [JsonProperty(PropertyName = "registryMetadata")]
        public RegistryMetadata RegistryMetadata { get; set; }
        
    }
}
