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


namespace Oci.DblmService.Models
{
    /// <summary>
    /// The Resource Info.
    /// </summary>
    public class ResourceInfo 
    {
        
        /// <value>
        /// The compartmentId of the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceCompartmentId is required.")]
        [JsonProperty(PropertyName = "resourceCompartmentId")]
        public string ResourceCompartmentId { get; set; }
        
        /// <value>
        /// The name of the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceName is required.")]
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }
        
        /// <value>
        /// The Id of the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceId is required.")]
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
        
        /// <value>
        /// The type of the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceType is required.")]
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }
        
        /// <value>
        /// The deployment type of the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DeploymentType is required.")]
        [JsonProperty(PropertyName = "deploymentType")]
        public string DeploymentType { get; set; }
        
        /// <value>
        /// The connector Id of the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConnectorId is required.")]
        [JsonProperty(PropertyName = "connectorId")]
        public string ConnectorId { get; set; }
        
        /// <value>
        /// True if it is a cluster db.
        /// </value>
        [JsonProperty(PropertyName = "isClusterDb")]
        public System.Nullable<bool> IsClusterDb { get; set; }
        
        /// <value>
        /// host info objects
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HostInfo is required.")]
        [JsonProperty(PropertyName = "hostInfo")]
        public System.Collections.Generic.List<HostInfo> HostInfo { get; set; }
        
        /// <value>
        /// The version of the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbVersion is required.")]
        [JsonProperty(PropertyName = "dbVersion")]
        public string DbVersion { get; set; }
        
        /// <value>
        /// The platform type of the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbPlatformType is required.")]
        [JsonProperty(PropertyName = "dbPlatformType")]
        public string DbPlatformType { get; set; }
        
        /// <value>
        /// The License Type of the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LicenseType is required.")]
        [JsonProperty(PropertyName = "licenseType")]
        public string LicenseType { get; set; }
        
    }
}
