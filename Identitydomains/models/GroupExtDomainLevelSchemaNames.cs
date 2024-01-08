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
    /// DBCS Domain-level schema-names. Each value is specific to a DB Domain.
    /// <br/>
    /// **Added In:** 18.2.4
    /// <br/>
    /// **SCIM++ Properties:**
    ///  - idcsCompositeKey: [domainName, schemaName]
    ///  - idcsSearchable: true
    ///  - multiValued: true
    ///  - mutability: readOnly
    ///  - required: false
    ///  - returned: request
    ///  - type: complex
    /// </summary>
    public class GroupExtDomainLevelSchemaNames 
    {
        
        /// <value>
        /// DBCS Domain Name
        /// <br/>
        /// **Added In:** 18.2.4
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DomainName is required.")]
        [JsonProperty(PropertyName = "domainName")]
        public string DomainName { get; set; }
        
        /// <value>
        /// The DBCS schema-name granted to this group in the DB domain that 'domainName' specifies.
        /// <br/>
        /// **Added In:** 18.2.4
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SchemaName is required.")]
        [JsonProperty(PropertyName = "schemaName")]
        public string SchemaName { get; set; }
        
    }
}
