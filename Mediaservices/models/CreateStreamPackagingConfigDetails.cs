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


namespace Oci.MediaservicesService.Models
{
    /// <summary>
    /// The information about the new Packaging Configuration.
    /// </summary>
    public class CreateStreamPackagingConfigDetails 
    {
        
        /// <value>
        /// Unique identifier of the Distribution Channel that this stream packaging configuration belongs to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DistributionChannelId is required.")]
        [JsonProperty(PropertyName = "distributionChannelId")]
        public string DistributionChannelId { get; set; }
        
        /// <value>
        /// The name of the stream Packaging Configuration. Avoid entering confidential information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
                ///
        /// <value>
        /// The output format for the package.
        /// </value>
        ///
        public enum StreamPackagingFormatEnum {
            [EnumMember(Value = "HLS")]
            Hls,
            [EnumMember(Value = "DASH")]
            Dash
        };

        /// <value>
        /// The output format for the package.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StreamPackagingFormat is required.")]
        [JsonProperty(PropertyName = "streamPackagingFormat")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<StreamPackagingFormatEnum> StreamPackagingFormat { get; set; }
        
        /// <value>
        /// The duration in seconds for each fragment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SegmentTimeInSeconds is required.")]
        [JsonProperty(PropertyName = "segmentTimeInSeconds")]
        public System.Nullable<int> SegmentTimeInSeconds { get; set; }
        
        [JsonProperty(PropertyName = "encryption")]
        public StreamPackagingConfigEncryption Encryption { get; set; }
        
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
