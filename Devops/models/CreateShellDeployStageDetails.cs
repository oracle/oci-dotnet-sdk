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
    /// Specifies the shell stage.
    /// </summary>
    public class CreateShellDeployStageDetails : CreateDeployStageDetails
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ContainerConfig is required.")]
        [JsonProperty(PropertyName = "containerConfig")]
        public ContainerConfig ContainerConfig { get; set; }
        
        /// <value>
        /// The OCID of the artifact that contains the command specification.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CommandSpecDeployArtifactId is required.")]
        [JsonProperty(PropertyName = "commandSpecDeployArtifactId")]
        public string CommandSpecDeployArtifactId { get; set; }
        
        /// <value>
        /// Time to wait for execution of a shell stage. Defaults to 36000 seconds.
        /// </value>
        [JsonProperty(PropertyName = "timeoutInSeconds")]
        public System.Nullable<int> TimeoutInSeconds { get; set; }
        
        [JsonProperty(PropertyName = "deployStageType")]
        private readonly string deployStageType = "SHELL";
    }
}
