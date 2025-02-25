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
    /// Provides a list of packages to be removed from the software source.
    /// </summary>
    public class RemovePackagesFromSoftwareSourceDetails 
    {
        
        /// <value>
        /// List of packages specified by the name of the package (N) or the full package name (NVRA or NEVRA).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Packages is required.")]
        [JsonProperty(PropertyName = "packages")]
        public System.Collections.Generic.List<string> Packages { get; set; }
        
    }
}
