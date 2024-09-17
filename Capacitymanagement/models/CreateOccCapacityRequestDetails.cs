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
    /// Details about the create request for the capacity request.
    /// 
    /// </summary>
    public class CreateOccCapacityRequestDetails 
    {
        
        /// <value>
        /// Since all resources are at tenancy level hence this will be the ocid of the tenancy where operation is to be performed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The OCID of the availability catalog against which capacity request is made.
        /// </value>
        [JsonProperty(PropertyName = "occAvailabilityCatalogId")]
        public string OccAvailabilityCatalogId { get; set; }
        
        /// <value>
        /// The name of the OCI service in consideration. For example, Compute, Exadata, and so on.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Namespace is required.")]
        [JsonProperty(PropertyName = "namespace")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Namespace> Namespace { get; set; }
        
        /// <value>
        /// The name of the region for which the capacity request is made.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Region is required.")]
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }
        
        /// <value>
        /// An user-friendly name for the capacity request. Does not have to be unique, and it's changeable. Avoid entering confidential information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Type of Capacity Request(New or Transfer)
        /// </value>
        [JsonProperty(PropertyName = "requestType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OccCapacityRequest.RequestTypeEnum> RequestType { get; set; }
        
        /// <value>
        /// Meaningful text about the capacity request.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in a Failed State.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The availability domain (AD) in which the new resource is to be placed. If this is specified then the capacity will be validated and fulfilled within the scope of this AD. Note that this field is NOT required for Capacity request Transfer requests.
        /// </value>
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
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
        /// The subset of request states available for creating the capacity request.
        /// </value>
        ///
        public enum RequestStateEnum {
            [EnumMember(Value = "CREATED")]
            Created,
            [EnumMember(Value = "SUBMITTED")]
            Submitted
        };

        /// <value>
        /// The subset of request states available for creating the capacity request.
        /// </value>
        [JsonProperty(PropertyName = "requestState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RequestStateEnum> RequestState { get; set; }
        
        /// <value>
        /// A list of different resources requested by the user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Details is required.")]
        [JsonProperty(PropertyName = "details")]
        public System.Collections.Generic.List<OccCapacityRequestBaseDetails> Details { get; set; }
        
    }
}
