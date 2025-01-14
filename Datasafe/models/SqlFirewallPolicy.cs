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
    /// The SQL Firewall policy resource contains the firewall policy metadata for a single user.
    /// 
    /// </summary>
    public class SqlFirewallPolicy 
    {
        
        /// <value>
        /// The OCID of the SQL Firewall policy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the compartment containing the SQL Firewall policy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The display name of the SQL Firewall policy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The description of the SQL Firewall policy.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The OCID of the security policy corresponding to the SQL Firewall policy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SecurityPolicyId is required.")]
        [JsonProperty(PropertyName = "securityPolicyId")]
        public string SecurityPolicyId { get; set; }
        
        /// <value>
        /// The database user name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbUserName is required.")]
        [JsonProperty(PropertyName = "dbUserName")]
        public string DbUserName { get; set; }
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
        [JsonProperty(PropertyName = "sqlLevel")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SqlLevelEnum> SqlLevel { get; set; }
                ///
        /// <value>
        /// Specifies whether the SQL Firewall policy is enabled or disabled.
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ENABLED")]
            Enabled,
            [EnumMember(Value = "DISABLED")]
            Disabled
        };

        /// <value>
        /// Specifies whether the SQL Firewall policy is enabled or disabled.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
                ///
        /// <value>
        /// Specifies the SQL Firewall policy enforcement option.
        /// </value>
        ///
        public enum EnforcementScopeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ENFORCE_CONTEXT")]
            EnforceContext,
            [EnumMember(Value = "ENFORCE_SQL")]
            EnforceSql,
            [EnumMember(Value = "ENFORCE_ALL")]
            EnforceAll
        };

        /// <value>
        /// Specifies the SQL Firewall policy enforcement option.
        /// </value>
        [JsonProperty(PropertyName = "enforcementScope")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<EnforcementScopeEnum> EnforcementScope { get; set; }
                ///
        /// <value>
        /// Specifies the mode in which the SQL Firewall policy is enabled.
        /// </value>
        ///
        public enum ViolationActionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "BLOCK")]
            Block,
            [EnumMember(Value = "OBSERVE")]
            Observe
        };

        /// <value>
        /// Specifies the mode in which the SQL Firewall policy is enabled.
        /// </value>
        [JsonProperty(PropertyName = "violationAction")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ViolationActionEnum> ViolationAction { get; set; }
                ///
        /// <value>
        /// Specifies whether a unified audit policy should be enabled for auditing the SQL Firewall policy violations.
        /// </value>
        ///
        public enum ViolationAuditEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ENABLED")]
            Enabled,
            [EnumMember(Value = "DISABLED")]
            Disabled
        };

        /// <value>
        /// Specifies whether a unified audit policy should be enabled for auditing the SQL Firewall policy violations.
        /// </value>
        [JsonProperty(PropertyName = "violationAudit")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ViolationAuditEnum> ViolationAudit { get; set; }
        
        /// <value>
        /// The list of allowed ip addresses for the SQL Firewall policy.
        /// </value>
        [JsonProperty(PropertyName = "allowedClientIps")]
        public System.Collections.Generic.List<string> AllowedClientIps { get; set; }
        
        /// <value>
        /// The list of allowed operating system user names for the SQL Firewall policy.
        /// </value>
        [JsonProperty(PropertyName = "allowedClientOsUsernames")]
        public System.Collections.Generic.List<string> AllowedClientOsUsernames { get; set; }
        
        /// <value>
        /// The list of allowed client programs for the SQL Firewall policy.
        /// </value>
        [JsonProperty(PropertyName = "allowedClientPrograms")]
        public System.Collections.Generic.List<string> AllowedClientPrograms { get; set; }
        
        /// <value>
        /// The time that the SQL Firewall policy was created, in the format defined by RFC3339.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the SQL Firewall policy was last updated, in the format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The current state of the SQL Firewall policy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SqlFirewallPolicyLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Details about the current state of the SQL Firewall policy in Data Safe.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm)
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm)
        /// <br/>
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
