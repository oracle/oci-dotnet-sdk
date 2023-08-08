/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
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
    /// The document response for batch detect personal identification.
    /// </summary>
    public class PiiEntityDocumentResult 
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
        /// List of batch detect personal identification.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Entities is required.")]
        [JsonProperty(PropertyName = "entities")]
        public System.Collections.Generic.List<PiiEntity> Entities { get; set; }
        
        /// <value>
        /// Masked text per given mask mode.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MaskedText is required.")]
        [JsonProperty(PropertyName = "maskedText")]
        public string MaskedText { get; set; }
        
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
