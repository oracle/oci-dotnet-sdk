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


namespace Oci.RecoveryService.Models
{
    /// <summary>
    /// A protected database is an Oracle Cloud Database whose backups are managed by Oracle Database Autonomous Recovery Service.
    /// Each protected database requires a recovery service subnet and a protection policy to use Recovery Service as the backup destination for centralized backup and recovery.
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you are not authorized, talk to an administrator.
    /// If you are an administrator who needs to write policies to give users access, see [Getting Started with Policies](https://docs.oracle.com/iaas/Content/Identity/Concepts/policygetstarted.htm).
    /// <br/>
    /// For information about access control and compartments, see [Overview of the Identity Service](https://docs.oracle.com/iaas/Content/Identity/Concepts/overview.htm).
    /// 
    /// </summary>
    public class ProtectedDatabaseSummary 
    {
        
        /// <value>
        /// The OCID of the protected database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The protected database name. You can change the displayName. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The OCID of the compartment that contains the protected database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The dbUniqueName for the protected database in Recovery Service. You cannot change the unique name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbUniqueName is required.")]
        [JsonProperty(PropertyName = "dbUniqueName")]
        public string DbUniqueName { get; set; }
        
        /// <value>
        /// The virtual private catalog (VPC) user credentials that authenticates the protected database to access Recovery Service.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VpcUserName is required.")]
        [JsonProperty(PropertyName = "vpcUserName")]
        public string VpcUserName { get; set; }
        
        /// <value>
        /// The size of the protected database. XS - Less than 5GB, S - 5GB to 50GB, M - 50GB to 500GB, L - 500GB to 1TB, XL - 1TB to 5TB, XXL - Greater than 5TB.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseSize is required.")]
        [JsonProperty(PropertyName = "databaseSize")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DatabaseSizes> DatabaseSize { get; set; }
        
        /// <value>
        /// The OCID of the protection policy associated with the protected database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProtectionPolicyId is required.")]
        [JsonProperty(PropertyName = "protectionPolicyId")]
        public string ProtectionPolicyId { get; set; }
        
        /// <value>
        /// List of recovery service subnet resources associated with the protected database.
        /// </value>
        [JsonProperty(PropertyName = "recoveryServiceSubnets")]
        public System.Collections.Generic.List<RecoveryServiceSubnetDetails> RecoveryServiceSubnets { get; set; }
        
        /// <value>
        /// The OCID of the protected database.
        /// </value>
        [JsonProperty(PropertyName = "databaseId")]
        public string DatabaseId { get; set; }
        
        /// <value>
        /// An RFC3339 formatted datetime string that indicates the created time for a protected database. For Example: '2020-05-22T21:10:29.600Z'
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// An RFC3339 formatted datetime string that indicates the last updated time for a protected database. For Example: '2020-05-22T21:10:29.600Z'
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The current state of the Protected Database.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// The health of the Protected Database.
        /// </value>
        [JsonProperty(PropertyName = "health")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<Health> Health { get; set; }
        
        /// <value>
        /// Detailed description about the current lifecycle state of the protected database. For example, it can be used to provide actionable information for a resource in a Failed state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// A message describing the current health of the protected database.
        /// </value>
        [JsonProperty(PropertyName = "healthDetails")]
        public string HealthDetails { get; set; }
        
        /// <value>
        /// Indicates whether the protected database is created by Recovery Service or created manually.
        /// Set to <b>TRUE</b> for a service-defined protected database. When you enable the OCI-managed automatic backups option for a database and set Recovery Service as the backup destination, then Recovery Service creates the associated protected database resource.
        /// Set to <b>FALSE</b> for a user-defined protected database.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isReadOnlyResource")]
        public System.Nullable<bool> IsReadOnlyResource { get; set; }
        
        [JsonProperty(PropertyName = "metrics")]
        public MetricsSummary Metrics { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}. For more information, see [Resource Tags](https://docs.oracle.com/en-us/iaas/Content/General/Concepts/resourcetags.htm)
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}. For more information, see [Resource Tags](https://docs.oracle.com/en-us/iaas/Content/General/Concepts/resourcetags.htm)
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
