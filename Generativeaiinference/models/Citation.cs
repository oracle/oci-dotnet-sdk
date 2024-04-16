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
    /// A section of the generated reply which cites external knowledge.
    /// </summary>
    public class Citation 
    {
        
        /// <value>
        /// The index of text that the citation starts at, counting from zero.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Start is required.")]
        [JsonProperty(PropertyName = "start")]
        public System.Nullable<int> Start { get; set; }
        
        /// <value>
        /// The index of text that the citation ends after, counting from zero.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "End is required.")]
        [JsonProperty(PropertyName = "end")]
        public System.Nullable<int> End { get; set; }
        
        /// <value>
        /// The text of the citation
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Text is required.")]
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
        
        /// <value>
        /// Identifiers of documents cited by this section of the generated reply.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DocumentIds is required.")]
        [JsonProperty(PropertyName = "documentIds")]
        public System.Collections.Generic.List<string> DocumentIds { get; set; }
        
    }
}
