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


namespace Oci.CapacitymanagementService.Models
{
    /// <summary>
    /// Detailed information about a particular occHandoverResourceBlock. 
    /// For compute namespace this information includes host serial, host ocid etc.
    /// 
    /// </summary>
    public class OccHandoverResourceBlockDetailSummary 
    {
        
        /// <value>
        /// The OCID of the occResourceHandoverBlock.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OccResourceHandoverBlockId is required.")]
        [JsonProperty(PropertyName = "occResourceHandoverBlockId")]
        public string OccResourceHandoverBlockId { get; set; }
        
        /// <value>
        /// A map that contains additional details for a given handover resource. For example for compute namespace this includes host ocid, host serial etc.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Details is required.")]
        [JsonProperty(PropertyName = "details")]
        public System.Collections.Generic.Dictionary<string, string> Details { get; set; }
        
    }
}
