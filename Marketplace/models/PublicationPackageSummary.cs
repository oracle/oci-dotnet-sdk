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


namespace Oci.MarketplaceService.Models
{
    /// <summary>
    /// The model for a summary of a publication package.
    /// </summary>
    public class PublicationPackageSummary 
    {
        
        /// <value>
        /// The ID of the listing that the specified package belongs to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ListingId is required.")]
        [JsonProperty(PropertyName = "listingId")]
        public string ListingId { get; set; }
        
        /// <value>
        /// The version of the specified package.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PackageVersion is required.")]
        [JsonProperty(PropertyName = "packageVersion")]
        public string PackageVersion { get; set; }
        
        /// <value>
        /// The specified package's type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PackageType is required.")]
        [JsonProperty(PropertyName = "packageType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PackageTypeEnum> PackageType { get; set; }
        
        /// <value>
        /// The unique identifier for the package resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceId is required.")]
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
        
        /// <value>
        /// The date and time the publication package was created, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339)
        /// timestamp format.
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
    }
}
