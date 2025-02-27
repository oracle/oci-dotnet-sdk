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
    /// Details about custom property
    /// </summary>
    public class FacetedSearchCustomProperty 
    {
        
        /// <value>
        /// Name of custom property field
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Value of the custom property field
        /// </value>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        /// <value>
        /// Data type of the custom property field
        /// </value>
        [JsonProperty(PropertyName = "dataType")]
        public string DataType { get; set; }
        
    }
}
