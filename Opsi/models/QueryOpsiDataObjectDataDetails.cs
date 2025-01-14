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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Information required to form and execute query on an OPSI data object.
    /// </summary>
    public class QueryOpsiDataObjectDataDetails 
    {
        
        /// <value>
        /// Unique OPSI data object identifier.
        /// </value>
        [JsonProperty(PropertyName = "dataObjectIdentifier")]
        public string DataObjectIdentifier { get; set; }
        
        /// <value>
        /// Details of OPSI data objects used in the query.
        /// </value>
        [JsonProperty(PropertyName = "dataObjects")]
        public System.Collections.Generic.List<OpsiDataObjectDetailsInQuery> DataObjects { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Query is required.")]
        [JsonProperty(PropertyName = "query")]
        public DataObjectQuery Query { get; set; }
        
        [JsonProperty(PropertyName = "resourceFilters")]
        public ResourceFilters ResourceFilters { get; set; }
        
    }
}
