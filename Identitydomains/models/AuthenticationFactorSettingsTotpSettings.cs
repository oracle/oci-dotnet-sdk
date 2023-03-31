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
    /// Settings related to Time-Based One-Time Passcodes (TOTP), such as hashing algo, totp time step, passcode length, and so on
    /// <br/>
    /// **SCIM++ Properties:**
    ///  - idcsSearchable: false
    ///  - multiValued: false
    ///  - mutability: readWrite
    ///  - required: true
    ///  - returned: default
    ///  - type: complex
    ///  - uniqueness: none
    /// </summary>
    public class AuthenticationFactorSettingsTotpSettings 
    {
                ///
        /// <value>
        /// The hashing algorithm to be used to calculate a One-Time Passcode. By default, the system uses SHA1.
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
        public enum HashingAlgorithmEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SHA1")]
            Sha1,
            [EnumMember(Value = "SHA256")]
            Sha256,
            [EnumMember(Value = "SHA384")]
            Sha384,
            [EnumMember(Value = "SHA512")]
            Sha512,
            [EnumMember(Value = "MD5")]
            Md5
        };

        /// <value>
        /// The hashing algorithm to be used to calculate a One-Time Passcode. By default, the system uses SHA1.
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
        [Required(ErrorMessage = "HashingAlgorithm is required.")]
        [JsonProperty(PropertyName = "hashingAlgorithm")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<HashingAlgorithmEnum> HashingAlgorithm { get; set; }
        
        /// <value>
        /// Exact length of the One-Time Passcode that the system should generate
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsMaxValue: 10
        ///  - idcsMinValue: 4
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: integer
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PasscodeLength is required.")]
        [JsonProperty(PropertyName = "passcodeLength")]
        public System.Nullable<int> PasscodeLength { get; set; }
        
        /// <value>
        /// The duration of time (in days) after which the shared secret has to be refreshed
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsMaxValue: 999
        ///  - idcsMinValue: 30
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: integer
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "KeyRefreshIntervalInDays is required.")]
        [JsonProperty(PropertyName = "keyRefreshIntervalInDays")]
        public System.Nullable<int> KeyRefreshIntervalInDays { get; set; }
        
        /// <value>
        /// Time (in secs) to be used as the time step
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsMaxValue: 300
        ///  - idcsMinValue: 30
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: integer
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeStepInSecs is required.")]
        [JsonProperty(PropertyName = "timeStepInSecs")]
        public System.Nullable<int> TimeStepInSecs { get; set; }
        
        /// <value>
        /// The tolerance/step-size that the system should use when validating a One-Time Passcode
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsMaxValue: 3
        ///  - idcsMinValue: 2
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: integer
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeStepTolerance is required.")]
        [JsonProperty(PropertyName = "timeStepTolerance")]
        public System.Nullable<int> TimeStepTolerance { get; set; }
        
        /// <value>
        /// The period of time (in minutes) for which a One-Time Passcode that the system sends by Short Message Service (SMS) or by voice remains valid
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsMaxValue: 60
        ///  - idcsMinValue: 2
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: integer
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SmsOtpValidityDurationInMins is required.")]
        [JsonProperty(PropertyName = "smsOtpValidityDurationInMins")]
        public System.Nullable<int> SmsOtpValidityDurationInMins { get; set; }
        
        /// <value>
        /// The period of time (in seconds) that a JSON Web Token (JWT) is valid
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsMaxValue: 99999
        ///  - idcsMinValue: 30
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: integer
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "JwtValidityDurationInSecs is required.")]
        [JsonProperty(PropertyName = "jwtValidityDurationInSecs")]
        public System.Nullable<int> JwtValidityDurationInSecs { get; set; }
        
        /// <value>
        /// Exact length of the Short Message Service (SMS) One-Time Passcode
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsMaxValue: 10
        ///  - idcsMinValue: 4
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: integer
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SmsPasscodeLength is required.")]
        [JsonProperty(PropertyName = "smsPasscodeLength")]
        public System.Nullable<int> SmsPasscodeLength { get; set; }
        
        /// <value>
        /// The period of time (in minutes) that a one-time passcode remains valid that the system sends by email.
        /// <br/>
        /// **Added In:** 18.1.2
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsMaxValue: 60
        ///  - idcsMinValue: 2
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: integer
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EmailOtpValidityDurationInMins is required.")]
        [JsonProperty(PropertyName = "emailOtpValidityDurationInMins")]
        public System.Nullable<int> EmailOtpValidityDurationInMins { get; set; }
        
        /// <value>
        /// Exact length of the email one-time passcode.
        /// <br/>
        /// **Added In:** 18.1.2
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsMaxValue: 10
        ///  - idcsMinValue: 4
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: integer
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EmailPasscodeLength is required.")]
        [JsonProperty(PropertyName = "emailPasscodeLength")]
        public System.Nullable<int> EmailPasscodeLength { get; set; }
        
    }
}