/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
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
    /// Specifies the Trigger Deployment stage, which runs another pipeline of the application.
    /// </summary>
    public class CreateTriggerDeploymentStageDetails : CreateBuildPipelineStageDetails
    {
        
        /// <value>
        /// A target deployment pipeline OCID that will run in this stage.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DeployPipelineId is required.")]
        [JsonProperty(PropertyName = "deployPipelineId")]
        public string DeployPipelineId { get; set; }
        
        /// <value>
        /// A boolean flag that specifies whether all the parameters must be passed when the deployment is triggered.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsPassAllParametersEnabled is required.")]
        [JsonProperty(PropertyName = "isPassAllParametersEnabled")]
        public System.Nullable<bool> IsPassAllParametersEnabled { get; set; }
        
        [JsonProperty(PropertyName = "buildPipelineStageType")]
        private readonly string buildPipelineStageType = "TRIGGER_DEPLOYMENT_PIPELINE";
    }
}
