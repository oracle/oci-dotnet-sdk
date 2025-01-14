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


namespace Oci.ComputecloudatcustomerService.Models
{
    /// <summary>
    /// Updates Compute Cloud@Customer infrastructure configuration details.
    /// </summary>
    public class UpdateCccInfrastructureDetails 
    {
        
        /// <value>
        /// The name that will be used to display the Compute Cloud@Customer infrastructure
        /// in the Oracle Cloud Infrastructure console. Does not have to be unique and can be changed.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A mutable client-meaningful text description of the Compute Cloud@Customer infrastructure.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) for the network subnet that is 
        /// used to communicate with Compute Cloud@Customer infrastructure.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// An updated connection state of the Compute Cloud@Customer infrastructure.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "connectionState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<CccInfrastructure.ConnectionStateEnum> ConnectionState { get; set; }
        
        /// <value>
        /// A message describing the current connection state in more detail.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "connectionDetails")]
        public string ConnectionDetails { get; set; }
        
        /// <value>
        /// Schedule used for upgrades. If no schedule is associated with the infrastructure,
        /// it can be updated at any time.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "cccUpgradeScheduleId")]
        public string CccUpgradeScheduleId { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
