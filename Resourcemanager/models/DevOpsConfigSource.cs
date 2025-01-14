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
    /// Metadata about the [DevOps](https://docs.cloud.oracle.com/iaas/Content/devops/using/home.htm) configuration source.
    /// 
    /// </summary>
    public class DevOpsConfigSource : ConfigSource
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the {@link Project}.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProjectId is required.")]
        [JsonProperty(PropertyName = "projectId")]
        public string ProjectId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the {@link Repository}.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RepositoryId is required.")]
        [JsonProperty(PropertyName = "repositoryId")]
        public string RepositoryId { get; set; }
        
        /// <value>
        /// The name of the branch that contains the Terraform configuration.
        /// </value>
        [JsonProperty(PropertyName = "branchName")]
        public string BranchName { get; set; }
        
        [JsonProperty(PropertyName = "configSourceType")]
        private readonly string configSourceType = "DEVOPS_CONFIG_SOURCE";
    }
}
