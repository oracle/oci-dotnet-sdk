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
    /// Details of aggregation dimensions used for summarizing audit policies.
    /// </summary>
    public class AuditPolicyDimensions 
    {
        
        /// <value>
        /// The category to which the audit policy belongs.
        /// </value>
        [JsonProperty(PropertyName = "auditPolicyCategory")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AuditPolicyCategory> AuditPolicyCategory { get; set; }
        
        /// <value>
        /// The name of the audit policy. Refer to the [documentation](https://www.oracle.com/pls/topic/lookup?ctx=en/cloud/paas/data-safe&id=UDSCS-GUID-361A9A9A-7C21-4F5A-8945-9B3A0C472827) for seeded audit policy names. For custom policies, refer to the user-defined policy name created in the target database.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "auditPolicyName")]
        public string AuditPolicyName { get; set; }
        
        /// <value>
        /// The OCID of the target database for which the audit policy will be created.
        /// </value>
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }
        
    }
}
