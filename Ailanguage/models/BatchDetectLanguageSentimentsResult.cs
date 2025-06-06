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
    /// Result of sentiments detect call.
    /// </summary>
    public class BatchDetectLanguageSentimentsResult 
    {
        
        /// <value>
        /// List of succeeded document response.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Documents is required.")]
        [JsonProperty(PropertyName = "documents")]
        public System.Collections.Generic.List<SentimentDocumentResult> Documents { get; set; }
        
        /// <value>
        /// List of failed document response.
        /// </value>
        [JsonProperty(PropertyName = "errors")]
        public System.Collections.Generic.List<DocumentError> Errors { get; set; }
        
    }
}
