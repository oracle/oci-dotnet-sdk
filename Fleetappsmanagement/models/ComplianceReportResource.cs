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
    /// Details of the Resource
    /// </summary>
    public class ComplianceReportResource 
    {
        
        /// <value>
        /// The OCID to identify the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceId is required.")]
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
        
        /// <value>
        /// Display name of the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceName is required.")]
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }
        
        /// <value>
        /// Type of the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceType is required.")]
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }
        
        /// <value>
        /// TenancyId of the resource.
        /// </value>
        [JsonProperty(PropertyName = "tenancyId")]
        public string TenancyId { get; set; }
        
        /// <value>
        /// Tenancy the resource belongs to.
        /// </value>
        [JsonProperty(PropertyName = "tenancyName")]
        public string TenancyName { get; set; }
        
        /// <value>
        /// Compartment the resource belongs to.
        /// </value>
        [JsonProperty(PropertyName = "compartment")]
        public string Compartment { get; set; }
        
        /// <value>
        /// The region the resource belongs to.
        /// </value>
        [JsonProperty(PropertyName = "resourceRegion")]
        public string ResourceRegion { get; set; }
        
        /// <value>
        /// The last known compliance state of the fleet.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ComplianceState is required.")]
        [JsonProperty(PropertyName = "complianceState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ComplianceState> ComplianceState { get; set; }
        
        /// <value>
        /// Products associated with the Fleet. 
        /// Only the products belonging to managed targets will be shown.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "products")]
        public System.Collections.Generic.List<ComplianceReportProduct> Products { get; set; }
        
    }
}
