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


namespace Oci.CloudguardService.Models
{
    /// <summary>
    /// Problems are at the core of Cloud Guard\u2019s functionality. A Problem resource is created whenever an action or a configuration on a resource triggers a rule in a detector that\u2019s attached to the target containing the compartment where the resource is located. Each Problem resource contains all the details for a single problem. This is the information for the problem that appears on the Cloud Guard Problems page.
    /// </summary>
    public class Problem 
    {
        
        /// <value>
        /// Unique identifier that can't be changed after creation
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Compartment OCID where the resource is created
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Unique identifier of the detector rule that triggered the problem
        /// </value>
        [JsonProperty(PropertyName = "detectorRuleId")]
        public string DetectorRuleId { get; set; }
        
        /// <value>
        /// DEPRECATED
        /// </value>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }
        
        /// <value>
        /// Regions where the problem is found
        /// </value>
        [JsonProperty(PropertyName = "regions")]
        public System.Collections.Generic.List<string> Regions { get; set; }
        
        /// <value>
        /// The risk level for the problem
        /// </value>
        [JsonProperty(PropertyName = "riskLevel")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RiskLevel> RiskLevel { get; set; }
        
        /// <value>
        /// The risk score for the problem
        /// </value>
        [JsonProperty(PropertyName = "riskScore")]
        public System.Double RiskScore { get; set; }
        
        /// <value>
        /// The date and time for the peak risk score that is observed for the problem. Format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "peakRiskScoreDate")]
        public string PeakRiskScoreDate { get; set; }
        
        /// <value>
        /// Peak risk score for the problem
        /// </value>
        [JsonProperty(PropertyName = "peakRiskScore")]
        public System.Double PeakRiskScore { get; set; }
        
        /// <value>
        /// The date and time when the problem will be auto resolved. Format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "autoResolveDate")]
        public string AutoResolveDate { get; set; }
        
        /// <value>
        /// Number of days for which peak score is calculated for the problem
        /// </value>
        [JsonProperty(PropertyName = "peakRiskScoreLookupPeriodInDays")]
        public System.Nullable<int> PeakRiskScoreLookupPeriodInDays { get; set; }
        
        /// <value>
        /// Unique identifier of the resource affected by the problem
        /// </value>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
        
        /// <value>
        /// Display name of the affected resource
        /// </value>
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }
        
        /// <value>
        /// Type of the affected resource
        /// </value>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }
        
        /// <value>
        /// User-defined labels on the problem
        /// </value>
        [JsonProperty(PropertyName = "labels")]
        public System.Collections.Generic.List<string> Labels { get; set; }
        
        /// <value>
        /// The date and time the problem was last detected. Format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeLastDetected")]
        public System.Nullable<System.DateTime> TimeLastDetected { get; set; }
        
        /// <value>
        /// The date and time the problem was first detected. Format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeFirstDetected")]
        public System.Nullable<System.DateTime> TimeFirstDetected { get; set; }
        
        /// <value>
        /// The current lifecycle state of the problem
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ProblemLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Additional details on the substate of the lifecycle state
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetail")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ProblemLifecycleDetail> LifecycleDetail { get; set; }
        
        /// <value>
        /// Unique identifier of the detector rule that triggered the problem
        /// </value>
        [JsonProperty(PropertyName = "detectorId")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DetectorEnum> DetectorId { get; set; }
        
        /// <value>
        /// Unique identifier of the target associated with the problem
        /// </value>
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }
        
        /// <value>
        /// The additional details of the problem
        /// </value>
        [JsonProperty(PropertyName = "additionalDetails")]
        public System.Collections.Generic.Dictionary<string, string> AdditionalDetails { get; set; }
        
        /// <value>
        /// Description of the problem
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Recommendation for the problem
        /// </value>
        [JsonProperty(PropertyName = "recommendation")]
        public string Recommendation { get; set; }
        
        /// <value>
        /// User comments on the problem
        /// </value>
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }
        
        /// <value>
        /// Unique identifier of the resource impacted by the problem
        /// </value>
        [JsonProperty(PropertyName = "impactedResourceId")]
        public string ImpactedResourceId { get; set; }
        
        /// <value>
        /// Display name of the impacted resource
        /// </value>
        [JsonProperty(PropertyName = "impactedResourceName")]
        public string ImpactedResourceName { get; set; }
        
        /// <value>
        /// Type of the impacted resource
        /// </value>
        [JsonProperty(PropertyName = "impactedResourceType")]
        public string ImpactedResourceType { get; set; }
        
        /// <value>
        /// Locks associated with this resource.
        /// </value>
        [JsonProperty(PropertyName = "locks")]
        public System.Collections.Generic.List<ResourceLock> Locks { get; set; }
        
    }
}
