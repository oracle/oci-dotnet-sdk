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


namespace Oci.LoggingingestionService.Models
{
    /// <summary>
    /// Contains the log content with the associated timestamp and ID. Each
    /// entry should be less than 1 MB size.
    /// 
    /// </summary>
    public class LogEntry 
    {
        
        /// <value>
        /// The log entry content.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Data is required.")]
        [JsonProperty(PropertyName = "data")]
        public string Data { get; set; }
        
        /// <value>
        /// UUID uniquely representing this logEntry. This is not an OCID related
        /// to any oracle resource.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Optional. The timestamp associated with the log entry. An RFC3339-formatted date-time string with milliseconds precision.
        /// If unspecified, defaults to PutLogsDetails.defaultlogentrytime.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "time")]
        public System.Nullable<System.DateTime> Time { get; set; }
        
    }
}
