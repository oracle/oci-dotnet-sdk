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


namespace Oci.UsageapiService.Models
{
    /// <summary>
    /// The account (tenant) carbon emissions usage.
    /// </summary>
    public class UsageCarbonEmissionAggregation 
    {
        
        /// <value>
        /// Specifies what to aggregate the result by.
        /// </value>
        [JsonProperty(PropertyName = "groupBy")]
        public System.Collections.Generic.List<string> GroupBy { get; set; }
        
        /// <value>
        /// A list of carbon emission usage items.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Items is required.")]
        [JsonProperty(PropertyName = "items")]
        public System.Collections.Generic.List<UsageCarbonEmissionSummary> Items { get; set; }
        
    }
}
