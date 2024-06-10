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


namespace Oci.DatascienceService.Models
{
    /// <summary>
    /// The type of step where user provides the container details for an execution engine managed by the pipelines service.
    /// </summary>
    public class PipelineContainerStepDetails : PipelineStepDetails
    {
        
        [JsonProperty(PropertyName = "stepInfrastructureConfigurationDetails")]
        public PipelineInfrastructureConfigurationDetails StepInfrastructureConfigurationDetails { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StepContainerConfigurationDetails is required.")]
        [JsonProperty(PropertyName = "stepContainerConfigurationDetails")]
        public PipelineContainerConfigurationDetails StepContainerConfigurationDetails { get; set; }
        
        /// <value>
        /// A flag to indicate whether the artifact has been uploaded for this step or not.
        /// </value>
        [JsonProperty(PropertyName = "isArtifactUploaded")]
        public System.Nullable<bool> IsArtifactUploaded { get; set; }
        
        [JsonProperty(PropertyName = "stepType")]
        private readonly string stepType = "CONTAINER";
    }
}