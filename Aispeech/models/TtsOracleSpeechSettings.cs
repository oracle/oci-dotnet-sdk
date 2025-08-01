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
    /// Settings to use for generating speech with a model from ORACLE family.
    /// </summary>
    public class TtsOracleSpeechSettings 
    {
                ///
        /// <value>
        /// The format in which the input text has been supplied i.e., Text or SSML. The supported text types are:
        /// - TEXT
        /// - SSML : This is only supported for en-US language.
        /// 
        /// </value>
        ///
        public enum TextTypeEnum {
            [EnumMember(Value = "TEXT")]
            Text,
            [EnumMember(Value = "SSML")]
            Ssml
        };

        /// <value>
        /// The format in which the input text has been supplied i.e., Text or SSML. The supported text types are:
        /// - TEXT
        /// - SSML : This is only supported for en-US language.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "textType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TextTypeEnum> TextType { get; set; }
        
        /// <value>
        /// The sample rate of the generated audio. By default, the audio will be generated with speaker voice sample rate.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sampleRateInHz")]
        public System.Nullable<int> SampleRateInHz { get; set; }
                ///
        /// <value>
        /// The format of audio in which the user wants the audio to be in. The supported output formats are:
        /// - MP3
        /// - OGG
        /// - PCM
        /// - JSON
        /// 
        /// </value>
        ///
        public enum OutputFormatEnum {
            [EnumMember(Value = "MP3")]
            Mp3,
            [EnumMember(Value = "OGG")]
            Ogg,
            [EnumMember(Value = "PCM")]
            Pcm,
            [EnumMember(Value = "JSON")]
            Json
        };

        /// <value>
        /// The format of audio in which the user wants the audio to be in. The supported output formats are:
        /// - MP3
        /// - OGG
        /// - PCM
        /// - JSON
        /// 
        /// </value>
        [JsonProperty(PropertyName = "outputFormat")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OutputFormatEnum> OutputFormat { get; set; }
                ///
        ///
        public enum SpeechMarkTypesEnum {
            [EnumMember(Value = "SENTENCE")]
            Sentence,
            [EnumMember(Value = "WORD")]
            Word
        };

        /// <value>
        /// The kind of time stamp markings the user wants for the audio.
        /// This property should be provided if outputFormat is json, otherwise it will be ignored.
        /// null value (i.e. no value is not specified) indicates no speech marking.
        /// The supported speech mark types are:
        /// - SENTENCE
        /// - WORD
        /// 
        /// </value>
        [JsonProperty(PropertyName = "speechMarkTypes", ItemConverterType = typeof(StringEnumConverter))]
        public System.Collections.Generic.List<SpeechMarkTypesEnum> SpeechMarkTypes { get; set; }
        
    }
}
