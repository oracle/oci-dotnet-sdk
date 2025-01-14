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
    /// Response object that is returned to sender upon successfully submitting the email request.
    /// </summary>
    public class EmailSubmittedResponse 
    {
        
        /// <value>
        /// The unique ID for the email's Message-ID header used for service log correlation. The submission will return an error if the syntax is not a valid RFC 5322 Message-ID. This will be generated if not provided.
        /// Example: sdiofu234qwermls24fd@mail.example.com
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MessageId is required.")]
        [JsonProperty(PropertyName = "messageId")]
        public string MessageId { get; set; }
        
        /// <value>
        /// Email Delivery generated unique Envelope ID of the email submission. If you need to contact Email Delivery about a particular request, please provide the Envelope ID.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EnvelopeId is required.")]
        [JsonProperty(PropertyName = "envelopeId")]
        public string EnvelopeId { get; set; }
        
        /// <value>
        /// Return list of suppressed email addresses.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SuppressedRecipients is required.")]
        [JsonProperty(PropertyName = "suppressedRecipients")]
        public System.Collections.Generic.List<EmailAddress> SuppressedRecipients { get; set; }
        
    }
}
