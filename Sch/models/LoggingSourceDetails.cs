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


namespace Oci.SchService.Models
{
    /// <summary>
    /// The Logging source.
    /// For configuration instructions, see
    /// [Creating a Connector with a Logging Source](https://docs.cloud.oracle.com/iaas/Content/connector-hub/create-service-connector-logging-source.htm).
    /// 
    /// </summary>
    public class LoggingSourceDetails : SourceDetails
    {
        
        /// <value>
        /// The logs for this Logging source.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LogSources is required.")]
        [JsonProperty(PropertyName = "logSources")]
        public System.Collections.Generic.List<LogSource> LogSources { get; set; }
        
        [JsonProperty(PropertyName = "kind")]
        private readonly string kind = "logging";
    }
}
