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
    /// Specifies the build stage.
    /// </summary>
    public class BuildStage : BuildPipelineStage
    {
                ///
        /// <value>
        /// Image name for the build environment.
        /// </value>
        ///
        public enum ImageEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "OL7_X86_64_STANDARD_10")]
            Ol7X8664Standard10
        };

        /// <value>
        /// Image name for the build environment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Image is required.")]
        [JsonProperty(PropertyName = "image")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ImageEnum> Image { get; set; }
        
        /// <value>
        /// The path to the build specification file for this environment. The default location of the file if not specified is build_spec.yaml.
        /// </value>
        [JsonProperty(PropertyName = "buildSpecFile")]
        public string BuildSpecFile { get; set; }
        
        /// <value>
        /// Timeout for the build stage execution. Specify value in seconds.
        /// </value>
        [JsonProperty(PropertyName = "stageExecutionTimeoutInSeconds")]
        public System.Nullable<int> StageExecutionTimeoutInSeconds { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BuildSourceCollection is required.")]
        [JsonProperty(PropertyName = "buildSourceCollection")]
        public BuildSourceCollection BuildSourceCollection { get; set; }
        
        /// <value>
        /// Name of the build source where the build_spec.yml file is located. If not specified, then the first entry in the build source collection is chosen as primary build source.
        /// </value>
        [JsonProperty(PropertyName = "primaryBuildSource")]
        public string PrimaryBuildSource { get; set; }
        
        [JsonProperty(PropertyName = "buildRunnerShapeConfig")]
        public BuildRunnerShapeConfig BuildRunnerShapeConfig { get; set; }
        
        [JsonProperty(PropertyName = "privateAccessConfig")]
        public NetworkChannel PrivateAccessConfig { get; set; }
        
        [JsonProperty(PropertyName = "buildPipelineStageType")]
        private readonly string buildPipelineStageType = "BUILD";
    }
}
