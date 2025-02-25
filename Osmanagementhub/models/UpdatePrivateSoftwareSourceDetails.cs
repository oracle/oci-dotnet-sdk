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
    /// Provides the information used to update a private software source.
    /// </summary>
    public class UpdatePrivateSoftwareSourceDetails : UpdateSoftwareSourceDetails
    {
        
        /// <value>
        /// URL for the private software source.
        /// </value>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        
        /// <value>
        /// URI of the GPG key for this software source.
        /// </value>
        [JsonProperty(PropertyName = "gpgKeyUrl")]
        public string GpgKeyUrl { get; set; }
        
        /// <value>
        /// Whether signature verification should be done for the software source.
        /// </value>
        [JsonProperty(PropertyName = "isGpgCheckEnabled")]
        public System.Nullable<bool> IsGpgCheckEnabled { get; set; }
        
        /// <value>
        /// Whether SSL validation needs to be turned on
        /// </value>
        [JsonProperty(PropertyName = "isSslVerifyEnabled")]
        public System.Nullable<bool> IsSslVerifyEnabled { get; set; }
        
        /// <value>
        /// Advanced repository options for the software source
        /// </value>
        [JsonProperty(PropertyName = "advancedRepoOptions")]
        public string AdvancedRepoOptions { get; set; }
        
        /// <value>
        /// Whether this software source can be synced to a management station
        /// </value>
        [JsonProperty(PropertyName = "isMirrorSyncAllowed")]
        public System.Nullable<bool> IsMirrorSyncAllowed { get; set; }
        
        [JsonProperty(PropertyName = "softwareSourceType")]
        private readonly string softwareSourceType = "PRIVATE";
    }
}
