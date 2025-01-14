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


namespace Oci.OsmanagementhubService.Models
{
    /// <summary>
    /// Provides summary information for a software package.
    /// </summary>
    public class SoftwarePackageSummary 
    {
        
        /// <value>
        /// Package name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Unique identifier for the package. Note that this is not an OCID.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Type of the package.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        
        /// <value>
        /// Version of the package.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Version is required.")]
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
        /// <value>
        /// The architecture for which this software was built.
        /// </value>
        [JsonProperty(PropertyName = "architecture")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SoftwarePackageArchitecture> Architecture { get; set; }
        
        /// <value>
        /// Checksum of the package.
        /// </value>
        [JsonProperty(PropertyName = "checksum")]
        public string Checksum { get; set; }
        
        /// <value>
        /// Type of the checksum.
        /// </value>
        [JsonProperty(PropertyName = "checksumType")]
        public string ChecksumType { get; set; }
        
        /// <value>
        /// Indicates whether this package is the latest version.
        /// </value>
        [JsonProperty(PropertyName = "isLatest")]
        public System.Nullable<bool> IsLatest { get; set; }
        
        /// <value>
        /// List of software sources that provide the software package. This property is deprecated and it will be removed in a future API release.
        /// </value>
        [JsonProperty(PropertyName = "softwareSources")]
        public System.Collections.Generic.List<SoftwareSourceDetails> SoftwareSources { get; set; }
        
        /// <value>
        /// The OS families the package belongs to.
        /// </value>
        [JsonProperty(PropertyName = "osFamilies")]
        public System.Collections.Generic.List<OsFamily> OsFamilies { get; set; }
        
    }
}
