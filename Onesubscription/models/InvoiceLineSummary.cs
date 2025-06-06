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
    /// Invoice Line
    /// 
    /// </summary>
    public class InvoiceLineSummary 
    {
        
        /// <value>
        /// SPM Invoice Line internal identifier
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Product is required.")]
        [JsonProperty(PropertyName = "product")]
        public InvoicingProduct Product { get; set; }
        
        /// <value>
        /// AR Invoice Number for Invoice Line
        /// 
        /// </value>
        [JsonProperty(PropertyName = "arInvoiceNumber")]
        public string ArInvoiceNumber { get; set; }
        
        /// <value>
        /// Data Center Attribute.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DataCenter is required.")]
        [JsonProperty(PropertyName = "dataCenter")]
        public string DataCenter { get; set; }
        
        /// <value>
        /// Usage start time
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeStart is required.")]
        [JsonProperty(PropertyName = "timeStart")]
        public System.Nullable<System.DateTime> TimeStart { get; set; }
        
        /// <value>
        /// Usage end time
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeEnd is required.")]
        [JsonProperty(PropertyName = "timeEnd")]
        public System.Nullable<System.DateTime> TimeEnd { get; set; }
        
    }
}
