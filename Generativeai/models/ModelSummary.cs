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


namespace Oci.GenerativeaiService.Models
{
    /// <summary>
    /// Summary of the model.
    /// 
    /// </summary>
    public class ModelSummary 
    {
        
        /// <value>
        /// An ID that uniquely identifies a pretrained or a fine-tuned model.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The compartment OCID for fine-tuned models. For pretrained models, this value is null.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Describes what this model can be used for.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Capabilities is required.")]
        [JsonProperty(PropertyName = "capabilities", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<ModelCapability> Capabilities { get; set; }
        
        /// <value>
        /// The lifecycle state of the model.
        /// <br/>
        /// Allowed values are:
        /// - ACTIVE
        /// - CREATING
        /// - DELETING
        /// - DELETED
        /// - FAILED
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<Model.LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the current state of the model with detail that can provide actionable information.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// A user-friendly name.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The provider of the model.
        /// </value>
        [JsonProperty(PropertyName = "vendor")]
        public string Vendor { get; set; }
        
        /// <value>
        /// The version of the model.
        /// </value>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
        /// <value>
        /// The date and time that the model was created in the format of an RFC3339 datetime string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The OCID of the base model that's used for fine-tuning. For pretrained models, the value is null.
        /// </value>
        [JsonProperty(PropertyName = "baseModelId")]
        public string BaseModelId { get; set; }
        
        /// <value>
        /// The model type indicating whether this is a pretrained/base model or a custom/fine-tuned model.
        /// <br/>
        /// Allowed values are:
        /// - BASE
        /// - CUSTOM
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<Model.TypeEnum> Type { get; set; }
        
        [JsonProperty(PropertyName = "fineTuneDetails")]
        public FineTuneDetails FineTuneDetails { get; set; }
        
        [JsonProperty(PropertyName = "modelMetrics")]
        public ModelMetrics ModelMetrics { get; set; }
        
        /// <value>
        /// Whether a model is supported long-term. Applies only to base models.
        /// </value>
        [JsonProperty(PropertyName = "isLongTermSupported")]
        public System.Nullable<bool> IsLongTermSupported { get; set; }
        
        /// <value>
        /// Corresponds to the time when the custom model and its associated foundation model will be deprecated.
        /// </value>
        [JsonProperty(PropertyName = "timeDeprecated")]
        public System.Nullable<System.DateTime> TimeDeprecated { get; set; }
        
        /// <value>
        /// The timestamp indicating when the base model will no longer be available for on-demand usage.
        /// </value>
        [JsonProperty(PropertyName = "timeOnDemandRetired")]
        public System.Nullable<System.DateTime> TimeOnDemandRetired { get; set; }
        
        /// <value>
        /// The timestamp indicating when the custom model and its associated foundation model will be fully retired.
        /// </value>
        [JsonProperty(PropertyName = "timeDedicatedRetired")]
        public System.Nullable<System.DateTime> TimeDedicatedRetired { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// System tags for this resource. Each key is predefined and scoped to a namespace.
        /// <br/>
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
