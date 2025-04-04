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


namespace Oci.MarketplacepublisherService.Models
{
    /// <summary>
    /// The model for upload data for images and icons.
    /// </summary>
    public class UploadData 
    {
        
        /// <value>
        /// The name used to refer to the upload data.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The content URL of the upload data.
        /// </value>
        [JsonProperty(PropertyName = "contentUrl")]
        public string ContentUrl { get; set; }
        
        /// <value>
        /// The MIME type of the upload data.
        /// </value>
        [JsonProperty(PropertyName = "mimeType")]
        public string MimeType { get; set; }
        
    }
}
