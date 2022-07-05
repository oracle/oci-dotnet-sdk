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


namespace Oci.ManagementagentService.Models
{
    /// <summary>
    /// Summary of the ManagementAgentPlugin.
    /// </summary>
    public class ManagementAgentPluginSummary 
    {
        
        /// <value>
        /// Management Agent Plugin Id
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Management Agent Plugin Name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Management Agent Plugin Version
        /// </value>
        [JsonProperty(PropertyName = "version")]
        public System.Nullable<int> Version { get; set; }
        
        /// <value>
        /// Supported Platform Types
        /// </value>
        [JsonProperty(PropertyName = "supportedPlatformTypes", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<PlatformTypes> SupportedPlatformTypes { get; set; }
        
        /// <value>
        /// Management Agent Plugin Display Name
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Management Agent Plugin description
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// A flag to indicate whether a given plugin can be deployed from Agent Console UI or not.
        /// </value>
        [JsonProperty(PropertyName = "isConsoleDeployable")]
        public System.Nullable<bool> IsConsoleDeployable { get; set; }
        
        /// <value>
        /// The current state of Management Agent Plugin
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStates> LifecycleState { get; set; }
        
    }
}
