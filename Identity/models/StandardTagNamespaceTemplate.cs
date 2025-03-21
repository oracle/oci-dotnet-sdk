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


namespace Oci.IdentityService.Models
{
    /// <summary>
    /// The template of the standard tag namespace. This object includes necessary details to create the provided standard tag namespace.
    /// </summary>
    public class StandardTagNamespaceTemplate 
    {
        
        /// <value>
        /// The default description of the tag namespace that users can use to create the tag namespace
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Description is required.")]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The reserved name of this standard tag namespace
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StandardTagNamespaceName is required.")]
        [JsonProperty(PropertyName = "standardTagNamespaceName")]
        public string StandardTagNamespaceName { get; set; }
        
        /// <value>
        /// The template of the tag definition. This object includes necessary details to create the provided standard tag definition.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TagDefinitionTemplates is required.")]
        [JsonProperty(PropertyName = "tagDefinitionTemplates")]
        public System.Collections.Generic.List<StandardTagDefinitionTemplate> TagDefinitionTemplates { get; set; }
        
        /// <value>
        /// The status of the standard tag namespace
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        
    }
}
