/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.StackmonitoringService.Models;

namespace Oci.StackmonitoringService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/stackmonitoring/ListMetricExtensions.cs.html">here</a> to see an example of how to use ListMetricExtensions request.
    /// </example>
    public class ListMetricExtensionsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// For list pagination. The maximum number of results per page, or items to return in a
        /// paginated \"List\" call. For important details about how pagination works, see
        /// [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// For list pagination. The value of the `opc-next-page` response header from the
        /// previous \"List\" call. For important details about how pagination works, see
        /// [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The field to sort by. Only one sort order may be provided.
        /// Default order for timeCreated is descending. Default order for resources is ascending.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<MetricExtensionSortBy> SortBy { get; set; }
        
        /// <value>
        /// The sort order to use, either ascending (`ASC`) or descending (`DESC`).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrder> SortOrder { get; set; }
        
        /// <value>
        /// The ID of the compartment in which data is listed.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A filter to return resources based on resource type.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "resourceType")]
        public string ResourceType { get; set; }
        
        /// <value>
        /// A filter to return resources based on name.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "name")]
        public string Name { get; set; }
        
        /// <value>
        /// A filter to return resources based on status e.g. Draft or Published
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "status")]
        public System.Nullable<MetricExtensionLifeCycleDetails> Status { get; set; }
        
        /// <value>
        /// A filter to return metric extensions based on Lifecycle State
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleState")]
        public System.Nullable<MetricExtensionLifeCycleStates> LifecycleState { get; set; }
        
        /// <value>
        /// A filter to return metric extensions based on input resource Id on which metric extension is enabled
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "enabledOnResourceId")]
        public string EnabledOnResourceId { get; set; }
        
        /// <value>
        /// Identifier for the metric extension
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "metricExtensionId")]
        public string MetricExtensionId { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a
        /// particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
