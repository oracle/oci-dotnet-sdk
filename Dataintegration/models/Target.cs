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
    /// The information about the target operator. The target operator lets you specify the data entity to store the transformed data.
    /// </summary>
    public class Target : Operator
    {
        
        [JsonProperty(PropertyName = "entity")]
        public DataEntity Entity { get; set; }
        
        /// <value>
        /// Specifies the read access.
        /// </value>
        [JsonProperty(PropertyName = "isReadAccess")]
        public System.Nullable<bool> IsReadAccess { get; set; }
        
        /// <value>
        /// Specifies the copy fields.
        /// </value>
        [JsonProperty(PropertyName = "isCopyFields")]
        public System.Nullable<bool> IsCopyFields { get; set; }
        
        /// <value>
        /// Specifies if this uses a predefined shape.
        /// </value>
        [JsonProperty(PropertyName = "isPredefinedShape")]
        public System.Nullable<bool> IsPredefinedShape { get; set; }
        
        /// <value>
        /// Specifies if entity name is the same as source.
        /// </value>
        [JsonProperty(PropertyName = "isUseSameSourceName")]
        public System.Nullable<bool> IsUseSameSourceName { get; set; }
        
        /// <value>
        /// Prefix for the entity Name.
        /// </value>
        [JsonProperty(PropertyName = "targetEntityNamePrefix")]
        public string TargetEntityNamePrefix { get; set; }
        
        /// <value>
        /// Suffix for the entity Name.
        /// </value>
        [JsonProperty(PropertyName = "targetEntityNameSuffix")]
        public string TargetEntityNameSuffix { get; set; }
                ///
        /// <value>
        /// Specifies the data property.
        /// </value>
        ///
        public enum DataPropertyEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "TRUNCATE")]
            Truncate,
            [EnumMember(Value = "MERGE")]
            Merge,
            [EnumMember(Value = "BACKUP")]
            Backup,
            [EnumMember(Value = "OVERWRITE")]
            Overwrite,
            [EnumMember(Value = "APPEND")]
            Append,
            [EnumMember(Value = "IGNORE")]
            Ignore
        };

        /// <value>
        /// Specifies the data property.
        /// </value>
        [JsonProperty(PropertyName = "dataProperty")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DataPropertyEnum> DataProperty { get; set; }
        
        [JsonProperty(PropertyName = "schemaDriftConfig")]
        public SchemaDriftConfig SchemaDriftConfig { get; set; }
        
        [JsonProperty(PropertyName = "fixedDataShape")]
        public Shape FixedDataShape { get; set; }
        
        [JsonProperty(PropertyName = "writeOperationConfig")]
        public WriteOperationConfig WriteOperationConfig { get; set; }
        
        /// <value>
        /// A numeric loading order number for the target.
        /// </value>
        [JsonProperty(PropertyName = "loadOrder")]
        public System.Nullable<int> LoadOrder { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "TARGET_OPERATOR";
    }
}
