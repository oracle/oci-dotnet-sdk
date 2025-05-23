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


namespace Oci.FleetappsmanagementService.Models
{
    /// <summary>
    /// Patch artifact metadata Details which is platform specific.
    /// 
    /// </summary>
    public class PlatformSpecificArtifact 
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Content is required.")]
        [JsonProperty(PropertyName = "content")]
        public PatchFileContentDetails Content { get; set; }
                ///
        /// <value>
        /// The OS type the patch is applicable for.
        /// </value>
        ///
        public enum OsTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "WINDOWS")]
            Windows,
            [EnumMember(Value = "LINUX")]
            Linux
        };

        /// <value>
        /// The OS type the patch is applicable for.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OsType is required.")]
        [JsonProperty(PropertyName = "osType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OsTypeEnum> OsType { get; set; }
                ///
        /// <value>
        /// System architecture.
        /// </value>
        ///
        public enum ArchitectureEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ARM_64")]
            Arm64,
            [EnumMember(Value = "X64")]
            X64
        };

        /// <value>
        /// System architecture.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Architecture is required.")]
        [JsonProperty(PropertyName = "architecture")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ArchitectureEnum> Architecture { get; set; }
        
    }
}
