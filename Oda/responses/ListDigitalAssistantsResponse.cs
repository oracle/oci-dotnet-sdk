/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Runtime.Serialization;
using Oci.OdaService.Models;

namespace Oci.OdaService.Responses
{
    public class ListDigitalAssistantsResponse : Oci.Common.OciResponse
    {

        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact
        /// Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }


        /// <value>
        /// When you are paging through a list, if this header appears in the response,
        /// then there might be additional items still to get. Include this value as the
        /// `page` query parameter for the subsequent GET request.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-next-page")]
        public string OpcNextPage { get; set; }


        /// <value>
        /// The total number of results that match the query.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-total-items")]
        public System.Nullable<int> OpcTotalItems { get; set; }

        /// <value>
        /// The returned DigitalAssistantCollection instance.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public DigitalAssistantCollection DigitalAssistantCollection { get; set; }

    }
}
