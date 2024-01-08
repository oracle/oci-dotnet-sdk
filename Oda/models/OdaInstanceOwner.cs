/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.OdaService.Models
{
    /// <summary>
    /// Details about an ODA instance owner
    /// </summary>
    public class OdaInstanceOwner 
    {
        
        /// <value>
        /// Name of the owner service principal
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OwnerServiceName is required.")]
        [JsonProperty(PropertyName = "ownerServiceName")]
        public string OwnerServiceName { get; set; }
        
        /// <value>
        /// Tenancy OCID of the owner service principal
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OwnerServiceTenancy is required.")]
        [JsonProperty(PropertyName = "ownerServiceTenancy")]
        public string OwnerServiceTenancy { get; set; }
        
    }
}
