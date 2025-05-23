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
    /// Lists the compartment to find VCN overlap.
    /// </summary>
    public class GetIpInventoryVcnOverlapDetails 
    {
        
        /// <value>
        /// Lists the selected regions.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RegionList is required.")]
        [JsonProperty(PropertyName = "regionList")]
        public System.Collections.Generic.List<string> RegionList { get; set; }
        
        /// <value>
        /// The list of [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartments.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentList is required.")]
        [JsonProperty(PropertyName = "compartmentList")]
        public System.Collections.Generic.List<string> CompartmentList { get; set; }
        
    }
}
