/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.LimitsService.Models;

namespace Oci.LimitsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/limits/ListLimitValues.cs.html">here</a> to see an example of how to use ListLimitValues request.
    /// </example>
    public class ListLimitValuesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the parent compartment (remember that the tenancy is simply the root compartment).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The target service name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ServiceName is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "serviceName")]
        public string ServiceName { get; set; }
        
        /// <value>
        /// The OCID of the subscription assigned to tenant
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "subscriptionId")]
        public string SubscriptionId { get; set; }
        
        ///
        /// <value>
        /// Filter entries by scope type.
        /// </value>
        ///
        public enum ScopeTypeEnum {
            [EnumMember(Value = "GLOBAL")]
            Global,
            [EnumMember(Value = "REGION")]
            Region,
            [EnumMember(Value = "AD")]
            Ad
        };

        /// <value>
        /// Filter entries by scope type.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "scopeType")]
        public System.Nullable<ScopeTypeEnum> ScopeType { get; set; }
        
        /// <value>
        /// Filter entries by availability domain. This implies that only AD-specific values are returned.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// Optional field, can be used to see a specific resource limit value.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "name")]
        public string Name { get; set; }
        
        ///
        /// <value>
        /// The field to sort by. The sorting is by availabilityDomain, as a second level field, if available.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "name")]
            Name
        };

        /// <value>
        /// The field to sort by. The sorting is by availabilityDomain, as a second level field, if available.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        ///
        /// <value>
        /// The sort order to use, either 'asc' or 'desc'. By default, it is ascending.
        /// 
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// The sort order to use, either 'asc' or 'desc'. By default, it is ascending.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        /// <value>
        /// The maximum number of items to return in a paginated \"List\" call.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The value of the `opc-next-page` response header from the previous \"List\" call.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a
        /// particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
