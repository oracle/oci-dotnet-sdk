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


namespace Oci.FleetappsmanagementService.Models
{
    /// <summary>
    /// The variable of the task.
    /// At least one of the dynamicArguments or output needs to be provided.
    /// 
    /// </summary>
    public class TaskVariable 
    {
        
        /// <value>
        /// The input variables for the task.
        /// </value>
        [JsonProperty(PropertyName = "inputVariables")]
        public System.Collections.Generic.List<InputArgument> InputVariables { get; set; }
        
        /// <value>
        /// The list of output variables.
        /// </value>
        [JsonProperty(PropertyName = "outputVariables")]
        public System.Collections.Generic.List<string> OutputVariables { get; set; }
        
    }
}
