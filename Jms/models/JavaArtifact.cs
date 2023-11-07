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
    /// Information about a binary artifact of Java.
    /// </summary>
    public class JavaArtifact 
    {
        
        /// <value>
        /// Unique identifier for the artifact.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ArtifactId is required.")]
        [JsonProperty(PropertyName = "artifactId")]
        public System.Nullable<long> ArtifactId { get; set; }
        
        /// <value>
        /// Description of the binary artifact. Typically includes the OS, architecture, and installer type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ArtifactDescription is required.")]
        [JsonProperty(PropertyName = "artifactDescription")]
        public string ArtifactDescription { get; set; }
        
        /// <value>
        /// Product content type of this artifact.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ArtifactContentType is required.")]
        [JsonProperty(PropertyName = "artifactContentType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ArtifactContentType> ArtifactContentType { get; set; }
        
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
        /// SHA256 checksum of the artifact.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Sha256 is required.")]
        [JsonProperty(PropertyName = "sha256")]
        public string Sha256 { get; set; }
        
        /// <value>
        /// The file name of the artifact.
        /// </value>
        [JsonProperty(PropertyName = "artifactFileName")]
        public string ArtifactFileName { get; set; }
        
        /// <value>
        /// The target Operating System family for the artifact.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OsFamily is required.")]
        [JsonProperty(PropertyName = "osFamily")]
        public string OsFamily { get; set; }
        
        /// <value>
        /// The target Operating System architecture for the artifact.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Architecture is required.")]
        [JsonProperty(PropertyName = "architecture")]
        public string Architecture { get; set; }
        
        /// <value>
        /// The package type(typically the file extension) of the artifact.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PackageType is required.")]
        [JsonProperty(PropertyName = "packageType")]
        public string PackageType { get; set; }
        
        /// <value>
        /// Additional information about the package type.
        /// </value>
        [JsonProperty(PropertyName = "packageTypeDetail")]
        public string PackageTypeDetail { get; set; }
        
        /// <value>
        /// The endpoint that returns a short-lived artifact download URL in the response payload.
        /// This download url can then be used for downloading the artifact.
        /// See this [API](https://docs.oracle.com/en-us/iaas/api/#/en/jms/20230601/JavaArtifact/GenerateArtifactDownloadUrl) for more details.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DownloadUrl is required.")]
        [JsonProperty(PropertyName = "downloadUrl")]
        public string DownloadUrl { get; set; }
        
        /// <value>
        /// The endpoint for downloading this artifact from command line, automatically in scripts and dockerfiles.
        /// Depending on the context, this can point to the archive or latest update release version artifact in the specified family.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ScriptDownloadUrl is required.")]
        [JsonProperty(PropertyName = "scriptDownloadUrl")]
        public string ScriptDownloadUrl { get; set; }
        
        /// <value>
        /// The URL for retrieving the checksum for the artifact.
        /// Depending on the context, this can point to the checksum of the archive or latest update release version artifact.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ScriptChecksumUrl is required.")]
        [JsonProperty(PropertyName = "scriptChecksumUrl")]
        public string ScriptChecksumUrl { get; set; }
        
    }
}
