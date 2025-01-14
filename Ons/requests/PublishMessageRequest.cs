/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.OnsService.Models;

namespace Oci.OnsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/ons/PublishMessage.cs.html">here</a> to see an example of how to use PublishMessage request.
    /// </example>
    public class PublishMessageRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the topic.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TopicId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "topicId")]
        public string TopicId { get; set; }
        
        /// <value>
        /// The message to publish.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MessageDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public MessageDetails MessageDetails { get; set; }
        
        /// <value>
        /// The unique Oracle-assigned identifier for the request. If you need to contact Oracle about a
        /// particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        ///
        /// <value>
        /// **Deprecated.**
        /// Support for JSON is deprecated.
        /// You can send a JSON payload even when transmitting the payload as a raw string.
        /// Configure your receiving system to read the raw payload as JSON format.
        /// <br/>
        /// Type of message body in the request.
        /// For `messageType` of JSON, a default key-value pair is required. Example: {&quot;default&quot;: &quot;Alarm breached&quot;, &quot;Email&quot;: &quot;Alarm breached: <url>&quot;}.
        /// </value>
        ///
        public enum MessageTypeEnum {
            [EnumMember(Value = "JSON")]
            Json,
            [EnumMember(Value = "RAW_TEXT")]
            RawText
        };

        /// <value>
        /// **Deprecated.**
        /// Support for JSON is deprecated.
        /// You can send a JSON payload even when transmitting the payload as a raw string.
        /// Configure your receiving system to read the raw payload as JSON format.
        /// <br/>
        /// Type of message body in the request.
        /// For `messageType` of JSON, a default key-value pair is required. Example: {&quot;default&quot;: &quot;Alarm breached&quot;, &quot;Email&quot;: &quot;Alarm breached: <url>&quot;}.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "messageType")]
        public System.Nullable<MessageTypeEnum> MessageType { get; set; }
    }
}
