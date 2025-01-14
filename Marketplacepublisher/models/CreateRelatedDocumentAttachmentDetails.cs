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
    /// Create Details of the related document attachment.
    /// 
    /// </summary>
    public class CreateRelatedDocumentAttachmentDetails : CreateListingRevisionAttachmentDetails
    {
        
        /// <value>
        /// The document category of the listing revision attachment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DocumentCategory is required.")]
        [JsonProperty(PropertyName = "documentCategory")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RelatedDocumentAttachment.DocumentCategoryEnum> DocumentCategory { get; set; }
        
        [JsonProperty(PropertyName = "attachmentType")]
        private readonly string attachmentType = "RELATED_DOCUMENT";
    }
}
