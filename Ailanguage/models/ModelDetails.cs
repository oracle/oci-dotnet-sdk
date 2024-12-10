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
using Newtonsoft.Json.Linq;

namespace Oci.AilanguageService.Models
{
    /// <summary>
    /// Possible model types
    /// </summary>
    [JsonConverter(typeof(ModelDetailsModelConverter))]
    public class ModelDetails 
    {
        
        /// <value>
        /// supported language default value is en
        /// </value>
        [JsonProperty(PropertyName = "languageCode")]
        public string LanguageCode { get; set; }
                ///
        /// <value>
        /// Model type
        /// </value>
        ///
        public enum ModelTypeEnum {
            [EnumMember(Value = "NAMED_ENTITY_RECOGNITION")]
            NamedEntityRecognition,
            [EnumMember(Value = "TEXT_CLASSIFICATION")]
            TextClassification,
            [EnumMember(Value = "PRE_TRAINED_NAMED_ENTITY_RECOGNITION")]
            PreTrainedNamedEntityRecognition,
            [EnumMember(Value = "PRE_TRAINED_TEXT_CLASSIFICATION")]
            PreTrainedTextClassification,
            [EnumMember(Value = "PRE_TRAINED_SENTIMENT_ANALYSIS")]
            PreTrainedSentimentAnalysis,
            [EnumMember(Value = "PRE_TRAINED_KEYPHRASE_EXTRACTION")]
            PreTrainedKeyphraseExtraction,
            [EnumMember(Value = "PRE_TRAINED_LANGUAGE_DETECTION")]
            PreTrainedLanguageDetection,
            [EnumMember(Value = "PRE_TRAINED_PII")]
            PreTrainedPii,
            [EnumMember(Value = "PRE_TRAINED_HEALTH_NLU")]
            PreTrainedHealthNlu,
            [EnumMember(Value = "PRE_TRAINED_SUMMARIZATION")]
            PreTrainedSummarization,
            [EnumMember(Value = "PRE_TRAINED_UNIVERSAL")]
            PreTrainedUniversal,
            [EnumMember(Value = "PII")]
            Pii,
            [EnumMember(Value = "PRE_TRAINED_TRANSLATION")]
            PreTrainedTranslation,
            [EnumMember(Value = "HEALTH_NLU")]
            HealthNlu
        };

        
    }

    public class ModelDetailsModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ModelDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ModelDetails);
            var discriminator = jsonObject["modelType"].Value<string>();
            switch (discriminator)
            {
                case "PRE_TRAINED_KEYPHRASE_EXTRACTION":
                    obj = new PreTrainedKeyPhraseExtractionModelDetails();
                    break;
                case "PRE_TRAINED_TRANSLATION":
                    obj = new PreTrainedTranslationModelDetails();
                    break;
                case "PRE_TRAINED_HEALTH_NLU":
                    obj = new PreTrainedHealthNluModelDetails();
                    break;
                case "PRE_TRAINED_UNIVERSAL":
                    obj = new PreTrainedUniversalModel();
                    break;
                case "PRE_TRAINED_LANGUAGE_DETECTION":
                    obj = new PreTrainedLanguageDetectionModelDetails();
                    break;
                case "PRE_TRAINED_SENTIMENT_ANALYSIS":
                    obj = new PreTrainedSentimentAnalysisModelDetails();
                    break;
                case "TEXT_CLASSIFICATION":
                    obj = new TextClassificationModelDetails();
                    break;
                case "HEALTH_NLU":
                    obj = new HealthNluModelDetails();
                    break;
                case "PRE_TRAINED_SUMMARIZATION":
                    obj = new PreTrainedSummarization();
                    break;
                case "NAMED_ENTITY_RECOGNITION":
                    obj = new NamedEntityRecognitionModelDetails();
                    break;
                case "PII":
                    obj = new PiiModelDetails();
                    break;
                case "PRE_TRAINED_NAMED_ENTITY_RECOGNITION":
                    obj = new PreTrainedNamedEntityRecognitionModelDetails();
                    break;
                case "PRE_TRAINED_TEXT_CLASSIFICATION":
                    obj = new PreTrainedTextClassificationModelDetails();
                    break;
                case "PRE_TRAINED_PII":
                    obj = new PreTrainedPiiModelDetails();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under ModelDetails! Returning null value.");
            }
            return obj;
        }
    }
}
