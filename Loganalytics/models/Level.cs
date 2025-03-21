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
    /// An object used to represent a level at which a property or resource or constraint is defined.
    /// </summary>
    public class Level 
    {
        
        /// <value>
        /// The level name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// A string representation of constraints that apply at this level.
        /// For example, a property defined at SOURCE level could further be applicable only for SOURCE_TYPE:database_sql.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "constraints")]
        public string Constraints { get; set; }
        
    }
}
