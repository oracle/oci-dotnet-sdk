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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// Shows details about the last recycle performed on this host.
    /// 
    /// </summary>
    public class RecycleDetails 
    {
                ///
        /// <value>
        /// Preferred recycle level for hosts associated with the reservation config.
        /// * `SKIP_RECYCLE` - Skips host wipe.
        /// * `FULL_RECYCLE` - Does not skip host wipe. This is the default behavior.
        /// 
        /// </value>
        ///
        public enum RecycleLevelEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SKIP_RECYCLE")]
            SkipRecycle,
            [EnumMember(Value = "FULL_RECYCLE")]
            FullRecycle
        };

        /// <value>
        /// Preferred recycle level for hosts associated with the reservation config.
        /// * `SKIP_RECYCLE` - Skips host wipe.
        /// * `FULL_RECYCLE` - Does not skip host wipe. This is the default behavior.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "recycleLevel")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RecycleLevelEnum> RecycleLevel { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compute host group this host was attached to at the time of recycle. 
        /// 
        /// </value>
        [JsonProperty(PropertyName = "computeHostGroupId")]
        public string ComputeHostGroupId { get; set; }
        
    }
}
