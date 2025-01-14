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
    /// Device Resource.
    /// </summary>
    public class MyDevice 
    {
        
        /// <value>
        /// Unique identifier for the SCIM Resource as defined by the Service Provider. Each representation of the Resource MUST include a non-empty id value. This identifier MUST be unique across the Service Provider's entire set of Resources. It MUST be a stable, non-reassignable identifier that does not change when the same Resource is returned in subsequent requests. The value of the id attribute is always issued by the Service Provider and MUST never be specified by the Service Consumer. bulkId: is a reserved keyword and MUST NOT be used in the unique identifier.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: always
        ///  - type: string
        ///  - uniqueness: global
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Unique OCI identifier for the SCIM Resource.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: immutable
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: global
        /// </value>
        [JsonProperty(PropertyName = "ocid")]
        public string Ocid { get; set; }
        
        /// <value>
        /// REQUIRED. The schemas attribute is an array of Strings which allows introspection of the supported schema version for a SCIM representation as well any schema extensions supported by that representation. Each String value must be a unique URI. This specification defines URIs for User, Group, and a standard \\\"enterprise\\\" extension. All representations of SCIM schema MUST include a non-zero value array with value(s) of the URIs supported by that representation. Duplicate values MUST NOT be included. Value order is not specified and MUST not impact behavior.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
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
        [Required(ErrorMessage = "Schemas is required.")]
        [JsonProperty(PropertyName = "schemas")]
        public System.Collections.Generic.List<string> Schemas { get; set; }
        
        [JsonProperty(PropertyName = "meta")]
        public Meta Meta { get; set; }
        
        [JsonProperty(PropertyName = "idcsCreatedBy")]
        public IdcsCreatedBy IdcsCreatedBy { get; set; }
        
        [JsonProperty(PropertyName = "idcsLastModifiedBy")]
        public IdcsLastModifiedBy IdcsLastModifiedBy { get; set; }
        
        /// <value>
        /// Each value of this attribute specifies an operation that only an internal client may perform on this particular resource.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: true
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "idcsPreventedOperations", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<IdcsPreventedOperations> IdcsPreventedOperations { get; set; }
        
        /// <value>
        /// A list of tags on this resource.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [key, value]
        ///  - idcsSearchable: true
        ///  - multiValued: true
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: request
        ///  - type: complex
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.List<Tags> Tags { get; set; }
        
        /// <value>
        /// A boolean flag indicating this resource in the process of being deleted. Usually set to true when synchronous deletion of the resource would take too long.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "deleteInProgress")]
        public System.Nullable<bool> DeleteInProgress { get; set; }
        
        /// <value>
        /// The release number when the resource was upgraded.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "idcsLastUpgradedInRelease")]
        public string IdcsLastUpgradedInRelease { get; set; }
        
        /// <value>
        /// OCI Domain Id (ocid) in which the resource lives.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "domainOcid")]
        public string DomainOcid { get; set; }
        
        /// <value>
        /// OCI Compartment Id (ocid) in which the resource lives.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "compartmentOcid")]
        public string CompartmentOcid { get; set; }
        
        /// <value>
        /// OCI Tenant Id (ocid) in which the resource lives.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "tenancyOcid")]
        public string TenancyOcid { get; set; }
        
        /// <value>
        /// An identifier for the Resource as defined by the Service Consumer. The externalId may simplify identification of the Resource between Service Consumer and Service Provider by allowing the Consumer to refer to the Resource with its own identifier, obviating the need to store a local mapping between the local identifier of the Resource and the identifier used by the Service Provider. Each Resource MAY include a non-empty externalId value. The value of the externalId attribute is always issued be the Service Consumer and can never be specified by the Service Provider. The Service Provider MUST always interpret the externalId as scoped to the Service Consumer's tenant.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "externalId")]
        public string ExternalId { get; set; }
        
        /// <value>
        /// Device friendly display name
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        ///  - idcsRequiresWriteForAccessFlows: true
        ///  - idcsRequiresImmediateReadAfterWriteForAccessFlows: true
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
                ///
        /// <value>
        /// Device Platform
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: immutable
        ///  - idcsRequiresWriteForAccessFlows: true
        ///  - idcsRequiresImmediateReadAfterWriteForAccessFlows: true
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        ///
        public enum PlatformEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "IOS")]
            Ios,
            [EnumMember(Value = "ANDROID")]
            Android,
            [EnumMember(Value = "WINDOWS")]
            Windows,
            [EnumMember(Value = "CELLULAR")]
            Cellular
        };

        /// <value>
        /// Device Platform
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: immutable
        ///  - idcsRequiresWriteForAccessFlows: true
        ///  - idcsRequiresImmediateReadAfterWriteForAccessFlows: true
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "platform")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PlatformEnum> Platform { get; set; }
                ///
        /// <value>
        /// Device Status
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        ///  - idcsRequiresWriteForAccessFlows: true
        ///  - idcsRequiresImmediateReadAfterWriteForAccessFlows: true
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
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            [EnumMember(Value = "ENROLLED")]
            Enrolled,
            [EnumMember(Value = "LOCKED")]
            Locked,
            [EnumMember(Value = "BLOCKED")]
            Blocked
        };

        /// <value>
        /// Device Status
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        ///  - idcsRequiresWriteForAccessFlows: true
        ///  - idcsRequiresImmediateReadAfterWriteForAccessFlows: true
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// Additional comments/reasons for the change in device status
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
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }
        
        /// <value>
        /// Device hardware name/model
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        ///  - idcsRequiresWriteForAccessFlows: true
        ///  - idcsRequiresImmediateReadAfterWriteForAccessFlows: true
        /// </value>
        [JsonProperty(PropertyName = "deviceType")]
        public string DeviceType { get; set; }
        
        /// <value>
        /// Mobile Authenticator App Version
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        ///  - idcsRequiresWriteForAccessFlows: true
        ///  - idcsRequiresImmediateReadAfterWriteForAccessFlows: true
        /// </value>
        [JsonProperty(PropertyName = "appVersion")]
        public string AppVersion { get; set; }
        
        /// <value>
        /// Mobile Authenticator App Package Id
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        ///  - idcsRequiresWriteForAccessFlows: true
        ///  - idcsRequiresImmediateReadAfterWriteForAccessFlows: true
        /// </value>
        [JsonProperty(PropertyName = "packageId")]
        public string PackageId { get; set; }
        
        /// <value>
        /// Last Sync time for device
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - idcsRequiresWriteForAccessFlows: true
        ///  - idcsRequiresImmediateReadAfterWriteForAccessFlows: true
        ///  - required: false
        ///  - returned: default
        ///  - type: dateTime
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "lastSyncTime")]
        public string LastSyncTime { get; set; }
        
        /// <value>
        /// The most recent timestamp when the device was successfully validated using one time passcode
        /// <br/>
        /// **Added In:** 17.3.6
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - idcsAllowUpdatesInReadOnlyMode: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - idcsRequiresWriteForAccessFlows: true
        ///  - idcsRequiresImmediateReadAfterWriteForAccessFlows: true
        ///  - required: false
        ///  - returned: default
        ///  - type: dateTime
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "lastValidatedTime")]
        public string LastValidatedTime { get; set; }
        
        /// <value>
        /// Device Compliance Status
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "isCompliant")]
        public System.Nullable<bool> IsCompliant { get; set; }
        
        /// <value>
        /// Country code of user's Phone Number
        /// <br/>
        /// **Added In:** 19.1.4
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: immutable
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        ///  - idcsRequiresWriteForAccessFlows: true
        ///  - idcsRequiresImmediateReadAfterWriteForAccessFlows: true
        /// </value>
        [JsonProperty(PropertyName = "countryCode")]
        public string CountryCode { get; set; }
        
        /// <value>
        /// User's Phone Number
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: immutable
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        ///  - idcsRequiresWriteForAccessFlows: true
        ///  - idcsRequiresImmediateReadAfterWriteForAccessFlows: true
        /// </value>
        [JsonProperty(PropertyName = "phoneNumber")]
        public string PhoneNumber { get; set; }
        
        /// <value>
        /// Flag that indicates whether the device is enrolled for account recovery
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        ///  - idcsRequiresWriteForAccessFlows: true
        ///  - idcsRequiresImmediateReadAfterWriteForAccessFlows: true
        /// </value>
        [JsonProperty(PropertyName = "isAccRecEnabled")]
        public System.Nullable<bool> IsAccRecEnabled { get; set; }
        
        /// <value>
        /// Unique id sent from device
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        ///  - idcsRequiresWriteForAccessFlows: true
        ///  - idcsRequiresImmediateReadAfterWriteForAccessFlows: true
        /// </value>
        [JsonProperty(PropertyName = "deviceUUID")]
        public string DeviceUUID { get; set; }
        
        /// <value>
        /// Device base public Key
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        ///  - idcsRequiresWriteForAccessFlows: true
        ///  - idcsRequiresImmediateReadAfterWriteForAccessFlows: true
        /// </value>
        [JsonProperty(PropertyName = "basePublicKey")]
        public string BasePublicKey { get; set; }
        
        /// <value>
        /// Authentication method used in device. For FIDO, it will contain SECURITY_KEY/WINDOWS_HELLO etc
        /// <br/>
        /// **Added In:** 2009232244
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        ///  - idcsRequiresWriteForAccessFlows: true
        ///  - idcsRequiresImmediateReadAfterWriteForAccessFlows: true
        /// </value>
        [JsonProperty(PropertyName = "authenticationMethod")]
        public string AuthenticationMethod { get; set; }
        
        /// <value>
        /// Attribute added for replication log, it is not used by IDCS, just added as place holder
        /// <br/>
        /// **Added In:** 2111040242
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: integer
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "expiresOn")]
        public System.Nullable<int> ExpiresOn { get; set; }
        
        /// <value>
        /// Attribute added for replication log, it is not used by IDCS, the DEK that encrypts the specific seed for that user
        /// <br/>
        /// **Added In:** 2111040242
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "seedDekId")]
        public string SeedDekId { get; set; }
        
        /// <value>
        /// Attribute added for replication log, it is not used by IDCS, it is actual encrypted TOTP seed for the user
        /// <br/>
        /// **Added In:** 2111040242
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "seed")]
        public string Seed { get; set; }
        
        [JsonProperty(PropertyName = "thirdPartyFactor")]
        public MyDeviceThirdPartyFactor ThirdPartyFactor { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "User is required.")]
        [JsonProperty(PropertyName = "user")]
        public MyDeviceUser User { get; set; }
        
        [JsonProperty(PropertyName = "pushNotificationTarget")]
        public MyDevicePushNotificationTarget PushNotificationTarget { get; set; }
        
        /// <value>
        /// Device additional attributes
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [key, value]
        ///  - idcsSearchable: false
        ///  - multiValued: true
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: complex
        /// </value>
        [JsonProperty(PropertyName = "additionalAttributes")]
        public System.Collections.Generic.List<MyDeviceAdditionalAttributes> AdditionalAttributes { get; set; }
        
        /// <value>
        /// Authentication Factors
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsCompositeKey: [type]
        ///  - idcsSearchable: true
        ///  - multiValued: true
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: complex
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AuthenticationFactors is required.")]
        [JsonProperty(PropertyName = "authenticationFactors")]
        public System.Collections.Generic.List<MyDeviceAuthenticationFactors> AuthenticationFactors { get; set; }
        
        /// <value>
        /// Device Non Compliances
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [name, value]
        ///  - idcsSearchable: false
        ///  - multiValued: true
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: complex
        /// </value>
        [JsonProperty(PropertyName = "nonCompliances")]
        public System.Collections.Generic.List<MyDeviceNonCompliances> NonCompliances { get; set; }
        
    }
}
