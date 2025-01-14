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


namespace Oci.ManagementagentService.Models
{
    /// <summary>
    /// Details for configuring tenancy-level agent AutoUpgradable configuration.
    /// </summary>
    public class SetAutoUpgradableConfigDetails 
    {
        
        /// <value>
        /// Tenancy identifier i.e, Root compartment identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// true if the agents can be upgraded automatically; false if they must be upgraded manually.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsAgentAutoUpgradable is required.")]
        [JsonProperty(PropertyName = "isAgentAutoUpgradable")]
        public System.Nullable<bool> IsAgentAutoUpgradable { get; set; }
        
    }
}
