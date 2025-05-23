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
    /// The location of the OCI Search with OpenSearch that the agent will use.
    /// 
    /// </summary>
    public class OciOpenSearchSourceLocation : SourceLocation
    {
        
        /// <value>
        /// The OCID of the OCI OpenSearch cluster.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The name of the index in OpenSearch that contains the source text.
        /// </value>
        [JsonProperty(PropertyName = "indexName")]
        public string IndexName { get; set; }
        
        /// <value>
        /// The URL of the retrieved document, if available.
        /// </value>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        
        [JsonProperty(PropertyName = "sourceLocationType")]
        private readonly string sourceLocationType = "OCI_OPEN_SEARCH";
    }
}
