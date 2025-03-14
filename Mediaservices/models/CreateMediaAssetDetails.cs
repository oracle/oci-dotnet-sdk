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
    /// The information about new MediaAsset.
    /// </summary>
    public class CreateMediaAssetDetails 
    {
        
        /// <value>
        /// The ID of the MediaWorkflow used to produce this asset.
        /// </value>
        [JsonProperty(PropertyName = "sourceMediaWorkflowId")]
        public string SourceMediaWorkflowId { get; set; }
        
        /// <value>
        /// The ID of the MediaWorkflowJob used to produce this asset.
        /// </value>
        [JsonProperty(PropertyName = "mediaWorkflowJobId")]
        public string MediaWorkflowJobId { get; set; }
        
        /// <value>
        /// The version of the MediaWorkflow used to produce this asset.
        /// </value>
        [JsonProperty(PropertyName = "sourceMediaWorkflowVersion")]
        public System.Nullable<long> SourceMediaWorkflowVersion { get; set; }
        
        /// <value>
        /// Display name for the Media Asset. Does not have to be unique. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Compartment Identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The type of the media asset.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AssetType> Type { get; set; }
        
        /// <value>
        /// The ID of the parent asset from which this asset is derived.
        /// </value>
        [JsonProperty(PropertyName = "parentMediaAssetId")]
        public string ParentMediaAssetId { get; set; }
        
        /// <value>
        /// The ID of the senior most asset from which this asset is derived.
        /// </value>
        [JsonProperty(PropertyName = "masterMediaAssetId")]
        public string MasterMediaAssetId { get; set; }
        
        /// <value>
        /// The name of the object storage bucket where this asset is located.
        /// </value>
        [JsonProperty(PropertyName = "bucketName")]
        public string BucketName { get; set; }
        
        /// <value>
        /// The object storage namespace where this asset is located.
        /// </value>
        [JsonProperty(PropertyName = "namespaceName")]
        public string NamespaceName { get; set; }
        
        /// <value>
        /// The object storage object name that identifies this asset.
        /// </value>
        [JsonProperty(PropertyName = "objectName")]
        public string ObjectName { get; set; }
        
        /// <value>
        /// eTag of the underlying object storage object.
        /// </value>
        [JsonProperty(PropertyName = "objectEtag")]
        public string ObjectEtag { get; set; }
        
        /// <value>
        /// List of Metadata.
        /// </value>
        [JsonProperty(PropertyName = "metadata")]
        public System.Collections.Generic.List<Metadata> Metadata { get; set; }
        
        /// <value>
        /// The start index for video segment files.
        /// </value>
        [JsonProperty(PropertyName = "segmentRangeStartIndex")]
        public System.Nullable<long> SegmentRangeStartIndex { get; set; }
        
        /// <value>
        /// The end index for video segment files.
        /// </value>
        [JsonProperty(PropertyName = "segmentRangeEndIndex")]
        public System.Nullable<long> SegmentRangeEndIndex { get; set; }
        
        /// <value>
        /// list of tags for the MediaAsset.
        /// </value>
        [JsonProperty(PropertyName = "mediaAssetTags")]
        public System.Collections.Generic.List<MediaAssetTag> MediaAssetTags { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Locks associated with this resource.
        /// </value>
        [JsonProperty(PropertyName = "locks")]
        public System.Collections.Generic.List<ResourceLock> Locks { get; set; }
        
    }
}
