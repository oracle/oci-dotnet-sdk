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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// The user aggregation provides information about the overall security state of database users.
    /// For example, it states how many users have the DBA role and how many users are in the critical category.
    /// 
    /// </summary>
    public class UserAggregation 
    {
        
        /// <value>
        /// List containing maps as values.
        /// Example: {&quot;Operations&quot;: [ {&quot;CostCenter&quot;: &quot;42&quot;} ] }
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Items is required.")]
        [JsonProperty(PropertyName = "items")]
        public System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, System.Object>> Items { get; set; }
        
    }
}
