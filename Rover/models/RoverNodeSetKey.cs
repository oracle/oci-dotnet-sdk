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


namespace Oci.RoverService.Models
{
    /// <summary>
    /// Information about the success of setting a rover node's resource principal public key.
    /// </summary>
    public class RoverNodeSetKey 
    {
        
        /// <value>
        /// Whether the node's resource principal public key was set correctly
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsSuccessful is required.")]
        [JsonProperty(PropertyName = "isSuccessful")]
        public System.Nullable<bool> IsSuccessful { get; set; }
        
    }
}
