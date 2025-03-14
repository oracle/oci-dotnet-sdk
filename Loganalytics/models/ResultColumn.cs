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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// Querylanguage result column.
    /// 
    /// </summary>
    public class ResultColumn 
    {
        
        /// <value>
        /// Internal identifier for the column.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "internalName")]
        public string InternalName { get; set; }
        
        /// <value>
        /// Display name - will be alias if result column is renamed by queryString.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Field denoting column data type.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "valueType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ValueType> ValueType { get; set; }
        
    }
}
