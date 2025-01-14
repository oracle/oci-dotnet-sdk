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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Describes the modification parameters for the Scheduled Action.
    /// 
    /// </summary>
    public class UpdateScheduledActionDetails 
    {
        
        /// <value>
        /// Map<ParamName, ParamValue> where a key value pair describes the specific action parameter.
        /// Example: {&quot;count&quot;: &quot;3&quot;}
        /// </value>
        [JsonProperty(PropertyName = "actionParams")]
        public System.Collections.Generic.Dictionary<string, string> ActionParams { get; set; }
        
        /// <value>
        /// The list of action members in a scheduled action.
        /// </value>
        [JsonProperty(PropertyName = "actionMembers")]
        public System.Collections.Generic.List<ActionMember> ActionMembers { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Scheduling Window.
        /// </value>
        [JsonProperty(PropertyName = "schedulingWindowId")]
        public string SchedulingWindowId { get; set; }
        
    }
}
