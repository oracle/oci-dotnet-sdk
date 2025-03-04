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


namespace Oci.MediaservicesService.Models
{
    /// <summary>
    /// Summary of the MediaAssetDistributionChannelAttachment.
    /// </summary>
    public class MediaAssetDistributionChannelAttachmentSummary 
    {
        
        /// <value>
        /// OCID of associated media asset.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MediaAssetId is required.")]
        [JsonProperty(PropertyName = "mediaAssetId")]
        public string MediaAssetId { get; set; }
        
        /// <value>
        /// Display name for the MediaAssetDistributionChannelAttachment. Does not have to be unique, and it's changeable. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// OCID of associated Distribution Channel.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DistributionChannelId is required.")]
        [JsonProperty(PropertyName = "distributionChannelId")]
        public string DistributionChannelId { get; set; }
        
        /// <value>
        /// Version number of the attachment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Version is required.")]
        [JsonProperty(PropertyName = "version")]
        public System.Nullable<long> Version { get; set; }
        
        /// <value>
        /// Lifecycle state of the attachment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MediaAssetDistributionChannelAttachment.LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The identifier for the metadata.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MetadataRef is required.")]
        [JsonProperty(PropertyName = "metadataRef")]
        public string MetadataRef { get; set; }
        
        /// <value>
        /// The ingest MediaWorkflowJob ID that created this attachment.
        /// </value>
        [JsonProperty(PropertyName = "mediaWorkflowJobId")]
        public string MediaWorkflowJobId { get; set; }
        
        /// <value>
        /// Locks associated with this resource.
        /// </value>
        [JsonProperty(PropertyName = "locks")]
        public System.Collections.Generic.List<ResourceLock> Locks { get; set; }
        
    }
}
