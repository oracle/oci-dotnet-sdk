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
    /// A masking policy defines the approach to mask data in a target database. It's basically 
    /// a collection of columns to be masked, called masking columns, and the associated masking 
    /// formats to be used to mask these columns. A masking policy can be used to mask multiple 
    /// databases provided that they have the same schema design. For more information, see 
    /// <a href=\"https://docs.oracle.com/en/cloud/paas/data-safe/udscs/masking-policies.html\">Masking Policies </a> 
    /// in the Oracle Data Safe documentation. 
    /// 
    /// </summary>
    public class MaskingPolicy 
    {
        
        /// <value>
        /// The OCID of the masking policy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the compartment that contains the masking policy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The display name of the masking policy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The date and time the masking policy was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339). 
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The current state of the masking policy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MaskingLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time the masking policy was last updated, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339) 
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The description of the masking policy.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Indicates if the temporary tables created during a masking operation should be dropped after masking. It's enabled by default.
        /// Set this attribute to false to preserve the temporary tables. Masking creates temporary tables that map the original sensitive 
        /// data values to mask values. By default, these temporary tables are dropped after masking. But, in some cases, you may want 
        /// to preserve this information to track how masking changed your data. Note that doing so compromises security. These tables 
        /// must be dropped before the database is available for unprivileged users. 
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsDropTempTablesEnabled is required.")]
        [JsonProperty(PropertyName = "isDropTempTablesEnabled")]
        public System.Nullable<bool> IsDropTempTablesEnabled { get; set; }
        
        /// <value>
        /// Indicates if redo logging is enabled during a masking operation. It's disabled by default. Set this attribute to true to
        /// enable redo logging. By default, masking disables redo logging and flashback logging to purge any original unmasked 
        /// data from logs. However, in certain circumstances when you only want to test masking, rollback changes, and retry masking,
        /// you could enable logging and use a flashback database to retrieve the original unmasked data after it has been masked. 
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsRedoLoggingEnabled is required.")]
        [JsonProperty(PropertyName = "isRedoLoggingEnabled")]
        public System.Nullable<bool> IsRedoLoggingEnabled { get; set; }
        
        /// <value>
        /// Indicates if statistics gathering is enabled. It's enabled by default. Set this attribute to false to disable statistics
        /// gathering. The masking process gathers statistics on masked database tables after masking completes.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsRefreshStatsEnabled is required.")]
        [JsonProperty(PropertyName = "isRefreshStatsEnabled")]
        public System.Nullable<bool> IsRefreshStatsEnabled { get; set; }
        
        /// <value>
        /// Specifies options to enable parallel execution when running data masking. Allowed values are 'NONE' (no parallelism),
        /// 'DEFAULT' (the Oracle Database computes the optimum degree of parallelism) or an integer value to be used as the degree
        /// of parallelism. Parallel execution helps effectively use multiple CPUs and improve masking performance. Refer to the
        /// Oracle Database parallel execution framework when choosing an explicit degree of parallelism.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ParallelDegree is required.")]
        [JsonProperty(PropertyName = "parallelDegree")]
        public string ParallelDegree { get; set; }
                ///
        /// <value>
        /// Specifies how to recompile invalid objects post data masking. Allowed values are 'SERIAL' (recompile in serial), 
        /// 'PARALLEL' (recompile in parallel), 'NONE' (do not recompile). If it's set to PARALLEL, the value of parallelDegree
        /// attribute is used. Use the built-in UTL_RECOMP package to recompile any remaining invalid objects after masking completes.
        /// 
        /// </value>
        ///
        public enum RecompileEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SERIAL")]
            Serial,
            [EnumMember(Value = "PARALLEL")]
            Parallel,
            [EnumMember(Value = "NONE")]
            None
        };

        /// <value>
        /// Specifies how to recompile invalid objects post data masking. Allowed values are 'SERIAL' (recompile in serial), 
        /// 'PARALLEL' (recompile in parallel), 'NONE' (do not recompile). If it's set to PARALLEL, the value of parallelDegree
        /// attribute is used. Use the built-in UTL_RECOMP package to recompile any remaining invalid objects after masking completes.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Recompile is required.")]
        [JsonProperty(PropertyName = "recompile")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RecompileEnum> Recompile { get; set; }
        
        /// <value>
        /// A pre-masking script, which can contain SQL and PL/SQL statements. It's executed before 
        /// the core masking script generated using the masking policy. It's usually used to perform
        /// any preparation or prerequisite work before masking data.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "preMaskingScript")]
        public string PreMaskingScript { get; set; }
        
        /// <value>
        /// A post-masking script, which can contain SQL and PL/SQL statements. It's executed after
        /// the core masking script generated using the masking policy. It's usually used to perform
        /// additional transformation or cleanup work after masking.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "postMaskingScript")]
        public string PostMaskingScript { get; set; }
        
        [JsonProperty(PropertyName = "columnSource")]
        public ColumnSourceDetails ColumnSource { get; set; }
        
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
