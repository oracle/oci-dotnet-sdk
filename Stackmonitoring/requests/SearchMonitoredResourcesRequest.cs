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
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/stackmonitoring/SearchMonitoredResources.cs.html">here</a> to see an example of how to use SearchMonitoredResources request.
    /// </example>
    public class SearchMonitoredResourcesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// Search Criteria for listing monitored resources.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SearchMonitoredResourcesDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public SearchMonitoredResourcesDetails SearchMonitoredResourcesDetails { get; set; }
        
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
        /// Partial response refers to an optimization technique offered
        /// by the RESTful web APIs, to return only the information
        /// (fields) required by the client. In this mechanism, the client
        /// sends the required field names as the query parameters for
        /// an API to the server, and the server trims down the default
        /// response content by removing the fields that are not required
        /// by the client. The parameter controls which fields to
        /// return and should be a query string parameter called \"fields\" of
        /// an array type, provide the values as enums, and use collectionFormat.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "fields", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> Fields { get; set; }
        
        /// <value>
        /// Partial response refers to an optimization technique offered
        /// by the RESTful web APIs, to return all the information except
        /// the fields requested to be excluded (excludeFields) by the client.
        /// In this mechanism, the client
        /// sends the exclude field names as the query parameters for
        /// an API to the server, and the server trims down the default
        /// response content by removing the fields that are not required
        /// by the client. The parameter controls which fields to
        /// exlude and to return and should be a query string parameter
        /// called \"excludeFields\" of an array type, provide the values
        /// as enums, and use collectionFormat.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "excludeFields", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> ExcludeFields { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a
        /// particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// A token that uniquely identifies a request so it can be retried in case of a timeout or
        /// server error without risk of executing that same action again. Retry tokens expire after 24
        /// hours, but can be invalidated before then due to conflicting operations. For example, if a resource
        /// has been deleted and purged from the system, then a retry of the original creation request
        /// might be rejected.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-retry-token")]
        public string OpcRetryToken { get; set; }
        
        /// <value>
        /// For optimistic concurrency control. In the PUT or DELETE call
        /// for a resource, set the `if-match` parameter to the value of the
        /// etag from a previous GET or POST response for that resource.
        /// The resource will be updated or deleted only if the etag you
        /// provide matches the resource's current etag value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-match")]
        public string IfMatch { get; set; }
    }
}
