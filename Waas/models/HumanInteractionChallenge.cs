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


namespace Oci.WaasService.Models
{
    /// <summary>
    /// The human interaction challenge settings. The human interaction challenge checks various event listeners in the user's browser to determine if there is a human user making a request.
    /// </summary>
    public class HumanInteractionChallenge 
    {
        
        /// <value>
        /// Enables or disables the human interaction challenge Web Application Firewall feature.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsEnabled is required.")]
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
                ///
        /// <value>
        /// The action to take against requests from detected bots. If unspecified, defaults to `DETECT`.
        /// </value>
        ///
        public enum ActionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "DETECT")]
            Detect,
            [EnumMember(Value = "BLOCK")]
            Block
        };

        /// <value>
        /// The action to take against requests from detected bots. If unspecified, defaults to `DETECT`.
        /// </value>
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ActionEnum> Action { get; set; }
        
        /// <value>
        /// The number of failed requests before taking action. If unspecified, defaults to `10`.
        /// </value>
        [JsonProperty(PropertyName = "failureThreshold")]
        public System.Nullable<int> FailureThreshold { get; set; }
        
        /// <value>
        /// The number of seconds between challenges for the same IP address. If unspecified, defaults to `60`.
        /// </value>
        [JsonProperty(PropertyName = "actionExpirationInSeconds")]
        public System.Nullable<int> ActionExpirationInSeconds { get; set; }
        
        /// <value>
        /// The number of seconds before the failure threshold resets. If unspecified, defaults to  `60`.
        /// </value>
        [JsonProperty(PropertyName = "failureThresholdExpirationInSeconds")]
        public System.Nullable<int> FailureThresholdExpirationInSeconds { get; set; }
        
        /// <value>
        /// The number of interactions required to pass the challenge. If unspecified, defaults to `3`.
        /// </value>
        [JsonProperty(PropertyName = "interactionThreshold")]
        public System.Nullable<int> InteractionThreshold { get; set; }
        
        /// <value>
        /// The number of seconds to record the interactions from the user. If unspecified, defaults to `15`.
        /// </value>
        [JsonProperty(PropertyName = "recordingPeriodInSeconds")]
        public System.Nullable<int> RecordingPeriodInSeconds { get; set; }
        
        /// <value>
        /// Adds an additional HTTP header to requests that fail the challenge before being passed to the origin. Only applicable when the `action` is set to `DETECT`.
        /// </value>
        [JsonProperty(PropertyName = "setHttpHeader")]
        public Header SetHttpHeader { get; set; }
        
        [JsonProperty(PropertyName = "challengeSettings")]
        public BlockChallengeSettings ChallengeSettings { get; set; }
        
        /// <value>
        /// When enabled, the user is identified not only by the IP address but also by an unique additional hash, which prevents blocking visitors with shared IP addresses.
        /// </value>
        [JsonProperty(PropertyName = "isNatEnabled")]
        public System.Nullable<bool> IsNatEnabled { get; set; }
        
    }
}
