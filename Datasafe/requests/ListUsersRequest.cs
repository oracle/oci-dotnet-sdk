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
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/datasafe/ListUsers.cs.html">here</a> to see an example of how to use ListUsers request.
    /// </example>
    public class ListUsersRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the user assessment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UserAssessmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "userAssessmentId")]
        public string UserAssessmentId { get; set; }
        
        /// <value>
        /// For list pagination. The maximum number of items to return per page in a paginated \"List\" call. For details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/en-us/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
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
        /// A filter to return only items that match the specified user category.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "userCategory")]
        public string UserCategory { get; set; }
        
        /// <value>
        /// A filter to return only items that match the specified user role.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "userRole")]
        public string UserRole { get; set; }
        
        /// <value>
        /// A filter to return only items that match the specified user profile.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "userProfile")]
        public string UserProfile { get; set; }
        
        /// <value>
        /// A filter to return only items that match the specified user type. The possible values can be
        ///   - ADMIN_PRIVILEGED
        ///   - APPLICATION
        ///   - PRIVILEGED
        ///   - SCHEMA
        ///   - NON_PRIVILEGED
        /// as specified by '#/definitions/userTypes'.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "userType")]
        public string UserType { get; set; }
        
        /// <value>
        /// A filter to return only items that match the specified user key.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "userKey")]
        public string UserKey { get; set; }
        
        /// <value>
        /// A filter to return only items that match the specified account status.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "accountStatus")]
        public string AccountStatus { get; set; }
        
        /// <value>
        /// A filter to return only items that match the specified authentication type.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "authenticationType")]
        public string AuthenticationType { get; set; }
        
        /// <value>
        /// A filter to return only items that match the specified user name.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "userName")]
        public string UserName { get; set; }
        
        /// <value>
        /// A filter to return only items related to a specific target OCID.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "targetId")]
        public string TargetId { get; set; }
        
        /// <value>
        /// A filter to return users whose last login time in the database is greater than or equal to the date and time specified, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// **Example: ** 2016-12-19T16:39:57.600Z
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeLastLoginGreaterThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeLastLoginGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// A filter to return users whose last login time in the database is less than the date and time specified, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// **Example: ** 2016-12-19T16:39:57.600Z
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeLastLoginLessThan")]
        public System.Nullable<System.DateTime> TimeLastLoginLessThan { get; set; }
        
        /// <value>
        /// A filter to return users whose creation time in the database is greater than or equal to the date and time specified, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// **Example: ** 2016-12-19T16:39:57.600Z
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeUserCreatedGreaterThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeUserCreatedGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// A filter to return users whose creation time in the database is less than the date and time specified, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// **Example: ** 2016-12-19T16:39:57.600Z
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeUserCreatedLessThan")]
        public System.Nullable<System.DateTime> TimeUserCreatedLessThan { get; set; }
        
        /// <value>
        /// A filter to return users whose last password change in the database is greater than or equal to the date and time specified, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// **Example: ** 2016-12-19T16:39:57.600Z
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timePasswordLastChangedGreaterThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimePasswordLastChangedGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// A filter to return users whose last password change in the database is less than the date and time specified, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// **Example: ** 2016-12-19T16:39:57.600Z
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timePasswordLastChangedLessThan")]
        public System.Nullable<System.DateTime> TimePasswordLastChangedLessThan { get; set; }
        
        /// <value>
        /// For list pagination. The page token representing the page at which to start retrieving results. It is usually retrieved from a previous \"List\" call. For details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/en-us/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
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
        /// The field to sort by. You can specify only one sort order (sortOrder). The default order for userName is ascending.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "userName")]
            UserName,
            [EnumMember(Value = "userCategory")]
            UserCategory,
            [EnumMember(Value = "accountStatus")]
            AccountStatus,
            [EnumMember(Value = "timeLastLogin")]
            TimeLastLogin,
            [EnumMember(Value = "targetId")]
            TargetId,
            [EnumMember(Value = "timeUserCreated")]
            TimeUserCreated,
            [EnumMember(Value = "authenticationType")]
            AuthenticationType,
            [EnumMember(Value = "timePasswordChanged")]
            TimePasswordChanged
        };

        /// <value>
        /// The field to sort by. You can specify only one sort order (sortOrder). The default order for userName is ascending.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// Unique identifier for the request.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// A filter to return items that contain the specified schema list.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "schemaList", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> SchemaList { get; set; }
        
        /// <value>
        /// A filter to return only items that match the criteria that all schemas can be accessed by a user.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "areAllSchemasAccessible")]
        public System.Nullable<bool> AreAllSchemasAccessible { get; set; }
    }
}
