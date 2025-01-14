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
    /// The command output destination when saved to an Object Storage URL.
    /// </summary>
    public class InstanceAgentCommandOutputViaObjectStorageUriDetails : InstanceAgentCommandOutputDetails
    {
        
        /// <value>
        /// The Object Storage URL or pre-authenticated request (PAR) for the command output.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OutputUri is required.")]
        [JsonProperty(PropertyName = "outputUri")]
        public string OutputUri { get; set; }
        
        [JsonProperty(PropertyName = "outputType")]
        private readonly string outputType = "OBJECT_STORAGE_URI";
    }
}
