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


namespace Oci.MngdmacService.Models
{
    /// <summary>
    /// The data to update a MacOrder.
    /// </summary>
    public class UpdateMacOrderDetails 
    {
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// <br/>
        /// Example: My new resource
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A user-friendly description. To provide some insight about the resource.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "orderDescription")]
        public string OrderDescription { get; set; }
        
        /// <value>
        /// Number of macs requested in this MacOrder.
        /// </value>
        [JsonProperty(PropertyName = "orderSize")]
        public System.Nullable<int> OrderSize { get; set; }
        
        /// <value>
        /// The shape of the Mac.
        /// </value>
        [JsonProperty(PropertyName = "shape")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MacOrder.ShapeEnum> Shape { get; set; }
        
        /// <value>
        /// The IP Range specified by the customer for this order.
        /// </value>
        [JsonProperty(PropertyName = "ipRange")]
        public string IpRange { get; set; }
        
    }
}
