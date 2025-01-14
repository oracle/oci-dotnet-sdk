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


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// The list of potential matches returned from the suggest operation for the given input text. The size of the list will be determined
    /// by the limit parameter.
    /// 
    /// </summary>
    public class SuggestResults 
    {
        
        /// <value>
        /// Total number of items returned.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalCount is required.")]
        [JsonProperty(PropertyName = "totalCount")]
        public System.Nullable<int> TotalCount { get; set; }
        
        /// <value>
        /// Time taken to compute the result, in milliseconds.
        /// </value>
        [JsonProperty(PropertyName = "searchLatencyInMs")]
        public System.Nullable<int> SearchLatencyInMs { get; set; }
        
        /// <value>
        /// Input string for which the potential matches are computed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InputText is required.")]
        [JsonProperty(PropertyName = "inputText")]
        public string InputText { get; set; }
        
        /// <value>
        /// List of suggestions.
        /// </value>
        [JsonProperty(PropertyName = "items")]
        public System.Collections.Generic.List<SuggestListItem> Items { get; set; }
        
    }
}
