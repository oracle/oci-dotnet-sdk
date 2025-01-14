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


namespace Oci.MarketplacepublisherService.Models
{
    /// <summary>
    /// The information about new Offers.
    /// </summary>
    public class CreateOfferDetails 
    {
        
        /// <value>
        /// Offers Identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Compartment Identifier of the seller
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SellerCompartmentId is required.")]
        [JsonProperty(PropertyName = "sellerCompartmentId")]
        public string SellerCompartmentId { get; set; }
        
        /// <value>
        /// Compartment Identifier of the buyer
        /// </value>
        [JsonProperty(PropertyName = "buyerCompartmentId")]
        public string BuyerCompartmentId { get; set; }
        
        /// <value>
        /// Description of the Offer
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Internal notes of the Offer
        /// </value>
        [JsonProperty(PropertyName = "internalNotes")]
        public string InternalNotes { get; set; }
        
        /// <value>
        /// The time the Offer will become active after it has been accepted by the Buyer. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeStartDate")]
        public System.Nullable<System.DateTime> TimeStartDate { get; set; }
        
        /// <value>
        /// Duration the Offer will be active after its start date. An ISO8601 extended formatted string.
        /// </value>
        [JsonProperty(PropertyName = "duration")]
        public string Duration { get; set; }
        
        /// <value>
        /// The time the Offer must be accepted by the Buyer before the Offer becomes invalid. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeAcceptBy")]
        public System.Nullable<System.DateTime> TimeAcceptBy { get; set; }
        
        [JsonProperty(PropertyName = "pricing")]
        public Pricing Pricing { get; set; }
        
        [JsonProperty(PropertyName = "buyerInformation")]
        public BuyerInformation BuyerInformation { get; set; }
        
        [JsonProperty(PropertyName = "sellerInformation")]
        public SellerInformation SellerInformation { get; set; }
        
        /// <value>
        /// A list of Resource Bundles associated with an Offer.
        /// </value>
        [JsonProperty(PropertyName = "resourceBundles")]
        public System.Collections.Generic.List<ResourceBundle> ResourceBundles { get; set; }
        
        /// <value>
        /// A list of key value pairs specified by the seller
        /// </value>
        [JsonProperty(PropertyName = "customFields")]
        public System.Collections.Generic.List<CustomField> CustomFields { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
