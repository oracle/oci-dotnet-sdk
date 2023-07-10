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


namespace Oci.OsmanagementhubService.Models
{
    /// <summary>
    /// Used to select packages from VendorSoftwareSources to create/update CustomSoftwareSources.
    /// </summary>
    public class PackageFilter 
    {
        
        /// <value>
        /// The package name.
        /// </value>
        [JsonProperty(PropertyName = "packageName")]
        public string PackageName { get; set; }
        
        /// <value>
        /// The package name pattern.
        /// </value>
        [JsonProperty(PropertyName = "packageNamePattern")]
        public string PackageNamePattern { get; set; }
        
        /// <value>
        /// The package version, which is denoted by 'version-release', or 'epoch:version-release'.
        /// </value>
        [JsonProperty(PropertyName = "packageVersion")]
        public string PackageVersion { get; set; }
        
        /// <value>
        /// The type of the filter, which can be of two types - INCLUDE or EXCLUDE.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FilterType is required.")]
        [JsonProperty(PropertyName = "filterType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<FilterType> FilterType { get; set; }
        
    }
}