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
    /// Provides the information used to apply filters to a vendor software source to create or update a custom software source.
    /// </summary>
    public class CustomSoftwareSourceFilter 
    {
        
        /// <value>
        /// The list of package filters.
        /// </value>
        [JsonProperty(PropertyName = "packageFilters")]
        public System.Collections.Generic.List<PackageFilter> PackageFilters { get; set; }
        
        /// <value>
        /// The list of module stream/profile filters.
        /// </value>
        [JsonProperty(PropertyName = "moduleStreamProfileFilters")]
        public System.Collections.Generic.List<ModuleStreamProfileFilter> ModuleStreamProfileFilters { get; set; }
        
        /// <value>
        /// The list of group filters.
        /// </value>
        [JsonProperty(PropertyName = "packageGroupFilters")]
        public System.Collections.Generic.List<PackageGroupFilter> PackageGroupFilters { get; set; }
        
    }
}
