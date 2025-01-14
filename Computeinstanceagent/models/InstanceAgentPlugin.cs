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


namespace Oci.ComputeinstanceagentService.Models
{
    /// <summary>
    /// The agent plugin
    /// </summary>
    public class InstanceAgentPlugin 
    {
        
        /// <value>
        /// The plugin name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
                ///
        /// <value>
        /// The plugin status Specified the plugin state on the instance * `RUNNING` - The plugin is in running state * `STOPPED` - The plugin is in stopped state * `NOT_SUPPORTED` - The plugin is not supported on this platform * `INVALID` - The plugin state is not recognizable by the service
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "RUNNING")]
            Running,
            [EnumMember(Value = "STOPPED")]
            Stopped,
            [EnumMember(Value = "NOT_SUPPORTED")]
            NotSupported,
            [EnumMember(Value = "INVALID")]
            Invalid
        };

        /// <value>
        /// The plugin status Specified the plugin state on the instance * `RUNNING` - The plugin is in running state * `STOPPED` - The plugin is in stopped state * `NOT_SUPPORTED` - The plugin is not supported on this platform * `INVALID` - The plugin state is not recognizable by the service
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// The last update time of the plugin in UTC
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeLastUpdatedUtc is required.")]
        [JsonProperty(PropertyName = "timeLastUpdatedUtc")]
        public System.Nullable<System.DateTime> TimeLastUpdatedUtc { get; set; }
        
        /// <value>
        /// The optional message from the agent plugin
        /// </value>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        
    }
}
