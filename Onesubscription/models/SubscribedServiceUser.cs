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


namespace Oci.OnesubscriptionService.Models
{
    /// <summary>
    /// User.
    /// 
    /// </summary>
    public class SubscribedServiceUser 
    {
        
        /// <value>
        /// Name.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Username.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        
        /// <value>
        /// First name.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }
        
        /// <value>
        /// Last name.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }
        
        /// <value>
        /// Email.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
        
        /// <value>
        /// TCA contact ID.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "tcaContactId")]
        public System.Nullable<long> TcaContactId { get; set; }
        
        /// <value>
        /// TCA customer account site ID.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "tcaCustAccntSiteId")]
        public System.Nullable<long> TcaCustAccntSiteId { get; set; }
        
        /// <value>
        /// TCA party ID.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "tcaPartyId")]
        public System.Nullable<long> TcaPartyId { get; set; }
        
    }
}
