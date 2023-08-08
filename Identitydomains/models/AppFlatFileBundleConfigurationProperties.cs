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
    /// Flat file connector bundle configuration properties
    /// <br/>
    /// **SCIM++ Properties:**
    ///  - idcsCompositeKey: [name]
    ///  - idcsSearchable: true
    ///  - multiValued: true
    ///  - mutability: readWrite
    ///  - required: false
    ///  - returned: default
    ///  - type: complex
    ///  - uniqueness: none
    /// </summary>
    public class AppFlatFileBundleConfigurationProperties 
    {
        
        /// <value>
        /// Name of the flatfile bundle configuration property. This attribute maps to \\\"name\\\" attribute in \\\"ConfigurationProperty\\\" in ICF.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: immutable
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Display name of the flatfile bundle configuration property. This attribute maps to \\\"displayName\\\" attribute in \\\"ConfigurationProperty\\\" in ICF.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
                ///
        /// <value>
        /// ICF data type of flatfile the bundle configuration property. This attribute maps to \\\"type\\\" attribute in \\\"ConfigurationProperty\\\" in ICF.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: immutable
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        ///
        public enum IcfTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "Long")]
            Long,
            [EnumMember(Value = "String")]
            String,
            [EnumMember(Value = "Character")]
            Character,
            [EnumMember(Value = "Double")]
            Double,
            [EnumMember(Value = "Float")]
            Float,
            [EnumMember(Value = "Integer")]
            Integer,
            [EnumMember(Value = "Boolean")]
            Boolean,
            [EnumMember(Value = "URI")]
            Uri,
            [EnumMember(Value = "File")]
            File,
            [EnumMember(Value = "GuardedByteArray")]
            GuardedByteArray,
            [EnumMember(Value = "GuardedString")]
            GuardedString,
            [EnumMember(Value = "ArrayOfLong")]
            ArrayOfLong,
            [EnumMember(Value = "ArrayOfString")]
            ArrayOfString,
            [EnumMember(Value = "ArrayOfCharacter")]
            ArrayOfCharacter,
            [EnumMember(Value = "ArrayOfDouble")]
            ArrayOfDouble,
            [EnumMember(Value = "ArrayOfFloat")]
            ArrayOfFloat,
            [EnumMember(Value = "ArrayOfInteger")]
            ArrayOfInteger,
            [EnumMember(Value = "ArrayOfBoolean")]
            ArrayOfBoolean,
            [EnumMember(Value = "ArrayOfURI")]
            ArrayOfUri,
            [EnumMember(Value = "ArrayOfFile")]
            ArrayOfFile,
            [EnumMember(Value = "ArrayOfGuardedByteArray")]
            ArrayOfGuardedByteArray,
            [EnumMember(Value = "ArrayOfGuardedString")]
            ArrayOfGuardedString
        };

        /// <value>
        /// ICF data type of flatfile the bundle configuration property. This attribute maps to \\\"type\\\" attribute in \\\"ConfigurationProperty\\\" in ICF.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: immutable
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IcfType is required.")]
        [JsonProperty(PropertyName = "icfType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<IcfTypeEnum> IcfType { get; set; }
        
        /// <value>
        /// Value of the flatfile bundle configuration property. This attribute maps to \\\"value\\\" attribute in \\\"ConfigurationProperty\\\" in ICF.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - idcsSensitive: encrypt
        ///  - multiValued: true
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.List<string> Value { get; set; }
        
        /// <value>
        /// Display sequence of the bundle configuration property.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: integer
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "order")]
        public System.Nullable<int> Order { get; set; }
        
        /// <value>
        /// Help message of the flatfile bundle configuration property. This attribute maps to \\\"helpMessage\\\" attribute in \\\"ConfigurationProperty\\\" in ICF.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "helpMessage")]
        public string HelpMessage { get; set; }
        
        /// <value>
        /// If true, this flatfile bundle configuration property is required to connect to the target connected managed app. This attribute maps to \\\"isRequired\\\" attribute in \\\"ConfigurationProperty\\\" in ICF.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: immutable
        ///  - required: true
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Required is required.")]
        [JsonProperty(PropertyName = "required")]
        public System.Nullable<bool> Required { get; set; }
        
        /// <value>
        /// If true, this flatfile bundle configuration property value is confidential and will be encrypted in Oracle Identity Cloud Service. This attribute maps to \\\"isConfidential\\\" attribute in \\\"ConfigurationProperty\\\" in ICF.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: immutable
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "confidential")]
        public System.Nullable<bool> Confidential { get; set; }
        
    }
}
