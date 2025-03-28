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


namespace Oci.GenerativeaiagentruntimeService.Models
{
    /// <summary>
    /// An action describing user approval to the agent.
    /// </summary>
    public class HumanApprovalPerformedAction : PerformedAction
    {
                ///
        /// <value>
        /// The chosen approval or denial option to the agent.
        /// </value>
        ///
        public enum ChosenOptionEnum {
            [EnumMember(Value = "APPROVE")]
            Approve,
            [EnumMember(Value = "DENY")]
            Deny
        };

        /// <value>
        /// The chosen approval or denial option to the agent.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ChosenOption is required.")]
        [JsonProperty(PropertyName = "chosenOption")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ChosenOptionEnum> ChosenOption { get; set; }
        
        [JsonProperty(PropertyName = "performedActionType")]
        private readonly string performedActionType = "HUMAN_APPROVAL_PERFORMED_ACTION";
    }
}
