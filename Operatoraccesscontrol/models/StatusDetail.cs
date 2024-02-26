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


namespace Oci.OperatoraccesscontrolService.Models
{
    /// <summary>
    /// Detail of execution.
    /// </summary>
    public class StatusDetail 
    {
        
        /// <value>
        /// running unique number of the command executed
        /// </value>
        [JsonProperty(PropertyName = "statusId")]
        public System.Nullable<int> StatusId { get; set; }
        
        /// <value>
        /// Name of the process or command executed.
        /// </value>
        [JsonProperty(PropertyName = "commandName")]
        public string CommandName { get; set; }
        
        /// <value>
        /// Status of the process or command executed Success or Failure.
        /// </value>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        
        /// <value>
        /// Time when the execution happened in [RFC 3339](https://tools.ietf.org/html/rfc3339)timestamp format. Example: '2020-05-22T21:10:29.600Z'.
        /// </value>
        [JsonProperty(PropertyName = "timeOfValidation")]
        public System.Nullable<System.DateTime> TimeOfValidation { get; set; }
        
    }
}
