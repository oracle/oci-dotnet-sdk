/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The details of an ASM discovered in an external DB system discovery run.
    /// </summary>
    public class DiscoveredExternalAsm : DiscoveredExternalDbSystemComponent
    {
        
        /// <value>
        /// The directory in which ASM is installed. This is the same directory in which Oracle Grid Infrastructure is installed.
        /// </value>
        [JsonProperty(PropertyName = "gridHome")]
        public string GridHome { get; set; }
        
        /// <value>
        /// Indicates whether Oracle Flex ASM is enabled or not.
        /// </value>
        [JsonProperty(PropertyName = "isFlexEnabled")]
        public System.Nullable<bool> IsFlexEnabled { get; set; }
        
        /// <value>
        /// The ASM version.
        /// </value>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
        [JsonProperty(PropertyName = "asmInstances")]
        public System.Collections.Generic.List<DiscoveredExternalAsmInstance> AsmInstances { get; set; }
        
        [JsonProperty(PropertyName = "connector")]
        public ExternalDbSystemDiscoveryConnector Connector { get; set; }
        
        [JsonProperty(PropertyName = "componentType")]
        private readonly string componentType = "ASM";
    }
}
