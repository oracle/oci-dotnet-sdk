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
    /// Object with date filter criteria
    /// </summary>
    public class FacetedSearchDateFilterRequest 
    {
        
        /// <value>
        /// Date field name that needs to be filtered by. Acceptable fields include TimeCreated and TimeUpdated.
        /// </value>
        [JsonProperty(PropertyName = "fieldName")]
        public string FieldName { get; set; }
        
        /// <value>
        /// The date and time the request was created, as described in
        /// [RFC 3339](https://tools.ietf.org/rfc/rfc3339), section 14.29.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeAfter")]
        public System.Nullable<System.DateTime> TimeAfter { get; set; }
        
        /// <value>
        /// The date and time the request was created, as described in
        /// [RFC 3339](https://tools.ietf.org/rfc/rfc3339), section 14.29.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeBefore")]
        public System.Nullable<System.DateTime> TimeBefore { get; set; }
        
    }
}
