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

namespace Oci.DisasterrecoveryService.Models
{
    /// <summary>
    /// The details for updating a user-defined step in a DR plan.
    /// </summary>
    [JsonConverter(typeof(UpdateDrPlanUserDefinedStepDetailsModelConverter))]
    public class UpdateDrPlanUserDefinedStepDetails 
    {
                ///
        /// <value>
        /// The type of the user-defined step.
        /// <br/>
        ///   **RUN_OBJECTSTORE_SCRIPT_PRECHECK** - A built-in step which performs a precheck on a script stored
        ///     in OCI object storage.  This step cannot be added, deleted, or customized by the user.
        /// <br/>
        ///   **RUN_LOCAL_SCRIPT_PRECHECK** - A built-in step which performs a precheck on a script which resides
        ///     locally on a compute instance.  This step cannot be added, deleted, or customized by the user.
        /// <br/>
        ///   **INVOKE_FUNCTION_PRECHECK** - A built-in step which performs a precheck on an OCI function.  This 
        ///     step cannot be added, deleted, or customized by the user.
        ///     See https://docs.oracle.com/en-us/iaas/Content/Functions/home.htm.
        /// <br/>
        ///   **RUN_OBJECTSTORE_SCRIPT** - A step which runs a script stored in OCI object storage.
        /// <br/>
        ///   **RUN_LOCAL_SCRIPT** - A step which runs a script that resides locally on a compute instance.
        /// <br/>
        ///   **INVOKE_FUNCTION** - A step which invokes an OCI function.
        ///     See https://docs.oracle.com/en-us/iaas/Content/Functions/home.htm.
        /// <br/>
        ///   **RUN_OBJECTSTORE_SCRIPT_USER_DEFINED_CUSTOM_PRECHECK** - A user-defined step which performs a precheck by executing a user-provided script stored
        ///     in OCI object storage.
        /// <br/>
        ///   **RUN_LOCAL_SCRIPT_USER_DEFINED_CUSTOM_PRECHECK** - A user-defined step which performs a precheck by executing a user-provided script which resides
        ///     locally on a compute instance.
        /// <br/>
        ///   **INVOKE_FUNCTION_USER_DEFINED_CUSTOM_PRECHECK** - A user-defined step which performs a precheck by executing a user-provided OCI function.
        ///     See https://docs.oracle.com/en-us/iaas/Content/Functions/home.htm.
        /// 
        /// </value>
        ///
        public enum StepTypeEnum {
            [EnumMember(Value = "RUN_OBJECTSTORE_SCRIPT_PRECHECK")]
            RunObjectstoreScriptPrecheck,
            [EnumMember(Value = "RUN_LOCAL_SCRIPT_PRECHECK")]
            RunLocalScriptPrecheck,
            [EnumMember(Value = "INVOKE_FUNCTION_PRECHECK")]
            InvokeFunctionPrecheck,
            [EnumMember(Value = "RUN_OBJECTSTORE_SCRIPT")]
            RunObjectstoreScript,
            [EnumMember(Value = "RUN_LOCAL_SCRIPT")]
            RunLocalScript,
            [EnumMember(Value = "INVOKE_FUNCTION")]
            InvokeFunction,
            [EnumMember(Value = "RUN_OBJECTSTORE_SCRIPT_USER_DEFINED_CUSTOM_PRECHECK")]
            RunObjectstoreScriptUserDefinedCustomPrecheck,
            [EnumMember(Value = "RUN_LOCAL_SCRIPT_USER_DEFINED_CUSTOM_PRECHECK")]
            RunLocalScriptUserDefinedCustomPrecheck,
            [EnumMember(Value = "INVOKE_FUNCTION_USER_DEFINED_CUSTOM_PRECHECK")]
            InvokeFunctionUserDefinedCustomPrecheck
        };

        
    }

    public class UpdateDrPlanUserDefinedStepDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(UpdateDrPlanUserDefinedStepDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(UpdateDrPlanUserDefinedStepDetails);
            var discriminator = jsonObject["stepType"].Value<string>();
            switch (discriminator)
            {
                case "RUN_LOCAL_SCRIPT_USER_DEFINED_CUSTOM_PRECHECK":
                    obj = new UpdateRunLocalScriptUserDefinedCustomPrecheckStepDetails();
                    break;
                case "RUN_LOCAL_SCRIPT_PRECHECK":
                    obj = new UpdateLocalScriptPrecheckStepDetails();
                    break;
                case "INVOKE_FUNCTION_PRECHECK":
                    obj = new UpdateInvokeFunctionPrecheckStepDetails();
                    break;
                case "INVOKE_FUNCTION":
                    obj = new UpdateInvokeFunctionUserDefinedStepDetails();
                    break;
                case "RUN_OBJECTSTORE_SCRIPT_USER_DEFINED_CUSTOM_PRECHECK":
                    obj = new UpdateRunObjectStoreScriptUserDefinedCustomPrecheckStepDetails();
                    break;
                case "INVOKE_FUNCTION_USER_DEFINED_CUSTOM_PRECHECK":
                    obj = new UpdateInvokeFunctionUserDefinedCustomPrecheckStepDetails();
                    break;
                case "RUN_OBJECTSTORE_SCRIPT":
                    obj = new UpdateRunObjectStoreScriptUserDefinedStepDetails();
                    break;
                case "RUN_OBJECTSTORE_SCRIPT_PRECHECK":
                    obj = new UpdateObjectStoreScriptPrecheckStepDetails();
                    break;
                case "RUN_LOCAL_SCRIPT":
                    obj = new UpdateRunLocalScriptUserDefinedStepDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
