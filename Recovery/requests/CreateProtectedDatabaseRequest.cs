/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.RecoveryService.Models;

namespace Oci.RecoveryService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/recovery/CreateProtectedDatabase.cs.html">here</a> to see an example of how to use CreateProtectedDatabase request.
    /// </example>
    public class CreateProtectedDatabaseRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// Describes the parameters required to create a protected database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CreateProtectedDatabaseDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public CreateProtectedDatabaseDetails CreateProtectedDatabaseDetails { get; set; }
        
        /// <value>
        /// A token that uniquely identifies a request so it can be retried in case of a timeout or
        /// server error without risk of executing that same action again. Retry tokens expire after 24
        /// hours, but can be invalidated before then due to conflicting operations. For example, if a resource
        /// has been deleted and purged from the system, then a retry of the original creation request
        /// might be rejected.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-retry-token")]
        public string OpcRetryToken { get; set; }
        
        /// <value>
        /// Unique identifier for the request.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// Indicates if the request is to test the preparedness for creating a protected database, without actually creating a protected database.
        /// <br/>
        /// If you set the `opcDryRun` option as `true`, then Recovery Service only performs a test run to check for any missing prerequisites or configurations required to create a protected database, and then returns error messages to warn you about any missing requirements.
        /// <br/>
        /// If an error occurs, you can review, correct, and repeat the dry run until the `createProtectedDatabase` request does not return any errors.
        /// <br/>
        /// These are the common issues that you can identify by performing a dry run of the `createProtectedDatabase` request:
        /// <br/>
        /// * The Recovery Service subnet has insufficient free IP addresses to support the required number of private endpoints. See, [troubleshooting](https://docs.oracle.com/en/cloud/paas/recovery-service/dbrsu/troubleshoot-backup-failures-recovery-service.html#GUID-05FA08B8-421D-4E52-B84B-7AFB84ADECF9) information
        /// * Recovery Service does not have permissions to manage the network resources in a chosen compartment
        /// * Recovery Service is out of capacity. See, [Service Limits](https://docs.oracle.com/en-us/iaas/Content/General/Concepts/servicelimits.htm) for more information
        /// * Recovery Service resources exceed quota limits
        /// * A protected database, having the same database ID, already exists
        /// * The specified protection policy does not exist, or it is not in an Active state
        /// * The specified Recovery Service subnet does not exist, or it is not in an Active state
        /// <br/>
        /// See, [Prerequisites for Using Recovery Service](https://docs.oracle.com/en/cloud/paas/recovery-service/dbrsu/backup-recover-recovery-service.html#GUID-B2ABF281-DFF8-4A4E-AC85-629801AAF36A) for more information.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-dry-run")]
        public System.Nullable<bool> OpcDryRun { get; set; }
    }
}
