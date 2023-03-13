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
    /// Settings related to compliance, Personal Identification Number (PIN) policy, and so on
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
    public class AuthenticationFactorSettingsClientAppSettings 
    {
        
        /// <value>
        /// Minimum length of the Personal Identification Number (PIN)
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsMaxValue: 10
        ///  - idcsMinValue: 6
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
        [Required(ErrorMessage = "MinPinLength is required.")]
        [JsonProperty(PropertyName = "minPinLength")]
        public System.Nullable<int> MinPinLength { get; set; }
        
        /// <value>
        /// The maximum number of login failures that the system will allow before raising a warning and sending an alert via email
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsMaxValue: 10
        ///  - idcsMinValue: 0
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
        [Required(ErrorMessage = "MaxFailuresBeforeWarning is required.")]
        [JsonProperty(PropertyName = "maxFailuresBeforeWarning")]
        public System.Nullable<int> MaxFailuresBeforeWarning { get; set; }
        
        /// <value>
        /// The maximum number of times that a particular user can fail to login before the system locks that user out of the service
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsMaxValue: 10
        ///  - idcsMinValue: 5
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
        [Required(ErrorMessage = "MaxFailuresBeforeLockout is required.")]
        [JsonProperty(PropertyName = "maxFailuresBeforeLockout")]
        public System.Nullable<int> MaxFailuresBeforeLockout { get; set; }
        
        /// <value>
        /// The period of time in seconds that the system will lock a user out of the service after that user exceeds the maximum number of login failures
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsMaxValue: 86400
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
        [Required(ErrorMessage = "InitialLockoutPeriodInSecs is required.")]
        [JsonProperty(PropertyName = "initialLockoutPeriodInSecs")]
        public System.Nullable<int> InitialLockoutPeriodInSecs { get; set; }
        
        /// <value>
        /// The pattern of escalation that the system follows, in locking a particular user out of the service.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCanonicalValueSourceFilter: attrName eq \"lockoutEscalationPattern\" and attrValues.value eq \"$(lockoutEscalationPattern)\"
        ///  - idcsCanonicalValueSourceResourceType: AllowedValue
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
        [Required(ErrorMessage = "LockoutEscalationPattern is required.")]
        [JsonProperty(PropertyName = "lockoutEscalationPattern")]
        public string LockoutEscalationPattern { get; set; }
        
        /// <value>
        /// The maximum period of time that the system will lock a particular user out of the service regardless of what the configured pattern of escalation would otherwise dictate
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsMaxValue: 86400
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
        [Required(ErrorMessage = "MaxLockoutIntervalInSecs is required.")]
        [JsonProperty(PropertyName = "maxLockoutIntervalInSecs")]
        public System.Nullable<int> MaxLockoutIntervalInSecs { get; set; }
                ///
        /// <value>
        /// Indicates which algorithm the system will use to sign requests
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
        public enum RequestSigningAlgoEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SHA256withRSA")]
            Sha256withRsa,
            [EnumMember(Value = "SHA384withRSA")]
            Sha384withRsa,
            [EnumMember(Value = "SHA512withRSA")]
            Sha512withRsa
        };

        /// <value>
        /// Indicates which algorithm the system will use to sign requests
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
        [Required(ErrorMessage = "RequestSigningAlgo is required.")]
        [JsonProperty(PropertyName = "requestSigningAlgo")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RequestSigningAlgoEnum> RequestSigningAlgo { get; set; }
        
        /// <value>
        /// The period of time in days after which a client should refresh its policy by re-reading that policy from the server
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsMaxValue: 999
        ///  - idcsMinValue: 1
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
        [Required(ErrorMessage = "PolicyUpdateFreqInDays is required.")]
        [JsonProperty(PropertyName = "policyUpdateFreqInDays")]
        public System.Nullable<int> PolicyUpdateFreqInDays { get; set; }
        
        /// <value>
        /// The size of the key that the system uses to generate the public-private key pair
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsMaxValue: 4000
        ///  - idcsMinValue: 32
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
        [Required(ErrorMessage = "KeyPairLength is required.")]
        [JsonProperty(PropertyName = "keyPairLength")]
        public System.Nullable<int> KeyPairLength { get; set; }
        
        /// <value>
        /// Indicates what protection policy that the system applies on a device. By default, the value is NONE, which indicates that the system applies no protection policy. A value of APP_PIN indicates that the system requires a Personal Identification Number (PIN). A value of DEVICE_BIOMETRIC_OR_APP_PIN indicates that either a PIN or a biometric authentication factor is required.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCanonicalValueSourceFilter: attrName eq \"deviceProtectionPolicy\" and attrValues.value eq \"$(deviceProtectionPolicy)\"
        ///  - idcsCanonicalValueSourceResourceType: AllowedValue
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
        [Required(ErrorMessage = "DeviceProtectionPolicy is required.")]
        [JsonProperty(PropertyName = "deviceProtectionPolicy")]
        public string DeviceProtectionPolicy { get; set; }
        
        /// <value>
        /// If true, indicates that the system should require the user to unlock the client app for each request. In order to unlock the App, the user must supply a Personal Identification Number (PIN) or a biometric authentication-factor.
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
        [Required(ErrorMessage = "UnlockAppForEachRequestEnabled is required.")]
        [JsonProperty(PropertyName = "unlockAppForEachRequestEnabled")]
        public System.Nullable<bool> UnlockAppForEachRequestEnabled { get; set; }
        
        /// <value>
        /// If true, indicates that the system should require the user to unlock the client App whenever the App is started. In order to unlock the App, the user must supply a Personal Identification Number (PIN) or a biometric authentication-factor.
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
        [Required(ErrorMessage = "UnlockOnAppStartEnabled is required.")]
        [JsonProperty(PropertyName = "unlockOnAppStartEnabled")]
        public System.Nullable<bool> UnlockOnAppStartEnabled { get; set; }
        
        /// <value>
        /// Specifies the period of time in seconds after which the client App should require the user to unlock the App. In order to unlock the App, the user must supply a Personal Identification Number (PIN) or a biometric authentication-factor. A value of zero means that it is disabled.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsMaxValue: 9999999
        ///  - idcsMinValue: 0
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
        [Required(ErrorMessage = "UnlockAppIntervalInSecs is required.")]
        [JsonProperty(PropertyName = "unlockAppIntervalInSecs")]
        public System.Nullable<int> UnlockAppIntervalInSecs { get; set; }
                ///
        /// <value>
        /// Indicates the type of encoding that the system should use to generate a shared secret
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
        public enum SharedSecretEncodingEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "Base32")]
            Base32,
            [EnumMember(Value = "Base64")]
            Base64
        };

        /// <value>
        /// Indicates the type of encoding that the system should use to generate a shared secret
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
        [Required(ErrorMessage = "SharedSecretEncoding is required.")]
        [JsonProperty(PropertyName = "sharedSecretEncoding")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SharedSecretEncodingEnum> SharedSecretEncoding { get; set; }
        
        /// <value>
        /// If true, indicates that the system should require the user to unlock the client App, when the client App comes to the foreground in the display of the device. In order to unlock the App, the user must supply a Personal Identification Number (PIN) or a biometric authentication-factor.
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
        [Required(ErrorMessage = "UnlockOnAppForegroundEnabled is required.")]
        [JsonProperty(PropertyName = "unlockOnAppForegroundEnabled")]
        public System.Nullable<bool> UnlockOnAppForegroundEnabled { get; set; }
        
    }
}
