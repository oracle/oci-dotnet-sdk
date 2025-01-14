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
    /// The scope of analytics data.
    /// </summary>
    public class SecurityFeatureAnalyticsDimensions 
    {
                ///
        /// <value>
        /// The name of the security feature.
        /// </value>
        ///
        public enum SecurityFeatureEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "UNIFIED_AUDIT")]
            UnifiedAudit,
            [EnumMember(Value = "FINE_GRAINED_AUDIT")]
            FineGrainedAudit,
            [EnumMember(Value = "TRADITIONAL_AUDIT")]
            TraditionalAudit,
            [EnumMember(Value = "DATABASE_VAULT")]
            DatabaseVault,
            [EnumMember(Value = "PRIVILEGE_ANALYSIS")]
            PrivilegeAnalysis,
            [EnumMember(Value = "TABLESPACE_ENCRYPTION")]
            TablespaceEncryption,
            [EnumMember(Value = "COLUMN_ENCRYPTION")]
            ColumnEncryption,
            [EnumMember(Value = "NETWORK_ENCRYPTION")]
            NetworkEncryption,
            [EnumMember(Value = "PASSWORD_AUTHENTICATION")]
            PasswordAuthentication,
            [EnumMember(Value = "GLOBAL_AUTHENTICATION")]
            GlobalAuthentication,
            [EnumMember(Value = "EXTERNAL_AUTHENTICATION")]
            ExternalAuthentication
        };

        /// <value>
        /// The name of the security feature.
        /// </value>
        [JsonProperty(PropertyName = "securityFeature")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SecurityFeatureEnum> SecurityFeature { get; set; }
        
    }
}
