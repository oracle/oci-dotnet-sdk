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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Details about a section of changes within a difference chunk.
    /// </summary>
    public class DiffSection 
    {
        
        /// <value>
        /// Type of change.
        /// </value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        
        /// <value>
        /// The lines within changed section.
        /// </value>
        [JsonProperty(PropertyName = "lines")]
        public System.Collections.Generic.List<DiffLineDetails> Lines { get; set; }
        
    }
}
