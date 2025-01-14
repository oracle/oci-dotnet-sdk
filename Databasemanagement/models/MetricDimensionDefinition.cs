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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The metric dimension details.
    /// </summary>
    public class MetricDimensionDefinition 
    {
        
        /// <value>
        /// The name of the dimension.
        /// </value>
        [JsonProperty(PropertyName = "dimensionName")]
        public string DimensionName { get; set; }
        
        /// <value>
        /// The value of the dimension.
        /// </value>
        [JsonProperty(PropertyName = "dimensionValue")]
        public string DimensionValue { get; set; }
        
    }
}
