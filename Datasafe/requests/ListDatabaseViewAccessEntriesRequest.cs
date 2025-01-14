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
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/datasafe/ListDatabaseViewAccessEntries.cs.html">here</a> to see an example of how to use ListDatabaseViewAccessEntries request.
    /// </example>
    public class ListDatabaseViewAccessEntriesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the security policy report resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SecurityPolicyReportId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "securityPolicyReportId")]
        public string SecurityPolicyReportId { get; set; }
        
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
        /// The scimQuery query parameter accepts filter expressions that use the syntax described in Section 3.2.2.2
        /// of the System for Cross-Domain Identity Management (SCIM) specification, which is available
        /// at [RFC3339](https://tools.ietf.org/html/draft-ietf-scim-api-12). In SCIM filtering expressions,
        /// text, date, and time values must be enclosed in quotation marks, with date and time values using ISO-8601 format.
        /// (Numeric and boolean values should not be quoted.)
        /// <br/>
        /// **Example: ** query=(accessType eq 'SELECT') and (grantee eq 'ADMIN')
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "scimQuery")]
        public string ScimQuery { get; set; }
        
        /// <value>
        /// A filter to return only items related to a specific target OCID.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "targetId")]
        public string TargetId { get; set; }
        
        ///
        /// <value>
        /// The field to sort by. Only one sort parameter should be provided.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "key")]
            Key,
            [EnumMember(Value = "grantee")]
            Grantee,
            [EnumMember(Value = "accessType")]
            AccessType,
            [EnumMember(Value = "tableSchema")]
            TableSchema,
            [EnumMember(Value = "tableName")]
            TableName,
            [EnumMember(Value = "viewSchema")]
            ViewSchema,
            [EnumMember(Value = "viewName")]
            ViewName,
            [EnumMember(Value = "privilegeType")]
            PrivilegeType,
            [EnumMember(Value = "privilege")]
            Privilege,
            [EnumMember(Value = "privilegeGrantable")]
            PrivilegeGrantable,
            [EnumMember(Value = "grantFromRole")]
            GrantFromRole,
            [EnumMember(Value = "accessThroughObject")]
            AccessThroughObject,
            [EnumMember(Value = "columnName")]
            ColumnName,
            [EnumMember(Value = "grantor")]
            Grantor,
            [EnumMember(Value = "isAccessConstrainedByDatabaseVault")]
            IsAccessConstrainedByDatabaseVault,
            [EnumMember(Value = "isAccessConstrainedByVirtualPrivateDatabase")]
            IsAccessConstrainedByVirtualPrivateDatabase,
            [EnumMember(Value = "isAccessConstrainedByRedaction")]
            IsAccessConstrainedByRedaction,
            [EnumMember(Value = "isAccessConstrainedByRealApplicationSecurity")]
            IsAccessConstrainedByRealApplicationSecurity,
            [EnumMember(Value = "isAccessConstrainedBySqlFirewall")]
            IsAccessConstrainedBySqlFirewall
        };

        /// <value>
        /// The field to sort by. Only one sort parameter should be provided.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
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
        
        /// <value>
        /// Unique identifier for the request.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
