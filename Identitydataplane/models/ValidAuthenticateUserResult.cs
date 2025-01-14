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


namespace Oci.IdentitydataplaneService.Models
{
    
    public class ValidAuthenticateUserResult 
    {
        
        /// <value>
        /// The tenant name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TenantInput is required.")]
        [JsonProperty(PropertyName = "tenantInput")]
        public string TenantInput { get; set; }
        
        /// <value>
        /// The user name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UserInput is required.")]
        [JsonProperty(PropertyName = "userInput")]
        public string UserInput { get; set; }
        
        /// <value>
        /// The resolved principal.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResolvedPrincipal is required.")]
        [JsonProperty(PropertyName = "resolvedPrincipal")]
        public AuthenticationPrincipal ResolvedPrincipal { get; set; }
        
    }
}
