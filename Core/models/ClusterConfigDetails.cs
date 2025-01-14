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
    /// The HPC cluster configuration requested when launching instances in a compute capacity reservation.
    /// <br/>
    /// If the parameter is provided, the reservation is created with the HPC island and a list of HPC blocks that you
    /// specify. If a list of HPC blocks are missing or not provided, the reservation is created with any HPC blocks in
    /// the HPC island that you specify. If the values of HPC island or HPC block that you provide are not valid, an error
    /// is returned.
    /// 
    /// </summary>
    public class ClusterConfigDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the HPC island.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HpcIslandId is required.")]
        [JsonProperty(PropertyName = "hpcIslandId")]
        public string HpcIslandId { get; set; }
        
        /// <value>
        /// The list of OCIDs of the network blocks.
        /// </value>
        [JsonProperty(PropertyName = "networkBlockIds")]
        public System.Collections.Generic.List<string> NetworkBlockIds { get; set; }
        
    }
}
