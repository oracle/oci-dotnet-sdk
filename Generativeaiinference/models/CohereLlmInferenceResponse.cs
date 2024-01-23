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


namespace Oci.GenerativeaiinferenceService.Models
{
    /// <summary>
    /// The generated text result to return.
    /// </summary>
    public class CohereLlmInferenceResponse : LlmInferenceResponse
    {
        
        /// <value>
        /// Each prompt in the input array has an array of GeneratedText, controlled by numGenerations parameter in the request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "GeneratedTexts is required.")]
        [JsonProperty(PropertyName = "generatedTexts")]
        public System.Collections.Generic.List<GeneratedText> GeneratedTexts { get; set; }
        
        /// <value>
        /// The date and time that the model was created in an RFC3339 formatted datetime string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Represents the original prompt. Applies only to non-stream responses.
        /// </value>
        [JsonProperty(PropertyName = "prompt")]
        public string Prompt { get; set; }
        
        [JsonProperty(PropertyName = "runtimeType")]
        private readonly string runtimeType = "COHERE";
    }
}
