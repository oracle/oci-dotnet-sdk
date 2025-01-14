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


namespace Oci.BlockchainService.Models
{
    /// <summary>
    /// Metadata parameter details
    /// </summary>
    public class MetadataDetails 
    {
        
        /// <value>
        /// Metadata param name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ParamName is required.")]
        [JsonProperty(PropertyName = "paramName")]
        public string ParamName { get; set; }
        
        /// <value>
        /// Metadata param value. Complex value will be a JSON string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ParamValue is required.")]
        [JsonProperty(PropertyName = "paramValue")]
        public string ParamValue { get; set; }
        
        /// <value>
        /// Indicates if the value is a JSON string
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsJsonValue is required.")]
        [JsonProperty(PropertyName = "isJsonValue")]
        public System.Nullable<bool> IsJsonValue { get; set; }
        
    }
}
