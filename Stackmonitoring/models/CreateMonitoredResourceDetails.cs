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


namespace Oci.StackmonitoringService.Models
{
    /// <summary>
    /// The information about new monitored resource to be created. 
    /// The combination of monitored resource name and type should be unique across tenancy.
    /// 
    /// </summary>
    public class CreateMonitoredResourceDetails 
    {
        
        /// <value>
        /// Monitored Resource Name.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Monitored resource display name.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Monitored Resource Type.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        
        /// <value>
        /// Compartment Identifier [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Host name of the monitored resource.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "hostName")]
        public string HostName { get; set; }
        
        /// <value>
        /// External resource is any OCI resource identifier [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm)
        /// which is not a Stack Monitoring service resource.
        /// Currently supports only OCI compute instance.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "externalId")]
        public string ExternalId { get; set; }
        
        /// <value>
        /// Management Agent Identifier [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// </value>
        [JsonProperty(PropertyName = "managementAgentId")]
        public string ManagementAgentId { get; set; }
        
        /// <value>
        /// Time zone in the form of tz database canonical zone ID. Specifies the preference with
        /// a value that uses the IANA Time Zone Database format (x-obmcs-time-zone).
        /// For example - America/Los_Angeles
        /// 
        /// </value>
        [JsonProperty(PropertyName = "resourceTimeZone")]
        public string ResourceTimeZone { get; set; }
        
        /// <value>
        /// License edition of the monitored resource. If not provided 
        /// the default license type for the compartment will be used.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "license")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LicenseType> License { get; set; }
        
        /// <value>
        /// List of monitored resource properties.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "properties")]
        public System.Collections.Generic.List<MonitoredResourceProperty> Properties { get; set; }
        
        [JsonProperty(PropertyName = "databaseConnectionDetails")]
        public ConnectionDetails DatabaseConnectionDetails { get; set; }
        
        [JsonProperty(PropertyName = "credentials")]
        public MonitoredResourceCredential Credentials { get; set; }
        
        [JsonProperty(PropertyName = "aliases")]
        public MonitoredResourceAliasCredential Aliases { get; set; }
        
        /// <value>
        /// List of MonitoredResourceCredentials. This property complements the existing 
        /// \"credentials\" property by allowing user to specify more than one credential. 
        /// If both \"credential\" and \"additionalCredentials\" are specified, union of the 
        /// values is used as list of credentials applicable for this resource.
        /// If any duplicate found in the combined list of \"credentials\" and \"additionalCredentials\", 
        /// an error will be thrown.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "additionalCredentials")]
        public System.Collections.Generic.List<MonitoredResourceCredential> AdditionalCredentials { get; set; }
        
        /// <value>
        /// List of MonitoredResourceAliasCredentials. This property complements the existing 
        /// \"aliases\" property by allowing user to specify more than one credential alias. 
        /// If both \"aliases\" and \"additionalAliases\" are specified, union of the 
        /// values is used as list of aliases applicable for this resource.
        /// If any duplicate found in the combined list of \"alias\" and \"additionalAliases\", 
        /// an error will be thrown.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "additionalAliases")]
        public System.Collections.Generic.List<MonitoredResourceAliasCredential> AdditionalAliases { get; set; }
        
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
