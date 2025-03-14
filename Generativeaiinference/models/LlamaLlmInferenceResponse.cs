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


namespace Oci.GenerativeaiinferenceService.Models
{
    /// <summary>
    /// The generated text result to return.
    /// </summary>
    public class LlamaLlmInferenceResponse : LlmInferenceResponse
    {
        
        /// <value>
        /// The Unix timestamp (in seconds) of when the generation was created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Created is required.")]
        [JsonProperty(PropertyName = "created")]
        public System.Nullable<System.DateTime> Created { get; set; }
        
        /// <value>
        /// A list of generated texts. Can be more than one if n is greater than 1.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Choices is required.")]
        [JsonProperty(PropertyName = "choices")]
        public System.Collections.Generic.List<Choice> Choices { get; set; }
        
        [JsonProperty(PropertyName = "runtimeType")]
        private readonly string runtimeType = "LLAMA";
    }
}
