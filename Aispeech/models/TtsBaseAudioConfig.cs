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
    /// Use this audio config for saving the audio response at specified path.
    /// </summary>
    public class TtsBaseAudioConfig : TtsAudioConfig
    {
        
        /// <value>
        /// Specify the path where you want to save the audio response.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SavePath is required.")]
        [JsonProperty(PropertyName = "savePath")]
        public string SavePath { get; set; }
        
        [JsonProperty(PropertyName = "configType")]
        private readonly string configType = "BASE_AUDIO_CONFIG";
    }
}
