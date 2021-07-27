/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
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
    /// The stage information for submitting for approval.
    /// </summary>
    public class ApproveDeploymentDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the stage which is marked for approval.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DeployStageId is required.")]
        [JsonProperty(PropertyName = "deployStageId")]
        public string DeployStageId { get; set; }
        
        /// <value>
        /// The reason for approving or rejecting the deployment.
        /// </value>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }
                ///
        /// <value>
        /// The action of Approve or Reject.
        /// </value>
        ///
        public enum ActionEnum {
            [EnumMember(Value = "APPROVE")]
            Approve,
            [EnumMember(Value = "REJECT")]
            Reject
        };

        /// <value>
        /// The action of Approve or Reject.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Action is required.")]
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ActionEnum> Action { get; set; }
        
    }
}