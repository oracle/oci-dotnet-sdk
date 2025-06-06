/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.FleetappsmanagementService.Models;

namespace Oci.FleetappsmanagementService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/fleetappsmanagement/ListInventoryResources.cs.html">here</a> to see an example of how to use ListInventoryResources request.
    /// </example>
    public class ListInventoryResourcesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// A filter to return only resources whose base Compartment ID(TenancyId) matches the given base Compartment ID.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A filter to return only resources whose resource Compartment ID matches the given resource Compartment ID.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceCompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "resourceCompartmentId")]
        public string ResourceCompartmentId { get; set; }
        
        /// <value>
        /// A filter to return only resources their lifecycleState matches the given lifecycleState.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleState")]
        public string LifecycleState { get; set; }
        
        /// <value>
        /// A filter to return only resources that match the entire display name given.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Resource Region
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "resourceRegion")]
        public string ResourceRegion { get; set; }
        
        /// <value>
        /// A list of tag filters to apply.  Only resources with a defined tag matching the value will be returned.
        /// Each item in the list has the format \"{namespace}.{tagName}={value}\".  All inputs are case-insensitive.
        /// Multiple values for the same key (i.e. same namespace and tag name) are interpreted as \"OR\".
        /// Values for different keys (i.e. different namespaces, different tag names, or both) are interpreted as \"AND\".
        /// Example: Identification.Development=Yes
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "definedTagEquals", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> DefinedTagEquals { get; set; }
        
        /// <value>
        /// A list of tag filters to apply.  Only resources with a freeform tag matching the value will be returned.
        /// The key for each tag is \"{tagName}.{value}\".  All inputs are case-insensitive.
        /// Multiple values for the same tag name are interpreted as \"OR\".  Values for different tag names are interpreted as \"AND\".
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "freeformTagEquals", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> FreeformTagEquals { get; set; }
        
        /// <value>
        /// A list of inventory properties filters to apply.
        /// The key for each inventory property and value for each resource type is \"{resourceType}.{inventoryProperty}={value}\".
        /// Example: Instance.displayName=TEST_INSTANCE
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "inventoryProperties", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> InventoryProperties { get; set; }
        
        /// <value>
        /// Fetch resources matching ANY or ALL criteria passed as params in \"tags\" and \"inventoryProperties\".
        /// Example: matchingCriteria=ANY
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "matchingCriteria")]
        public string MatchingCriteria { get; set; }
        
        /// <value>
        /// The maximum number of items to return.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// A token representing the position at which to start retrieving results. This must come from the `opc-next-page` header field of a previous response.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The sort order to use, either 'ASC' or 'DESC'.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrder> SortOrder { get; set; }
        
        /// <value>
        /// The field to sort by. Only one sort order may be provided. Default order for timeCreated is descending. Default order for displayName is ascending.
        ///     
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<InventoryResourceSortBy> SortBy { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
