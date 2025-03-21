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
    /// The resource represents a SQL Firewall allowed SQL in Data Safe.
    /// 
    /// </summary>
    public class SqlFirewallAllowedSql 
    {
        
        /// <value>
        /// The OCID of the SQL Firewall allowed SQL.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the compartment containing the SQL Firewall allowed SQL.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The display name of the SQL Firewall allowed SQL.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The description of the SQL Firewall allowed SQL.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The OCID of the SQL Firewall policy corresponding to the SQL Firewall allowed SQL.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SqlFirewallPolicyId is required.")]
        [JsonProperty(PropertyName = "sqlFirewallPolicyId")]
        public string SqlFirewallPolicyId { get; set; }
        
        /// <value>
        /// The name of the user that SQL was executed as.
        /// </value>
        [JsonProperty(PropertyName = "currentUser")]
        public string CurrentUser { get; set; }
        
        /// <value>
        /// The database user name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbUserName is required.")]
        [JsonProperty(PropertyName = "dbUserName")]
        public string DbUserName { get; set; }
        
        /// <value>
        /// The SQL text of the SQL Firewall allowed SQL.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SqlText is required.")]
        [JsonProperty(PropertyName = "sqlText")]
        public string SqlText { get; set; }
                ///
        /// <value>
        /// Specifies the level of SQL included for this SQL Firewall policy.
        /// USER_ISSUED_SQL - User issued SQL statements only.
        /// ALL_SQL - Includes all SQL statements including SQL statement issued inside PL/SQL units.
        /// 
        /// </value>
        ///
        public enum SqlLevelEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "USER_ISSUED_SQL")]
            UserIssuedSql,
            [EnumMember(Value = "ALL_SQL")]
            AllSql
        };

        /// <value>
        /// Specifies the level of SQL included for this SQL Firewall policy.
        /// USER_ISSUED_SQL - User issued SQL statements only.
        /// ALL_SQL - Includes all SQL statements including SQL statement issued inside PL/SQL units.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SqlLevel is required.")]
        [JsonProperty(PropertyName = "sqlLevel")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SqlLevelEnum> SqlLevel { get; set; }
        
        /// <value>
        /// The objects accessed by the SQL.
        /// </value>
        [JsonProperty(PropertyName = "sqlAccessedObjects")]
        public System.Collections.Generic.List<string> SqlAccessedObjects { get; set; }
        
        /// <value>
        /// Version of the associated SQL Firewall policy. This identifies whether the allowed SQLs were added in the same batch or not.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Version is required.")]
        [JsonProperty(PropertyName = "version")]
        public System.Nullable<float> Version { get; set; }
        
        /// <value>
        /// The time the the SQL Firewall allowed SQL was collected from the target database, in the format defined by RFC3339.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCollected is required.")]
        [JsonProperty(PropertyName = "timeCollected")]
        public System.Nullable<System.DateTime> TimeCollected { get; set; }
        
        /// <value>
        /// The last date and time the SQL Firewall allowed SQL was updated, in the format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The current state of the SQL Firewall allowed SQL.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SqlFirewallAllowedSqlLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm)
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm)
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// System tags for this resource. Each key is predefined and scoped to a namespace. For more information, see Resource Tags.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
