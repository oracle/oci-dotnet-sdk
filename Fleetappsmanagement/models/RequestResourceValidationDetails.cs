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


namespace Oci.FleetappsmanagementService.Models
{
    /// <summary>
    /// Request to initiate resource validation.
    /// 
    /// </summary>
    public class RequestResourceValidationDetails 
    {
        
        /// <value>
        /// A boolean flag that decides if all resources within the fleet should be part of the validation.
        /// </value>
        [JsonProperty(PropertyName = "isApplicableToAllResources")]
        public System.Nullable<bool> IsApplicableToAllResources { get; set; }
        
        /// <value>
        /// Resource OCIDS to be included for validation.
        /// </value>
        [JsonProperty(PropertyName = "resourceIds")]
        public System.Collections.Generic.List<string> ResourceIds { get; set; }
        
    }
}
