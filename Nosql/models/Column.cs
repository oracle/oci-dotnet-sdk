/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.NosqlService.Models
{
    /// <summary>
    /// A column of a table.
    /// </summary>
    public class Column 
    {
        
        /// <value>
        /// The column name.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The column type.
        /// </value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        
        /// <value>
        /// The column nullable flag.
        /// </value>
        [JsonProperty(PropertyName = "isNullable")]
        public System.Nullable<bool> IsNullable { get; set; }
        
        /// <value>
        /// The column default value.
        /// </value>
        [JsonProperty(PropertyName = "defaultValue")]
        public string DefaultValue { get; set; }
        
        /// <value>
        /// True if the STRING column was declared AS UUID.
        /// </value>
        [JsonProperty(PropertyName = "isAsUuid")]
        public System.Nullable<bool> IsAsUuid { get; set; }
        
        /// <value>
        /// True if the STRING AS UUID column is also GENERATED BY DEFAULT.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isGenerated")]
        public System.Nullable<bool> IsGenerated { get; set; }
        
    }
}
