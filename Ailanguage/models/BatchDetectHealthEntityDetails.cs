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
    /// The documents details for health entities detect call.
    /// </summary>
    public class BatchDetectHealthEntityDetails 
    {
        
        /// <value>
        /// Unique name across user tenancy in a region to identify an endpoint to be used for inferencing.
        /// </value>
        [JsonProperty(PropertyName = "alias")]
        public string Alias { get; set; }
        
        /// <value>
        /// The endpoint which have to be used for inferencing.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EndpointId is required.")]
        [JsonProperty(PropertyName = "endpointId")]
        public string EndpointId { get; set; }
        
        /// <value>
        /// List of Documents for detect health entities.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Documents is required.")]
        [JsonProperty(PropertyName = "documents")]
        public System.Collections.Generic.List<TextDocument> Documents { get; set; }
        
        /// <value>
        /// List of NLP health ontologies to be linked
        /// </value>
        [JsonProperty(PropertyName = "linkOntologies")]
        public System.Collections.Generic.List<string> LinkOntologies { get; set; }
        
        /// <value>
        /// is assertion on input text required. default value true.
        /// </value>
        [JsonProperty(PropertyName = "isDetectAssertions")]
        public System.Nullable<bool> IsDetectAssertions { get; set; }
        
        /// <value>
        /// is relationship on input text required. default value true.
        /// </value>
        [JsonProperty(PropertyName = "isDetectRelationships")]
        public System.Nullable<bool> IsDetectRelationships { get; set; }
        
        [JsonProperty(PropertyName = "profile")]
        public Profile Profile { get; set; }
        
    }
}
