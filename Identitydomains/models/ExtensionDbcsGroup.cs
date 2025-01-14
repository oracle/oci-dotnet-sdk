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
    /// Schema for Database Service  Resource
    /// </summary>
    public class ExtensionDbcsGroup 
    {
        
        /// <value>
        /// DBCS instance-level schema-names. Each schema-name is specific to a DB Instance.
        /// <br/>
        /// **Added In:** 18.2.4
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [dbInstanceId, schemaName]
        ///  - idcsSearchable: true
        ///  - multiValued: true
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: complex
        /// </value>
        [JsonProperty(PropertyName = "instanceLevelSchemaNames")]
        public System.Collections.Generic.List<GroupExtInstanceLevelSchemaNames> InstanceLevelSchemaNames { get; set; }
        
        /// <value>
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
        /// </value>
        [JsonProperty(PropertyName = "domainLevelSchemaNames")]
        public System.Collections.Generic.List<GroupExtDomainLevelSchemaNames> DomainLevelSchemaNames { get; set; }
        
        /// <value>
        /// DBCS Domain-level schema-name.  This attribute refers implicitly to a value of 'domainLevelSchemaNames' for a particular DB Domain.
        /// <br/>
        /// **Added In:** 18.2.4
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - idcsSensitive: none
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "domainLevelSchema")]
        public string DomainLevelSchema { get; set; }
        
        /// <value>
        /// DBCS instance-level schema-name. This attribute refers implicitly to a value of 'instanceLevelSchemaNames' for a particular DB Instance.
        /// <br/>
        /// **Added In:** 18.2.4
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - idcsSensitive: none
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "instanceLevelSchema")]
        public string InstanceLevelSchema { get; set; }
        
    }
}
