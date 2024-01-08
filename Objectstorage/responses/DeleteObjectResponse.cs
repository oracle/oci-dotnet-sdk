/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Runtime.Serialization;
using Oci.ObjectstorageService.Models;

namespace Oci.ObjectstorageService.Responses
{
    public class DeleteObjectResponse : Oci.Common.IOciResponse
    {

        /// <value>
        /// Echoes back the value passed in the opc-client-request-id header, for use by clients when debugging.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-client-request-id")]
        public string OpcClientRequestId { get; set; }


        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular
        /// request, provide this request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }


        /// <value>
        /// The time the object was deleted, as described in [RFC 2616](https://tools.ietf.org/html/rfc2616#section-14.29).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "last-modified")]
        public System.Nullable<System.DateTime> LastModified { get; set; }


        /// <value>
        /// The `versionId` of the delete marker created as a result of the DELETE Object.
        /// If the request contains a specific `versionId`, then this response header will be the same as the requested `versionId` of the object that was deleted.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "version-id")]
        public string VersionId { get; set; }


        /// <value>
        /// This is `true` if the deleted object is a delete marker, otherwise `false`
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "is-delete-marker")]
        public System.Nullable<bool> IsDeleteMarker { get; set; }



    }
}
