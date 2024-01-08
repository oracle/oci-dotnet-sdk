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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// The details used to generate a new security assessment report.
    /// </summary>
    public class GenerateSecurityAssessmentReportDetails 
    {
                ///
        /// <value>
        /// Format of the report.
        /// </value>
        ///
        public enum FormatEnum {
            [EnumMember(Value = "PDF")]
            Pdf,
            [EnumMember(Value = "XLS")]
            Xls
        };

        /// <value>
        /// Format of the report.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Format is required.")]
        [JsonProperty(PropertyName = "format")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<FormatEnum> Format { get; set; }
        
    }
}
