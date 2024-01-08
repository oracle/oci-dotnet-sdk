/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.BdsService.Models
{
    /// <summary>
    /// Summary of a package contained in a os patch.
    /// </summary>
    public class OsPatchPackageSummary 
    {
        
        /// <value>
        /// The package's name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PackageName is required.")]
        [JsonProperty(PropertyName = "packageName")]
        public string PackageName { get; set; }
        
        /// <value>
        /// The target version of the package.
        /// </value>
        [JsonProperty(PropertyName = "targetVersion")]
        public string TargetVersion { get; set; }
                ///
        /// <value>
        /// The action that current package will be executed on the cluster.
        /// </value>
        ///
        public enum UpdateTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "INSTALL")]
            Install,
            [EnumMember(Value = "REMOVE")]
            Remove,
            [EnumMember(Value = "UPDATE")]
            Update
        };

        /// <value>
        /// The action that current package will be executed on the cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UpdateType is required.")]
        [JsonProperty(PropertyName = "updateType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<UpdateTypeEnum> UpdateType { get; set; }
        
        /// <value>
        /// Related CVEs of the package update.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RelatedCVEs is required.")]
        [JsonProperty(PropertyName = "relatedCVEs")]
        public System.Collections.Generic.List<string> RelatedCVEs { get; set; }
        
    }
}
