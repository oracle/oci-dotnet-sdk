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


namespace Oci.IdentitydataplaneService.Models
{
    
    public class ResourcePrincipalSessionTokenRequest 
    {
        
        /// <value>
        /// The resource principal token.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourcePrincipalToken is required.")]
        [JsonProperty(PropertyName = "resourcePrincipalToken")]
        public string ResourcePrincipalToken { get; set; }
        
        /// <value>
        /// The service principal session token.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ServicePrincipalSessionToken is required.")]
        [JsonProperty(PropertyName = "servicePrincipalSessionToken")]
        public string ServicePrincipalSessionToken { get; set; }
        
        /// <value>
        /// The session public key.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SessionPublicKey is required.")]
        [JsonProperty(PropertyName = "sessionPublicKey")]
        public string SessionPublicKey { get; set; }
        
    }
}
