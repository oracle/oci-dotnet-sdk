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
        [JsonProperty(PropertyName = "licenseModel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LicenseModel> LicenseModel { get; set; }
        
        /// <value>
        /// Specifies whether the deployment is used in a production or development/testing environment.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "environmentType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<EnvironmentType> EnvironmentType { get; set; }
        
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
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the deployment being referenced.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sourceDeploymentId")]
        public string SourceDeploymentId { get; set; }
        
        /// <value>
        /// The availability domain of a placement.
        /// </value>
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The fault domain of a placement.
        /// </value>
        [JsonProperty(PropertyName = "faultDomain")]
        public string FaultDomain { get; set; }
        
        /// <value>
        /// An array of local peers of deployment
        /// 
        /// </value>
        [JsonProperty(PropertyName = "placements")]
        public System.Collections.Generic.List<DeploymentPlacementDetails> Placements { get; set; }
        
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
        /// Locks associated with this resource.
        /// </value>
        [JsonProperty(PropertyName = "locks")]
        public System.Collections.Generic.List<AddResourceLockDetails> Locks { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the backup being referenced.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "deploymentBackupId")]
        public string DeploymentBackupId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the subnet of the deployment's private endpoint.
        /// The subnet must be a private subnet. For backward compatibility, public subnets are allowed until May 31 2025,
        /// after which the private subnet will be enforced.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of a public subnet in the customer tenancy.
        /// Can be provided only for public deployments. If provided, the loadbalancer will be created in this subnet instead of the service tenancy.
        /// For backward compatibility, this is an optional property. It will become mandatory for public deployments after October 1, 2024.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "loadBalancerSubnetId")]
        public string LoadBalancerSubnetId { get; set; }
        
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
        [JsonProperty(PropertyName = "cpuCoreCount")]
        public System.Nullable<int> CpuCoreCount { get; set; }
        
        /// <value>
        /// Indicates if auto scaling is enabled for the Deployment's CPU core count.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAutoScalingEnabled")]
        public System.Nullable<bool> IsAutoScalingEnabled { get; set; }
        
        /// <value>
        /// The type of deployment, which can be any one of the Allowed values. 
        /// NOTE: Use of the value 'OGG' is maintained for backward compatibility purposes. 
        ///     Its use is discouraged in favor of 'DATABASE_ORACLE'.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "deploymentType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DeploymentType> DeploymentType { get; set; }
        
        [JsonProperty(PropertyName = "oggData")]
        public CreateOggDeploymentDetails OggData { get; set; }
        
        [JsonProperty(PropertyName = "maintenanceWindow")]
        public CreateMaintenanceWindowDetails MaintenanceWindow { get; set; }
        
        [JsonProperty(PropertyName = "maintenanceConfiguration")]
        public CreateMaintenanceConfigurationDetails MaintenanceConfiguration { get; set; }
        
        [JsonProperty(PropertyName = "backupSchedule")]
        public CreateBackupScheduleDetails BackupSchedule { get; set; }
        
    }
}
