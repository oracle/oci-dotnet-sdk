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
    /// Currency details
    /// 
    /// </summary>
    public class InvoicingCurrency 
    {
        
        /// <value>
        /// Currency name
        /// 
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Currency Code
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsoCode is required.")]
        [JsonProperty(PropertyName = "isoCode")]
        public string IsoCode { get; set; }
        
        /// <value>
        /// Standard Precision of the Currency
        /// 
        /// </value>
        [JsonProperty(PropertyName = "stdPrecision")]
        public System.Nullable<long> StdPrecision { get; set; }
        
    }
}
