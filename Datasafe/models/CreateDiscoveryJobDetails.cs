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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// Details to create a new data discovery job.
    /// </summary>
    public class CreateDiscoveryJobDetails 
    {
        
        /// <value>
        /// The type of the discovery job. It defines the job's scope.
        /// NEW identifies new sensitive columns in the target database that are not in the sensitive data model.
        /// DELETED identifies columns that are present in the sensitive data model but have been deleted from the target database.
        /// MODIFIED identifies columns that are present in the target database as well as the sensitive data model but some of their attributes have been modified.
        /// ALL covers all the above three scenarios and reports new, deleted and modified columns.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "discoveryType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DiscoveryJob.DiscoveryTypeEnum> DiscoveryType { get; set; }
        
        /// <value>
        /// The OCID of the sensitive data model.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SensitiveDataModelId is required.")]
        [JsonProperty(PropertyName = "sensitiveDataModelId")]
        public string SensitiveDataModelId { get; set; }
        
        /// <value>
        /// The OCID of the compartment where the discovery job resource should be created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A user-friendly name for the discovery job. Does not have to be unique, and it is changeable. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The schemas to be scanned by the discovery job. If not provided, the schemasForDiscovery attribute of the sensitive
        /// data model is used to get the list of schemas.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "schemasForDiscovery")]
        public System.Collections.Generic.List<string> SchemasForDiscovery { get; set; }
        
        /// <value>
        /// The data discovery jobs will scan the tables specified here, including both schemas and tables. In the absence 
        /// of explicit input, the list of tables is obtained from the tablesForDiscovery attribute of the sensitive data model.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "tablesForDiscovery")]
        public System.Collections.Generic.List<TablesForDiscovery> TablesForDiscovery { get; set; }
        
        /// <value>
        /// The OCIDs of the sensitive types to be used by the discovery job. If not provided, the sensitiveTypeIdsForDiscovery
        /// attribute of the sensitive data model is used to get the list of sensitive types.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sensitiveTypeIdsForDiscovery")]
        public System.Collections.Generic.List<string> SensitiveTypeIdsForDiscovery { get; set; }
        
        /// <value>
        /// The OCIDs of the sensitive type groups to be used by the discovery job. All the sensitive types present in
        /// sensitive type group will be used for discovery.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sensitiveTypeGroupIdsForDiscovery")]
        public System.Collections.Generic.List<string> SensitiveTypeGroupIdsForDiscovery { get; set; }
        
        /// <value>
        /// Indicates if the discovery job should collect and store sample data values for the discovered columns. Sample data
        /// helps review the discovered columns and ensure that they actually contain sensitive data. As it collects original
        /// data from the target database, it's disabled by default and should be used only if it's acceptable to store sample
        /// data in Data Safe's repository in Oracle Cloud. Note that sample data values are not collected for columns with the
        /// following data types: LONG, LOB, RAW, XMLTYPE and BFILE.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSampleDataCollectionEnabled")]
        public System.Nullable<bool> IsSampleDataCollectionEnabled { get; set; }
        
        /// <value>
        /// Indicates if the discovery job should identify potential application-level (non-dictionary) referential relationships
        /// between columns. Note that data discovery automatically identifies and adds database-level (dictionary-defined)
        /// relationships. This option helps identify application-level relationships that are not defined in the database
        /// dictionary, which in turn, helps identify additional sensitive columns and preserve referential integrity during
        /// data masking. It's disabled by default and should be used only if there is a need to identify application-level
        /// relationships.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAppDefinedRelationDiscoveryEnabled")]
        public System.Nullable<bool> IsAppDefinedRelationDiscoveryEnabled { get; set; }
        
        /// <value>
        /// Indicates if all the schemas should be scanned by the discovery job. If it is set to true, sensitive data is discovered
        /// in all schemas (except for schemas maintained by Oracle). If both attributes are not provided, the configuration
        /// from the sensitive data model is used.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isIncludeAllSchemas")]
        public System.Nullable<bool> IsIncludeAllSchemas { get; set; }
        
        /// <value>
        /// Indicates if all the existing sensitive types should be used by the discovery job. If it's set to true, the
        /// sensitiveTypeIdsForDiscovery attribute is ignored and all sensitive types are used for data discovery. If both
        /// attributes are not provided, the configuration from the sensitive data model is used.
        /// 
        /// </value>
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
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
