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


namespace Oci.NetworkfirewallService.Models
{
    /// <summary>
    /// A group of services.
    /// 
    /// </summary>
    public class ServiceList 
    {
        
        /// <value>
        /// Name of the service Group.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// List of services in the group.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Services is required.")]
        [JsonProperty(PropertyName = "services")]
        public System.Collections.Generic.List<string> Services { get; set; }
        
        /// <value>
        /// Count of total services in the given service List.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalServices is required.")]
        [JsonProperty(PropertyName = "totalServices")]
        public System.Nullable<int> TotalServices { get; set; }
        
        /// <value>
        /// OCID of the Network Firewall Policy this serviceList belongs to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ParentResourceId is required.")]
        [JsonProperty(PropertyName = "parentResourceId")]
        public string ParentResourceId { get; set; }
        
    }
}
