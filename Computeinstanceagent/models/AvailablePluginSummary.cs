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


namespace Oci.ComputeinstanceagentService.Models
{
    /// <summary>
    /// Information about where a plugin is supported.
    /// </summary>
    public class AvailablePluginSummary 
    {
        
        /// <value>
        /// The plugin name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// A brief description of the plugin's functionality.
        /// </value>
        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }
        
        /// <value>
        /// Whether the plugin is supported.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsSupported is required.")]
        [JsonProperty(PropertyName = "isSupported")]
        public System.Nullable<bool> IsSupported { get; set; }
        
        /// <value>
        /// Whether the plugin is enabled or disabled by default.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsEnabledByDefault is required.")]
        [JsonProperty(PropertyName = "isEnabledByDefault")]
        public System.Nullable<bool> IsEnabledByDefault { get; set; }
        
    }
}
