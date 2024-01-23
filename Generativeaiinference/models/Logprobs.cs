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
    /// Returns if the logarithmic probabilites is set.
    /// </summary>
    public class Logprobs 
    {
        
        /// <value>
        /// The text offset.
        /// </value>
        [JsonProperty(PropertyName = "textOffset")]
        public System.Collections.Generic.List<int> TextOffset { get; set; }
        
        /// <value>
        /// The logarithmic probabilites of the output token.
        /// </value>
        [JsonProperty(PropertyName = "tokenLogprobs")]
        public System.Collections.Generic.List<System.Double> TokenLogprobs { get; set; }
        
        /// <value>
        /// The list of output tokens.
        /// </value>
        [JsonProperty(PropertyName = "tokens")]
        public System.Collections.Generic.List<string> Tokens { get; set; }
        
        /// <value>
        /// The logarithmic probabilities of each of the top k tokens.
        /// </value>
        [JsonProperty(PropertyName = "topLogprobs")]
        public System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>> TopLogprobs { get; set; }
        
    }
}
