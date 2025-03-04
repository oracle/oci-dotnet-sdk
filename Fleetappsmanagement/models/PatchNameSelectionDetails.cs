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


namespace Oci.FleetappsmanagementService.Models
{
    /// <summary>
    /// Patch Name Details.
    /// If you set the policy rule by selecting this option, provide a specific patch name.
    /// 
    /// </summary>
    public class PatchNameSelectionDetails : PatchSelectionDetails
    {
        
        /// <value>
        /// Patch Name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PatchName is required.")]
        [JsonProperty(PropertyName = "patchName")]
        public string PatchName { get; set; }
        
        [JsonProperty(PropertyName = "selectionType")]
        private readonly string selectionType = "PATCH_NAME";
    }
}
