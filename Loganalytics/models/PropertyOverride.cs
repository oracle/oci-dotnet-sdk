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
    /// Property overrides at the scope of objects.
    /// For example, if you want to use logSourceName as 'xyz' for all objects that conatins string 'abc/' then
    /// define matchType as 'contains', matchValue as 'abc/', propertyName as 'logSourceName' and propertyValue as 'xyz'.
    /// 
    /// </summary>
    public class PropertyOverride 
    {
        
        /// <value>
        /// Match Type. Accepted values are: contains.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "matchType")]
        public string MatchType { get; set; }
        
        /// <value>
        /// Match Value.
        /// </value>
        [JsonProperty(PropertyName = "matchValue")]
        public string MatchValue { get; set; }
        
        /// <value>
        /// Property to override. Accepted values are: logSourceName, charEncoding.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "propertyName")]
        public string PropertyName { get; set; }
        
        /// <value>
        /// Value of the property.
        /// </value>
        [JsonProperty(PropertyName = "propertyValue")]
        public string PropertyValue { get; set; }
        
    }
}
