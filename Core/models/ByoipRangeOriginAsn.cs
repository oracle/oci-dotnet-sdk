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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// Information about the origin asn.
    /// </summary>
    public class ByoipRangeOriginAsn 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the `Byoasn` resource.
        /// </value>
        [JsonProperty(PropertyName = "byoasnId")]
        public string ByoasnId { get; set; }
        
        /// <value>
        /// The Autonomous System Number (ASN) you are importing to the Oracle cloud.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Asn is required.")]
        [JsonProperty(PropertyName = "asn")]
        public System.Nullable<long> Asn { get; set; }
        
        /// <value>
        /// The as path prepend length.
        /// </value>
        [JsonProperty(PropertyName = "asPathPrependLength")]
        public System.Nullable<int> AsPathPrependLength { get; set; }
        
    }
}
