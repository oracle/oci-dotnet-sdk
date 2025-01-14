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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The details required to change SQL plan baseline attributes.
    /// It takes either credentials or databaseCredential. It's recommended to provide databaseCredential
    /// 
    /// </summary>
    public class ChangeSqlPlanBaselinesAttributesDetails 
    {
        
        /// <value>
        /// The SQL statement handle. It identifies plans associated with a SQL statement
        /// for attribute changes. If `null` then `planName` must be specified.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sqlHandle")]
        public string SqlHandle { get; set; }
        
        /// <value>
        /// Then plan name. It identifies a specific plan. If `null' then all plans associated
        /// with a SQL statement identified by `sqlHandle' are considered for attribute changes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "planName")]
        public string PlanName { get; set; }
        
        /// <value>
        /// Indicates whether the plan is available for use by the optimizer.
        /// </value>
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        
        /// <value>
        /// Indicates whether the plan baseline is fixed. A fixed plan takes precedence over a non-fixed plan.
        /// </value>
        [JsonProperty(PropertyName = "isFixed")]
        public System.Nullable<bool> IsFixed { get; set; }
        
        /// <value>
        /// Indicates whether the plan is purged if it is not used for a time period.
        /// </value>
        [JsonProperty(PropertyName = "isAutoPurged")]
        public System.Nullable<bool> IsAutoPurged { get; set; }
        
        [JsonProperty(PropertyName = "credentials")]
        public ManagedDatabaseCredential Credentials { get; set; }
        
        [JsonProperty(PropertyName = "databaseCredential")]
        public DatabaseCredentialDetails DatabaseCredential { get; set; }
        
    }
}
