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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// A rule to define the set of fields to sort by, and whether to sort by ascending or descending values.
    /// </summary>
    public class SortKeyRule 
    {
        
        [JsonProperty(PropertyName = "wrappedRule")]
        public ProjectionRule WrappedRule { get; set; }
        
        /// <value>
        /// Specifies if the sort key has ascending order.
        /// </value>
        [JsonProperty(PropertyName = "isAscending")]
        public System.Nullable<bool> IsAscending { get; set; }
        
    }
}
