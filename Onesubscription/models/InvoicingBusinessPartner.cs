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
    /// Business partner.
    /// 
    /// </summary>
    public class InvoicingBusinessPartner 
    {
        
        /// <value>
        /// Commercial name also called customer name.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Phonetic name.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "namePhonetic")]
        public string NamePhonetic { get; set; }
        
        /// <value>
        /// TCA customer account number.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "tcaCustomerAccountNumber")]
        public string TcaCustomerAccountNumber { get; set; }
        
        /// <value>
        /// The business partner is part of the public sector or not.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isPublicSector")]
        public System.Nullable<bool> IsPublicSector { get; set; }
        
        /// <value>
        /// The business partner is chain customer or not.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isChainCustomer")]
        public System.Nullable<bool> IsChainCustomer { get; set; }
        
        /// <value>
        /// Customer chain type.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "customerChainType")]
        public string CustomerChainType { get; set; }
        
        /// <value>
        /// TCA party number.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "tcaPartyNumber")]
        public string TcaPartyNumber { get; set; }
        
        /// <value>
        /// TCA party ID.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "tcaPartyId")]
        public System.Nullable<long> TcaPartyId { get; set; }
        
        /// <value>
        /// TCA customer account ID.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "tcaCustomerAccountId")]
        public System.Nullable<long> TcaCustomerAccountId { get; set; }
        
    }
}
