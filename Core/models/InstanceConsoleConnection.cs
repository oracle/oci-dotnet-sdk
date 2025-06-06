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
    /// The `InstanceConsoleConnection` API provides you with console access to Compute instances,
    /// enabling you to troubleshoot malfunctioning instances remotely.
    /// <br/>
    /// For more information about instance console connections, see [Troubleshooting Instances Using Instance Console Connections](https://docs.cloud.oracle.com/iaas/Content/Compute/References/serialconsole.htm).
    /// 
    /// </summary>
    public class InstanceConsoleConnection 
    {
        
        /// <value>
        /// The OCID of the compartment to contain the console connection.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The SSH connection string for the console connection.
        /// </value>
        [JsonProperty(PropertyName = "connectionString")]
        public string ConnectionString { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// The SSH public key's fingerprint for client authentication to the console connection.
        /// </value>
        [JsonProperty(PropertyName = "fingerprint")]
        public string Fingerprint { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The OCID of the console connection.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the instance the console connection connects to.
        /// </value>
        [JsonProperty(PropertyName = "instanceId")]
        public string InstanceId { get; set; }
                ///
        /// <value>
        /// The current state of the console connection.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current state of the console connection.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The SSH public key's fingerprint for the console connection service host.
        /// </value>
        [JsonProperty(PropertyName = "serviceHostKeyFingerprint")]
        public string ServiceHostKeyFingerprint { get; set; }
        
        /// <value>
        /// The SSH connection string for the SSH tunnel used to
        /// connect to the console connection over VNC.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vncConnectionString")]
        public string VncConnectionString { get; set; }
        
    }
}
