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


namespace Oci.DatascienceService.Models
{
    /// <summary>
    /// Payload for trigger request endpoint
    /// </summary>
    public class TriggerMlApplicationInstanceViewFlowDetails 
    {
        
        /// <value>
        /// Name of trigger
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TriggerName is required.")]
        [JsonProperty(PropertyName = "triggerName")]
        public string TriggerName { get; set; }
        
        /// <value>
        /// Parameters provided for given trigger invocation (they must match predefined schema)
        /// </value>
        [JsonProperty(PropertyName = "parameters")]
        public System.Collections.Generic.List<TriggerParameter> Parameters { get; set; }
        
    }
}
