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


namespace Oci.DatascienceService.Models
{
    /// <summary>
    /// Schema for single configuration property
    /// </summary>
    public class ConfigurationPropertySchema 
    {
        
        /// <value>
        /// Name of key (parameter name)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "KeyName is required.")]
        [JsonProperty(PropertyName = "keyName")]
        public string KeyName { get; set; }
                ///
        /// <value>
        /// Type of value
        /// </value>
        ///
        public enum ValueTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "STRING")]
            String,
            [EnumMember(Value = "SECRET")]
            Secret,
            [EnumMember(Value = "VAULT_SECRET_ID")]
            VaultSecretId
        };

        /// <value>
        /// Type of value
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ValueType is required.")]
        [JsonProperty(PropertyName = "valueType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ValueTypeEnum> ValueType { get; set; }
        
        /// <value>
        /// Description of this configuration property
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Description is required.")]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// If the value is true this configuration property is mandatory and visa versa. If not specified configuration property is optional.
        /// </value>
        [JsonProperty(PropertyName = "isMandatory")]
        public System.Nullable<bool> IsMandatory { get; set; }
        
        /// <value>
        /// The default value for the optional configuration property (it must not be specified for mandatory configuration properties)
        /// </value>
        [JsonProperty(PropertyName = "defaultValue")]
        public string DefaultValue { get; set; }
        
        /// <value>
        /// A regular expression will be used for the validation of property value.
        /// </value>
        [JsonProperty(PropertyName = "validationRegexp")]
        public string ValidationRegexp { get; set; }
        
        /// <value>
        /// Sample property value (it must match validationRegexp if it is specified)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SampleValue is required.")]
        [JsonProperty(PropertyName = "sampleValue")]
        public string SampleValue { get; set; }
        
    }
}
