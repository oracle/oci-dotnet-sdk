/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.LimitsService.Models;

namespace Oci.LimitsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/limits/GetResourceAvailability.cs.html">here</a> to see an example of how to use GetResourceAvailability request.
    /// </example>
    public class GetResourceAvailabilityRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The service name of the target quota.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ServiceName is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "serviceName")]
        public string ServiceName { get; set; }
        
        /// <value>
        /// The limit name for which to fetch the data.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LimitName is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "limitName")]
        public string LimitName { get; set; }
        
        /// <value>
        /// The OCID of the compartment for which data is being fetched.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// This field is mandatory if the scopeType of the target resource limit is AD.
        /// Otherwise, this field should be omitted.
        /// If the above requirements are not met, the API returns a 400 - InvalidParameter response.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a
        /// particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// The OCID of the subscription assigned to tenant
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "subscriptionId")]
        public string SubscriptionId { get; set; }
    }
}
