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


namespace Oci.AivisionService.Models
{
    /// <summary>
    /// A segment of a tracked object in a video.
    /// </summary>
    public class VideoTrackedObjectSegment 
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VideoSegment is required.")]
        [JsonProperty(PropertyName = "videoSegment")]
        public VideoSegment VideoSegment { get; set; }
        
        /// <value>
        /// The confidence score, between 0 and 1.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Confidence is required.")]
        [JsonProperty(PropertyName = "confidence")]
        public System.Nullable<float> Confidence { get; set; }
        
        /// <value>
        /// Frames within the segment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Frames is required.")]
        [JsonProperty(PropertyName = "frames")]
        public System.Collections.Generic.List<VideoTrackingFrame> Frames { get; set; }
        
    }
}
