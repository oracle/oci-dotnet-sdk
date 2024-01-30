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
                ///
        /// <value>
        /// The different types of resources against which customers can place capacity requests.
        /// </value>
        ///
        public enum ResourceTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SERVER_HW")]
            ServerHw,
            [EnumMember(Value = "CAPACITY_CONSTRAINT")]
            CapacityConstraint
        };

        /// <value>
        /// The different types of resources against which customers can place capacity requests.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceType is required.")]
        [JsonProperty(PropertyName = "resourceType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ResourceTypeEnum> ResourceType { get; set; }
                ///
        /// <value>
        /// The type of workload (Generic/ROW).
        /// </value>
        ///
        public enum WorkloadTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "GENERIC")]
            Generic,
            [EnumMember(Value = "ROW")]
            Row,
            [EnumMember(Value = "US_PROD")]
            UsProd
        };

        /// <value>
        /// The type of workload (Generic/ROW).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WorkloadType is required.")]
        [JsonProperty(PropertyName = "workloadType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<WorkloadTypeEnum> WorkloadType { get; set; }
        
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
        /// The quantity of available resource that the customer can request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AvailableQuantity is required.")]
        [JsonProperty(PropertyName = "availableQuantity")]
        public System.Nullable<long> AvailableQuantity { get; set; }
        
        /// <value>
        /// The unit in which the resource available is measured.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Unit is required.")]
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }
        
    }
}