/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// A sensitive data model is a collection of sensitive columns and their referential relationships. It helps
    /// understand the sensitive data landscape, track changes, and efficiently enable security controls such as data
    /// masking. It can be managed either manually or by performing sensitive data discovery on a reference target
    /// database. [Learn more](https://docs.oracle.com/en/cloud/paas/data-safe/udscs/sensitive-data-models1.html#GUID-849CA7D2-1809-40DD-B6D7-44E46EFF7EB5).
    /// 
    /// </summary>
    public class SensitiveDataModel 
    {
        
        /// <value>
        /// The OCID of the sensitive data model.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The display name of the sensitive data model.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The OCID of the compartment that contains the sensitive data model.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The OCID of the reference target database associated with the sensitive data model. All operations such as
        /// performing data discovery and adding columns manually are done in the context of the associated target database.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetId is required.")]
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }
        
        /// <value>
        /// The date and time the sensitive data model was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the sensitive data model was last updated, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The current state of the sensitive data model.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DiscoveryLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// The application suite name identifying a collection of applications. The default value is GENERIC. It's useful
        /// only if maintaining a sensitive data model for a suite of applications.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AppSuiteName is required.")]
        [JsonProperty(PropertyName = "appSuiteName")]
        public string AppSuiteName { get; set; }
        
        /// <value>
        /// The description of the sensitive data model.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The schemas to be scanned by data discovery jobs.
        /// </value>
        [JsonProperty(PropertyName = "schemasForDiscovery")]
        public System.Collections.Generic.List<string> SchemasForDiscovery { get; set; }
        
        /// <value>
        /// The OCIDs of the sensitive types to be used by data discovery jobs.
        /// </value>
        [JsonProperty(PropertyName = "sensitiveTypeIdsForDiscovery")]
        public System.Collections.Generic.List<string> SensitiveTypeIdsForDiscovery { get; set; }
        
        /// <value>
        /// Indicates if data discovery jobs should collect and store sample data values for the discovered columns.
        /// Sample data helps review the discovered columns and ensure that they actually contain sensitive data.
        /// As it collects original data from the target database, it's disabled by default and should be used only if
        /// it's acceptable to store sample data in Data Safe's repository in Oracle Cloud. Note that sample data values
        /// are not collected for columns with the following data types: LONG, LOB, RAW, XMLTYPE and BFILE.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsSampleDataCollectionEnabled is required.")]
        [JsonProperty(PropertyName = "isSampleDataCollectionEnabled")]
        public System.Nullable<bool> IsSampleDataCollectionEnabled { get; set; }
        
        /// <value>
        /// Indicates if data discovery jobs should identify potential application-level (non-dictionary) referential
        /// relationships between columns. Note that data discovery automatically identifies and adds database-level (dictionary-defined)
        /// relationships. This option helps identify application-level relationships that are not defined in the database dictionary,
        /// which in turn, helps identify additional sensitive columns and preserve referential integrity during data masking.
        /// It's disabled by default and should be used only if there is a need to identify application-level relationships.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsAppDefinedRelationDiscoveryEnabled is required.")]
        [JsonProperty(PropertyName = "isAppDefinedRelationDiscoveryEnabled")]
        public System.Nullable<bool> IsAppDefinedRelationDiscoveryEnabled { get; set; }
        
        /// <value>
        /// Indicates if all the schemas in the associated target database should be scanned by data discovery jobs.
        /// If it's set to true, the schemasForDiscovery attribute is ignored and all schemas are used for data discovery.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsIncludeAllSchemas is required.")]
        [JsonProperty(PropertyName = "isIncludeAllSchemas")]
        public System.Nullable<bool> IsIncludeAllSchemas { get; set; }
        
        /// <value>
        /// Indicates if all the existing sensitive types should be used by data discovery jobs.If it's set to true, the
        /// sensitiveTypeIdsForDiscovery attribute is ignored and all sensitive types are used for data discovery.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsIncludeAllSensitiveTypes is required.")]
        [JsonProperty(PropertyName = "isIncludeAllSensitiveTypes")]
        public System.Nullable<bool> IsIncludeAllSensitiveTypes { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm)
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm)
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// System tags for this resource. Each key is predefined and scoped to a namespace. For more information, see Resource Tags.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
