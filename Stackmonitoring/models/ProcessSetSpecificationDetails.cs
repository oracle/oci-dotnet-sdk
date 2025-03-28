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


namespace Oci.StackmonitoringService.Models
{
    /// <summary>
    /// Details of a single regular expression specification in a Process Set.
    /// </summary>
    public class ProcessSetSpecificationDetails 
    {
        
        /// <value>
        /// Optional label used to identify a single filter.
        /// </value>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }
        
        /// <value>
        /// String literal used for exact matching on process name.
        /// </value>
        [JsonProperty(PropertyName = "processCommand")]
        public string ProcessCommand { get; set; }
        
        /// <value>
        /// String literal used for exact matching on process user.
        /// </value>
        [JsonProperty(PropertyName = "processUser")]
        public string ProcessUser { get; set; }
        
        /// <value>
        /// Regex pattern matching on process arguments.
        /// </value>
        [JsonProperty(PropertyName = "processLineRegexPattern")]
        public string ProcessLineRegexPattern { get; set; }
        
    }
}
