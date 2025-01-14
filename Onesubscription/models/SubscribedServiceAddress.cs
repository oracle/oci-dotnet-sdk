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
    /// Address.
    /// 
    /// </summary>
    public class SubscribedServiceAddress 
    {
        
        [JsonProperty(PropertyName = "location")]
        public SubscribedServiceLocation Location { get; set; }
        
        /// <value>
        /// Address name identifier.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Phone.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }
        
        /// <value>
        /// Identify as the customer shipping address.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isBillTo")]
        public System.Nullable<bool> IsBillTo { get; set; }
        
        /// <value>
        /// Identify as the customer invoicing address.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isShipTo")]
        public System.Nullable<bool> IsShipTo { get; set; }
        
        /// <value>
        /// Bill to site use Id.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "billSiteUseId")]
        public System.Nullable<long> BillSiteUseId { get; set; }
        
        /// <value>
        /// Service to site use Id.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "service2SiteUseId")]
        public System.Nullable<long> Service2SiteUseId { get; set; }
        
        /// <value>
        /// TCA customer account site Id.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "tcaCustAcctSiteId")]
        public System.Nullable<long> TcaCustAcctSiteId { get; set; }
        
        /// <value>
        /// Party site number.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "tcaPartySiteNumber")]
        public string TcaPartySiteNumber { get; set; }
        
    }
}
