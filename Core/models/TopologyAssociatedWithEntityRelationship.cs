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
    /// Defines the `AssociatedWith` relationship between virtual network topology entities. An `AssociatedWith` relationship
    /// is defined when there is no obvious `contains` relationship but entities are still related.
    /// For example, a DRG is associated with a VCN because a DRG is not managed by VCN but can be
    /// attached to a VCN.
    /// 
    /// </summary>
    public class TopologyAssociatedWithEntityRelationship : TopologyEntityRelationship
    {
        
        [JsonProperty(PropertyName = "associatedWithDetails")]
        public TopologyAssociatedWithRelationshipDetails AssociatedWithDetails { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "ASSOCIATED_WITH";
    }
}
