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
using Newtonsoft.Json.Linq;

namespace Oci.DatascienceService.Models
{
    /// <summary>
    /// Detail of each StepRun.
    /// </summary>
    [JsonConverter(typeof(PipelineStepRunModelConverter))]
    public class PipelineStepRun 
    {
                ///
        /// <value>
        /// The type of step.
        /// </value>
        ///
        public enum StepTypeEnum {
            [EnumMember(Value = "ML_JOB")]
            MlJob,
            [EnumMember(Value = "CUSTOM_SCRIPT")]
            CustomScript,
            [EnumMember(Value = "CONTAINER")]
            Container,
            [EnumMember(Value = "DATAFLOW")]
            Dataflow
        };

        
        /// <value>
        /// The date and time the pipeline step run was started in the timestamp format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeStarted is required.")]
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The date and time the pipeline step run finshed executing in the timestamp format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// </value>
        [JsonProperty(PropertyName = "timeFinished")]
        public System.Nullable<System.DateTime> TimeFinished { get; set; }
        
        /// <value>
        /// The name of the step.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StepName is required.")]
        [JsonProperty(PropertyName = "stepName")]
        public string StepName { get; set; }
                ///
        /// <value>
        /// The state of the step run.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "WAITING")]
            Waiting,
            [EnumMember(Value = "ACCEPTED")]
            Accepted,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "CANCELING")]
            Canceling,
            [EnumMember(Value = "CANCELED")]
            Canceled,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "SKIPPED")]
            Skipped
        };

        /// <value>
        /// The state of the step run.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Details of the state of the step run.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
    }

    public class PipelineStepRunModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(PipelineStepRun);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(PipelineStepRun);
            var discriminator = jsonObject["stepType"].Value<string>();
            switch (discriminator)
            {
                case "CONTAINER":
                    obj = new PipelineContainerStepRun();
                    break;
                case "CUSTOM_SCRIPT":
                    obj = new PipelineCustomScriptStepRun();
                    break;
                case "ML_JOB":
                    obj = new PipelineMLJobStepRun();
                    break;
                case "DATAFLOW":
                    obj = new PipelineDataflowStepRun();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under PipelineStepRun! Returning null value.");
            }
            return obj;
        }
    }
}
