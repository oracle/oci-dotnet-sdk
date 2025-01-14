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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Specifies Helm command spec details
    /// </summary>
    public class HelmCommandSpecArtifactSource : DeployArtifactSource
    {
        
        /// <value>
        /// The Helm commands to be executed, base 64 encoded
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Base64EncodedContent is required.")]
        [JsonProperty(PropertyName = "base64EncodedContent")]
        public string Base64EncodedContent { get; set; }
                ///
        /// <value>
        /// Specifies types of artifact sources.
        /// </value>
        ///
        public enum HelmArtifactSourceTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "INLINE")]
            Inline
        };

        /// <value>
        /// Specifies types of artifact sources.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HelmArtifactSourceType is required.")]
        [JsonProperty(PropertyName = "helmArtifactSourceType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<HelmArtifactSourceTypeEnum> HelmArtifactSourceType { get; set; }
        
        [JsonProperty(PropertyName = "deployArtifactSourceType")]
        private readonly string deployArtifactSourceType = "HELM_COMMAND_SPEC";
    }
}
