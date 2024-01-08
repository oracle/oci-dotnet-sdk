/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.HealthchecksService.Models;

namespace Oci.HealthchecksService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/healthchecks/GetHttpMonitor.cs.html">here</a> to see an example of how to use GetHttpMonitor request.
    /// </example>
    public class GetHttpMonitorRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of a monitor.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MonitorId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "monitorId")]
        public string MonitorId { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a
        /// particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// The `If-None-Match` header field makes the request method conditional on
        /// the absence of any current representation of the target resource, when
        /// the field-value is `*`, or having a selected representation with an
        /// entity-tag that does not match any of those listed in the field-value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-none-match")]
        public string IfNoneMatch { get; set; }
    }
}
