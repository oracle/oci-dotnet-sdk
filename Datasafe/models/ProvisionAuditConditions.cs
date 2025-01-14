/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// Represents audit policies with corresponding audit provisioning conditions.
    /// </summary>
    public class ProvisionAuditConditions 
    {
        
        /// <value>
        /// Indicates the audit policy name available for provisioning from Data Safe. Refer to the [documentation](https://docs.oracle.com/en/cloud/paas/data-safe/udscs/audit-policies.html#GUID-361A9A9A-7C21-4F5A-8945-9B3A0C472827) for seeded audit policy names. For custom policies, refer to the user-defined policy name created in the target database.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AuditPolicyName is required.")]
        [JsonProperty(PropertyName = "auditPolicyName")]
        public string AuditPolicyName { get; set; }
        
        /// <value>
        /// Indicates whether the privileged user list is managed by Data Safe.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsPrivUsersManagedByDataSafe is required.")]
        [JsonProperty(PropertyName = "isPrivUsersManagedByDataSafe")]
        public System.Nullable<bool> IsPrivUsersManagedByDataSafe { get; set; }
        
        /// <value>
        /// Indicates whether the policy has to be enabled or disabled in the target database. Set this to true if you want the audit policy to be enabled in the target database. If the seeded audit policy is not already created in the database, the provisioning creates and enables them. If this is set to false, the policy will be disabled in the target database.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsEnabled is required.")]
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        
        /// <value>
        /// Indicates the users/roles in the target database for which the audit policy will be enforced, and the success/failure event condition to generate the audit event.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "enableConditions")]
        public System.Collections.Generic.List<EnableConditions> EnableConditions { get; set; }
        
    }
}
