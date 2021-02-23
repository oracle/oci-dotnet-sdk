/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.ArtifactsService.Models
{
    /// <summary>
    /// Create container repository details.
    /// </summary>
    public class CreateContainerRepositoryDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment in which to create the resource.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The container repository name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Whether the repository is immutable. Images cannot be overwritten in an immutable repository.
        /// </value>
        [JsonProperty(PropertyName = "isImmutable")]
        public System.Nullable<bool> IsImmutable { get; set; }
        
        /// <value>
        /// Whether the repository is public. A public repository allows unauthenticated access.
        /// </value>
        [JsonProperty(PropertyName = "isPublic")]
        public System.Nullable<bool> IsPublic { get; set; }
        
        [JsonProperty(PropertyName = "readme")]
        public ContainerRepositoryReadme Readme { get; set; }
        
    }
}
