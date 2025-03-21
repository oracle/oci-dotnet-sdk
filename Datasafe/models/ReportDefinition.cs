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
    /// Description of report definition.
    /// </summary>
    public class ReportDefinition 
    {
        
        /// <value>
        /// Name of the report definition.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The OCID of the report definition.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the parent report definition. In the case of seeded report definition, this is same as definition OCID.
        /// </value>
        [JsonProperty(PropertyName = "parentId")]
        public string ParentId { get; set; }
                ///
        /// <value>
        /// Specifies the name of the category that this report belongs to.
        /// </value>
        ///
        public enum CategoryEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CUSTOM_REPORTS")]
            CustomReports,
            [EnumMember(Value = "SUMMARY")]
            Summary,
            [EnumMember(Value = "ACTIVITY_AUDITING")]
            ActivityAuditing,
            [EnumMember(Value = "SECURITY_ASSESSMENT")]
            SecurityAssessment,
            [EnumMember(Value = "FIREWALL_VIOLATIONS")]
            FirewallViolations,
            [EnumMember(Value = "ALLOWED_SQL")]
            AllowedSql
        };

        /// <value>
        /// Specifies the name of the category that this report belongs to.
        /// </value>
        [JsonProperty(PropertyName = "category")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CategoryEnum> Category { get; set; }
        
        /// <value>
        /// A description of the report definition.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Specifies the name of a resource that provides data for the report. For example alerts, events.
        /// </value>
        [JsonProperty(PropertyName = "dataSource")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ReportDefinitionDataSource> DataSource { get; set; }
        
        /// <value>
        /// Signifies whether the definition is seeded or user defined. Values can either be 'true' or 'false'.
        /// </value>
        [JsonProperty(PropertyName = "isSeeded")]
        public System.Nullable<bool> IsSeeded { get; set; }
        
        /// <value>
        /// Specifies how the report definitions are ordered in the display.
        /// </value>
        [JsonProperty(PropertyName = "displayOrder")]
        public System.Nullable<int> DisplayOrder { get; set; }
        
        /// <value>
        /// Specifies the date and time the report definition was created.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the report definition was updated.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Additional SCIM filters used to define the report.
        /// </value>
        [JsonProperty(PropertyName = "scimFilter")]
        public string ScimFilter { get; set; }
        
        /// <value>
        /// An array of column objects in the order (left to right) displayed in the report. A column object stores all information about a column, including the name displayed on the UI, corresponding field name in the data source, data type of the column, and column visibility (if the column is visible to the user).
        /// </value>
        [JsonProperty(PropertyName = "columnInfo")]
        public System.Collections.Generic.List<Column> ColumnInfo { get; set; }
        
        /// <value>
        /// An array of columnFilter objects. A columnFilter object stores all information about a column filter including field name, an operator, one or more expressions, if the filter is enabled, or if the filter is hidden.
        /// </value>
        [JsonProperty(PropertyName = "columnFilters")]
        public System.Collections.Generic.List<ColumnFilter> ColumnFilters { get; set; }
        
        /// <value>
        /// An array of column sorting objects. Each column sorting object stores the column name to be sorted and if the sorting is in ascending order; sorting is done by the first column in the array, then by the second column in the array, etc.
        /// </value>
        [JsonProperty(PropertyName = "columnSortings")]
        public System.Collections.Generic.List<ColumnSorting> ColumnSortings { get; set; }
        
        /// <value>
        /// An array of report summary objects in the order (left to right)  displayed in the report.  A  report summary object stores all information about summary of report to be displayed, including the name displayed on UI, the display order, corresponding group by and count of values, summary visibility (if the summary is visible to user).
        /// </value>
        [JsonProperty(PropertyName = "summary")]
        public System.Collections.Generic.List<Summary> Summary { get; set; }
        
        /// <value>
        /// The OCID of the compartment containing the report definition.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The current state of the report.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ReportDefinitionLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// The schedule to generate the report periodically in the specified format:
        /// <version-string>;<version-specific-schedule>
        /// <br/>
        /// Allowed version strings - \"v1\"
        /// v1's version specific schedule -<ss> <mm> <hh> <day-of-week> <day-of-month>
        /// Each of the above fields potentially introduce constraints. A workrequest is created only
        /// when clock time satisfies all the constraints. Constraints introduced:
        /// 1. seconds = <ss> (So, the allowed range for <ss> is [0, 59])
        /// 2. minutes = <mm> (So, the allowed range for <mm> is [0, 59])
        /// 3. hours = <hh> (So, the allowed range for <hh> is [0, 23])
        /// 4. <day-of-week> can be either '*' (without quotes or a number between 1(Monday) and 7(Sunday))
        /// No constraint introduced when it is '*'. When not, day of week must equal the given value
        /// 5. <day-of-month> can be either '*' (without quotes or a number between 1 and 28)
        /// No constraint introduced when it is '*'. When not, day of month must equal the given value
        /// 
        /// </value>
        [JsonProperty(PropertyName = "schedule")]
        public string Schedule { get; set; }
                ///
        /// <value>
        /// Specifies the format of the report ( either .xls or .pdf or .json)
        /// </value>
        ///
        public enum ScheduledReportMimeTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PDF")]
            Pdf,
            [EnumMember(Value = "XLS")]
            Xls,
            [EnumMember(Value = "JSON")]
            Json
        };

        /// <value>
        /// Specifies the format of the report ( either .xls or .pdf or .json)
        /// </value>
        [JsonProperty(PropertyName = "scheduledReportMimeType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ScheduledReportMimeTypeEnum> ScheduledReportMimeType { get; set; }
        
        /// <value>
        /// Specifies the limit on the number of rows in the report.
        /// </value>
        [JsonProperty(PropertyName = "scheduledReportRowLimit")]
        public System.Nullable<int> ScheduledReportRowLimit { get; set; }
        
        /// <value>
        /// The name of the report to be scheduled.
        /// </value>
        [JsonProperty(PropertyName = "scheduledReportName")]
        public string ScheduledReportName { get; set; }
        
        /// <value>
        /// The OCID of the compartment in which the scheduled resource will be created.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "scheduledReportCompartmentId")]
        public string ScheduledReportCompartmentId { get; set; }
        
        /// <value>
        /// The time span for the records in the report to be scheduled.
        /// <period-value><period>
        /// Allowed period strings - \"H\",\"D\",\"M\",\"Y\"
        /// Each of the above fields potentially introduce constraints. A workRequest is created only
        /// when period-value satisfies all the constraints. Constraints introduced:
        /// 1. period = H (The allowed range for period-value is [1, 23])
        /// 2. period = D (The allowed range for period-value is [1, 30])
        /// 3. period = M (The allowed range for period-value is [1, 11])
        /// 4. period = Y (The minimum period-value is 1)
        /// 
        /// </value>
        [JsonProperty(PropertyName = "recordTimeSpan")]
        public string RecordTimeSpan { get; set; }
        
        /// <value>
        /// The list of the data protection regulations/standards used in the report that will help demonstrate compliance.
        /// </value>
        [JsonProperty(PropertyName = "complianceStandards")]
        public System.Collections.Generic.List<string> ComplianceStandards { get; set; }
        
        /// <value>
        /// Details about the current state of the report definition in Data Safe.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
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
        
        /// <value>
        /// System tags for this resource. Each key is predefined and scoped to a namespace. For more information, see Resource Tags.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
