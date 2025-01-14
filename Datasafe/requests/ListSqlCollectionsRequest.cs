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
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/datasafe/ListSqlCollections.cs.html">here</a> to see an example of how to use ListSqlCollections request.
    /// </example>
    public class ListSqlCollectionsRequest : Oci.Common.IOciRequest
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
        /// Valid values are RESTRICTED and ACCESSIBLE. Default is RESTRICTED.
        /// Setting this to ACCESSIBLE returns only those compartments for which the
        /// user has INSPECT permissions directly or indirectly (permissions can be on a
        /// resource in a subcompartment). When set to RESTRICTED permissions are checked and no partial results are displayed.
        /// 
        /// </value>
        ///
        public enum AccessLevelEnum {
            [EnumMember(Value = "RESTRICTED")]
            Restricted,
            [EnumMember(Value = "ACCESSIBLE")]
            Accessible
        };

        /// <value>
        /// Valid values are RESTRICTED and ACCESSIBLE. Default is RESTRICTED.
        /// Setting this to ACCESSIBLE returns only those compartments for which the
        /// user has INSPECT permissions directly or indirectly (permissions can be on a
        /// resource in a subcompartment). When set to RESTRICTED permissions are checked and no partial results are displayed.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "accessLevel")]
        public System.Nullable<AccessLevelEnum> AccessLevel { get; set; }
        
        /// <value>
        /// A filter to return only resources that match the specified display name.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "displayName")]
        public string DisplayName { get; set; }
        
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
        /// The current state of the SQL collection.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleState")]
        public System.Nullable<SqlCollectionLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// An optional filter to return only resources that match the specified OCID of the SQL collection resource.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sqlCollectionId")]
        public string SqlCollectionId { get; set; }
        
        /// <value>
        /// A filter to return only the resources that were created after the specified date and time, as defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Using TimeCreatedGreaterThanOrEqualToQueryParam parameter retrieves all resources created after that date.
        /// <br/>
        /// **Example: ** 2016-12-19T16:39:57.600Z
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeCreatedGreaterThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeCreatedGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// Search for resources that were created before a specific date.
        /// Specifying this parameter corresponding `timeCreatedLessThan`
        /// parameter will retrieve all resources created before the
        /// specified created date, in \"YYYY-MM-ddThh:mmZ\" format with a Z offset, as
        /// defined by RFC 3339.
        /// <br/>
        /// **Example: ** 2016-12-19T16:39:57.600Z
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeCreatedLessThan")]
        public System.Nullable<System.DateTime> TimeCreatedLessThan { get; set; }
        
        /// <value>
        /// A filter to return only items related to a specific target OCID.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "targetId")]
        public string TargetId { get; set; }
        
        /// <value>
        /// A filter to return only items that match the specified user name.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "dbUserName")]
        public string DbUserName { get; set; }
        
        ///
        /// <value>
        /// The sort order to use, either ascending (ASC) or descending (DESC).
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// The sort order to use, either ascending (ASC) or descending (DESC).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        ///
        /// <value>
        /// The field used for sorting. Only one sorting parameter order (sortOrder) can be specified.
        /// The DISPLAYNAME sort order is case sensitive.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "TIMECREATED")]
            Timecreated,
            [EnumMember(Value = "DISPLAYNAME")]
            Displayname,
            [EnumMember(Value = "TIMELASTSTARTED")]
            Timelaststarted
        };

        /// <value>
        /// The field used for sorting. Only one sorting parameter order (sortOrder) can be specified.
        /// The DISPLAYNAME sort order is case sensitive.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// Unique identifier for the request.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
