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


namespace Oci.OdaService.Models
{
    /// <summary>
    /// Default values needed to import a resource type for a package.
    /// </summary>
    public class ResourceTypeDefaultParameterValues 
    {
        
        /// <value>
        /// The type of resource to which these resourceType-specific parameter values apply
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceType is required.")]
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }
        
        /// <value>
        /// A list of parameter values used to import the package.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ParameterValues is required.")]
        [JsonProperty(PropertyName = "parameterValues")]
        public System.Collections.Generic.Dictionary<string, string> ParameterValues { get; set; }
        
    }
}
