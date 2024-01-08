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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// Details for the flatten operator.
    /// </summary>
    public class FlattenDetails 
    {
        
        [JsonProperty(PropertyName = "flattenProjectionPreferences")]
        public FlattenProjectionPreferences FlattenProjectionPreferences { get; set; }
        
        /// <value>
        /// The string of flatten attribute column name where the flatten process starts.
        /// </value>
        [JsonProperty(PropertyName = "flattenAttributeRoot")]
        public string FlattenAttributeRoot { get; set; }
        
        /// <value>
        /// The string of flatten attribute path in flattenAttributeRoot from upper level to leaf/targeted level concatenated with dot(.).
        /// </value>
        [JsonProperty(PropertyName = "flattenAttributePath")]
        public string FlattenAttributePath { get; set; }
        
        /// <value>
        /// The array of flatten columns which are the input to flatten.
        /// </value>
        [JsonProperty(PropertyName = "flattenColumns")]
        public System.Collections.Generic.List<TypedObject> FlattenColumns { get; set; }
        
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
        
        [JsonProperty(PropertyName = "parentRef")]
        public ParentReference ParentRef { get; set; }
        
        /// <value>
        /// The status of an object that can be set to value 1 for shallow references across objects, other values reserved.
        /// </value>
        [JsonProperty(PropertyName = "objectStatus")]
        public System.Nullable<int> ObjectStatus { get; set; }
        
    }
}
