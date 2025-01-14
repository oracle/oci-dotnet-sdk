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


namespace Oci.AuditService.Models
{
    /// <summary>
    /// The retention period setting, specified in days. For more information, see [Setting Audit
    /// Log Retention Period](https://docs.cloud.oracle.com/iaas/Content/Audit/Tasks/settingretentionperiod.htm).
    /// 
    /// </summary>
    public class Configuration 
    {
        
        /// <value>
        /// The retention period setting, specified in days. The minimum is 90, the maximum 365.
        /// <br/>
        /// Example: 90
        /// </value>
        [JsonProperty(PropertyName = "retentionPeriodDays")]
        public System.Nullable<int> RetentionPeriodDays { get; set; }
        
    }
}
