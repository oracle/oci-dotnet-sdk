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
    /// The details about the available capacity and constraints for different resource types present in the availability catalog.
    /// </summary>
    public class OccAvailabilitySummary 
    {
        
        /// <value>
        /// The OCID of the availability catalog.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CatalogId is required.")]
        [JsonProperty(PropertyName = "catalogId")]
        public string CatalogId { get; set; }
        
        /// <value>
        /// The name of the OCI service in consideration. For example, Compute, Exadata, and so on.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Namespace is required.")]
        [JsonProperty(PropertyName = "namespace")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<Namespace> Namespace { get; set; }
        
        /// <value>
        /// The date by which the customer must place the order to have their capacity requirements met by the customer handover date.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DateFinalCustomerOrder is required.")]
        [JsonProperty(PropertyName = "dateFinalCustomerOrder")]
        public System.Nullable<System.DateTime> DateFinalCustomerOrder { get; set; }
        
        /// <value>
        /// The date by which the capacity requested by customers before dateFinalCustomerOrder needs to be fulfilled.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DateExpectedCapacityHandover is required.")]
        [JsonProperty(PropertyName = "dateExpectedCapacityHandover")]
        public System.Nullable<System.DateTime> DateExpectedCapacityHandover { get; set; }
        
        /// <value>
        /// The different types of resources against which customers can place capacity requests.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceType is required.")]
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }
        
        /// <value>
        /// The type of workload (Generic/ROW).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WorkloadType is required.")]
        [JsonProperty(PropertyName = "workloadType")]
        public string WorkloadType { get; set; }
        
        /// <value>
        /// The name of the resource that the customer can request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceName is required.")]
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }
        
        /// <value>
        /// The quantity of resource currently available that the customer can request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AvailableQuantity is required.")]
        [JsonProperty(PropertyName = "availableQuantity")]
        public System.Nullable<long> AvailableQuantity { get; set; }
        
        /// <value>
        /// The total quantity of resource that the customer can request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalAvailableQuantity is required.")]
        [JsonProperty(PropertyName = "totalAvailableQuantity")]
        public System.Nullable<long> TotalAvailableQuantity { get; set; }
        
        /// <value>
        /// The quantity of resource currently demanded by the customer.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DemandedQuantity is required.")]
        [JsonProperty(PropertyName = "demandedQuantity")]
        public System.Nullable<long> DemandedQuantity { get; set; }
        
        /// <value>
        /// The unit in which the resource available is measured.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Unit is required.")]
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }
        
        /// <value>
        /// System tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
