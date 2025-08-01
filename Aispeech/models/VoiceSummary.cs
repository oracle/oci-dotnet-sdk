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
    /// Details related to the voice available for the given language code and voice type.
    /// </summary>
    public class VoiceSummary 
    {
        
        /// <value>
        /// Unique Id of the voice.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VoiceId is required.")]
        [JsonProperty(PropertyName = "voiceId")]
        public string VoiceId { get; set; }
        
        /// <value>
        /// A user-friendly display name of the language for the user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A small description of the voice like its language and voice type.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
                ///
        /// <value>
        /// Gender of the speaker.
        /// </value>
        ///
        public enum GenderEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "MALE")]
            Male,
            [EnumMember(Value = "FEMALE")]
            Female
        };

        /// <value>
        /// Gender of the speaker.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Gender is required.")]
        [JsonProperty(PropertyName = "gender")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<GenderEnum> Gender { get; set; }
        
        /// <value>
        /// Models the particular speaker is aligned to.
        /// </value>
        [JsonProperty(PropertyName = "supportedModels")]
        public System.Collections.Generic.List<string> SupportedModels { get; set; }
        
        /// <value>
        /// An abbreviated notation of region to which the language and accent of the speaker belongs to.
        /// </value>
        [JsonProperty(PropertyName = "languageCode")]
        public string LanguageCode { get; set; }
        
        /// <value>
        /// A description of region to which the language and accent of the speaker belongs to.
        /// </value>
        [JsonProperty(PropertyName = "languageDescription")]
        public string LanguageDescription { get; set; }
        
        /// <value>
        /// The sample rate of the speaker in Hertz.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SampleRateInHertz is required.")]
        [JsonProperty(PropertyName = "sampleRateInHertz")]
        public System.Nullable<int> SampleRateInHertz { get; set; }
        
        /// <value>
        /// The number of words the speaker can narrate per minute. It signifies the speed of the speech produced by the speaker.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WordsPerMinute is required.")]
        [JsonProperty(PropertyName = "wordsPerMinute")]
        public System.Nullable<int> WordsPerMinute { get; set; }
        
        /// <value>
        /// Whether this voice id is default voice used for inference.
        /// </value>
        [JsonProperty(PropertyName = "isDefaultVoice")]
        public System.Nullable<bool> IsDefaultVoice { get; set; }
        
    }
}
