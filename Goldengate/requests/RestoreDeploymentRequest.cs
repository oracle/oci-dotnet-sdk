/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.GoldengateService.Models;

namespace Oci.GoldengateService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/goldengate/RestoreDeployment.cs.html">here</a> to see an example of how to use RestoreDeployment request.
    /// </example>
    public class RestoreDeploymentRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// A unique DeploymentBackup identifier.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DeploymentBackupId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "deploymentBackupId")]
        public string DeploymentBackupId { get; set; }
        
        /// <value>
        /// A placeholder for any additional metadata to describe the deployment restore.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RestoreDeploymentDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public RestoreDeploymentDetails RestoreDeploymentDetails { get; set; }
        
        /// <value>
        /// For optimistic concurrency control. In the PUT or DELETE call for a resource, set the
        /// `if-match` parameter to the value of the etag from a previous GET or POST response for that
        /// resource.  The resource is updated or deleted only if the etag you provide matches the
        /// resource's current etag value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-match")]
        public string IfMatch { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// A token that uniquely identifies a request so it can be retried, in case of a timeout or server error, 
        /// without the risk of executing that same action again. Retry tokens expire after 24 hours but can be 
        /// invalidated before then due to conflicting operations. For example, if a resource was deleted and purged 
        /// from the system, then a retry of the original creation request is rejected.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-retry-token")]
        public string OpcRetryToken { get; set; }
        
        /// <value>
        /// Whether to override locks (if any exist).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isLockOverride")]
        public System.Nullable<bool> IsLockOverride { get; set; }
    }
}
