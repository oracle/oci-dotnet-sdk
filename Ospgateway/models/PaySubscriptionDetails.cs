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


namespace Oci.OspgatewayService.Models
{
    /// <summary>
    /// Request object for paying a subscription
    /// </summary>
    public class PaySubscriptionDetails 
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Subscription is required.")]
        [JsonProperty(PropertyName = "subscription")]
        public Subscription Subscription { get; set; }
        
        /// <value>
        /// Language code
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LanguageCode is required.")]
        [JsonProperty(PropertyName = "languageCode")]
        public string LanguageCode { get; set; }
        
        /// <value>
        /// User email
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Email is required.")]
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
        
    }
}
