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


namespace Oci.MarketplaceprivateofferService.Models
{
    /// <summary>
    /// The information related to the seller of an Offer
    /// </summary>
    public class SellerInformation 
    {
        
        [JsonProperty(PropertyName = "primaryContact")]
        public Contact PrimaryContact { get; set; }
        
        /// <value>
        /// the additional contacts associated with the seller
        /// </value>
        [JsonProperty(PropertyName = "additionalContacts")]
        public System.Collections.Generic.List<Contact> AdditionalContacts { get; set; }
        
    }
}
