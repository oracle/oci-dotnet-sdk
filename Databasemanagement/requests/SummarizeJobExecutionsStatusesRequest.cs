/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
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
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/databasemanagement/SummarizeJobExecutionsStatuses.cs.html">here</a> to see an example of how to use SummarizeJobExecutionsStatuses request.
    /// </example>
    public class SummarizeJobExecutionsStatusesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The start time of the time range to retrieve the status summary of job executions
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
        /// The end time of the time range to retrieve the status summary of job executions
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
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// The identifier of the resource.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Managed Database Group.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "managedDatabaseGroupId")]
        public string ManagedDatabaseGroupId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Managed Database.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "managedDatabaseId")]
        public string ManagedDatabaseId { get; set; }
        
        /// <value>
        /// A filter to return only resources that match the entire name.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "name")]
        public string Name { get; set; }
        
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