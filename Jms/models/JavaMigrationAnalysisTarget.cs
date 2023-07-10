/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
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
    /// The target describes the input data for Java migration analysis.
    /// A target contains a managed instance, application Installation Key, sourceJdkVersion, and targetJdkVersion.
    /// 
    /// </summary>
    public class JavaMigrationAnalysisTarget 
    {
        
        /// <value>
        /// The OCID of the managed instance that hosts the application for which the Java migration analysis was performed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ManagedInstanceId is required.")]
        [JsonProperty(PropertyName = "managedInstanceId")]
        public string ManagedInstanceId { get; set; }
        
        /// <value>
        /// The unique key that identifies the application's installation path that is to be used for the Java migration analysis.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ApplicationInstallationKey is required.")]
        [JsonProperty(PropertyName = "applicationInstallationKey")]
        public string ApplicationInstallationKey { get; set; }
        
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
        /// The JDK version against which the migration analysis was performed to identify effort required to move from source JDK.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetJdkVersion is required.")]
        [JsonProperty(PropertyName = "targetJdkVersion")]
        public string TargetJdkVersion { get; set; }
        
    }
}