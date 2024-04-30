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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The information needed to create a new workspace.
    /// </summary>
    public class CreateWorkspaceDetails 
    {
        
        /// <value>
        /// The OCID of the VCN the subnet is in.
        /// </value>
        [JsonProperty(PropertyName = "vcnId")]
        public string VcnId { get; set; }
        
        /// <value>
        /// The OCID of the subnet for customer connected databases.
        /// </value>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// The IP of the custom DNS.
        /// </value>
        [JsonProperty(PropertyName = "dnsServerIp")]
        public string DnsServerIp { get; set; }
        
        /// <value>
        /// The DNS zone of the custom DNS to use to resolve names.
        /// </value>
        [JsonProperty(PropertyName = "dnsServerZone")]
        public string DnsServerZone { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A user defined description for the workspace.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// A user-friendly display name for the workspace. Does not have to be unique, and can be modified. Avoid entering confidential information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The OCID of the compartment containing the workspace.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Specifies whether the private network connection is enabled or disabled.
        /// </value>
        [JsonProperty(PropertyName = "isPrivateNetworkEnabled")]
        public System.Nullable<bool> IsPrivateNetworkEnabled { get; set; }
        
        /// <value>
        /// DCMS Data Asset Registry ID to which the workspace is associated
        /// </value>
        [JsonProperty(PropertyName = "registryId")]
        public string RegistryId { get; set; }
        
        /// <value>
        /// DCMS Private Endpoint ID associated with workspace if the pvt networking is enabled
        /// </value>
        [JsonProperty(PropertyName = "endpointId")]
        public string EndpointId { get; set; }
        
        /// <value>
        /// DCMS Data Asset Registry display name
        /// </value>
        [JsonProperty(PropertyName = "registryName")]
        public string RegistryName { get; set; }
        
        /// <value>
        /// DCMS Data Asset Registry Compartment Identifier
        /// </value>
        [JsonProperty(PropertyName = "registryCompartmentId")]
        public string RegistryCompartmentId { get; set; }
        
        /// <value>
        /// DCMS Private Endpoint Name
        /// </value>
        [JsonProperty(PropertyName = "endpointName")]
        public string EndpointName { get; set; }
        
        /// <value>
        /// DCMS PRivate Endpoint Compartment Identifier
        /// </value>
        [JsonProperty(PropertyName = "endpointCompartmentId")]
        public string EndpointCompartmentId { get; set; }
        
        /// <value>
        /// Key-values pairs of workspace for storing properties on the workspace.
        /// </value>
        [JsonProperty(PropertyName = "workspaceProperties")]
        public System.Collections.Generic.Dictionary<string, string> WorkspaceProperties { get; set; }
        
    }
}
