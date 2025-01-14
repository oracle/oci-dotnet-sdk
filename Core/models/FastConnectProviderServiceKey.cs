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
    /// A provider service key and its details. A provider service key is an identifier for a provider's
    /// virtual circuit.
    /// 
    /// </summary>
    public class FastConnectProviderServiceKey 
    {
        
        /// <value>
        /// The service key that the provider gives you when you set up a virtual circuit connection
        /// from the provider to Oracle Cloud Infrastructure. Use this value as the `providerServiceKeyName`
        /// query parameter for
        /// {@link #getFastConnectProviderServiceKey(GetFastConnectProviderServiceKeyRequest) getFastConnectProviderServiceKey}.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The provisioned data rate of the connection. To get a list of the
        /// available bandwidth levels (that is, shapes), see
        /// {@link #listFastConnectProviderVirtualCircuitBandwidthShapes(ListFastConnectProviderVirtualCircuitBandwidthShapesRequest) listFastConnectProviderVirtualCircuitBandwidthShapes}.
        /// <br/>
        /// Example: 10 Gbps
        /// </value>
        [JsonProperty(PropertyName = "bandwidthShapeName")]
        public string BandwidthShapeName { get; set; }
        
        /// <value>
        /// The provider's peering location.
        /// </value>
        [JsonProperty(PropertyName = "peeringLocation")]
        public string PeeringLocation { get; set; }
        
    }
}
