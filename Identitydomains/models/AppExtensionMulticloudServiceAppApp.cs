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
    /// This extension defines attributes specific to Apps that represent instances of Multicloud Service App
    /// </summary>
    public class AppExtensionMulticloudServiceAppApp 
    {
                ///
        /// <value>
        /// Specifies the service type for which the application is configured for multicloud integration. For applicable external service types, app will invoke multicloud service for runtime operations
        /// <br/>
        /// **Added In:** 2301202328
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: immutable
        ///  - required: true
        ///  - returned: request
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        ///
        public enum MulticloudServiceTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "AWSCognito")]
            AwsCognito
        };

        /// <value>
        /// Specifies the service type for which the application is configured for multicloud integration. For applicable external service types, app will invoke multicloud service for runtime operations
        /// <br/>
        /// **Added In:** 2301202328
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: immutable
        ///  - required: true
        ///  - returned: request
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MulticloudServiceType is required.")]
        [JsonProperty(PropertyName = "multicloudServiceType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MulticloudServiceTypeEnum> MulticloudServiceType { get; set; }
        
        /// <value>
        /// The multicloud platform service URL which the application will invoke for runtime operations such as AWSCredentials api invocation
        /// <br/>
        /// **Added In:** 2301202328
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: immutable
        ///  - required: false
        ///  - returned: request
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "multicloudPlatformUrl")]
        public string MulticloudPlatformUrl { get; set; }
        
    }
}
