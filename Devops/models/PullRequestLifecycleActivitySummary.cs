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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// activity describing a pull request state change
    /// </summary>
    public class PullRequestLifecycleActivitySummary : PullRequestActivitySummary
    {
                ///
        /// <value>
        /// The state of a pull request after an action.
        /// </value>
        ///
        public enum StateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "OPENED")]
            Opened,
            [EnumMember(Value = "CLOSED")]
            Closed,
            [EnumMember(Value = "MERGED")]
            Merged,
            [EnumMember(Value = "REOPENED")]
            Reopened
        };

        /// <value>
        /// The state of a pull request after an action.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "State is required.")]
        [JsonProperty(PropertyName = "state")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StateEnum> State { get; set; }
        
        [JsonProperty(PropertyName = "activityType")]
        private readonly string activityType = "LIFECYCLE";
    }
}
