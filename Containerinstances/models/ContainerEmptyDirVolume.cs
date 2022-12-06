/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.ContainerinstancesService.Models
{
    /// <summary>
    /// The empty director of container
    /// </summary>
    public class ContainerEmptyDirVolume : ContainerVolume
    {
                ///
        /// <value>
        /// Volume type that we are using for empty dir where it could be either File Storage or Memory
        /// </value>
        ///
        public enum BackingStoreEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "EPHEMERAL_STORAGE")]
            EphemeralStorage,
            [EnumMember(Value = "MEMORY")]
            Memory
        };

        /// <value>
        /// Volume type that we are using for empty dir where it could be either File Storage or Memory
        /// </value>
        [JsonProperty(PropertyName = "backingStore")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<BackingStoreEnum> BackingStore { get; set; }
        
        [JsonProperty(PropertyName = "volumeType")]
        private readonly string volumeType = "EMPTYDIR";
    }
}
