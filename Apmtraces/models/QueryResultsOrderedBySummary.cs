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


namespace Oci.ApmtracesService.Models
{
    /// <summary>
    /// Summary of the sort and order by attribute based on which the query results are organized.
    /// 
    /// </summary>
    public class QueryResultsOrderedBySummary 
    {
        
        /// <value>
        /// Attribute by which the query results are sorted.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "queryResultsOrderedBy")]
        public string QueryResultsOrderedBy { get; set; }
        
        /// <value>
        /// The sort order for the attribute, either 'ASC' or 'DESC'.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "queryResultsSortOrder")]
        public string QueryResultsSortOrder { get; set; }
        
    }
}
