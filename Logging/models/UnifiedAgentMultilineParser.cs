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


namespace Oci.LoggingService.Models
{
    /// <summary>
    /// Multiline parser.
    /// </summary>
    public class UnifiedAgentMultilineParser : UnifiedAgentParser
    {
        
        /// <value>
        /// First line pattern format.
        /// </value>
        [JsonProperty(PropertyName = "formatFirstline")]
        public string FormatFirstline { get; set; }
        
        /// <value>
        /// Mutiline pattern format.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Format is required.")]
        [JsonProperty(PropertyName = "format")]
        public System.Collections.Generic.List<string> Format { get; set; }
        
        [JsonProperty(PropertyName = "parserType")]
        private readonly string parserType = "MULTILINE";
    }
}
