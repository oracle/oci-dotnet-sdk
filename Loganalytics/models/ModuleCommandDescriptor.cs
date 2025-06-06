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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// Command descriptor for querylanguage MODULE command.
    /// 
    /// </summary>
    public class ModuleCommandDescriptor : AbstractCommandDescriptor
    {
        
        /// <value>
        /// Description of the macro.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Description of the macro.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "example")]
        public string Example { get; set; }
        
        /// <value>
        /// Optional list of properties for the macro.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "properties")]
        public System.Collections.Generic.List<PropertyDefinition> Properties { get; set; }
        
        /// <value>
        /// Optional list of arguments used in the macro.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "arguments")]
        public System.Collections.Generic.List<VariableDefinition> Arguments { get; set; }
        
        [JsonProperty(PropertyName = "name")]
        private readonly string name = "MODULE";
    }
}
