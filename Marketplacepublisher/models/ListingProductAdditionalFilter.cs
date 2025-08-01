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


namespace Oci.MarketplacepublisherService.Models
{
    /// <summary>
    /// Additional filters attached to a product of listing
    /// </summary>
    public class ListingProductAdditionalFilter 
    {
        
        /// <value>
        /// filter code for the product
        /// </value>
        [JsonProperty(PropertyName = "filterCode")]
        public string FilterCode { get; set; }
        
        /// <value>
        /// additional properties attached to a filter
        /// </value>
        [JsonProperty(PropertyName = "filterProperties")]
        public System.Collections.Generic.List<string> FilterProperties { get; set; }
        
    }
}
