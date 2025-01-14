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
    /// The list of search result items matching the criteria returned from the search operation. Search errors and
    /// messages, if any , will be part of the standard error response.
    /// 
    /// </summary>
    public class SearchResultCollection 
    {
        
        /// <value>
        /// Total number of items returned.
        /// </value>
        [JsonProperty(PropertyName = "count")]
        public System.Nullable<int> Count { get; set; }
        
        /// <value>
        /// Search result set.
        /// </value>
        [JsonProperty(PropertyName = "items")]
        public System.Collections.Generic.List<SearchResult> Items { get; set; }
        
        /// <value>
        /// String that data objects are to be searched with.
        /// </value>
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }
        
        /// <value>
        /// Aggregations/facets on properties of data objects.
        /// </value>
        [JsonProperty(PropertyName = "facetedSearchAggregation")]
        public System.Collections.Generic.List<FacetedSearchAggregation> FacetedSearchAggregation { get; set; }
        
        /// <value>
        /// A list of fields or properties used in the sorting of a search result.
        /// </value>
        [JsonProperty(PropertyName = "sortableFields")]
        public System.Collections.Generic.List<string> SortableFields { get; set; }
        
    }
}
