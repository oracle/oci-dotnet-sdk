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
    /// Details to create a 'GI' type Exadata Fleet Update Collection.
    /// 
    /// </summary>
    public class GiCollection : FsuCollection
    {
        
        /// <value>
        /// Grid Infrastructure Major Version of targets to be included in the Exadata Fleet Update Collection.
        /// Only GI targets that match the version specified in this value would be added to the Exadata Fleet Update Collection.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceMajorVersion is required.")]
        [JsonProperty(PropertyName = "sourceMajorVersion")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<GiSourceMajorVersions> SourceMajorVersion { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FleetDiscovery is required.")]
        [JsonProperty(PropertyName = "fleetDiscovery")]
        public GiFleetDiscoveryDetails FleetDiscovery { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "GI";
    }
}
