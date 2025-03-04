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


namespace Oci.FleetsoftwareupdateService.Models
{
    /// <summary>
    /// Collection built from the results of a Succeeded Fleet Software Update Discovery resource.
    /// 
    /// </summary>
    public class GiDiscoveryResults : GiFleetDiscoveryDetails
    {
        
        /// <value>
        /// OCIDs of Fleet Software Update Discovery.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FsuDiscoveryId is required.")]
        [JsonProperty(PropertyName = "fsuDiscoveryId")]
        public string FsuDiscoveryId { get; set; }
        
        [JsonProperty(PropertyName = "strategy")]
        private readonly string strategy = "DISCOVERY_RESULTS";
    }
}
