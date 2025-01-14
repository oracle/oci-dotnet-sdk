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


namespace Oci.AilanguageService.Models
{
    /// <summary>
    /// The document response for test classification detect call.
    /// </summary>
    public class TextClassificationDocumentResult 
    {
        
        /// <value>
        /// Document unique identifier defined by the user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// List of detected text classes.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TextClassification is required.")]
        [JsonProperty(PropertyName = "textClassification")]
        public System.Collections.Generic.List<TextClassification> TextClassification { get; set; }
        
        /// <value>
        /// Language code supported
        /// - auto : Automatically detect language
        /// - ar : Arabic
        /// - pt-BR : Brazilian Portuguese   
        /// - cs : Czech
        /// - da : Danish
        /// - nl : Dutch
        /// - en : English
        /// - fi : Finnish
        /// - fr : French
        /// - fr-CA : Canadian French     
        /// - de : German
        /// - it : Italian
        /// - ja : Japanese
        /// - ko : Korean
        /// - no : Norwegian
        /// - pl : Polish
        /// - ro : Romanian
        /// - zh-CN : Simplified Chinese
        /// - es : Spanish
        /// - sv : Swedish
        /// - zh-TW : Traditional Chinese
        /// - tr : Turkish
        /// - el : Greek
        /// - he : Hebrew
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LanguageCode is required.")]
        [JsonProperty(PropertyName = "languageCode")]
        public string LanguageCode { get; set; }
        
    }
}
