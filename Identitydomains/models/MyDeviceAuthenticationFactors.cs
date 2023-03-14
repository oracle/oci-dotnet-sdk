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
    /// Authentication Factors
    /// </summary>
    public class MyDeviceAuthenticationFactors 
    {
                ///
        /// <value>
        /// Authentication Factor Type
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        ///
        public enum TypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "EMAIL")]
            Email,
            [EnumMember(Value = "SMS")]
            Sms,
            [EnumMember(Value = "TOTP")]
            Totp,
            [EnumMember(Value = "PUSH")]
            Push,
            [EnumMember(Value = "OFFLINETOTP")]
            Offlinetotp,
            [EnumMember(Value = "VOICE")]
            Voice,
            [EnumMember(Value = "PHONE_CALL")]
            PhoneCall,
            [EnumMember(Value = "THIRDPARTY")]
            Thirdparty,
            [EnumMember(Value = "FIDO_AUTHENTICATOR")]
            FidoAuthenticator,
            [EnumMember(Value = "YUBICO_OTP")]
            YubicoOtp
        };

        /// <value>
        /// Authentication Factor Type
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: true
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
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
                ///
        /// <value>
        /// Authentication Factor Status
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
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "INITIATED")]
            Initiated,
            [EnumMember(Value = "INPROGRESS")]
            Inprogress,
            [EnumMember(Value = "ENROLLED")]
            Enrolled,
            [EnumMember(Value = "LOCKED")]
            Locked,
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            [EnumMember(Value = "BLOCKED")]
            Blocked
        };

        /// <value>
        /// Authentication Factor Status
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
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// Authentication Factor public key issued by client
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "publicKey")]
        public string PublicKey { get; set; }
        
    }
}
