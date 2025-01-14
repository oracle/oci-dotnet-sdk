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


namespace Oci.LoggingService.Models
{
    /// <summary>
    /// Tail log source object.
    /// </summary>
    public class UnifiedAgentTailLogSource : UnifiedAgentLoggingSource
    {
        
        /// <value>
        /// Absolute paths for log source files. Wildcards can be used.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Paths is required.")]
        [JsonProperty(PropertyName = "paths")]
        public System.Collections.Generic.List<string> Paths { get; set; }
        
        [JsonProperty(PropertyName = "parser")]
        public UnifiedAgentParser Parser { get; set; }
        
        [JsonProperty(PropertyName = "advancedOptions")]
        public UnifiedAgentTailSourceAdvancedOptions AdvancedOptions { get; set; }
        
        [JsonProperty(PropertyName = "sourceType")]
        private readonly string sourceType = "LOG_TAIL";
    }
}
