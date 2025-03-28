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

namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Details about the execution progress of a stage in a deployment.
    /// </summary>
    [JsonConverter(typeof(DeployStageExecutionProgressModelConverter))]
    public class DeployStageExecutionProgress 
    {
        
        /// <value>
        /// Stage display name. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "deployStageDisplayName")]
        public string DeployStageDisplayName { get; set; }
        
        
        /// <value>
        /// The OCID of the stage.
        /// </value>
        [JsonProperty(PropertyName = "deployStageId")]
        public string DeployStageId { get; set; }
        
        /// <value>
        /// Time the stage started executing. Format defined by [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339).
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// Time the stage finished executing. Format defined by [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339).
        /// </value>
        [JsonProperty(PropertyName = "timeFinished")]
        public System.Nullable<System.DateTime> TimeFinished { get; set; }
                ///
        /// <value>
        /// The current state of the stage.
        /// </value>
        ///
        public enum StatusEnum {
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
            [EnumMember(Value = "ROLLBACK_IN_PROGRESS")]
            RollbackInProgress,
            [EnumMember(Value = "ROLLBACK_SUCCEEDED")]
            RollbackSucceeded,
            [EnumMember(Value = "ROLLBACK_FAILED")]
            RollbackFailed
        };

        /// <value>
        /// The current state of the stage.
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        [JsonProperty(PropertyName = "deployStagePredecessors")]
        public DeployStagePredecessorCollection DeployStagePredecessors { get; set; }
        
        /// <value>
        /// Details about stage execution for all the target environments.
        /// </value>
        [JsonProperty(PropertyName = "deployStageExecutionProgressDetails")]
        public System.Collections.Generic.List<DeployStageExecutionProgressDetails> DeployStageExecutionProgressDetails { get; set; }
        
    }

    public class DeployStageExecutionProgressModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(DeployStageExecutionProgress);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(DeployStageExecutionProgress);
            var discriminator = jsonObject["deployStageType"].Value<string>();
            switch (discriminator)
            {
                case "COMPUTE_INSTANCE_GROUP_BLUE_GREEN_TRAFFIC_SHIFT":
                    obj = new ComputeInstanceGroupBlueGreenTrafficShiftDeployStageExecutionProgress();
                    break;
                case "COMPUTE_INSTANCE_GROUP_CANARY_DEPLOYMENT":
                    obj = new ComputeInstanceGroupCanaryDeployStageExecutionProgress();
                    break;
                case "OKE_BLUE_GREEN_DEPLOYMENT":
                    obj = new OkeBlueGreenDeployStageExecutionProgress();
                    break;
                case "COMPUTE_INSTANCE_GROUP_ROLLING_DEPLOYMENT":
                    obj = new ComputeInstanceGroupDeployStageExecutionProgress();
                    break;
                case "SHELL":
                    obj = new ShellDeployStageExecutionProgress();
                    break;
                case "OKE_CANARY_DEPLOYMENT":
                    obj = new OkeCanaryDeployStageExecutionProgress();
                    break;
                case "LOAD_BALANCER_TRAFFIC_SHIFT":
                    obj = new LoadBalancerTrafficShiftDeployStageExecutionProgress();
                    break;
                case "WAIT":
                    obj = new WaitDeployStageExecutionProgress();
                    break;
                case "COMPUTE_INSTANCE_GROUP_CANARY_TRAFFIC_SHIFT":
                    obj = new ComputeInstanceGroupCanaryTrafficShiftDeployStageExecutionProgress();
                    break;
                case "OKE_CANARY_APPROVAL":
                    obj = new OkeCanaryApprovalDeployStageExecutionProgress();
                    break;
                case "MANUAL_APPROVAL":
                    obj = new ManualApprovalDeployStageExecutionProgress();
                    break;
                case "OKE_DEPLOYMENT":
                    obj = new OkeDeployStageExecutionProgress();
                    break;
                case "DEPLOY_FUNCTION":
                    obj = new FunctionDeployStageExecutionProgress();
                    break;
                case "OKE_BLUE_GREEN_TRAFFIC_SHIFT":
                    obj = new OkeBlueGreenTrafficShiftDeployStageExecutionProgress();
                    break;
                case "OKE_HELM_CHART_DEPLOYMENT":
                    obj = new OkeHelmChartDeploymentStageExecutionProgress();
                    break;
                case "INVOKE_FUNCTION":
                    obj = new InvokeFunctionDeployStageExecutionProgress();
                    break;
                case "OKE_CANARY_TRAFFIC_SHIFT":
                    obj = new OkeCanaryTrafficShiftDeployStageExecutionProgress();
                    break;
                case "COMPUTE_INSTANCE_GROUP_CANARY_APPROVAL":
                    obj = new ComputeInstanceGroupCanaryApprovalDeployStageExecutionProgress();
                    break;
                case "COMPUTE_INSTANCE_GROUP_BLUE_GREEN_DEPLOYMENT":
                    obj = new ComputeInstanceGroupBlueGreenDeployStageExecutionProgress();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under DeployStageExecutionProgress! Returning null value.");
            }
            return obj;
        }
    }
}
