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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The configuration details of SQL plan baselines. The details include:
    /// <br/>
    /// - whether automatic initial plan capture is enabled or disabled
    /// - whether use of SQL plan baselines is enabled or disabled
    /// - whether Automatic SPM Evolve Advisor task is enabled or disabled
    /// - whether high-frequency Automatic SPM Evolve Advisor task is enabled or disabled
    /// - filters for the automatic initial plan capture
    /// - parameters for the Automatic SPM Evolve Advisor task
    /// - plan retention and allocated space for the plan baselines
    /// 
    /// </summary>
    public class SqlPlanBaselineConfiguration 
    {
        
        /// <value>
        /// Indicates whether the automatic capture of SQL plan baselines is enabled (`true`) or not (`false`).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsAutomaticInitialPlanCaptureEnabled is required.")]
        [JsonProperty(PropertyName = "isAutomaticInitialPlanCaptureEnabled")]
        public System.Nullable<bool> IsAutomaticInitialPlanCaptureEnabled { get; set; }
        
        /// <value>
        /// Indicates whether the database uses SQL plan baselines (`true`) or not (`false`).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsSqlPlanBaselinesUsageEnabled is required.")]
        [JsonProperty(PropertyName = "isSqlPlanBaselinesUsageEnabled")]
        public System.Nullable<bool> IsSqlPlanBaselinesUsageEnabled { get; set; }
        
        /// <value>
        /// Indicates whether the Automatic SPM Evolve Advisor task is enabled (`true`) or not (`false`).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsAutoSpmEvolveTaskEnabled is required.")]
        [JsonProperty(PropertyName = "isAutoSpmEvolveTaskEnabled")]
        public System.Nullable<bool> IsAutoSpmEvolveTaskEnabled { get; set; }
        
        /// <value>
        /// Indicates whether the high frequency Automatic SPM Evolve Advisor task is enabled (`true`) or not (`false`).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsHighFrequencyAutoSpmEvolveTaskEnabled is required.")]
        [JsonProperty(PropertyName = "isHighFrequencyAutoSpmEvolveTaskEnabled")]
        public System.Nullable<bool> IsHighFrequencyAutoSpmEvolveTaskEnabled { get; set; }
        
        /// <value>
        /// The number of weeks to retain unused plans before they are purged.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PlanRetentionWeeks is required.")]
        [JsonProperty(PropertyName = "planRetentionWeeks")]
        public System.Nullable<int> PlanRetentionWeeks { get; set; }
        
        /// <value>
        /// The maximum percent of `SYSAUX` space that can be used for SQL Management Base.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SpaceBudgetPercent is required.")]
        [JsonProperty(PropertyName = "spaceBudgetPercent")]
        public System.Nullable<float> SpaceBudgetPercent { get; set; }
        
        /// <value>
        /// The maximum `SYSAUX` space that can be used for SQL Management Base in MB.
        /// </value>
        [JsonProperty(PropertyName = "spaceBudgetMB")]
        public System.Nullable<float> SpaceBudgetMB { get; set; }
        
        /// <value>
        /// The space used by SQL Management Base in MB.
        /// </value>
        [JsonProperty(PropertyName = "spaceUsedMB")]
        public System.Nullable<float> SpaceUsedMB { get; set; }
        
        /// <value>
        /// The capture filters used in automatic initial plan capture.
        /// </value>
        [JsonProperty(PropertyName = "autoCaptureFilters")]
        public System.Collections.Generic.List<AutomaticCaptureFilter> AutoCaptureFilters { get; set; }
        
        [JsonProperty(PropertyName = "autoSpmEvolveTaskParameters")]
        public SpmEvolveTaskParameters AutoSpmEvolveTaskParameters { get; set; }
        
    }
}
