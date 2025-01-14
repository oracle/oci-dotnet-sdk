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


namespace Oci.ContainerengineService.Models
{
    /// <summary>
    /// The properties that define a work request resource.
    /// </summary>
    public class AddonVersions 
    {
                ///
        /// <value>
        /// Current state of the addon, only active will be visible to customer, visibility of versions in other status will be filtered  based on limits property.
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "DEPRECATED")]
            Deprecated,
            [EnumMember(Value = "PREVIEW")]
            Preview,
            [EnumMember(Value = "RECALLED")]
            Recalled
        };

        /// <value>
        /// Current state of the addon, only active will be visible to customer, visibility of versions in other status will be filtered  based on limits property.
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// Version number, need be comparable within an addon.
        /// </value>
        [JsonProperty(PropertyName = "versionNumber")]
        public string VersionNumber { get; set; }
        
        /// <value>
        /// Information about the addon version.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The range of kubernetes versions an addon can be configured.
        /// </value>
        [JsonProperty(PropertyName = "kubernetesVersionFilters")]
        public KubernetesVersionsFilters KubernetesVersionFilters { get; set; }
        
        /// <value>
        /// Addon version configuration details.
        /// </value>
        [JsonProperty(PropertyName = "configurations")]
        public System.Collections.Generic.List<AddonVersionConfiguration> Configurations { get; set; }
        
    }
}
