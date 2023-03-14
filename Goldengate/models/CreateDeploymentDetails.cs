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


namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// The information about a new Deployment.
    /// 
    /// </summary>
    public class CreateDeploymentDetails 
    {
        
        /// <value>
        /// An object's Display Name.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The Oracle license model that applies to a Deployment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LicenseModel is required.")]
        [JsonProperty(PropertyName = "licenseModel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LicenseModel> LicenseModel { get; set; }
        
        /// <value>
        /// Metadata about this specific object.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment being referenced.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A simple key-value pair that is applied without any predefined name, type, or scope. Exists
        /// for cross-compatibility only.
        /// <br/>
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Tags defined for this resource. Each key is predefined and scoped to a namespace.
        /// <br/>
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the backup being referenced.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "deploymentBackupId")]
        public string DeploymentBackupId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the subnet being referenced.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// A three-label Fully Qualified Domain Name (FQDN) for a resource.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "fqdn")]
        public string Fqdn { get; set; }
        
        /// <value>
        /// An array of Network Security Group OCIDs used to define network access for either Deployments or Connections.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
        
        /// <value>
        /// True if this object is publicly available.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isPublic")]
        public System.Nullable<bool> IsPublic { get; set; }
        
        /// <value>
        /// The Minimum number of OCPUs to be made available for this Deployment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CpuCoreCount is required.")]
        [JsonProperty(PropertyName = "cpuCoreCount")]
        public System.Nullable<int> CpuCoreCount { get; set; }
        
        /// <value>
        /// Indicates if auto scaling is enabled for the Deployment's CPU core count.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsAutoScalingEnabled is required.")]
        [JsonProperty(PropertyName = "isAutoScalingEnabled")]
        public System.Nullable<bool> IsAutoScalingEnabled { get; set; }
        
        /// <value>
        /// The type of deployment, the value determines the exact 'type' of service executed in the Deployment.
        /// NOTE: Use of the value 'OGG' is maintained for backward compatibility purposes.  Its use is discouraged
        ///       in favor of the equivalent 'DATABASE_ORACLE' value.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DeploymentType is required.")]
        [JsonProperty(PropertyName = "deploymentType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DeploymentType> DeploymentType { get; set; }
        
        [JsonProperty(PropertyName = "oggData")]
        public CreateOggDeploymentDetails OggData { get; set; }
        
        [JsonProperty(PropertyName = "maintenanceWindow")]
        public CreateMaintenanceWindowDetails MaintenanceWindow { get; set; }
        
    }
}
