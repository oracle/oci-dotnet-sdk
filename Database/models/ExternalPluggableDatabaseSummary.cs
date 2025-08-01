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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// An Oracle Cloud Infrastructure resource that allows you to manage an external pluggable database.
    /// 
    /// </summary>
    public class ExternalPluggableDatabaseSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the the non-container database that was converted
        /// to a pluggable database to create this resource.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sourceId")]
        public string SourceId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the
        /// {@link #createExternalContainerDatabaseDetails(CreateExternalContainerDatabaseDetailsRequest) createExternalContainerDatabaseDetails} that contains
        /// the specified {@link #createExternalPluggableDatabaseDetails(CreateExternalPluggableDatabaseDetailsRequest) createExternalPluggableDatabaseDetails} resource.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExternalContainerDatabaseId is required.")]
        [JsonProperty(PropertyName = "externalContainerDatabaseId")]
        public string ExternalContainerDatabaseId { get; set; }
        
        [JsonProperty(PropertyName = "operationsInsightsConfig")]
        public OperationsInsightsConfig OperationsInsightsConfig { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// System tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
        /// <value>
        /// The user-friendly name for the external database. The name does not have to be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Oracle Cloud Infrastructure external database resource.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Additional information about the current lifecycle state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
                ///
        /// <value>
        /// The current state of the Oracle Cloud Infrastructure external database resource.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PROVISIONING")]
            Provisioning,
            [EnumMember(Value = "NOT_CONNECTED")]
            NotConnected,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current state of the Oracle Cloud Infrastructure external database resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time the database was created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The `DB_UNIQUE_NAME` of the external database.
        /// </value>
        [JsonProperty(PropertyName = "dbUniqueName")]
        public string DbUniqueName { get; set; }
        
        /// <value>
        /// The Oracle Database ID, which identifies an Oracle Database located outside of Oracle Cloud.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dbId")]
        public string DbId { get; set; }
        
        /// <value>
        /// The Oracle Database version.
        /// </value>
        [JsonProperty(PropertyName = "databaseVersion")]
        public string DatabaseVersion { get; set; }
                ///
        /// <value>
        /// The Oracle Database Edition that applies to all the databases on the DB system.
        /// Exadata DB systems and 2-node RAC DB systems require ENTERPRISE_EDITION_EXTREME_PERFORMANCE.
        /// 
        /// </value>
        ///
        public enum DatabaseEditionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "STANDARD_EDITION")]
            StandardEdition,
            [EnumMember(Value = "ENTERPRISE_EDITION")]
            EnterpriseEdition,
            [EnumMember(Value = "ENTERPRISE_EDITION_HIGH_PERFORMANCE")]
            EnterpriseEditionHighPerformance,
            [EnumMember(Value = "ENTERPRISE_EDITION_EXTREME_PERFORMANCE")]
            EnterpriseEditionExtremePerformance,
            [EnumMember(Value = "ENTERPRISE_EDITION_DEVELOPER")]
            EnterpriseEditionDeveloper
        };

        /// <value>
        /// The Oracle Database Edition that applies to all the databases on the DB system.
        /// Exadata DB systems and 2-node RAC DB systems require ENTERPRISE_EDITION_EXTREME_PERFORMANCE.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "databaseEdition")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DatabaseEditionEnum> DatabaseEdition { get; set; }
        
        /// <value>
        /// The time zone of the external database.
        /// It is a time zone offset (a character type in the format '[+|-]TZH:TZM') or a time zone region name,
        /// depending on how the time zone value was specified when the database was created / last altered.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; set; }
        
        /// <value>
        /// The character set of the external database.
        /// </value>
        [JsonProperty(PropertyName = "characterSet")]
        public string CharacterSet { get; set; }
        
        /// <value>
        /// The national character of the external database.
        /// </value>
        [JsonProperty(PropertyName = "ncharacterSet")]
        public string NcharacterSet { get; set; }
        
        /// <value>
        /// The database packs licensed for the external Oracle Database.
        /// </value>
        [JsonProperty(PropertyName = "dbPacks")]
        public string DbPacks { get; set; }
                ///
        /// <value>
        /// The Oracle Database configuration
        /// </value>
        ///
        public enum DatabaseConfigurationEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "RAC")]
            Rac,
            [EnumMember(Value = "SINGLE_INSTANCE")]
            SingleInstance
        };

        /// <value>
        /// The Oracle Database configuration
        /// </value>
        [JsonProperty(PropertyName = "databaseConfiguration")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DatabaseConfigurationEnum> DatabaseConfiguration { get; set; }
        
        [JsonProperty(PropertyName = "databaseManagementConfig")]
        public DatabaseManagementConfig DatabaseManagementConfig { get; set; }
        
        [JsonProperty(PropertyName = "stackMonitoringConfig")]
        public StackMonitoringConfig StackMonitoringConfig { get; set; }
        
    }
}
