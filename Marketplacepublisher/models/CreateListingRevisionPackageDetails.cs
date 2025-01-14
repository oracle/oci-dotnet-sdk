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


namespace Oci.MarketplacepublisherService.Models
{
    /// <summary>
    /// The model for an Oracle Cloud Infrastructure Marketplace Publisher listing revision package.
    /// </summary>
    public class CreateListingRevisionPackageDetails 
    {
        
        /// <value>
        /// The OCID for the listing revision in Marketplace Publisher.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ListingRevisionId is required.")]
        [JsonProperty(PropertyName = "listingRevisionId")]
        public string ListingRevisionId { get; set; }
        
        /// <value>
        /// The version for the package.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PackageVersion is required.")]
        [JsonProperty(PropertyName = "packageVersion")]
        public string PackageVersion { get; set; }
        
        /// <value>
        /// The name for the listing revision package.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Description for this package.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The unique identifier for the artifact.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ArtifactId is required.")]
        [JsonProperty(PropertyName = "artifactId")]
        public string ArtifactId { get; set; }
        
        /// <value>
        /// The unique identifier for the term.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TermId is required.")]
        [JsonProperty(PropertyName = "termId")]
        public string TermId { get; set; }
        
        /// <value>
        /// Identifies that this will be default package for the listing revision.
        /// </value>
        [JsonProperty(PropertyName = "isDefault")]
        public System.Nullable<bool> IsDefault { get; set; }
        
        /// <value>
        /// Identifies whether security upgrades will be provided for this package.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AreSecurityUpgradesProvided is required.")]
        [JsonProperty(PropertyName = "areSecurityUpgradesProvided")]
        public System.Nullable<bool> AreSecurityUpgradesProvided { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
