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
    /// SKU information.
    /// </summary>
    public class SubscriptionSku 
    {
        
        /// <value>
        /// Stock keeping unit id.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Sku is required.")]
        [JsonProperty(PropertyName = "sku")]
        public string Sku { get; set; }
        
        /// <value>
        /// Description of the covered product belonging to this Sku.
        /// </value>
        [JsonProperty(PropertyName = "licensePartDescription")]
        public string LicensePartDescription { get; set; }
        
        /// <value>
        /// Base metric for billing the service.
        /// </value>
        [JsonProperty(PropertyName = "metricName")]
        public string MetricName { get; set; }
        
        /// <value>
        /// Quantity of the stock units.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Quantity is required.")]
        [JsonProperty(PropertyName = "quantity")]
        public System.Nullable<int> Quantity { get; set; }
        
        /// <value>
        /// Description of the stock units.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
    }
}
