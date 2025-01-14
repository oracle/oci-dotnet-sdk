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


namespace Oci.AdmService.Models
{
    /// <summary>
    /// Extends a Verify configuration with appropriate data to reach and use the build service provided by a Jenkins Pipeline.
    /// </summary>
    public class JenkinsPipelineConfiguration : VerifyConfiguration
    {
        
        /// <value>
        /// The username that will be used to authenticate with Jenkins.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Username is required.")]
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        
        /// <value>
        /// The Oracle Cloud Identifier ([OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm)) of the Private Access Token (PAT) Secret.
        /// The PAT provides the credentials to access the Jenkins Pipeline.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PatSecretId is required.")]
        [JsonProperty(PropertyName = "patSecretId")]
        public string PatSecretId { get; set; }
        
        /// <value>
        /// The URL that locates the Jenkins pipeline.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "JenkinsUrl is required.")]
        [JsonProperty(PropertyName = "jenkinsUrl")]
        public string JenkinsUrl { get; set; }
        
        /// <value>
        /// The name of the Jenkins pipeline job that identifies the build pipeline.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "JobName is required.")]
        [JsonProperty(PropertyName = "jobName")]
        public string JobName { get; set; }
        
        /// <value>
        /// Additional key-value pairs passed as parameters to the build service when running an experiment.
        /// </value>
        [JsonProperty(PropertyName = "additionalParameters")]
        public System.Collections.Generic.Dictionary<string, string> AdditionalParameters { get; set; }
        
        [JsonProperty(PropertyName = "buildServiceType")]
        private readonly string buildServiceType = "JENKINS_PIPELINE";
    }
}
