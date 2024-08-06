/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
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
    /// The object that defines a versioned custom software source.
    /// </summary>
    public class VersionedCustomSoftwareSource : SoftwareSource
    {
        
        /// <value>
        /// List of vendor software sources that are used for the basis of the versioned custom software source.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VendorSoftwareSources is required.")]
        [JsonProperty(PropertyName = "vendorSoftwareSources")]
        public System.Collections.Generic.List<Id> VendorSoftwareSources { get; set; }
        
        [JsonProperty(PropertyName = "customSoftwareSourceFilter")]
        public CustomSoftwareSourceFilter CustomSoftwareSourceFilter { get; set; }
        
        /// <value>
        /// The version to assign to this custom software source.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SoftwareSourceVersion is required.")]
        [JsonProperty(PropertyName = "softwareSourceVersion")]
        public string SoftwareSourceVersion { get; set; }
        
        /// <value>
        /// Indicates whether the service should automatically resolve package dependencies when including specific packages in the software source.
        /// </value>
        [JsonProperty(PropertyName = "isAutoResolveDependencies")]
        public System.Nullable<bool> IsAutoResolveDependencies { get; set; }
        
        /// <value>
        /// Indicates whether the service should create the software source from a list of packages provided by the user.
        /// </value>
        [JsonProperty(PropertyName = "isCreatedFromPackageList")]
        public System.Nullable<bool> IsCreatedFromPackageList { get; set; }
        
        /// <value>
        /// Indicates whether the software source will include only the latest versions of content from vendor software sources, while accounting for other constraints set in the custom or versioned custom software source (such as a package list or filters).
        /// * For a module filter that does not specify a stream, this will include all available streams, and within each stream only the latest version of packages.
        /// * For a module filter that does specify a stream, this will include only the latest version of packages for the specified stream.
        /// * For a package filter that does not specify a version, this will include only the latest available version of the package.
        /// * For a package filter that does specify a version, this will include only the specified version of the package (the isLatestContentOnly attribute is ignored).
        /// * For a package list, this will include only the specified version of packages and modules in the list (the isLatestContentOnly attribute is ignored).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isLatestContentOnly")]
        public System.Nullable<bool> IsLatestContentOnly { get; set; }
        
        /// <value>
        /// The packages in the software source.
        /// </value>
        [JsonProperty(PropertyName = "packages")]
        public System.Collections.Generic.List<string> Packages { get; set; }
        
        [JsonProperty(PropertyName = "softwareSourceType")]
        private readonly string softwareSourceType = "VERSIONED";
    }
}
