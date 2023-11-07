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
    /// Metadata associated with a specific Java release family.
    /// A Java release family is typically a major version in the Java version identifier.
    /// 
    /// </summary>
    public class JavaFamily 
    {
        
        /// <value>
        /// List of artifacts for the latest Java release version in this family.
        /// The script URLs in the response can be used from a command line, or in scripts and dockerfiles to always get the artifacts corresponding to the latest update release version.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "latestReleaseArtifacts")]
        public System.Collections.Generic.List<JavaArtifact> LatestReleaseArtifacts { get; set; }
        
        /// <value>
        /// The Java release family identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FamilyVersion is required.")]
        [JsonProperty(PropertyName = "familyVersion")]
        public string FamilyVersion { get; set; }
        
        /// <value>
        /// The display name of the release family.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// This indicates the support category for the Java release family.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SupportType is required.")]
        [JsonProperty(PropertyName = "supportType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SupportType> SupportType { get; set; }
        
        /// <value>
        /// The End of Support Life (EOSL) date of the Java release family (formatted according to [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339)).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EndOfSupportLifeDate is required.")]
        [JsonProperty(PropertyName = "endOfSupportLifeDate")]
        public System.Nullable<System.DateTime> EndOfSupportLifeDate { get; set; }
        
        /// <value>
        /// Link to access the documentation for the release.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DocUrl is required.")]
        [JsonProperty(PropertyName = "docUrl")]
        public string DocUrl { get; set; }
        
        /// <value>
        /// Latest Java release version in the family.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LatestReleaseVersion is required.")]
        [JsonProperty(PropertyName = "latestReleaseVersion")]
        public string LatestReleaseVersion { get; set; }
        
        /// <value>
        /// Whether or not this Java release family is under active support.
        /// Refer [Java Support Roadmap](https://www.oracle.com/java/technologies/java-se-support-roadmap.html) for more details.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsSupportedVersion is required.")]
        [JsonProperty(PropertyName = "isSupportedVersion")]
        public System.Nullable<bool> IsSupportedVersion { get; set; }
        
    }
}
