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


namespace Oci.ResourceschedulerService.Models
{
    /// <summary>
    /// This is a defined tag filter value.
    /// </summary>
    public class DefinedTagFilterValue 
    {
        
        /// <value>
        /// This is the namespace of the defined tag.
        /// </value>
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }
        
        /// <value>
        /// This is the key of the defined tag.
        /// </value>
        [JsonProperty(PropertyName = "tagKey")]
        public string TagKey { get; set; }
        
        /// <value>
        /// This is the value of the defined tag.
        /// </value>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
    }
}
