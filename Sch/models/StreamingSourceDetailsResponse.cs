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


namespace Oci.SchService.Models
{
    /// <summary>
    /// The Streaming source response. Private metadata is included when the target is a stream accessed through 
    /// a [private endpoint](https://docs.cloud.oracle.com/iaas/Content/Streaming/Concepts/streamsecurity.htm#private_endpoints).
    /// 
    /// </summary>
    public class StreamingSourceDetailsResponse : SourceDetailsResponse
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the stream.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StreamId is required.")]
        [JsonProperty(PropertyName = "streamId")]
        public string StreamId { get; set; }
        
        [JsonProperty(PropertyName = "cursor")]
        public StreamingCursorDetails Cursor { get; set; }
        
        [JsonProperty(PropertyName = "kind")]
        private readonly string kind = "streaming";
    }
}
