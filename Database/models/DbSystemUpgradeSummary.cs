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
    /// It describes the various upgrade properties such as component, osversion, giversion for any VM DB system.
    /// 
    /// </summary>
    public class DbSystemUpgradeSummary 
    {
                ///
        /// <value>
        /// The component on which upgrade is applicable. OS (Operating System upgrade), GI (Grid Infrastructure upgrade) or OS_GI (both Operating System and Grid Infrastructure upgrade)
        /// </value>
        ///
        public enum ComponentEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "OS")]
            Os,
            [EnumMember(Value = "OS_GI")]
            OsGi,
            [EnumMember(Value = "GI")]
            Gi
        };

        /// <value>
        /// The component on which upgrade is applicable. OS (Operating System upgrade), GI (Grid Infrastructure upgrade) or OS_GI (both Operating System and Grid Infrastructure upgrade)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Component is required.")]
        [JsonProperty(PropertyName = "component")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ComponentEnum> Component { get; set; }
        
        /// <value>
        /// The version of the OS for this upgrade eg. Oracle Linux Server release 7.9
        /// </value>
        [JsonProperty(PropertyName = "osVersion")]
        public string OsVersion { get; set; }
        
        /// <value>
        /// The version of the grid infrastructure for this upgrade. This is only applicable for ASM based DbSystems
        /// </value>
        [JsonProperty(PropertyName = "giVersion")]
        public string GiVersion { get; set; }
        
    }
}
