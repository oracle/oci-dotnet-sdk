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


namespace Oci.ContainerengineService.Models
{
    /// <summary>
    /// The properties that define an upstream error while managing a node.
    /// </summary>
    public class NodeError 
    {
        
        /// <value>
        /// A short error code that defines the upstream error, meant for programmatic parsing. See [API Errors](https://docs.us-phoenix-1.oraclecloud.com/Content/API/References/apierrors.htm).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Code is required.")]
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }
        
        /// <value>
        /// A human-readable error string of the upstream error.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Message is required.")]
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        
        /// <value>
        /// The status of the HTTP response encountered in the upstream error.
        /// </value>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the upstream request. If you need to contact Oracle about a particular upstream request, please provide the request ID.
        /// </value>
        [JsonProperty(PropertyName = "opc-request-id")]
        public string OpcRequestId { get; set; }
        
    }
}
