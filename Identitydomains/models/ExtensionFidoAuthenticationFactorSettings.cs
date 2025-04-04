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
    /// This extension defines attributes used to manage Multi-Factor Authentication settings of fido authentication
    /// </summary>
    public class ExtensionFidoAuthenticationFactorSettings 
    {
                ///
        /// <value>
        /// Attribute used to define the type of attestation required.
        /// <br/>
        /// **Added In:** 2009232244
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        ///
        public enum AttestationEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NONE")]
            None,
            [EnumMember(Value = "DIRECT")]
            Direct,
            [EnumMember(Value = "INDIRECT")]
            Indirect
        };

        /// <value>
        /// Attribute used to define the type of attestation required.
        /// <br/>
        /// **Added In:** 2009232244
        /// <br/>
        /// **SCIM++ Properties:**
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
        [Required(ErrorMessage = "Attestation is required.")]
        [JsonProperty(PropertyName = "attestation")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AttestationEnum> Attestation { get; set; }
                ///
        /// <value>
        /// Attribute used to define authenticator selection attachment.
        /// <br/>
        /// **Added In:** 2009232244
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        ///
        public enum AuthenticatorSelectionAttachmentEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PLATFORM")]
            Platform,
            [EnumMember(Value = "CROSS-PLATFORM")]
            CrossPlatform,
            [EnumMember(Value = "BOTH")]
            Both
        };

        /// <value>
        /// Attribute used to define authenticator selection attachment.
        /// <br/>
        /// **Added In:** 2009232244
        /// <br/>
        /// **SCIM++ Properties:**
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
        [Required(ErrorMessage = "AuthenticatorSelectionAttachment is required.")]
        [JsonProperty(PropertyName = "authenticatorSelectionAttachment")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AuthenticatorSelectionAttachmentEnum> AuthenticatorSelectionAttachment { get; set; }
                ///
        /// <value>
        /// Attribute used to define authenticator selection verification.
        /// <br/>
        /// **Added In:** 2009232244
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        ///
        public enum AuthenticatorSelectionUserVerificationEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "REQUIRED")]
            Required,
            [EnumMember(Value = "PREFERRED")]
            Preferred,
            [EnumMember(Value = "DISCOURAGED")]
            Discouraged
        };

        /// <value>
        /// Attribute used to define authenticator selection verification.
        /// <br/>
        /// **Added In:** 2009232244
        /// <br/>
        /// **SCIM++ Properties:**
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
        [Required(ErrorMessage = "AuthenticatorSelectionUserVerification is required.")]
        [JsonProperty(PropertyName = "authenticatorSelectionUserVerification")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AuthenticatorSelectionUserVerificationEnum> AuthenticatorSelectionUserVerification { get; set; }
                ///
        /// <value>
        /// Attribute used to define authenticator selection resident key requirement.
        /// <br/>
        /// **Added In:** 2009232244
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        ///
        public enum AuthenticatorSelectionResidentKeyEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "REQUIRED")]
            Required,
            [EnumMember(Value = "PREFERRED")]
            Preferred,
            [EnumMember(Value = "DISCOURAGED")]
            Discouraged,
            [EnumMember(Value = "NONE")]
            None
        };

        /// <value>
        /// Attribute used to define authenticator selection resident key requirement.
        /// <br/>
        /// **Added In:** 2009232244
        /// <br/>
        /// **SCIM++ Properties:**
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
        [Required(ErrorMessage = "AuthenticatorSelectionResidentKey is required.")]
        [JsonProperty(PropertyName = "authenticatorSelectionResidentKey")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AuthenticatorSelectionResidentKeyEnum> AuthenticatorSelectionResidentKey { get; set; }
        
        /// <value>
        /// Timeout for the fido authentication to complete
        /// <br/>
        /// **Added In:** 2009232244
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - idcsMaxValue: 600000
        ///  - idcsMinValue: 10000
        ///  - required: true
        ///  - returned: default
        ///  - type: integer
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Timeout is required.")]
        [JsonProperty(PropertyName = "timeout")]
        public System.Nullable<int> Timeout { get; set; }
        
        /// <value>
        /// Flag used to indicate authenticator selection is required or not
        /// <br/>
        /// **Added In:** 2009232244
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AuthenticatorSelectionRequireResidentKey is required.")]
        [JsonProperty(PropertyName = "authenticatorSelectionRequireResidentKey")]
        public System.Nullable<bool> AuthenticatorSelectionRequireResidentKey { get; set; }
                ///
        ///
        public enum PublicKeyTypesEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "RS1")]
            Rs1,
            [EnumMember(Value = "RS256")]
            Rs256,
            [EnumMember(Value = "ES256")]
            Es256
        };

        /// <value>
        /// List of server supported public key algorithms
        /// <br/>
        /// **Added In:** 2009232244
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: true
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PublicKeyTypes is required.")]
        [JsonProperty(PropertyName = "publicKeyTypes", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<PublicKeyTypesEnum> PublicKeyTypes { get; set; }
        
        /// <value>
        /// Flag used to indicate whether we need to restrict creation of multiple credentials in same authenticator
        /// <br/>
        /// **Added In:** 2009232244
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExcludeCredentials is required.")]
        [JsonProperty(PropertyName = "excludeCredentials")]
        public System.Nullable<bool> ExcludeCredentials { get; set; }
        
        /// <value>
        /// Number of domain levels Oracle Identity Cloud Service should use for origin comparision
        /// <br/>
        /// **Added In:** 2109020413
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - idcsMaxValue: 2
        ///  - idcsMinValue: 0
        ///  - required: false
        ///  - returned: default
        ///  - type: integer
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "domainValidationLevel")]
        public System.Nullable<int> DomainValidationLevel { get; set; }
        
    }
}
