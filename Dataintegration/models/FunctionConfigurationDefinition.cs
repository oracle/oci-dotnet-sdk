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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The configuration details of a configurable object. This contains one or more config param definitions.
    /// </summary>
    public class FunctionConfigurationDefinition 
    {
        
        /// <value>
        /// The key of the object.
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
                ///
        /// <value>
        /// The type of the object.
        /// </value>
        ///
        public enum ModelTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CONFIG_DEFINITION")]
            ConfigDefinition
        };

        /// <value>
        /// The type of the object.
        /// </value>
        [JsonProperty(PropertyName = "modelType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ModelTypeEnum> ModelType { get; set; }
        
        /// <value>
        /// The model version of an object.
        /// </value>
        [JsonProperty(PropertyName = "modelVersion")]
        public string ModelVersion { get; set; }
        
        [JsonProperty(PropertyName = "parentRef")]
        public ParentReference ParentRef { get; set; }
        
        /// <value>
        /// Specifies whether the configuration is contained or not.
        /// </value>
        [JsonProperty(PropertyName = "isContained")]
        public System.Nullable<bool> IsContained { get; set; }
        
        /// <value>
        /// The parameter configuration details.
        /// </value>
        [JsonProperty(PropertyName = "configParamDefs")]
        public System.Collections.Generic.Dictionary<string, ConfigParameterDefinition> ConfigParamDefs { get; set; }
        
    }
}