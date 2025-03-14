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
    /// Email address Object that holds display name and email address.
    /// </summary>
    public class EmailAddress 
    {
        
        /// <value>
        /// ASCII only email address.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Email is required.")]
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
        
        /// <value>
        /// Display name for the email address. UTF-8 is supported for display name [RFC 2047](https://www.rfc-editor.org/rfc/rfc2047).
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
    }
}
