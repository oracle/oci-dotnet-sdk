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
    /// Specifies Invoke Function stage.
    /// </summary>
    public class InvokeFunctionDeployStage : DeployStage
    {
        
        /// <value>
        /// Function environment OCID.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FunctionDeployEnvironmentId is required.")]
        [JsonProperty(PropertyName = "functionDeployEnvironmentId")]
        public string FunctionDeployEnvironmentId { get; set; }
        
        /// <value>
        /// Optional artifact OCID. The artifact will be included in the body for the function invocation during the stage's execution.
        /// If the DeployArtifact.argumentSubstituitionMode is set to SUBSTITUTE_PLACEHOLDERS, then the pipeline parameter values will be used to replace the placeholders in the artifact content.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "deployArtifactId")]
        public string DeployArtifactId { get; set; }
        
        /// <value>
        /// A boolean flag specifies whether this stage executes asynchronously.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsAsync is required.")]
        [JsonProperty(PropertyName = "isAsync")]
        public System.Nullable<bool> IsAsync { get; set; }
        
        /// <value>
        /// A boolean flag specifies whether the invoked function must be validated.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsValidationEnabled is required.")]
        [JsonProperty(PropertyName = "isValidationEnabled")]
        public System.Nullable<bool> IsValidationEnabled { get; set; }
        
        [JsonProperty(PropertyName = "deployStageType")]
        private readonly string deployStageType = "INVOKE_FUNCTION";
    }
}
