/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatabasemanagementService.Models;

namespace Oci.DatabasemanagementService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/databasemanagement/ListManagedMySqlDatabaseSqlData.cs.html">here</a> to see an example of how to use ListManagedMySqlDatabaseSqlData request.
    /// </example>
    public class ListManagedMySqlDatabaseSqlDataRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the Managed MySQL Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ManagedMySqlDatabaseId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "managedMySqlDatabaseId")]
        public string ManagedMySqlDatabaseId { get; set; }
        
        /// <value>
        /// The start time of the time range to retrieve the health metrics of a Managed Database
        /// in UTC in ISO-8601 format, which is \"yyyy-MM-dd'T'hh:mm:ss.sss'Z'\".
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StartTime is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "startTime")]
        public string StartTime { get; set; }
        
        /// <value>
        /// The end time of the time range to retrieve the health metrics of a Managed Database
        /// in UTC in ISO-8601 format, which is \"yyyy-MM-dd'T'hh:mm:ss.sss'Z'\".
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EndTime is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "endTime")]
        public string EndTime { get; set; }
        
        /// <value>
        /// The parameter to filter results by key criteria which include :
        /// - AVG_TIMER_WAIT
        /// - SUM_TIMER_WAIT
        /// - COUNT_STAR
        /// - SUM_ERRORS
        /// - SUM_ROWS_AFFECTED
        /// - SUM_ROWS_SENT
        /// - SUM_ROWS_EXAMINED
        /// - SUM_CREATED_TMP_TABLES
        /// - SUM_NO_INDEX_USED
        /// - SUM_NO_GOOD_INDEX_USED
        /// - FIRST_SEEN
        /// - LAST_SEEN
        /// - HEATWAVE_OFFLOADED
        /// - HEATWAVE_OUT_OF_MEMORY
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "filterColumn")]
        public string FilterColumn { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// The maximum number of records returned in the paginated response.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The page token representing the page from where the next set of paginated results
        /// are retrieved. This is usually retrieved from a previous list call.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        ///
        /// <value>
        /// The field to sort information by. Only one sortOrder can be used. The default sort order
        /// for \u2018TIMECREATED\u2019 is descending and the default sort order for \u2018NAME\u2019 is ascending.
        /// The \u2018NAME\u2019 sort order is case-sensitive.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "TIMECREATED")]
            Timecreated,
            [EnumMember(Value = "NAME")]
            Name
        };

        /// <value>
        /// The field to sort information by. Only one sortOrder can be used. The default sort order
        /// for \u2018TIMECREATED\u2019 is descending and the default sort order for \u2018NAME\u2019 is ascending.
        /// The \u2018NAME\u2019 sort order is case-sensitive.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// The option to sort information in ascending (\u2018ASC\u2019) or descending (\u2018DESC\u2019) order. Ascending order is the default order.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrders> SortOrder { get; set; }
    }
}
