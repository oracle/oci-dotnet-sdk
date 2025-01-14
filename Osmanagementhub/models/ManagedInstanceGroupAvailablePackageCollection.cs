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
    /// A set of available packages returned for the {@link #listManagedInstanceGroupAvailablePackages(ListManagedInstanceGroupAvailablePackagesRequest) listManagedInstanceGroupAvailablePackages} operation.
    /// </summary>
    public class ManagedInstanceGroupAvailablePackageCollection 
    {
        
        /// <value>
        /// List of available packages.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Items is required.")]
        [JsonProperty(PropertyName = "items")]
        public System.Collections.Generic.List<ManagedInstanceGroupAvailablePackageSummary> Items { get; set; }
        
    }
}
