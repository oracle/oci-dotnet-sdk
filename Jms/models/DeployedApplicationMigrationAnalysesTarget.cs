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
    /// The target describes the input data for deployed Java migration analyses.
    /// A target contains a managed instance, deployed application installation Key, sourceJdkVersion, targetJdkVersion and optional excludePackagePrefixes.
    /// 
    /// </summary>
    public class DeployedApplicationMigrationAnalysesTarget 
    {
        
        /// <value>
        /// The OCID of the managed instance that hosts the application for which the Java migration analyses was performed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ManagedInstanceId is required.")]
        [JsonProperty(PropertyName = "managedInstanceId")]
        public string ManagedInstanceId { get; set; }
        
        /// <value>
        /// The unique key that identifies the deployed application's installation path that is to be used for the Java migration analyses.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DeployedApplicationInstallationKey is required.")]
        [JsonProperty(PropertyName = "deployedApplicationInstallationKey")]
        public string DeployedApplicationInstallationKey { get; set; }
        
        /// <value>
        /// The JDK version the application is currently running on.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceJdkVersion is required.")]
        [JsonProperty(PropertyName = "sourceJdkVersion")]
        public string SourceJdkVersion { get; set; }
        
        /// <value>
        /// The JDK version against which the migration analyses was performed to identify effort required to move from source JDK.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetJdkVersion is required.")]
        [JsonProperty(PropertyName = "targetJdkVersion")]
        public string TargetJdkVersion { get; set; }
        
        /// <value>
        /// Excludes the packages that starts with the prefix from the migration analyses result.
        /// </value>
        [JsonProperty(PropertyName = "excludePackagePrefixes")]
        public System.Collections.Generic.List<string> ExcludePackagePrefixes { get; set; }
        
    }
}
