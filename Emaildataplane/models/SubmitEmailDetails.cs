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


namespace Oci.EmaildataplaneService.Models
{
    /// <summary>
    /// Details that are required by the sender to submit a request to send email.
    /// </summary>
    public class SubmitEmailDetails 
    {
        
        /// <value>
        /// The unique ID for the email's Message-ID header used for service log correlation. The submission will return an error if the syntax is not a valid [RFC 5322](https://www.rfc-editor.org/rfc/rfc5322) Message-ID. This will be generated if not provided.
        /// Example: sdiofu234qwermls24fd@mail.example.com
        /// </value>
        [JsonProperty(PropertyName = "messageId")]
        public string MessageId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Sender is required.")]
        [JsonProperty(PropertyName = "sender")]
        public Sender Sender { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Recipients is required.")]
        [JsonProperty(PropertyName = "recipients")]
        public Recipients Recipients { get; set; }
        
        /// <value>
        /// A short summary of the content, which will appear in the recipient's inbox. UTF-8 supported [RFC 2047](https://www.rfc-editor.org/rfc/rfc2047).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Subject is required.")]
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }
        
        /// <value>
        /// HTML body content in UTF-8.
        /// NOTE: Even though bodytext and bodyhtml are both optional, at least one of them must be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "bodyHtml")]
        public string BodyHtml { get; set; }
        
        /// <value>
        /// Text body content.
        /// NOTE: Even though bodytext and bodyhtml are both optional, at least one of them must be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "bodyText")]
        public string BodyText { get; set; }
        
        /// <value>
        /// The email address for the recipient to reply to. If left blank, defaults to the sender address.
        /// </value>
        [JsonProperty(PropertyName = "replyTo")]
        public System.Collections.Generic.List<EmailAddress> ReplyTo { get; set; }
        
        /// <value>
        /// The header used by the customer for the email sent. Reserved headers are not allowed e.g \"subject\", \"from\", and \"to\" etc.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "headerFields")]
        public System.Collections.Generic.Dictionary<string, string> HeaderFields { get; set; }
        
    }
}
