/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.AnnouncementsService.Models;

namespace Oci.AnnouncementsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/announcementsservice/ListServices.cs.html">here</a> to see an example of how to use ListServices request.
    /// </example>
    public class ListServicesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the compartment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        ///
        /// <value>
        /// A filter to return only announcements affecting a specific platform.
        /// </value>
        ///
        public enum PlatformTypeEnum {
            [EnumMember(Value = "IAAS")]
            Iaas,
            [EnumMember(Value = "SAAS")]
            Saas,
            [EnumMember(Value = "PAAS")]
            Paas
        };

        /// <value>
        /// A filter to return only announcements affecting a specific platform.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "platformType")]
        public System.Nullable<PlatformTypeEnum> PlatformType { get; set; }
        
        /// <value>
        /// Filter by comms manager name
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "commsManagerName")]
        public System.Nullable<CommsManagerName> CommsManagerName { get; set; }
        
        /// <value>
        /// The maximum number of items to return in a paginated \"List\" call.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The value of the `opc-next-page` response header from the previous \"List\" call.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        ///
        /// <value>
        /// Sort by service name parameter
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "serviceName")]
            ServiceName
        };

        /// <value>
        /// Sort by service name parameter
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// The sort order to use, whether ascending ('ASC') or descending ('DESC').
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrder> SortOrder { get; set; }
        
        /// <value>
        /// The unique Oracle-assigned identifier for the request. If you need to contact Oracle about
        /// a particular request, please provide the complete request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}