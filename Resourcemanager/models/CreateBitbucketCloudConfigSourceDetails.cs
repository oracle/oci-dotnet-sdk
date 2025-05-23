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


namespace Oci.ResourcemanagerService.Models
{
    /// <summary>
    /// Creation details for a Bitbucket Cloud configuration source.
    /// 
    /// </summary>
    public class CreateBitbucketCloudConfigSourceDetails : CreateConfigSourceDetails
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the Bitbucket Cloud configuration source.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConfigurationSourceProviderId is required.")]
        [JsonProperty(PropertyName = "configurationSourceProviderId")]
        public string ConfigurationSourceProviderId { get; set; }
        
        /// <value>
        /// The URL of the Bitbucket Cloud repository for the configuration source.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RepositoryUrl is required.")]
        [JsonProperty(PropertyName = "repositoryUrl")]
        public string RepositoryUrl { get; set; }
        
        /// <value>
        /// The name of the branch in the Bitbucket Cloud repository for the configuration source.
        /// </value>
        [JsonProperty(PropertyName = "branchName")]
        public string BranchName { get; set; }
        
        /// <value>
        /// The id of the workspace in Bitbucket Cloud for the configuration source
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WorkspaceId is required.")]
        [JsonProperty(PropertyName = "workspaceId")]
        public string WorkspaceId { get; set; }
        
        [JsonProperty(PropertyName = "configSourceType")]
        private readonly string configSourceType = "BITBUCKET_CLOUD_CONFIG_SOURCE";
    }
}
