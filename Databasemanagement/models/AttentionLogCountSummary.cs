/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The details for one attention log count entry.
    /// 
    /// </summary>
    public class AttentionLogCountSummary 
    {
                ///
        /// <value>
        /// The category of different attention logs.
        /// </value>
        ///
        public enum CategoryEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            [EnumMember(Value = "INCIDENT_ERROR")]
            IncidentError,
            [EnumMember(Value = "ERROR")]
            Error,
            [EnumMember(Value = "WARNING")]
            Warning,
            [EnumMember(Value = "NOTIFICATION")]
            Notification,
            [EnumMember(Value = "TRACE")]
            Trace,
            [EnumMember(Value = "IMMEDIATE")]
            Immediate,
            [EnumMember(Value = "SOON")]
            Soon,
            [EnumMember(Value = "DEFERRABLE")]
            Deferrable,
            [EnumMember(Value = "INFO")]
            Info,
            [EnumMember(Value = "OTHER")]
            Other
        };

        /// <value>
        /// The category of different attention logs.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Category is required.")]
        [JsonProperty(PropertyName = "category")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CategoryEnum> Category { get; set; }
        
        /// <value>
        /// The count of attention logs with specific category.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Count is required.")]
        [JsonProperty(PropertyName = "count")]
        public System.Nullable<int> Count { get; set; }
        
    }
}
