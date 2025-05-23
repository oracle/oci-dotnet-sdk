/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.OpsiService.Models;

namespace Oci.OpsiService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/opsi/SummarizeAwrDatabaseWaitEventBuckets.cs.html">here</a> to see an example of how to use SummarizeAwrDatabaseWaitEventBuckets request.
    /// </example>
    public class SummarizeAwrDatabaseWaitEventBucketsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// Unique Awr Hub identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AwrHubId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "awrHubId")]
        public string AwrHubId { get; set; }
        
        /// <value>
        /// The internal ID of the database. The internal ID of the database is not the [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// It can be retrieved from the following endpoint:
        /// /awrHubs/{awrHubId}/awrDatabases
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AwrSourceDatabaseIdentifier is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "awrSourceDatabaseIdentifier")]
        public string AwrSourceDatabaseIdentifier { get; set; }
        
        /// <value>
        /// The required single value query parameter to filter the entity name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The optional single value query parameter to filter by database instance number.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "instanceNumber")]
        public string InstanceNumber { get; set; }
        
        /// <value>
        /// The optional greater than or equal to filter on the snapshot ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "beginSnapshotIdentifierGreaterThanOrEqualTo")]
        public System.Nullable<int> BeginSnapshotIdentifierGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// The optional less than or equal to query parameter to filter the snapshot Identifier.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "endSnapshotIdentifierLessThanOrEqualTo")]
        public System.Nullable<int> EndSnapshotIdentifierLessThanOrEqualTo { get; set; }
        
        /// <value>
        /// The optional greater than or equal to query parameter to filter the timestamp. The timestamp format to be followed is: YYYY-MM-DDTHH:MM:SSZ, example 2020-12-03T19:00:53Z
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeGreaterThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// The optional less than or equal to query parameter to filter the timestamp. The timestamp format to be followed is: YYYY-MM-DDTHH:MM:SSZ, example 2020-12-03T19:00:53Z
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeLessThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeLessThanOrEqualTo { get; set; }
        
        /// <value>
        /// The number of buckets within the histogram.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "numBucket")]
        public System.Nullable<int> NumBucket { get; set; }
        
        /// <value>
        /// The minimum value of the histogram.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "minValue")]
        public System.Double MinValue { get; set; }
        
        /// <value>
        /// The maximum value of the histogram.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "maxValue")]
        public System.Double MaxValue { get; set; }
        
        /// <value>
        /// For list pagination. The value of the `opc-next-page` response header from
        /// the previous \"List\" call. For important details about how pagination works,
        /// see [List Pagination](https://docs.cloud.oracle.com/Content/API/Concepts/usingapi.htm#nine).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// For list pagination. The maximum number of results per page, or items to
        /// return in a paginated \"List\" call.
        /// For important details about how pagination works, see
        /// [List Pagination](https://docs.cloud.oracle.com/Content/API/Concepts/usingapi.htm#nine).
        /// Example: 50
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        ///
        /// <value>
        /// The option to sort distribution data.
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "CATEGORY")]
            Category,
            [EnumMember(Value = "PERCENTAGE")]
            Percentage
        };

        /// <value>
        /// The option to sort distribution data.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// The sort order to use, either ascending (`ASC`) or descending (`DESC`).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrder> SortOrder { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact
        /// Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
