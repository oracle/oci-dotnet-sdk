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


namespace Oci.FusionappsService.Models
{
    /// <summary>
    /// IDM admin credentials without password
    /// </summary>
    public class AdminUserSummary 
    {
        
        /// <value>
        /// Admin username
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Username is required.")]
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        
        /// <value>
        /// Admin users email address
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EmailAddress is required.")]
        [JsonProperty(PropertyName = "emailAddress")]
        public string EmailAddress { get; set; }
        
        /// <value>
        /// Admin users first name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FirstName is required.")]
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }
        
        /// <value>
        /// Admin users last name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LastName is required.")]
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }
        
    }
}
