/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Oci.AdmService.Models
{
    /// <summary>
    /// A remediation run stage is one step of an remediation run. Each stage provides output logs and has a specific type.
    /// The stages are: DETECT, RECOMMEND, VERIFY, and APPLY.
    /// 
    /// </summary>
    [JsonConverter(typeof(RemediationRunStageModelConverter))]
    public class RemediationRunStage 
    {
                ///
        /// <value>
        /// The current status of a remediation run stage.
        /// </value>
        ///
        public enum StatusEnum {
            [EnumMember(Value = "CREATED")]
            Created,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "CANCELING")]
            Canceling,
            [EnumMember(Value = "CANCELED")]
            Canceled
        };

        /// <value>
        /// The current status of a remediation run stage.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// The creation date and time of the remediation run stage (formatted according to [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339)).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time of the start of the remediation run stage (formatted according to [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339)).
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The date and time of the finish of the remediation run stage (formatted according to [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339)).
        /// </value>
        [JsonProperty(PropertyName = "timeFinished")]
        public System.Nullable<System.DateTime> TimeFinished { get; set; }
        
        
        /// <value>
        /// Information about the current step within the stage.
        /// </value>
        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }
        
        /// <value>
        /// The Oracle Cloud identifier ([OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm)) of the remediation run.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RemediationRunId is required.")]
        [JsonProperty(PropertyName = "remediationRunId")]
        public string RemediationRunId { get; set; }
        
        /// <value>
        /// The previous type of stage in the remediation run.
        /// </value>
        [JsonProperty(PropertyName = "previousStageType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RemediationRunStageType> PreviousStageType { get; set; }
        
        /// <value>
        /// The next type of stage in the remediation run.
        /// </value>
        [JsonProperty(PropertyName = "nextStageType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RemediationRunStageType> NextStageType { get; set; }
        
    }

    public class RemediationRunStageModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(RemediationRunStage);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(RemediationRunStage);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "RECOMMEND":
                    obj = new RecommendStage();
                    break;
                case "VERIFY":
                    obj = new VerifyStage();
                    break;
                case "APPLY":
                    obj = new ApplyStage();
                    break;
                case "DETECT":
                    obj = new DetectStage();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under RemediationRunStage! Returning null value.");
            }
            return obj;
        }
    }
}
