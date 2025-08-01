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


namespace Oci.ComputeinstanceagentService.Models
{
    /// <summary>
    /// The contents of the command.
    /// </summary>
    public class InstanceAgentCommandContent 
    {
        
        /// <value>
        /// The source of the command.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Source is required.")]
        [JsonProperty(PropertyName = "source")]
        public InstanceAgentCommandSourceDetails Source { get; set; }
        
        /// <value>
        /// The output destination for the command.
        /// </value>
        [JsonProperty(PropertyName = "output")]
        public InstanceAgentCommandOutputDetails Output { get; set; }
        
        /// <value>
        /// Command String is a fully formed command that runcommand executes.
        /// Example: main.sh is stored in object storage and user provides the following command with parameters to execute/bin/sh main.sh abc 10 foo.sh
        /// </value>
        [JsonProperty(PropertyName = "commandString")]
        public string CommandString { get; set; }
        
    }
}
