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


namespace Oci.GenerativeaiService.Models
{
    /// <summary>
    /// An error encountered while performing an operation that is tracked by this work request.
    /// </summary>
    public class WorkRequestError 
    {
        
        /// <value>
        /// A machine-usable code for the error that occurred. For a list of error codes, see
        /// [API Errors](https://docs.cloud.oracle.com/iaas/Content/API/References/apierrors.htm).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Code is required.")]
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }
        
        /// <value>
        /// A human-readable error message.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Message is required.")]
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        
        /// <value>
        /// The date and time that the error occurred, in the format defined by
        /// [RFC 3339](https://tools.ietf.org/html/rfc3339).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Timestamp is required.")]
        [JsonProperty(PropertyName = "timestamp")]
        public System.Nullable<System.DateTime> Timestamp { get; set; }
        
    }
}
