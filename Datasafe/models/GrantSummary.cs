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
    /// The summary of user grants.
    /// </summary>
    public class GrantSummary 
    {
        
        /// <value>
        /// The unique key of a user grant.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The name of a user grant.
        /// </value>
        [JsonProperty(PropertyName = "grantName")]
        public string GrantName { get; set; }
                ///
        /// <value>
        /// The type of a user grant.
        /// </value>
        ///
        public enum PrivilegeTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SYSTEM_PRIVILEGE")]
            SystemPrivilege,
            [EnumMember(Value = "OBJECT_PRIVILEGE")]
            ObjectPrivilege,
            [EnumMember(Value = "ADMIN_PRIVILEGE")]
            AdminPrivilege,
            [EnumMember(Value = "ROLE")]
            Role
        };

        /// <value>
        /// The type of a user grant.
        /// </value>
        [JsonProperty(PropertyName = "privilegeType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PrivilegeTypeEnum> PrivilegeType { get; set; }
                ///
        /// <value>
        /// The privilege category.
        /// </value>
        ///
        public enum PrivilegeCategoryEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CRITICAL")]
            Critical,
            [EnumMember(Value = "HIGH")]
            High,
            [EnumMember(Value = "MEDIUM")]
            Medium,
            [EnumMember(Value = "LOW")]
            Low
        };

        /// <value>
        /// The privilege category.
        /// </value>
        [JsonProperty(PropertyName = "privilegeCategory")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PrivilegeCategoryEnum> PrivilegeCategory { get; set; }
        
        /// <value>
        /// The grant depth level of the indirect grant.
        /// An indirectly granted role/privilege is granted to the user through another role.
        /// The depth level indicates how deep a privilege is within the grant hierarchy.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "depthLevel")]
        public System.Nullable<int> DepthLevel { get; set; }
        
    }
}
