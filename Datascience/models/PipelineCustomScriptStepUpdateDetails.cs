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


namespace Oci.DatascienceService.Models
{
    /// <summary>
    /// The type of step where user provides the step artifact to be executed on an execution engine managed by the pipelines service.
    /// </summary>
    public class PipelineCustomScriptStepUpdateDetails : PipelineStepUpdateDetails
    {
        
        [JsonProperty(PropertyName = "stepInfrastructureConfigurationDetails")]
        public PipelineInfrastructureConfigurationDetails StepInfrastructureConfigurationDetails { get; set; }
        
        /// <value>
        /// The storage mount details to mount to the instance running the pipeline step.
        /// </value>
        [JsonProperty(PropertyName = "stepStorageMountConfigurationDetailsList")]
        public System.Collections.Generic.List<StorageMountConfigurationDetails> StepStorageMountConfigurationDetailsList { get; set; }
        
        [JsonProperty(PropertyName = "stepType")]
        private readonly string stepType = "CUSTOM_SCRIPT";
    }
}
