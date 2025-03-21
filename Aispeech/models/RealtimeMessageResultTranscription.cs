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


namespace Oci.AispeechService.Models
{
    /// <summary>
    /// Transcription object.
    /// </summary>
    public class RealtimeMessageResultTranscription 
    {
        
        /// <value>
        /// Transcription text.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Transcription is required.")]
        [JsonProperty(PropertyName = "transcription")]
        public string Transcription { get; set; }
        
        /// <value>
        /// Whether the transcription is final or partial.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsFinal is required.")]
        [JsonProperty(PropertyName = "isFinal")]
        public System.Nullable<bool> IsFinal { get; set; }
        
        /// <value>
        /// Start time in milliseconds for the transcription text.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StartTimeInMs is required.")]
        [JsonProperty(PropertyName = "startTimeInMs")]
        public System.Nullable<int> StartTimeInMs { get; set; }
        
        /// <value>
        /// End time in milliseconds for the transcription text.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EndTimeInMs is required.")]
        [JsonProperty(PropertyName = "endTimeInMs")]
        public System.Nullable<int> EndTimeInMs { get; set; }
        
        /// <value>
        /// Confidence for the transcription text.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Confidence is required.")]
        [JsonProperty(PropertyName = "confidence")]
        public System.Nullable<float> Confidence { get; set; }
        
        /// <value>
        /// Trailing silence after the transcription text.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TrailingSilence is required.")]
        [JsonProperty(PropertyName = "trailingSilence")]
        public System.Nullable<int> TrailingSilence { get; set; }
        
        /// <value>
        /// Array of individual transcription tokens.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Tokens is required.")]
        [JsonProperty(PropertyName = "tokens")]
        public System.Collections.Generic.List<RealtimeMessageResultTranscriptionToken> Tokens { get; set; }
        
    }
}
