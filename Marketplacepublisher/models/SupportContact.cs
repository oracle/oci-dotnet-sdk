/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.MarketplacepublisherService.Models
{
    /// <summary>
    /// Contact information to use to get support.
    /// </summary>
    public class SupportContact 
    {
        
        /// <value>
        /// The name of the contact.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The phone number of the contact.
        /// </value>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }
        
        /// <value>
        /// The email of the contact.
        /// </value>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
        
        /// <value>
        /// The email subject line to use when contacting support.
        /// </value>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }
        
    }
}
