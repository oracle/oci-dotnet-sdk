/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
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
    /// The platform configuration of a bare metal instance specific to the AMD Milan platform.
    /// 
    /// </summary>
    public class AmdMilanBmPlatformConfig : PlatformConfig
    {
                ///
        /// <value>
        /// The number of NUMA nodes per socket.
        /// 
        /// </value>
        ///
        public enum NumaNodesPerSocketEnum {
            [EnumMember(Value = "NPS0")]
            Nps0,
            [EnumMember(Value = "NPS1")]
            Nps1,
            [EnumMember(Value = "NPS2")]
            Nps2,
            [EnumMember(Value = "NPS4")]
            Nps4
        };

        /// <value>
        /// The number of NUMA nodes per socket.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "numaNodesPerSocket")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<NumaNodesPerSocketEnum> NumaNodesPerSocket { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "AMD_MILAN_BM";
    }
}
