/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatasafeService.Models;

namespace Oci.DatasafeService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/datasafe/ListDiscoveryAnalytics.cs.html">here</a> to see an example of how to use ListDiscoveryAnalytics request.
    /// </example>
    public class ListDiscoveryAnalyticsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// A filter to return only resources that match the specified compartment OCID.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Default is false.
        /// When set to true, the hierarchy of compartments is traversed and all compartments and subcompartments in the tenancy are returned. Depends on the 'accessLevel' setting.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentIdInSubtree")]
        public System.Nullable<bool> CompartmentIdInSubtree { get; set; }
        
        ///
        /// <value>
        /// Attribute by which the discovery analytics data should be grouped.
        /// </value>
        ///
        public enum GroupByEnum {
            [EnumMember(Value = "targetId")]
            TargetId,
            [EnumMember(Value = "sensitiveDataModelId")]
            SensitiveDataModelId,
            [EnumMember(Value = "sensitiveTypeId")]
            SensitiveTypeId,
            [EnumMember(Value = "targetIdAndSensitiveDataModelId")]
            TargetIdAndSensitiveDataModelId,
            [EnumMember(Value = "sensitiveTypeIdAndTargetId")]
            SensitiveTypeIdAndTargetId,
            [EnumMember(Value = "sensitiveTypeIdAndSensitiveDataModelId")]
            SensitiveTypeIdAndSensitiveDataModelId
        };

        /// <value>
        /// Attribute by which the discovery analytics data should be grouped.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "groupBy")]
        public System.Nullable<GroupByEnum> GroupBy { get; set; }
        
        /// <value>
        /// A filter to return only items related to a specific target OCID.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "targetId")]
        public string TargetId { get; set; }
        
        /// <value>
        /// A filter to return only the resources that match the specified sensitive data model OCID.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sensitiveDataModelId")]
        public string SensitiveDataModelId { get; set; }
        
        /// <value>
        /// A filter to return only items related to a specific sensitive type OCID.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sensitiveTypeId")]
        public string SensitiveTypeId { get; set; }
        
        /// <value>
        /// For list pagination. The maximum number of items to return per page in a paginated \"List\" call. For details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/en-us/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// For list pagination. The page token representing the page at which to start retrieving results. It is usually retrieved from a previous \"List\" call. For details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/en-us/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// Unique identifier for the request.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// A filter to return only the common sensitive type resources. Common sensitive types belong to 
        /// library sensitive types which are frequently used to perform sensitive data discovery.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isCommon")]
        public System.Nullable<bool> IsCommon { get; set; }
    }
}
