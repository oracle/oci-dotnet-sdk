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
    /// The update environment configuration details object for OCI Registry
    /// </summary>
    public class UpdateOcirModelDeploymentEnvironmentConfigurationDetails : UpdateModelDeploymentEnvironmentConfigurationDetails
    {
        
        /// <value>
        /// The full path to the Oracle Container Repository (OCIR) registry, image, and tag in a canonical format.
        /// Acceptable format:
        /// `<region>.ocir.io/<registry>/<image>:<tag>`
        /// `<region>.ocir.io/<registry>/<image>:<tag>@digest`
        /// 
        /// </value>
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }
        
        /// <value>
        /// The digest of the container image. For example,
        /// `sha256:881303a6b2738834d795a32b4a98eb0e5e3d1cad590a712d1e04f9b2fa90a030`
        /// 
        /// </value>
        [JsonProperty(PropertyName = "imageDigest")]
        public string ImageDigest { get; set; }
        
        /// <value>
        /// The container image run [CMD](https://docs.docker.com/engine/reference/builder/#cmd) as a list of strings.
        /// Use `CMD` as arguments to the `ENTRYPOINT` or the only command to run in the absence of an `ENTRYPOINT`.
        /// The combined size of `CMD` and `ENTRYPOINT` must be less than 2048 bytes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "cmd")]
        public System.Collections.Generic.List<string> Cmd { get; set; }
        
        /// <value>
        /// The container image run [ENTRYPOINT](https://docs.docker.com/engine/reference/builder/#entrypoint) as a list of strings.
        /// Accept the `CMD` as extra arguments.
        /// The combined size of `CMD` and `ENTRYPOINT` must be less than 2048 bytes.
        /// More information on how `CMD` and `ENTRYPOINT` interact are [here](https://docs.docker.com/engine/reference/builder/#understand-how-cmd-and-entrypoint-interact).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "entrypoint")]
        public System.Collections.Generic.List<string> Entrypoint { get; set; }
        
        /// <value>
        /// The port on which the web server serving the inference is running.
        /// The port can be anything between `1024` and `65535`. The following ports cannot be used `24224`, `8446`, `8447`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "serverPort")]
        public System.Nullable<int> ServerPort { get; set; }
        
        /// <value>
        /// The port on which the container [HEALTHCHECK](https://docs.docker.com/engine/reference/builder/#healthcheck) would listen.
        /// The port can be anything between `1024` and `65535`. The following ports cannot be used `24224`, `8446`, `8447`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "healthCheckPort")]
        public System.Nullable<int> HealthCheckPort { get; set; }
        
        /// <value>
        /// Environment variables to set for the web server container.
        /// The size of envVars must be less than 2048 bytes.
        /// Key should be under 32 characters.
        /// Key should contain only letters, digits and underscore (_)
        /// Key should start with a letter.
        /// Key should have at least 2 characters.
        /// Key should not end with underscore eg. `TEST_`
        /// Key if added cannot be empty. Value can be empty.
        /// No specific size limits on individual Values. But overall environment variables is limited to 2048 bytes.
        /// Key can't be reserved Model Deployment environment variables.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "environmentVariables")]
        public System.Collections.Generic.Dictionary<string, string> EnvironmentVariables { get; set; }
        
        [JsonProperty(PropertyName = "environmentConfigurationType")]
        private readonly string environmentConfigurationType = "OCIR_CONTAINER";
    }
}
