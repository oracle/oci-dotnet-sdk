/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.IdentityService.Models;

namespace Oci.IdentityService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/identity/ListBulkActionResourceTypes.cs.html">here</a> to see an example of how to use ListBulkActionResourceTypes request.
    /// </example>
    public class ListBulkActionResourceTypesRequest : Oci.Common.IOciRequest
    {
        
        ///
        /// <value>
        /// The type of bulk action.
        /// 
        /// </value>
        ///
        public enum BulkActionTypeEnum {
            [EnumMember(Value = "BULK_MOVE_RESOURCES")]
            BulkMoveResources,
            [EnumMember(Value = "BULK_DELETE_RESOURCES")]
            BulkDeleteResources
        };

        /// <value>
        /// The type of bulk action.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BulkActionType is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "bulkActionType")]
        public System.Nullable<BulkActionTypeEnum> BulkActionType { get; set; }
        
        /// <value>
        /// The value of the `opc-next-page` response header from the previous \"List\" call.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The maximum number of items to return in a paginated \"List\" call.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
    }
}
