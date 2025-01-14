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
    /// Details of the new deployment to be created based on a previously executed deployment.
    /// </summary>
    public class CreateDeployPipelineRedeploymentDetails : CreateDeploymentDetails
    {
        
        /// <value>
        /// Specifies the OCID of the previous deployment to be redeployed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PreviousDeploymentId is required.")]
        [JsonProperty(PropertyName = "previousDeploymentId")]
        public string PreviousDeploymentId { get; set; }
        
        [JsonProperty(PropertyName = "deploymentType")]
        private readonly string deploymentType = "PIPELINE_REDEPLOYMENT";
    }
}
