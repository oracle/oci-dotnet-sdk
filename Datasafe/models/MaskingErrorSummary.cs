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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// Summary of a masking error. A Masking error is an error seen during the masking run.
    /// </summary>
    public class MaskingErrorSummary 
    {
                ///
        /// <value>
        /// The stepName of the masking error.
        /// </value>
        ///
        public enum StepNameEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "EXECUTE_MASKING")]
            ExecuteMasking,
            [EnumMember(Value = "PRE_MASKING")]
            PreMasking,
            [EnumMember(Value = "POST_MASKING")]
            PostMasking
        };

        /// <value>
        /// The stepName of the masking error.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StepName is required.")]
        [JsonProperty(PropertyName = "stepName")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StepNameEnum> StepName { get; set; }
        
        /// <value>
        /// The text of the masking error.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Error is required.")]
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }
        
        /// <value>
        /// The statement resulting into the error.
        /// </value>
        [JsonProperty(PropertyName = "failedStatement")]
        public string FailedStatement { get; set; }
        
        /// <value>
        /// The date and time the error entry was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
    }
}
