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


namespace Oci.DesktopsService.Models
{
    /// <summary>
    /// Action and grace period for disconnect
    /// </summary>
    public class DisconnectConfig 
    {
                ///
        /// <value>
        /// a disconnect action to be triggered
        /// </value>
        ///
        public enum ActionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NONE")]
            None,
            [EnumMember(Value = "STOP")]
            Stop
        };

        /// <value>
        /// a disconnect action to be triggered
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Action is required.")]
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ActionEnum> Action { get; set; }
        
        /// <value>
        /// The period of time (in minutes) after disconnect before any action occurs.
        /// If the value is not provided, a default value is used.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "gracePeriodInMinutes")]
        public System.Nullable<int> GracePeriodInMinutes { get; set; }
        
    }
}
