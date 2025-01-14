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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// The list of supported platform configuration options for this shape.
    /// 
    /// </summary>
    public class ShapePlatformConfigOptions 
    {
                ///
        /// <value>
        /// The type of platform being configured.
        /// 
        /// </value>
        ///
        public enum TypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "AMD_MILAN_BM")]
            AmdMilanBm,
            [EnumMember(Value = "AMD_MILAN_BM_GPU")]
            AmdMilanBmGpu,
            [EnumMember(Value = "AMD_ROME_BM")]
            AmdRomeBm,
            [EnumMember(Value = "AMD_ROME_BM_GPU")]
            AmdRomeBmGpu,
            [EnumMember(Value = "GENERIC_BM")]
            GenericBm,
            [EnumMember(Value = "INTEL_ICELAKE_BM")]
            IntelIcelakeBm,
            [EnumMember(Value = "INTEL_SKYLAKE_BM")]
            IntelSkylakeBm,
            [EnumMember(Value = "AMD_VM")]
            AmdVm,
            [EnumMember(Value = "INTEL_VM")]
            IntelVm
        };

        /// <value>
        /// The type of platform being configured.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        [JsonProperty(PropertyName = "secureBootOptions")]
        public ShapeSecureBootOptions SecureBootOptions { get; set; }
        
        [JsonProperty(PropertyName = "measuredBootOptions")]
        public ShapeMeasuredBootOptions MeasuredBootOptions { get; set; }
        
        [JsonProperty(PropertyName = "trustedPlatformModuleOptions")]
        public ShapeTrustedPlatformModuleOptions TrustedPlatformModuleOptions { get; set; }
        
        [JsonProperty(PropertyName = "numaNodesPerSocketPlatformOptions")]
        public ShapeNumaNodesPerSocketPlatformOptions NumaNodesPerSocketPlatformOptions { get; set; }
        
        [JsonProperty(PropertyName = "memoryEncryptionOptions")]
        public ShapeMemoryEncryptionOptions MemoryEncryptionOptions { get; set; }
        
        [JsonProperty(PropertyName = "symmetricMultiThreadingOptions")]
        public ShapeSymmetricMultiThreadingEnabledPlatformOptions SymmetricMultiThreadingOptions { get; set; }
        
        [JsonProperty(PropertyName = "accessControlServiceOptions")]
        public ShapeAccessControlServiceEnabledPlatformOptions AccessControlServiceOptions { get; set; }
        
        [JsonProperty(PropertyName = "virtualInstructionsOptions")]
        public ShapeVirtualInstructionsEnabledPlatformOptions VirtualInstructionsOptions { get; set; }
        
        [JsonProperty(PropertyName = "inputOutputMemoryManagementUnitOptions")]
        public ShapeInputOutputMemoryManagementUnitEnabledPlatformOptions InputOutputMemoryManagementUnitOptions { get; set; }
        
        [JsonProperty(PropertyName = "percentageOfCoresEnabledOptions")]
        public PercentageOfCoresEnabledOptions PercentageOfCoresEnabledOptions { get; set; }
        
    }
}
