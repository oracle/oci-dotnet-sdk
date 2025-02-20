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
    /// Profanity transcription filter to recognize profane words.
    /// </summary>
    public class ProfanityTranscriptionFilter : TranscriptionFilter
    {
                ///
        /// <value>
        /// - `MASK`: Will mask detected profanity in transcription.
        /// - `REMOVE`: Will replace profane word with * in transcription.
        /// - `TAG`: Will tag profane word as profanity but will show actual word.
        /// 
        /// </value>
        ///
        public enum ModeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "MASK")]
            Mask,
            [EnumMember(Value = "REMOVE")]
            Remove,
            [EnumMember(Value = "TAG")]
            Tag
        };

        /// <value>
        /// - `MASK`: Will mask detected profanity in transcription.
        /// - `REMOVE`: Will replace profane word with * in transcription.
        /// - `TAG`: Will tag profane word as profanity but will show actual word.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Mode is required.")]
        [JsonProperty(PropertyName = "mode")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ModeEnum> Mode { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "PROFANITY";
    }
}
