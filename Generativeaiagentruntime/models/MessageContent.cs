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


namespace Oci.GenerativeaiagentruntimeService.Models
{
    /// <summary>
    /// The content of the message.
    /// 
    /// </summary>
    public class MessageContent 
    {
        
        /// <value>
        /// The content of the message.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Text is required.")]
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
        
        /// <value>
        /// Citations to data sources used for generating an agent's message.
        /// </value>
        [JsonProperty(PropertyName = "citations")]
        public System.Collections.Generic.List<Citation> Citations { get; set; }
        
        /// <value>
        /// A list of citations used to generate the paragraphs of the agent message.
        /// </value>
        [JsonProperty(PropertyName = "paragraphCitations")]
        public System.Collections.Generic.List<ParagraphCitation> ParagraphCitations { get; set; }
        
    }
}
