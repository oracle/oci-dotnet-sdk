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
    /// A container for your OCI GoldenGate Upgrade information.
    /// 
    /// </summary>
    public class DeploymentUpgrade 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the deployment upgrade being referenced.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// An object's Display Name.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
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
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DeploymentId is required.")]
        [JsonProperty(PropertyName = "deploymentId")]
        public string DeploymentId { get; set; }
        
        /// <value>
        /// The type of the deployment upgrade: MANUAL or AUTOMATIC
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DeploymentUpgradeType is required.")]
        [JsonProperty(PropertyName = "deploymentUpgradeType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DeploymentUpgradeType> DeploymentUpgradeType { get; set; }
        
        /// <value>
        /// The date and time the request was started. The format is defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339), such as `2016-08-25T21:10:29.600Z`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The date and time the request was finished. The format is defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339), such as `2016-08-25T21:10:29.600Z`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeFinished")]
        public System.Nullable<System.DateTime> TimeFinished { get; set; }
        
        /// <value>
        /// Version of OGG
        /// 
        /// </value>
        [JsonProperty(PropertyName = "oggVersion")]
        public string OggVersion { get; set; }
        
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
        /// Possible lifecycle states.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Possible GGS lifecycle sub-states.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleSubState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleSubState> LifecycleSubState { get; set; }
        
        /// <value>
        /// Describes the object's current state in detail. For example, it can be used to provide
        /// actionable information for a resource in a Failed state.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
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
        /// Version of OGG
        /// 
        /// </value>
        [JsonProperty(PropertyName = "previousOggVersion")]
        public string PreviousOggVersion { get; set; }
        
        /// <value>
        /// The time of upgrade schedule. The format is defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339), such as `2016-08-25T21:10:29.600Z`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeSchedule")]
        public System.Nullable<System.DateTime> TimeSchedule { get; set; }
        
        /// <value>
        /// Indicates if upgrade notifications are snoozed or not.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSnoozed")]
        public System.Nullable<bool> IsSnoozed { get; set; }
        
        /// <value>
        /// The time the upgrade notifications are snoozed until. The format is defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339), such as `2016-08-25T21:10:29.600Z`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeSnoozedUntil")]
        public System.Nullable<System.DateTime> TimeSnoozedUntil { get; set; }
        
        /// <value>
        /// The time the resource was released. The format is defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339), such as `2016-08-25T21:10:29.600Z`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeReleased")]
        public System.Nullable<System.DateTime> TimeReleased { get; set; }
        
        /// <value>
        /// The type of release.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "releaseType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ReleaseType> ReleaseType { get; set; }
        
        /// <value>
        /// Indicates if OGG release contains security fix.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSecurityFix")]
        public System.Nullable<bool> IsSecurityFix { get; set; }
        
        /// <value>
        /// Indicates if rollback is allowed. In practice only the last upgrade can be rolled back.
        /// - Manual upgrade is allowed to rollback only until the old version isn't deprecated yet.
        /// - Automatic upgrade by default is not allowed, unless a serious issue does not justify.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isRollbackAllowed")]
        public System.Nullable<bool> IsRollbackAllowed { get; set; }
        
        /// <value>
        /// The time until OGG version is supported. After this date has passed OGG version will not be available anymore. The format is defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339), such as `2016-08-25T21:10:29.600Z`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeOggVersionSupportedUntil")]
        public System.Nullable<System.DateTime> TimeOggVersionSupportedUntil { get; set; }
        
        /// <value>
        /// Indicates if cancel is allowed. Scheduled upgrade can be cancelled only if target version is not forced by service, 
        /// otherwise only reschedule allowed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isCancelAllowed")]
        public System.Nullable<bool> IsCancelAllowed { get; set; }
        
        /// <value>
        /// Indicates if reschedule is allowed. Upgrade can be rescheduled postponed until the end of the service defined auto-upgrade period.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isRescheduleAllowed")]
        public System.Nullable<bool> IsRescheduleAllowed { get; set; }
        
        /// <value>
        /// Indicates the latest time until the deployment upgrade could be rescheduled. The format is defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339), such as `2016-08-25T21:10:29.600Z`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeScheduleMax")]
        public System.Nullable<System.DateTime> TimeScheduleMax { get; set; }
        
    }
}
