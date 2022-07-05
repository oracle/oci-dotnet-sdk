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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Information about the approval action of DevOps deployment stages.
    /// </summary>
    public class ApprovalAction 
    {
        
        /// <value>
        /// The subject ID of the user who approves or disapproves a DevOps deployment stage.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubjectId is required.")]
        [JsonProperty(PropertyName = "subjectId")]
        public string SubjectId { get; set; }
                ///
        /// <value>
        /// The action of the user on the DevOps deployment stage.
        /// </value>
        ///
        public enum ActionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "APPROVE")]
            Approve,
            [EnumMember(Value = "REJECT")]
            Reject
        };

        /// <value>
        /// The action of the user on the DevOps deployment stage.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Action is required.")]
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ActionEnum> Action { get; set; }
        
        /// <value>
        /// The reason for approving or rejecting the deployment.
        /// </value>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }
        
    }
}
