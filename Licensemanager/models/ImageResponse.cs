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


namespace Oci.LicensemanagerService.Models
{
    /// <summary>
    /// The collection of image details for the product license.
    /// </summary>
    public class ImageResponse 
    {
        
        /// <value>
        /// The image ID associated with the product license.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The listing name associated with the product license.
        /// </value>
        [JsonProperty(PropertyName = "listingName")]
        public string ListingName { get; set; }
        
        /// <value>
        /// The image publisher.
        /// </value>
        [JsonProperty(PropertyName = "publisher")]
        public string Publisher { get; set; }
        
        /// <value>
        /// The image listing ID.
        /// </value>
        [JsonProperty(PropertyName = "listingId")]
        public string ListingId { get; set; }
        
        /// <value>
        /// The image package version.
        /// </value>
        [JsonProperty(PropertyName = "packageVersion")]
        public string PackageVersion { get; set; }
        
    }
}
