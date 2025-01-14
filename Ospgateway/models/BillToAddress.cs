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


namespace Oci.OspgatewayService.Models
{
    /// <summary>
    /// Address details model
    /// </summary>
    public class BillToAddress 
    {
        
        /// <value>
        /// Name of the contact person
        /// </value>
        [JsonProperty(PropertyName = "contactName")]
        public string ContactName { get; set; }
        
        /// <value>
        /// Name of the customer company
        /// </value>
        [JsonProperty(PropertyName = "companyName")]
        public string CompanyName { get; set; }
        
        /// <value>
        /// Address line 1
        /// </value>
        [JsonProperty(PropertyName = "addressLine1")]
        public string AddressLine1 { get; set; }
        
        /// <value>
        /// Address line 2
        /// </value>
        [JsonProperty(PropertyName = "addressLine2")]
        public string AddressLine2 { get; set; }
        
        /// <value>
        /// Address line 3
        /// </value>
        [JsonProperty(PropertyName = "addressLine3")]
        public string AddressLine3 { get; set; }
        
        /// <value>
        /// Address line 4
        /// </value>
        [JsonProperty(PropertyName = "addressLine4")]
        public string AddressLine4 { get; set; }
        
        /// <value>
        /// Street name
        /// </value>
        [JsonProperty(PropertyName = "streetName")]
        public string StreetName { get; set; }
        
        /// <value>
        /// House no
        /// </value>
        [JsonProperty(PropertyName = "streetNumber")]
        public string StreetNumber { get; set; }
        
        /// <value>
        /// Name of the city
        /// </value>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }
        
        [JsonProperty(PropertyName = "country")]
        public Country Country { get; set; }
        
        /// <value>
        /// County name
        /// </value>
        [JsonProperty(PropertyName = "county")]
        public string County { get; set; }
        
        /// <value>
        /// Name of the state
        /// </value>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }
        
        /// <value>
        /// ZIP no
        /// </value>
        [JsonProperty(PropertyName = "postalCode")]
        public string PostalCode { get; set; }
        
        /// <value>
        /// Name of the province
        /// </value>
        [JsonProperty(PropertyName = "province")]
        public string Province { get; set; }
        
    }
}
