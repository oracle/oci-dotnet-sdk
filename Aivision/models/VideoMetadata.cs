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


namespace Oci.AivisionService.Models
{
    /// <summary>
    /// Video information.
    /// </summary>
    public class VideoMetadata 
    {
        
        /// <value>
        /// Total number of frames.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FrameCount is required.")]
        [JsonProperty(PropertyName = "frameCount")]
        public System.Nullable<int> FrameCount { get; set; }
        
        /// <value>
        /// Video framerate.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FrameRate is required.")]
        [JsonProperty(PropertyName = "frameRate")]
        public System.Nullable<float> FrameRate { get; set; }
        
        /// <value>
        /// Width of each frame.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FrameWidth is required.")]
        [JsonProperty(PropertyName = "frameWidth")]
        public System.Nullable<int> FrameWidth { get; set; }
        
        /// <value>
        /// Height of each frame.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FrameHeight is required.")]
        [JsonProperty(PropertyName = "frameHeight")]
        public System.Nullable<int> FrameHeight { get; set; }
        
    }
}
