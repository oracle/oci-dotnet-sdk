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


namespace Oci.IdentitydomainsService.Models
{
    /// <summary>
    /// The keytab stored in the tenancy's Vault. This is required if the identity propagation type is 'SPNEGO'.
    /// <br/>
    /// **SCIM++ Properties:**
    ///  - idcsCompositeKey: [secretOcid]
    ///  - idcsSearchable: false
    ///  - multiValued: false
    ///  - mutability: readWrite
    ///  - required: false
    ///  - returned: default
    ///  - type: complex
    ///  - uniqueness: none
    /// </summary>
    public class IdentityPropagationTrustKeytab 
    {
        
        /// <value>
        /// The OCID of the secret. The secret content corresponding to the OCID is expected to be in Base64 encoded content type.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SecretOcid is required.")]
        [JsonProperty(PropertyName = "secretOcid")]
        public string SecretOcid { get; set; }
        
        /// <value>
        /// The version of the secret. When the version is not specified, then the latest secret version is used during runtime.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: integer
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "secretVersion")]
        public System.Nullable<int> SecretVersion { get; set; }
        
    }
}
