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
    /// Resource usage by autonomous container database in a particular VM.
    /// </summary>
    public class AcdAvmResourceStats 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Autonomous VM.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The user-friendly name for the Autonomous VM. The name does not need to be unique.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// CPUs/cores assigned to Autonomous Databases for the ACD instance in given Autonomus VM.
        /// </value>
        [JsonProperty(PropertyName = "provisionedCpus")]
        public System.Nullable<float> ProvisionedCpus { get; set; }
        
        /// <value>
        /// CPUs/cores assigned to the ACD instance in given Autonomous VM. Sum of provisioned,
        /// reserved and reclaimable CPUs/ cores to the ACD instance.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "usedCpus")]
        public System.Nullable<float> UsedCpus { get; set; }
        
        /// <value>
        /// CPUs/cores reserved for scalability, resilliency and other overheads.
        /// This includes failover, autoscaling and idle instance overhead.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "reservedCpus")]
        public System.Nullable<float> ReservedCpus { get; set; }
        
        /// <value>
        /// CPUs/cores that continue to be included in the count of OCPUs available to the
        /// Autonomous Container Database in given Autonomous VM, even after one of its
        /// Autonomous Database is terminated or scaled down. You can release them to the available
        /// OCPUs at its parent AVMC level by restarting the Autonomous Container Database.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "reclaimableCpus")]
        public System.Nullable<float> ReclaimableCpus { get; set; }
        
    }
}
