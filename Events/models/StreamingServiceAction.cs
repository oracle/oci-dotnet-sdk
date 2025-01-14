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


namespace Oci.EventsService.Models
{
    /// <summary>
    /// An action that delivers to an Oracle Stream Service stream.
    /// </summary>
    public class StreamingServiceAction : Action
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the stream to which messages are delivered.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "streamId")]
        public string StreamId { get; set; }
        
        [JsonProperty(PropertyName = "actionType")]
        private readonly string actionType = "OSS";
    }
}
