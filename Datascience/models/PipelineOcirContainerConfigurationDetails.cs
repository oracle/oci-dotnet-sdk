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
    /// Container configuration based on image stored in OCI Container Registry.
    /// </summary>
    public class PipelineOcirContainerConfigurationDetails : PipelineContainerConfigurationDetails
    {
        
        /// <value>
        /// The full path to the Oracle Container Repository (OCIR) registry, image, and tag in a canonical format.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Image is required.")]
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }
        
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
        /// The digest of the container image. For example,
        /// `sha256:881303a6b2738834d795a32b4a98eb0e5e3d1cad590a712d1e04f9b2fa90a030`
        /// 
        /// </value>
        [JsonProperty(PropertyName = "imageDigest")]
        public string ImageDigest { get; set; }
        
        /// <value>
        /// OCID of the container image signature
        /// </value>
        [JsonProperty(PropertyName = "imageSignatureId")]
        public string ImageSignatureId { get; set; }
        
        [JsonProperty(PropertyName = "containerType")]
        private readonly string containerType = "OCIR_CONTAINER";
    }
}
