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


namespace Oci.MarketplaceprivateofferService.Models
{
    /// <summary>
    /// The information related to the buyer of an Offer
    /// </summary>
    public class BuyerInformation 
    {
        
        /// <value>
        /// the name of the company for the buyer
        /// </value>
        [JsonProperty(PropertyName = "companyName")]
        public string CompanyName { get; set; }
        
        /// <value>
        /// a note the seller can specify for the buyer through a notification email
        /// </value>
        [JsonProperty(PropertyName = "noteToBuyer")]
        public string NoteToBuyer { get; set; }
        
        [JsonProperty(PropertyName = "primaryContact")]
        public Contact PrimaryContact { get; set; }
        
        /// <value>
        /// the additional contacts associated with the buyer
        /// </value>
        [JsonProperty(PropertyName = "additionalContacts")]
        public System.Collections.Generic.List<Contact> AdditionalContacts { get; set; }
        
    }
}
