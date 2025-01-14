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


namespace Oci.JmsjavadownloadsService.Models
{
    /// <summary>
    /// A summary of Java artifact download in a tenancy.
    /// </summary>
    public class JavaDownloadRecordSummary 
    {
        
        /// <value>
        /// The Java family version identifier.
        /// </value>
        [JsonProperty(PropertyName = "familyVersion")]
        public string FamilyVersion { get; set; }
        
        /// <value>
        /// The Java family display name.
        /// </value>
        [JsonProperty(PropertyName = "familyDisplayName")]
        public string FamilyDisplayName { get; set; }
        
        /// <value>
        /// The Java release version identifier.
        /// </value>
        [JsonProperty(PropertyName = "releaseVersion")]
        public string ReleaseVersion { get; set; }
        
        /// <value>
        /// The target Operating System family for the artifact.
        /// </value>
        [JsonProperty(PropertyName = "osFamily")]
        public string OsFamily { get; set; }
        
        /// <value>
        /// The target Operating System architecture for the artifact.
        /// </value>
        [JsonProperty(PropertyName = "architecture")]
        public string Architecture { get; set; }
        
        /// <value>
        /// The package type (typically the file extension) of the artifact.
        /// </value>
        [JsonProperty(PropertyName = "packageType")]
        public string PackageType { get; set; }
        
        /// <value>
        /// Additional information about the package type.
        /// </value>
        [JsonProperty(PropertyName = "packageTypeDetail")]
        public string PackageTypeDetail { get; set; }
        
        /// <value>
        /// Identifier of the source that downloaded the artifact.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DownloadSourceId is required.")]
        [JsonProperty(PropertyName = "downloadSourceId")]
        public string DownloadSourceId { get; set; }
        
        /// <value>
        /// Timestamp of download.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeDownloaded is required.")]
        [JsonProperty(PropertyName = "timeDownloaded")]
        public System.Nullable<System.DateTime> TimeDownloaded { get; set; }
        
        /// <value>
        /// Type of download.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DownloadType is required.")]
        [JsonProperty(PropertyName = "downloadType")]
        public string DownloadType { get; set; }
        
    }
}
