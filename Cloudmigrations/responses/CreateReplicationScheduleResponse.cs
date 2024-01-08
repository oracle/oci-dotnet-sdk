/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Runtime.Serialization;
using Oci.CloudmigrationsService.Models;

namespace Oci.CloudmigrationsService.Responses
{
    public class CreateReplicationScheduleResponse : Oci.Common.IOciResponse
    {

        /// <value>
        /// For optimistic concurrency control, see `if-match.`
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "etag")]
        public string Etag { get; set; }


        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact
        /// Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }


        /// <value>
        /// Unique Oracle-assigned identifier for the asynchronous request. You can use this to query status of the asynchronous operation.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-work-request-id")]
        public string OpcWorkRequestId { get; set; }


        /// <value>
        /// The full URI of the resource related to the request
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "location")]
        public string Location { get; set; }


        /// <value>
        /// The full URI of the resource related to the request
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "content-location")]
        public string ContentLocation { get; set; }

        /// <value>
        /// The returned ReplicationSchedule instance.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public ReplicationSchedule ReplicationSchedule { get; set; }

    }
}
