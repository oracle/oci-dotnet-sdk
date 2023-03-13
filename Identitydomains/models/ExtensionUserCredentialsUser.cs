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
    /// User's credentials
    /// </summary>
    public class ExtensionUserCredentialsUser 
    {
        
        /// <value>
        /// A list of db credentials corresponding to user.
        /// <br/>
        /// **Added In:** 2102181953
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
        /// </value>
        [JsonProperty(PropertyName = "dbCredentials")]
        public System.Collections.Generic.List<UserExtDbCredentials> DbCredentials { get; set; }
        
        /// <value>
        /// A list of customer secret keys corresponding to user.
        /// <br/>
        /// **Added In:** 2102181953
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
        /// </value>
        [JsonProperty(PropertyName = "customerSecretKeys")]
        public System.Collections.Generic.List<UserExtCustomerSecretKeys> CustomerSecretKeys { get; set; }
        
        /// <value>
        /// A list of auth tokens corresponding to user.
        /// <br/>
        /// **Added In:** 2012271618
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
        /// </value>
        [JsonProperty(PropertyName = "authTokens")]
        public System.Collections.Generic.List<UserExtAuthTokens> AuthTokens { get; set; }
        
        /// <value>
        /// A list of smtp credentials corresponding to user.
        /// <br/>
        /// **Added In:** 2012271618
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
        /// </value>
        [JsonProperty(PropertyName = "smtpCredentials")]
        public System.Collections.Generic.List<UserExtSmtpCredentials> SmtpCredentials { get; set; }
        
        /// <value>
        /// A list of api keys corresponding to user.
        /// <br/>
        /// **Added In:** 2012271618
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
        /// </value>
        [JsonProperty(PropertyName = "apiKeys")]
        public System.Collections.Generic.List<UserExtApiKeys> ApiKeys { get; set; }
        
        /// <value>
        /// A list of oauth2 client credentials corresponding to user.
        /// <br/>
        /// **Added In:** 2012271618
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
        /// </value>
        [JsonProperty(PropertyName = "oAuth2ClientCredentials")]
        public System.Collections.Generic.List<UserExtOAuth2ClientCredentials> OAuth2ClientCredentials { get; set; }
        
    }
}
