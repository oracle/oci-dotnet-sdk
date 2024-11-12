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


namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// The summary of the Backup.
    /// 
    /// </summary>
    public class DeploymentBackupSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the backup being referenced.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the deployment being referenced.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DeploymentId is required.")]
        [JsonProperty(PropertyName = "deploymentId")]
        public string DeploymentId { get; set; }
        
        /// <value>
        /// The type of deployment, which can be any one of the Allowed values. 
        /// NOTE: Use of the value 'OGG' is maintained for backward compatibility purposes. 
        ///     Its use is discouraged in favor of 'DATABASE_ORACLE'.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DeploymentType is required.")]
        [JsonProperty(PropertyName = "deploymentType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DeploymentType> DeploymentType { get; set; }
        
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
        /// An object's Display Name.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// True if this object is automatically created
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAutomatic")]
        public System.Nullable<bool> IsAutomatic { get; set; }
        
        /// <value>
        /// Possible lifecycle states.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Describes the object's current state in detail. For example, it can be used to provide
        /// actionable information for a resource in a Failed state.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The time of the resource backup. The format is defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339), such as `2016-08-25T21:10:29.600Z`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeOfBackup")]
        public System.Nullable<System.DateTime> TimeOfBackup { get; set; }
        
        /// <value>
        /// The time of the resource backup finish. The format is defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339), such as `2016-08-25T21:10:29.600Z`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeBackupFinished")]
        public System.Nullable<System.DateTime> TimeBackupFinished { get; set; }
        
        /// <value>
        /// The size of the backup stored in object storage (in bytes)
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sizeInBytes")]
        public System.Nullable<long> SizeInBytes { get; set; }
        
        /// <value>
        /// Possible Deployment backup types.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "backupType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DeploymentBackupType> BackupType { get; set; }
        
        /// <value>
        /// Version of OGG
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OggVersion is required.")]
        [JsonProperty(PropertyName = "oggVersion")]
        public string OggVersion { get; set; }
        
        /// <value>
        /// Name of namespace that serves as a container for all of your buckets
        /// </value>
        [JsonProperty(PropertyName = "namespaceName")]
        public string NamespaceName { get; set; }
        
        /// <value>
        /// Name of the bucket where the object is to be uploaded in the object storage
        /// </value>
        [JsonProperty(PropertyName = "bucketName")]
        public string BucketName { get; set; }
        
        /// <value>
        /// Name of the object to be uploaded to object storage
        /// </value>
        [JsonProperty(PropertyName = "objectName")]
        public string ObjectName { get; set; }
        
        /// <value>
        /// The time the resource was created. The format is defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339), such as `2016-08-25T21:10:29.600Z`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time the resource was last updated. The format is defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339), such as `2016-08-25T21:10:29.600Z`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
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
        /// The system tags associated with this resource, if any. The system tags are set by Oracle
        /// Cloud Infrastructure services. Each key is predefined and scoped to namespaces.  For more
        /// information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {orcl-cloud: {free-tier-retain: true}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
        /// <value>
        /// Parameter to allow users to create backup without trails
        /// </value>
        [JsonProperty(PropertyName = "isMetadataOnly")]
        public System.Nullable<bool> IsMetadataOnly { get; set; }
        
        /// <value>
        /// Locks associated with this resource.
        /// </value>
        [JsonProperty(PropertyName = "locks")]
        public System.Collections.Generic.List<ResourceLock> Locks { get; set; }
        
    }
}
