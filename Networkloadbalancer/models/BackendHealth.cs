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


namespace Oci.NetworkloadbalancerService.Models
{
    /// <summary>
    /// The health status of the specified backend server.
    /// 
    /// </summary>
    public class BackendHealth 
    {
                ///
        /// <value>
        /// The general health status of the specified backend server.
        /// <br/>
        /// *   **OK:**  All health check probes return `OK`
        /// <br/>
        /// *   **WARNING:** At least one of the health check probes does not return `OK`
        /// <br/>
        /// *   **CRITICAL:** None of the health check probes return `OK`.
        /// *
        /// *   **UNKNOWN:** One of the health checks probes return `UNKNOWN`,
        /// *   or the system is unable to retrieve metrics at this time.
        /// 
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "OK")]
            Ok,
            [EnumMember(Value = "WARNING")]
            Warning,
            [EnumMember(Value = "CRITICAL")]
            Critical,
            [EnumMember(Value = "UNKNOWN")]
            Unknown
        };

        /// <value>
        /// The general health status of the specified backend server.
        /// <br/>
        /// *   **OK:**  All health check probes return `OK`
        /// <br/>
        /// *   **WARNING:** At least one of the health check probes does not return `OK`
        /// <br/>
        /// *   **CRITICAL:** None of the health check probes return `OK`.
        /// *
        /// *   **UNKNOWN:** One of the health checks probes return `UNKNOWN`,
        /// *   or the system is unable to retrieve metrics at this time.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// A list of the most recent health check results returned for the specified backend server.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HealthCheckResults is required.")]
        [JsonProperty(PropertyName = "healthCheckResults")]
        public System.Collections.Generic.List<HealthCheckResult> HealthCheckResults { get; set; }
        
    }
}
