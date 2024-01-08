/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
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
    /// Autonomous VM usage statistics.
    /// </summary>
    public class AutonomousVmResourceUsage 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Autonomous VM Cluster.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The user-friendly name for the Autonomous VM cluster. The name does not need to be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The number of CPU cores alloted to the Autonomous Container Databases in an Cloud Autonomous VM cluster.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "usedCpus")]
        public System.Nullable<float> UsedCpus { get; set; }
        
        /// <value>
        /// The number of CPU cores available.
        /// </value>
        [JsonProperty(PropertyName = "availableCpus")]
        public System.Nullable<float> AvailableCpus { get; set; }
        
        /// <value>
        /// CPU cores that continue to be included in the count of OCPUs available to the
        /// Autonomous Container Database even after one of its Autonomous Database is
        /// terminated or scaled down. You can release them to the available OCPUs at its
        /// parent AVMC level by restarting the Autonomous Container Database.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "reclaimableCpus")]
        public System.Nullable<float> ReclaimableCpus { get; set; }
        
        /// <value>
        /// The number of CPUs provisioned in an Autonomous VM Cluster.
        /// </value>
        [JsonProperty(PropertyName = "provisionedCpus")]
        public System.Nullable<float> ProvisionedCpus { get; set; }
        
        /// <value>
        /// The number of CPUs reserved in an Autonomous VM Cluster.
        /// </value>
        [JsonProperty(PropertyName = "reservedCpus")]
        public System.Nullable<float> ReservedCpus { get; set; }
        
        /// <value>
        /// Associated Autonomous Container Database Usages.
        /// </value>
        [JsonProperty(PropertyName = "autonomousContainerDatabaseUsage")]
        public System.Collections.Generic.List<AvmAcdResourceStats> AutonomousContainerDatabaseUsage { get; set; }
        
    }
}
