/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.JmsjavadownloadsService.Models;

namespace Oci.JmsjavadownloadsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/jmsjavadownloads/RequestSummarizedJavaDownloadCounts.cs.html">here</a> to see an example of how to use RequestSummarizedJavaDownloadCounts request.
    /// </example>
    public class RequestSummarizedJavaDownloadCountsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// Details for retreiving the summary of download counts.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RequestSummarizedJavaDownloadCountsDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public RequestSummarizedJavaDownloadCountsDetails RequestSummarizedJavaDownloadCountsDetails { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
