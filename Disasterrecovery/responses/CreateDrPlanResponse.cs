/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Runtime.Serialization;
using Oci.DisasterrecoveryService.Models;

namespace Oci.DisasterrecoveryService.Responses
{
    public class CreateDrPlanResponse : Oci.Common.IOciResponse
    {

        /// <value>
        /// A URI for the new resource which was created by the request.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "location")]
        public string Location { get; set; }


        /// <value>
        /// For optimistic concurrency control. For more information, see [ETags for Optimistic Concurrency Control](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#eleven).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "etag")]
        public string Etag { get; set; }


        /// <value>
        /// Unique Oracle-assigned identifier (OCID) for the asynchronous request. You can use this to query status of the asynchronous operation. Use {@link #getWorkRequest(GetWorkRequestRequest) getWorkRequest} with this OCID to track the status of the request.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-work-request-id")]
        public string OpcWorkRequestId { get; set; }


        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact
        /// Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }

        /// <value>
        /// The returned DrPlan instance.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public DrPlan DrPlan { get; set; }

    }
}
