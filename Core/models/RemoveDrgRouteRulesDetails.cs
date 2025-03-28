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
    /// Details used in a request to remove static routes from a DRG route table.
    /// 
    /// </summary>
    public class RemoveDrgRouteRulesDetails 
    {
        
        /// <value>
        /// The Oracle-assigned ID of each DRG route rule to be deleted.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "routeRuleIds")]
        public System.Collections.Generic.List<string> RouteRuleIds { get; set; }
        
    }
}
