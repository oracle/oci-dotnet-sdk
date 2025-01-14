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
    /// A proxy field.
    /// </summary>
    public class ProxyField : TypedObject
    {
        
        /// <value>
        /// Deprecated - Reference to a typed object. This can be either a key value to an object within the document, a shall referenced to a `TypedObject`, or a full `TypedObject` definition.
        /// </value>
        [JsonProperty(PropertyName = "scope")]
        public System.Object Scope { get; set; }
        
        [JsonProperty(PropertyName = "scopeReference")]
        public ScopeReference ScopeReference { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        public BaseType Type { get; set; }
        
        /// <value>
        /// Labels are keywords or labels that you can add to data assets, dataflows and so on. You can define your own labels and use them to categorize content.
        /// </value>
        [JsonProperty(PropertyName = "labels")]
        public System.Collections.Generic.List<string> Labels { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "PROXY_FIELD";
    }
}
