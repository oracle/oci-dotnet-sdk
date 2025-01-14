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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The details to create a basic auth rest connection.
    /// </summary>
    public class CreateConnectionFromRestBasicAuth : CreateConnectionDetails
    {
        
        /// <value>
        /// Username for the connection.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Username is required.")]
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PasswordSecret is required.")]
        [JsonProperty(PropertyName = "passwordSecret")]
        public SensitiveAttribute PasswordSecret { get; set; }
        
        /// <value>
        /// Optional header name if used other than default header(Authorization).
        /// </value>
        [JsonProperty(PropertyName = "authHeader")]
        public string AuthHeader { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "REST_BASIC_AUTH_CONNECTION";
    }
}
