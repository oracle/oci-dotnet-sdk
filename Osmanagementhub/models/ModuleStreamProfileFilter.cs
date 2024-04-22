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


namespace Oci.OsmanagementhubService.Models
{
    /// <summary>
    /// Provides the information used to create a filter for module streams and profiles from a vendor software source to create or update a custom software source.
    /// </summary>
    public class ModuleStreamProfileFilter 
    {
        
        /// <value>
        /// Module name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ModuleName is required.")]
        [JsonProperty(PropertyName = "moduleName")]
        public string ModuleName { get; set; }
        
        /// <value>
        /// Profile name.
        /// </value>
        [JsonProperty(PropertyName = "profileName")]
        public string ProfileName { get; set; }
        
        /// <value>
        /// Stream name.
        /// </value>
        [JsonProperty(PropertyName = "streamName")]
        public string StreamName { get; set; }
        
        /// <value>
        /// The type of the filter.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FilterType is required.")]
        [JsonProperty(PropertyName = "filterType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<FilterType> FilterType { get; set; }
        
    }
}
