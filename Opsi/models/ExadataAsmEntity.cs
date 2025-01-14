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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// ASM entitie for an exadata
    /// 
    /// </summary>
    public class ExadataAsmEntity : DatabaseConfigurationMetricGroup
    {
        
        /// <value>
        /// Instance name of ASM
        /// </value>
        [JsonProperty(PropertyName = "instanceName")]
        public string InstanceName { get; set; }
        
        /// <value>
        /// Cluster name of ASM
        /// </value>
        [JsonProperty(PropertyName = "clusterName")]
        public string ClusterName { get; set; }
        
        /// <value>
        /// Software version
        /// </value>
        [JsonProperty(PropertyName = "softwareVersion")]
        public string SoftwareVersion { get; set; }
        
        [JsonProperty(PropertyName = "metricName")]
        private readonly string metricName = "ASM_ENTITY";
    }
}
