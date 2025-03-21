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
    /// Specifies the canary approval stage.
    /// </summary>
    public class ComputeInstanceGroupCanaryApprovalDeployStage : DeployStage
    {
        
        /// <value>
        /// A compute instance group canary traffic shift stage OCID for load balancer.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ComputeInstanceGroupCanaryTrafficShiftDeployStageId is required.")]
        [JsonProperty(PropertyName = "computeInstanceGroupCanaryTrafficShiftDeployStageId")]
        public string ComputeInstanceGroupCanaryTrafficShiftDeployStageId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ApprovalPolicy is required.")]
        [JsonProperty(PropertyName = "approvalPolicy")]
        public ApprovalPolicy ApprovalPolicy { get; set; }
        
        [JsonProperty(PropertyName = "deployStageType")]
        private readonly string deployStageType = "COMPUTE_INSTANCE_GROUP_CANARY_APPROVAL";
    }
}
