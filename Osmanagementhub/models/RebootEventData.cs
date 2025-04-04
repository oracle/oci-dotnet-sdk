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


namespace Oci.OsmanagementhubService.Models
{
    /// <summary>
    /// Provides additional information for a reboot event.
    /// </summary>
    public class RebootEventData 
    {
                ///
        /// <value>
        /// Reboot status for the current event
        /// </value>
        ///
        public enum RebootStatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "REBOOT_STARTED")]
            RebootStarted,
            [EnumMember(Value = "REBOOT_SUCCEEDED")]
            RebootSucceeded,
            [EnumMember(Value = "REBOOT_FAILED")]
            RebootFailed,
            [EnumMember(Value = "REBOOT_SUCCEEDED_AFTER_TIMEOUT")]
            RebootSucceededAfterTimeout
        };

        /// <value>
        /// Reboot status for the current event
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RebootStatus is required.")]
        [JsonProperty(PropertyName = "rebootStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RebootStatusEnum> RebootStatus { get; set; }
        
        [JsonProperty(PropertyName = "additionalDetails")]
        public WorkRequestEventDataAdditionalDetails AdditionalDetails { get; set; }
        
    }
}
