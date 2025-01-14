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
    /// ParserTestResult
    /// </summary>
    public class ParserTestResult 
    {
        
        /// <value>
        /// Additional information for the test result.
        /// </value>
        [JsonProperty(PropertyName = "additionalInfo")]
        public System.Collections.Generic.Dictionary<string, string> AdditionalInfo { get; set; }
        
        /// <value>
        /// The test result log entries.
        /// </value>
        [JsonProperty(PropertyName = "entries")]
        public System.Collections.Generic.List<AbstractParserTestResultLogEntry> Entries { get; set; }
        
        /// <value>
        /// The example content.
        /// </value>
        [JsonProperty(PropertyName = "exampleContent")]
        public string ExampleContent { get; set; }
        
        /// <value>
        /// The test result log lines.
        /// </value>
        [JsonProperty(PropertyName = "lines")]
        public System.Collections.Generic.List<AbstractParserTestResultLogLine> Lines { get; set; }
        
        /// <value>
        /// The named capture groups.
        /// </value>
        [JsonProperty(PropertyName = "namedCaptureGroups")]
        public System.Collections.Generic.List<string> NamedCaptureGroups { get; set; }
        
    }
}
