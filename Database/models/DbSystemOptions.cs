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
    /// The DB system options.
    /// </summary>
    public class DbSystemOptions 
    {
                ///
        /// <value>
        /// The storage option used in DB system.
        /// ASM - Automatic storage management
        /// LVM - Logical Volume management
        /// 
        /// </value>
        ///
        public enum StorageManagementEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ASM")]
            Asm,
            [EnumMember(Value = "LVM")]
            Lvm
        };

        /// <value>
        /// The storage option used in DB system.
        /// ASM - Automatic storage management
        /// LVM - Logical Volume management
        /// 
        /// </value>
        [JsonProperty(PropertyName = "storageManagement")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StorageManagementEnum> StorageManagement { get; set; }
        
    }
}
