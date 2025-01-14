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


namespace Oci.CloudmigrationsService.Models
{
    /// <summary>
    /// Summary of the migration plan.
    /// </summary>
    public class MigrationPlanSummary 
    {
        
        /// <value>
        /// The unique Oracle ID (OCID) that is immutable on creation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the compartment containing the migration plan.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The time when the migration plan was created. An RFC3339 formatted datetime string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time when the migration plan was updated. An RFC3339 formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The current state of the migration plan.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MigrationPlan.LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the current state in more detail. For example, it can be used to provide actionable information for a resource in Failed state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The OCID of the associated migration.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MigrationId is required.")]
        [JsonProperty(PropertyName = "migrationId")]
        public string MigrationId { get; set; }
        
        /// <value>
        /// List of strategies for the resources to be migrated.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Strategies is required.")]
        [JsonProperty(PropertyName = "strategies")]
        public System.Collections.Generic.List<ResourceAssessmentStrategy> Strategies { get; set; }
        
        [JsonProperty(PropertyName = "migrationPlanStats")]
        public MigrationPlanStats MigrationPlanStats { get; set; }
        
        /// <value>
        /// Limits of the resources that are needed for migration. Example: {&quot;BlockVolume&quot;: 2, &quot;VCN&quot;: 1}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CalculatedLimits is required.")]
        [JsonProperty(PropertyName = "calculatedLimits")]
        public System.Collections.Generic.Dictionary<string, int> CalculatedLimits { get; set; }
        
        /// <value>
        /// List of target environments.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetEnvironments is required.")]
        [JsonProperty(PropertyName = "targetEnvironments")]
        public System.Collections.Generic.List<TargetEnvironment> TargetEnvironments { get; set; }
        
        /// <value>
        /// OCID of the referenced ORM job.
        /// </value>
        [JsonProperty(PropertyName = "referenceToRmsStack")]
        public string ReferenceToRmsStack { get; set; }
        
        /// <value>
        /// Source migraiton plan ID to be cloned.
        /// </value>
        [JsonProperty(PropertyName = "sourceMigrationPlanId")]
        public string SourceMigrationPlanId { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. It exists only for cross-compatibility.
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
        
        /// <value>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
