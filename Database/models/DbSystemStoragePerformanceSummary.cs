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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Representation of storage performance summary per shapeType .
    /// 
    /// </summary>
    public class DbSystemStoragePerformanceSummary 
    {
                ///
        /// <value>
        /// ShapeType of the DbSystems INTEL , AMD, INTEL_FLEX_X9 or AMPERE_FLEX_A1
        /// </value>
        ///
        public enum ShapeTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "AMD")]
            Amd,
            [EnumMember(Value = "INTEL")]
            Intel,
            [EnumMember(Value = "INTEL_FLEX_X9")]
            IntelFlexX9,
            [EnumMember(Value = "AMPERE_FLEX_A1")]
            AmpereFlexA1
        };

        /// <value>
        /// ShapeType of the DbSystems INTEL , AMD, INTEL_FLEX_X9 or AMPERE_FLEX_A1
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ShapeType is required.")]
        [JsonProperty(PropertyName = "shapeType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ShapeTypeEnum> ShapeType { get; set; }
        
        /// <value>
        /// List of storage performance for the DATA disks
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DataStoragePerformanceList is required.")]
        [JsonProperty(PropertyName = "dataStoragePerformanceList")]
        public System.Collections.Generic.List<StoragePerformanceDetails> DataStoragePerformanceList { get; set; }
        
        /// <value>
        /// List of storage performance for the RECO disks
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RecoStoragePerformanceList is required.")]
        [JsonProperty(PropertyName = "recoStoragePerformanceList")]
        public System.Collections.Generic.List<StoragePerformanceDetails> RecoStoragePerformanceList { get; set; }
        
    }
}
