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


namespace Oci.ResourcemanagerService.Models
{
    /// <summary>
    /// Log entry for an operation resulting from a job's execution.
    /// </summary>
    public class LogEntry 
    {
                ///
        /// <value>
        /// Specifies the log type for the log entry.
        /// </value>
        ///
        public enum TypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "TERRAFORM_CONSOLE")]
            TerraformConsole
        };

        /// <value>
        /// Specifies the log type for the log entry.
        /// </value>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
                ///
        /// <value>
        /// Specifies the severity level of the log entry.
        /// </value>
        ///
        public enum LevelEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "TRACE")]
            Trace,
            [EnumMember(Value = "DEBUG")]
            Debug,
            [EnumMember(Value = "INFO")]
            Info,
            [EnumMember(Value = "WARN")]
            Warn,
            [EnumMember(Value = "ERROR")]
            Error,
            [EnumMember(Value = "FATAL")]
            Fatal
        };

        /// <value>
        /// Specifies the severity level of the log entry.
        /// </value>
        [JsonProperty(PropertyName = "level")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LevelEnum> Level { get; set; }
        
        /// <value>
        /// The date and time of the log entry.
        /// Format is defined by RFC3339.
        /// Example: 2020-01-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timestamp")]
        public System.Nullable<System.DateTime> Timestamp { get; set; }
        
        /// <value>
        /// The log entry value.
        /// </value>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        
    }
}
