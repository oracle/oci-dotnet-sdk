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
    /// The rerank response to return to the caller.
    /// </summary>
    public class RerankTextResult 
    {
        
        /// <value>
        /// A unique identifier for this `RerankResult`.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the model used in the rerank request.
        /// </value>
        [JsonProperty(PropertyName = "modelId")]
        public string ModelId { get; set; }
        
        /// <value>
        /// The version of the model.
        /// </value>
        [JsonProperty(PropertyName = "modelVersion")]
        public string ModelVersion { get; set; }
        
        /// <value>
        /// Top n documents with their index and relevance score.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DocumentRanks is required.")]
        [JsonProperty(PropertyName = "documentRanks")]
        public System.Collections.Generic.List<DocumentRank> DocumentRanks { get; set; }
        
    }
}
