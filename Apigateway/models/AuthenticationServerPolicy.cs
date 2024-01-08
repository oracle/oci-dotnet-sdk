/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// Policy for the details regarding each authentication server under dynamic authentication. We specify the value of selectors for which this authentication server must be selected for a request under keys. We specify the configuration details of authentication server under authenticationServerDetail.
    /// </summary>
    public class AuthenticationServerPolicy 
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public DynamicSelectionKey Key { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AuthenticationServerDetail is required.")]
        [JsonProperty(PropertyName = "authenticationServerDetail")]
        public AuthenticationPolicy AuthenticationServerDetail { get; set; }
        
    }
}
