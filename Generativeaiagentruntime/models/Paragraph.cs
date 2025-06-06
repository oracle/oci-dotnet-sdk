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
    /// The paragraph of the generated message that contains a citation.
    /// 
    /// </summary>
    public class Paragraph 
    {
        
        /// <value>
        /// The part of the generated message that contains a citation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Text is required.")]
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
        
        /// <value>
        /// Where the text with a citation starts in the generated message.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Start is required.")]
        [JsonProperty(PropertyName = "start")]
        public System.Nullable<int> Start { get; set; }
        
        /// <value>
        /// Where the text with a citation ends in the generated message.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "End is required.")]
        [JsonProperty(PropertyName = "end")]
        public System.Nullable<int> End { get; set; }
        
    }
}
