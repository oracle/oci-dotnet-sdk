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
    /// Label for the attribute to be shown in the UI.
    /// </summary>
    public class AppAttrRenderingMetadata 
    {
        
        /// <value>
        /// Name of the attribute.
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
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Label for the attribute to be shown in the UI.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }
        
        /// <value>
        /// Help text for the attribute. It can contain HTML tags.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "helptext")]
        public string Helptext { get; set; }
                ///
        /// <value>
        /// UI widget to use for the attribute.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        ///
        public enum WidgetEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "inputtext")]
            Inputtext,
            [EnumMember(Value = "checkbox")]
            Checkbox,
            [EnumMember(Value = "textarea")]
            Textarea
        };

        /// <value>
        /// UI widget to use for the attribute.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "widget")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<WidgetEnum> Widget { get; set; }
        
        /// <value>
        /// Data type of the attribute.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "datatype")]
        public string Datatype { get; set; }
                ///
        /// <value>
        /// UI widget to use for the attribute.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        ///
        public enum SectionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "saml")]
            Saml,
            [EnumMember(Value = "general")]
            General
        };

        /// <value>
        /// UI widget to use for the attribute.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "section")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SectionEnum> Section { get; set; }
        
        /// <value>
        /// Data type of the attribute.
        /// <br/>
        /// **SCIM++ Properties:**
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
        /// Attribute is required or optional.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "required")]
        public System.Nullable<bool> Required { get; set; }
        
        /// <value>
        /// Regular expression of the attribute for validation.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "regexp")]
        public string Regexp { get; set; }
        
        /// <value>
        /// Is the attribute readOnly.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "readOnly")]
        public System.Nullable<bool> ReadOnly { get; set; }
        
        /// <value>
        /// Indicates whether the attribute is to be shown on the application creation UI.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "visible")]
        public System.Nullable<bool> Visible { get; set; }
        
        /// <value>
        /// Minimum length of the attribute.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: integer
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "minLength")]
        public System.Nullable<int> MinLength { get; set; }
        
        /// <value>
        /// Maximum length of the attribute.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: integer
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "maxLength")]
        public System.Nullable<int> MaxLength { get; set; }
        
        /// <value>
        /// Minimum size of the attribute..
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: integer
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "minSize")]
        public System.Nullable<int> MinSize { get; set; }
        
        /// <value>
        /// Maximum size of the attribute.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: integer
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "maxSize")]
        public System.Nullable<int> MaxSize { get; set; }
        
    }
}
