/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.ApmtracesService.Models;

namespace Oci.ApmtracesService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/apmtraces/PutToggleAutoActivate.cs.html">here</a> to see an example of how to use PutToggleAutoActivate request.
    /// </example>
    public class PutToggleAutoActivateRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The APM Domain ID for the intended request.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ApmDomainId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "apmDomainId")]
        public string ApmDomainId { get; set; }
        
        /// <value>
        /// Autoactivate toggle switch.  Set to true to turn on auto-activate.  Set to false to turn off auto-activate.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsAutoActivateOn is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isAutoActivateOn")]
        public System.Nullable<bool> IsAutoActivateOn { get; set; }
        
        ///
        /// <value>
        /// Data key type for which auto-activate needs to be turned on or off.
        /// 
        /// </value>
        ///
        public enum DataKeyTypeEnum {
            [EnumMember(Value = "PRIVATE_DATA_KEY")]
            PrivateDataKey,
            [EnumMember(Value = "PUBLIC_DATA_KEY")]
            PublicDataKey
        };

        /// <value>
        /// Data key type for which auto-activate needs to be turned on or off.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DataKeyType is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "dataKeyType")]
        public System.Nullable<DataKeyTypeEnum> DataKeyType { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request.  If you need to contact Oracle about a
        /// particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
