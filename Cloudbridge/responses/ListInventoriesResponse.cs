/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Runtime.Serialization;
using Oci.CloudbridgeService.Models;

namespace Oci.CloudbridgeService.Responses
{
    public class ListInventoriesResponse : Oci.Common.OciResponse
    {

        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact
        /// Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }


        /// <value>
        /// For pagination of a list of items. When paging through a list, if this header appears in the response,
        /// then a partial list might have been returned. Include this value as the `page` parameter for the
        /// subsequent GET request to get the next batch of items.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-next-page")]
        public string OpcNextPage { get; set; }

        /// <value>
        /// The returned InventoryCollection instance.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public InventoryCollection InventoryCollection { get; set; }

    }
}
