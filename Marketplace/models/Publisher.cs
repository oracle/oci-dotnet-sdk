/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
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
    /// The model for a publisher.
    /// </summary>
    public class Publisher 
    {
        
        /// <value>
        /// Unique identifier for the publisher.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The name of the publisher.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// A description of the publisher.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The year the publisher's company or organization was founded.
        /// </value>
        [JsonProperty(PropertyName = "yearFounded")]
        public System.Nullable<long> YearFounded { get; set; }
        
        /// <value>
        /// The publisher's website.
        /// </value>
        [JsonProperty(PropertyName = "websiteUrl")]
        public string WebsiteUrl { get; set; }
        
        /// <value>
        /// The email address of the publisher.
        /// </value>
        [JsonProperty(PropertyName = "contactEmail")]
        public string ContactEmail { get; set; }
        
        /// <value>
        /// The phone number of the publisher.
        /// </value>
        [JsonProperty(PropertyName = "contactPhone")]
        public string ContactPhone { get; set; }
        
        /// <value>
        /// The address of the publisher's headquarters.
        /// </value>
        [JsonProperty(PropertyName = "hqAddress")]
        public string HqAddress { get; set; }
        
        [JsonProperty(PropertyName = "logo")]
        public UploadData Logo { get; set; }
        
        /// <value>
        /// Reference links.
        /// </value>
        [JsonProperty(PropertyName = "links")]
        public System.Collections.Generic.List<Link> Links { get; set; }
        
    }
}
