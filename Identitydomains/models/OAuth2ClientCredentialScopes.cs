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


namespace Oci.IdentitydomainsService.Models
{
    /// <summary>
    /// Scopes
    /// </summary>
    public class OAuth2ClientCredentialScopes 
    {
        
        /// <value>
        /// Audience
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - type: string
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Audience is required.")]
        [JsonProperty(PropertyName = "audience")]
        public string Audience { get; set; }
        
        /// <value>
        /// Scope
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsScimCompliant: false
        ///  - type: string
        ///  - mutability: readWrite
        ///  - multiValued: false
        ///  - required: true
        ///  - returned: default
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Scope is required.")]
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }
        
    }
}
