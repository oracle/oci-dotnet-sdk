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


namespace Oci.AivisionService.Models
{
    /// <summary>
    /// Machine-learned Model.
    /// </summary>
    public class Model 
    {
        
        /// <value>
        /// A unique identifier that is immutable after creation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// A human-friendly name for the model, which can be changed.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// An optional description of the model.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The compartment identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
                ///
        /// <value>
        /// What type of Vision model this is.
        /// </value>
        ///
        public enum ModelTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "IMAGE_CLASSIFICATION")]
            ImageClassification,
            [EnumMember(Value = "OBJECT_DETECTION")]
            ObjectDetection
        };

        /// <value>
        /// What type of Vision model this is.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ModelType is required.")]
        [JsonProperty(PropertyName = "modelType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ModelTypeEnum> ModelType { get; set; }
        
        /// <value>
        /// Set to true when experimenting with a new model type or dataset, so model training is quick, with a predefined low number of passes through the training data.
        /// </value>
        [JsonProperty(PropertyName = "isQuickMode")]
        public System.Nullable<bool> IsQuickMode { get; set; }
        
        /// <value>
        /// The maximum model training duration in hours, expressed as a decimal fraction.
        /// </value>
        [JsonProperty(PropertyName = "maxTrainingDurationInHours")]
        public System.Double MaxTrainingDurationInHours { get; set; }
        
        /// <value>
        /// The total hours actually used for model training.
        /// </value>
        [JsonProperty(PropertyName = "trainedDurationInHours")]
        public System.Double TrainedDurationInHours { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TrainingDataset is required.")]
        [JsonProperty(PropertyName = "trainingDataset")]
        public Dataset TrainingDataset { get; set; }
        
        [JsonProperty(PropertyName = "testingDataset")]
        public Dataset TestingDataset { get; set; }
        
        [JsonProperty(PropertyName = "validationDataset")]
        public Dataset ValidationDataset { get; set; }
        
        /// <value>
        /// The version of the model.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ModelVersion is required.")]
        [JsonProperty(PropertyName = "modelVersion")]
        public string ModelVersion { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the project that contains the model.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProjectId is required.")]
        [JsonProperty(PropertyName = "projectId")]
        public string ProjectId { get; set; }
        
        /// <value>
        /// When the model was created, as an RFC3339 datetime string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// When the model was updated, as an RFC3339 datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
                ///
        /// <value>
        /// The current state of the model.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current state of the model.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the current state in more detail, that can provide actionable information if training failed.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The precision of the trained model.
        /// </value>
        [JsonProperty(PropertyName = "precision")]
        public System.Nullable<float> Precision { get; set; }
        
        /// <value>
        /// Recall of the trained model.
        /// </value>
        [JsonProperty(PropertyName = "recall")]
        public System.Nullable<float> Recall { get; set; }
        
        /// <value>
        /// The mean average precision of the trained model.
        /// </value>
        [JsonProperty(PropertyName = "averagePrecision")]
        public System.Nullable<float> AveragePrecision { get; set; }
        
        /// <value>
        /// The intersection over the union threshold used for calculating precision and recall.
        /// </value>
        [JsonProperty(PropertyName = "confidenceThreshold")]
        public System.Nullable<float> ConfidenceThreshold { get; set; }
        
        /// <value>
        /// The number of images in the dataset used to train, validate, and test the model.
        /// </value>
        [JsonProperty(PropertyName = "totalImageCount")]
        public System.Nullable<int> TotalImageCount { get; set; }
        
        /// <value>
        /// The number of images set aside for evaluating model performance metrics after training.
        /// </value>
        [JsonProperty(PropertyName = "testImageCount")]
        public System.Nullable<int> TestImageCount { get; set; }
        
        /// <value>
        /// The complete set of per-label metrics for successfully trained models.
        /// </value>
        [JsonProperty(PropertyName = "metrics")]
        public string Metrics { get; set; }
        
        /// <value>
        /// A simple key-value pair that is applied without any predefined name, type, or scope. It exists for cross-compatibility only.
        /// For Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces.
        /// For Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
