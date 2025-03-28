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


namespace Oci.JmsService.Models
{
    /// <summary>
    /// Supported agent installer downloads.
    /// 
    /// </summary>
    public class AgentInstallerSummary 
    {
        
        /// <value>
        /// Unique identifier for the agent installer.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AgentInstallerId is required.")]
        [JsonProperty(PropertyName = "agentInstallerId")]
        public System.Nullable<long> AgentInstallerId { get; set; }
        
        /// <value>
        /// Description of the agent installer artifact. The description typically includes the OS, architecture, and agent installer type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AgentInstallerDescription is required.")]
        [JsonProperty(PropertyName = "agentInstallerDescription")]
        public string AgentInstallerDescription { get; set; }
        
        /// <value>
        /// Approximate compressed file size in bytes.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ApproximateFileSizeInBytes is required.")]
        [JsonProperty(PropertyName = "approximateFileSizeInBytes")]
        public System.Nullable<long> ApproximateFileSizeInBytes { get; set; }
        
        /// <value>
        /// SHA256 checksum of the agent installer.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Sha256 is required.")]
        [JsonProperty(PropertyName = "sha256")]
        public string Sha256 { get; set; }
        
        /// <value>
        /// The target operating system family for the agent installer.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OsFamily is required.")]
        [JsonProperty(PropertyName = "osFamily")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OsFamily> OsFamily { get; set; }
        
        /// <value>
        /// The target operating system architecture for the installer.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PlatformArchitecture is required.")]
        [JsonProperty(PropertyName = "platformArchitecture")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PlatformArchitectureType> PlatformArchitecture { get; set; }
        
        /// <value>
        /// The package type (typically the file extension) of the agent software included in the installer.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PackageType is required.")]
        [JsonProperty(PropertyName = "packageType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PackageType> PackageType { get; set; }
        
        /// <value>
        /// Agent image version.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AgentVersion is required.")]
        [JsonProperty(PropertyName = "agentVersion")]
        public string AgentVersion { get; set; }
        
        /// <value>
        /// Java version.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "JavaVersion is required.")]
        [JsonProperty(PropertyName = "javaVersion")]
        public string JavaVersion { get; set; }
        
        /// <value>
        /// Agent installer version.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AgentInstallerVersion is required.")]
        [JsonProperty(PropertyName = "agentInstallerVersion")]
        public string AgentInstallerVersion { get; set; }
        
    }
}
