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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Autonomous Database configuration details for storing [manual backups](https://docs.oracle.com/en/cloud/paas/autonomous-database/adbsa/backup-restore.html#GUID-9035DFB8-4702-4CEB-8281-C2A303820809) in the [Object Storage](https://docs.cloud.oracle.com/Content/Object/Concepts/objectstorageoverview.htm) service.
    /// 
    /// </summary>
    public class AutonomousDatabaseBackupConfig 
    {
        
        /// <value>
        /// Name of [Object Storage](https://docs.cloud.oracle.com/Content/Object/Concepts/objectstorageoverview.htm) bucket to use for storing manual backups.
        /// </value>
        [JsonProperty(PropertyName = "manualBackupBucketName")]
        public string ManualBackupBucketName { get; set; }
                ///
        /// <value>
        /// The manual backup destination type.
        /// </value>
        ///
        public enum ManualBackupTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NONE")]
            None,
            [EnumMember(Value = "OBJECT_STORE")]
            ObjectStore
        };

        /// <value>
        /// The manual backup destination type.
        /// </value>
        [JsonProperty(PropertyName = "manualBackupType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ManualBackupTypeEnum> ManualBackupType { get; set; }
        
    }
}
