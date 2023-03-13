/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
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
    /// A list of Support Accounts corresponding to user.
    /// <br/>
    /// **Added In:** 2103141444
    /// <br/>
    /// **SCIM++ Properties:**
    ///  - idcsCompositeKey: [value]
    ///  - idcsSearchable: true
    ///  - multiValued: true
    ///  - mutability: readOnly
    ///  - required: false
    ///  - returned: request
    ///  - type: complex
    ///  - uniqueness: none
    /// </summary>
    public class UserExtSupportAccounts 
    {
        
        /// <value>
        /// The identifier of the User's support Account.
        /// <br/>
        /// **Added In:** 2103141444
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: always
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        /// <value>
        /// User Support Account Provider
        /// <br/>
        /// **Added In:** 2103141444
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: always
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; set; }
        
        /// <value>
        /// User Support User Id
        /// <br/>
        /// **Added In:** 2103141444
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: always
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }
        
        /// <value>
        /// Ocid of the User's Support Account.
        /// <br/>
        /// **Added In:** 2103141444
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: always
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "ocid")]
        public string Ocid { get; set; }
        
        /// <value>
        /// The URI of the corresponding Support Account resource to which the user belongs
        /// <br/>
        /// **Added In:** 2103141444
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: reference
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "$ref")]
        public string Ref { get; set; }
        
    }
}
